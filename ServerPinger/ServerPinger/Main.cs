using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Threading;
using System.Media;
using System.IO;
using WMPLib;

namespace ServerPinger
{
    public partial class FrmPinger : Form
    {
        public FrmPinger()
        {
            InitializeComponent();
        }
        

        //environment variables
        Stopwatch stopwatch = new Stopwatch();
        SoundPlayer song = new SoundPlayer(@"D:\Programs\C#\ServerPinger\ServerPinger\MapleRemix.wav");
        WindowsMediaPlayer player = new WindowsMediaPlayer();  //For MP3.
        bool playing = false;
        string programPath;


        private void SelectSongPath()
        {
            //Specify path of sound to play
            try
            {
                OpenFileDialog programSelect = new OpenFileDialog
                {
                    Filter = "Sound files|*.wav; *.mp3"
                };

                if (programSelect.ShowDialog() == DialogResult.OK)
                {
                    song.SoundLocation = programSelect.FileName;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occured when attempting to select file:\n" + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnStopPinging_Click(object sender, EventArgs e)
        {
            btnCheckIP.Enabled = true;
            btnStopPinging.Enabled = false;
            radICMP.Enabled = true;
            radTCP.Enabled = true;
            backgroundWorker1.CancelAsync();
        }


        private void BtnCheckIP_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIP.Text))
                {
                    WriteLog("Please input a valid hostname or IP.");
                    return;
                }
                else if (radTCP.Checked)
                {
                    if (!UInt16.TryParse(txtPort.Text, out UInt16 port) || string.IsNullOrEmpty(txtPort.Text))
                    {
                        WriteLog("Please input a proper port number for the specified host.");
                        WriteLog("Port can have a maximum value of 65535");
                        return;
                    }
                        
                } 
                
                {
                    btnCheckIP.Enabled = false;
                    btnStopPinging.Enabled = true;
                    radICMP.Enabled = false;
                    radTCP.Enabled = false;
                    btnStopPinging.Select();

                    //writeLog("Attempting to ping " + txtIP.Text);
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            catch(Exception ex)
            {
                WriteLog(ex.Message.ToString());
            }
        }


        public void WriteLog(string text)
        {
            Invoke((MethodInvoker)delegate()
            {
                DateTime timestamp = DateTime.Now;
                lstLog.Items.Add("[" + timestamp.ToLongTimeString() + "] " + text);
                lstLog.TopIndex = lstLog.Items.Count - 1;  //Makes it autoscroll
            });
        }


        private bool PingHostTCP(TcpClientWithTimeout c, string ipendpoint, int port)
        {
            try
            {
                stopwatch.Restart();
                WriteLog("Pinged " + ipendpoint + "...");
                c.Connect(ipendpoint, port);
                stopwatch.Stop();  //Is this the right placement?
                //writeLog("Pinged " + ipendpoint + "...");

                return true;
            }
            catch (Exception)
            {
                //writeLog("[TCP] Caught exception");
                return false;
            }
        }


        #region BackgroundWorker Events
        //Do all the work in this backgroundworker method
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string host = txtIP.Text;

            if (radICMP.Checked)
            {
                Ping ping = new Ping();
                PingReply reply;

                try
                {
                    do
                    {
                        if (backgroundWorker1.CancellationPending)
                        {
                            e.Cancel = true;
                            return;
                        }

                        reply = ping.Send(host, (int)nmrPingDelay.Value * 1000);
                        WriteLog("Pinged " + host + "...");
                    }
                    while (reply.Status != IPStatus.Success);
                    WriteLog(host + " is up! " + "(" + reply.RoundtripTime + " ms)");
                    PlaySong();
                }
                catch(Exception ex)
                {
                    WriteLog(ex.Message.ToString());
                } 
            }
            else
            {
                bool success = false;
                int port = Convert.ToUInt16(txtPort.Text);
                //TcpClient client = new TcpClient();
                TcpClientWithTimeout client = new TcpClientWithTimeout();

                WriteLog("Initiating TCP ping sequence...");

                try
                {
                    do
                    {
                        if (backgroundWorker1.CancellationPending)
                        {
                            e.Cancel = true;
                            return;
                        }

                        if (PingHostTCP(client, host, port))
                        {
                            success = true;
                            WriteLog(host + " is up! " + "(" + stopwatch.ElapsedMilliseconds + " ms)");
                            PlaySong();
                        }
                        else
                        {
                            Thread.Sleep((int)nmrPingDelay.Value * 1000);
                        }
                    }
                    while (!success);
                }
                catch(Exception ex)
                {
                    WriteLog(ex.Message.ToString());
                }
            }

            //BackgroundWorker should never touch the UI so use invoke
            Invoke((MethodInvoker)delegate { btnCheckIP.Enabled = true; });
            Invoke((MethodInvoker)delegate { btnStopPinging.Enabled = false; });
            Invoke((MethodInvoker)delegate { radICMP.Enabled = true; });
            Invoke((MethodInvoker)delegate { radTCP.Enabled = true; });

            if (chkLaunchProgram.Checked)
                LaunchProgram();
        }


        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }


        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
        #endregion


        private void NmrPingDelay_ValueChanged(object sender, EventArgs e)
        {
            if (nmrPingDelay.Value != 1)
                label3.Text = "seconds";
            else
                label3.Text = "second";
        }


        private void RadTCP_CheckedChanged(object sender, EventArgs e)
        {
            if (radTCP.Checked)
            {
                txtPort.Enabled = true;
                label4.Enabled = true;
            }
            else
            {
                txtPort.Enabled = false;
                label4.Enabled = false;
            }
        }


        private void PlaySong()
        {
            if (chkPlaySong.Checked)
            {
                //Only way I was able to make it play MP3 files
                if (song.SoundLocation.EndsWith(".mp3"))
                {
                    player.URL = song.SoundLocation;

                    player.controls.play();
                    playing = true;
                }
                else
                {
                    song.Play();
                    playing = true;
                }

            }
        }


        /// <summary>
        /// Uncheck to stop song playing.
        /// </summary>
        private void ChkPlaySong_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPlaySong.Checked)
                btnSoundLocation.Visible = true;
            else
                btnSoundLocation.Visible = false;
            if (playing)
            {
                song.Stop();
                player.controls.stop();
                playing = false;
            }
            else
                return;
        }


        private void BtnClear_Click(object sender, EventArgs e)
        {
            lstLog.Items.Clear();
        }


        private void LaunchProgram()
        {
            programPath = txtLaunchPath.Text;
            WriteLog("Starting " + Path.GetFileName(programPath));
            try
            {
                Process.Start(programPath);
            }
            catch(Exception)
            {
                WriteLog("Cannot start the program. Please check the file path is valid and try again.");
            }
        }


        private void TxtLaunchPath_Click(object sender, EventArgs e)
        {
            SelectFilePath();
        }


        private void SelectFilePath()
        {
            //Select the program we'll be working with
            try
            {
                OpenFileDialog programSelect = new OpenFileDialog
                {
                    Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*"
                };

                if (programSelect.ShowDialog() == DialogResult.OK)
                {
                    programPath = programSelect.FileName;
                    txtLaunchPath.Text = programPath;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occured when attempting to select file:\n" + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ChkLaunchProgram_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLaunchProgram.Checked)
                txtLaunchPath.Visible = true;
            else
                txtLaunchPath.Visible = false;
        }


        private void LoadSavedIPs()
        {
            lstLog.Items.Add("MapleRoyals:");
            lstLog.Items.Add("Login");
            lstLog.Items.Add("185.125.230.180:8484");
            lstLog.Items.Add("Game");
            lstLog.Items.Add("185.125.230.137:7575");
            lstLog.Items.Add("------------------------------------------------------------------------------------");
            lstLog.Items.Add("GMS Login server 1 + 2:");
            lstLog.Items.Add("8.31.99.141:8484");
            lstLog.Items.Add("8.31.99.142:8484");
            lstLog.Items.Add("------------------------------------------------------------------------------------");
        }


        private void LstLog_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //The listbox entry we clicked on
                string entry = lstLog.SelectedItem.ToString();

                //Check to see if entry is an IP (starts with a number..)
                if (!char.IsDigit(entry[0]))
                    return;

                //Cut string at the : between ip and port, creating 2 strings and putting them into array serverInfo
                string[] serverInfo = entry.Split(':');

                //Put selected IP:Port into proper textboxes
                txtIP.Text = serverInfo[0];
                txtPort.Text = serverInfo[1];
            }
            catch
            {
                return;
            }
        }


        private void BtnLoadIPs_Click(object sender, EventArgs e)
        {
            lstLog.Items.Clear();
            LoadSavedIPs();
        }


        //private int DetermineHoveredItem()
        //{
        //    Point screenPosition = MousePosition;
        //    Point listBoxClientAreaPosition = lstLog.PointToClient(screenPosition);

        //    int hoveredIndex = lstLog.IndexFromPoint(listBoxClientAreaPosition);

        //    if (hoveredIndex != -1)
        //    {
        //        return hoveredIndex;
        //    }
        //    else
        //    {
        //        return -1;
        //    }
        //}


        //private void lstLog_MouseHover(object sender, EventArgs e)
        //{
        //    int index = DetermineHoveredItem();

        //    if (index == -1) return;

        //    //Show tooltip if list item is greater than 60 characters (goes off screen)
        //    if (lstLog.Items[index].ToString().Length > 60)
        //    {
        //        ToolTip toolTip = new ToolTip();
        //        toolTip.SetToolTip(lstLog, lstLog.Items[index].ToString());
        //    }
        //    //WriteLog(index.ToString());
        //}


        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        
        private void btnSoundLocation_Click(object sender, EventArgs e)
        {
            SelectSongPath();
        }
    }
}