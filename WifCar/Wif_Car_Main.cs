using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.Sockets;
using AForge.Video.DirectShow;
using AForge;
using AForge.Controls;
using AForge.Imaging;
using AForge.Video;



namespace WifCar
{
    public partial class Wif_Car_Main : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoDevice = null;
        private VideoCapabilities[] videoCapabilities;
        private VideoCapabilities[] snapshotCapabilities;
        private MJPEGStream mjpegSource;
        public Wif_Car_Main()
        {
            InitializeComponent();
        }
        //声明读写INI文件的API函数
        [DllImport("kernel32")]
        private static extern bool WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, byte[] retVal, int size, string filePath);
        static string FileName = Application.StartupPath + "\\Setting.ini";

        public string ReadIni(string Section, string Ident, string Default)
        {
            Byte[] Buffer = new Byte[65535];
            int bufLen = GetPrivateProfileString(Section, Ident, Default, Buffer, Buffer.GetUpperBound(0), FileName);
            string s = Encoding.GetEncoding(0).GetString(Buffer);
            s = s.Substring(0, bufLen);
            return s.Trim();
        }
        //需要更改
        string CameraIp = "";
        string ControlIp = "192.168.43.41";
        string Port = "8080";
        
        string forward = "";
        string backward = "";
        string left = "";
        string right = "";
        string stop = "";
        string leftForward = "";
        string rightForward = "";
        string leftBackward = "";
        string rightBackward = "";
        string speedup = "";
        string speeddown = "";

        string leftlampon = "";
        string rightlampon = "";
        string leftlampoff = "";
        string rightlampoff = "";
        string lowbeamon = "";
        string lowbeamoff = "";
        string highbeamon = "";
        string highbeamoff = "";

        string cameraup = "";
        string cameradown = "";
        string cameraleft = "";
        string cameraright = "";
        string camerastop = "";

        string auto = "";
        string manual = "";
        string whistle = "";
        string hot = "";

        public int speed = 100;
        public int mode = 0;
        private void GetIni()
        {
            //WIFI
            CameraIp = ReadIni("VideoUrl", "videoUrl", "");
            ControlIp = ReadIni("ControlUrl", "controlUrl", "");
            Port = ReadIni("ControlPort", "controlPort", "");
            //direction
            forward = ReadIni("Forward", "forward", "");
            left = ReadIni("Left", "left", "");
            right = ReadIni("Right", "right", "");
            backward = ReadIni("Backward", "backward", "");
            stop = ReadIni("Stop", "stop", "");
            leftForward = ReadIni("LeftForward", "leftForward", "");
            rightForward = ReadIni("RightForward", "rightForward", "");
            leftBackward = ReadIni("LeftBackward", "leftBackward", "");
            rightBackward = ReadIni("RightBackward", "rightBackward", "");
            //speed
            speedup = ReadIni("SpeedUp", "speedup", "");
            speeddown = ReadIni("SpeedDown", "speeddown", "");
            //light
            leftlampon = ReadIni("LeftLampOn", "leftlampon", "");
            leftlampoff = ReadIni("LeftLampOff", "leftlampoff", "");
            rightlampon = ReadIni("RightLampOn", "rightlampon", "");
            rightlampoff = ReadIni("RightLampOff", "rightlampoff", "");
            lowbeamon = ReadIni("LowBeamOn", "lowbeamon", "");
            lowbeamoff = ReadIni("LowBeamOff", "lowbeamoff", "");
            highbeamon = ReadIni("HighBeamOn", "highbeamon", "");
            highbeamoff = ReadIni("HighBeamOff", "highbeamoff", "");
            //mode
            auto = ReadIni("Auto", "auto", "");
            manual = ReadIni("Manual", "manual", "");
            //function
            whistle = ReadIni("Whistle", "whistle", "");
            hot = ReadIni("Hot", "hot", "");
            //camera
            cameraup = ReadIni("CameraUp", "cameraup", "");
            cameradown = ReadIni("CameraDown", "cameradown", "");
            cameraleft = ReadIni("CameraLeft", "cameraleft", "");
            cameraright = ReadIni("CameraRight", "cameraright", "");
            camerastop = ReadIni("CameraStop", "camerastop", "");

        }

        private void Wif_Car_Main_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(680, 510);
            //使按钮背景自适应按钮大小
            button_forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button_backward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button_lforward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button_lbackward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button_rforward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button_rbackward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            GetIni();
            if (mode == 0)
            {
                textBox_mode.Text = "手动";
            }
            else if (mode == 1)
            {
                textBox_mode.Text = "自动";
            }

        }
        //键盘按键设置
        
        private void Wif_Car_Main_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString(), "您所按动的健为：");
            //direction
            if (e.KeyCode == Keys.W)
            {
                //MessageBox.Show("forward");
                button_forward.PerformClick();
            }
            else if(e.KeyData == Keys.S)
            {
                //button_backward.BackColor = Color.DarkGray;
                button_backward.PerformClick();
                //MessageBox.Show("backward");
            }
            else if (e.KeyCode == Keys.A)
            {
                //button_left.BackColor = Color.DarkGray;
                button_left.PerformClick();
            }
            else if (e.KeyCode == Keys.D)
            {
                //button_right.BackColor = Color.DarkGray;
                button_right.PerformClick();
            }
            else if (e.KeyCode == Keys.Q)
            {
                button_lforward.PerformClick();
            }
            else if(e.KeyCode == Keys.E)
            {
                button_rforward.PerformClick();
            }
            else if (e.KeyCode == Keys.Z)
            {
                button_lbackward.PerformClick();
            }
            else if (e.KeyCode == Keys.C)
            {
                button_rbackward.PerformClick();
            }
            //speed
            else if(e.KeyCode == Keys.F)
            {
                button_speedup.PerformClick();
            }
            else if (e.KeyCode == Keys.G)
            {
                button_speeddown.PerformClick();
            }
            //light
            else if (e.KeyCode == Keys.H)
            {
                button_llamp_on.PerformClick();
            }
            else if (e.KeyCode == Keys.Y)
            {
                button_llamp_off.PerformClick();
            }
            else if (e.KeyCode == Keys.J)
            {
                button_rlamp_on.PerformClick();
            }
            else if (e.KeyCode == Keys.U)
            {
                button_rlamp_off.PerformClick();
            }
            else if (e.KeyCode == Keys.K)
            {
                button_lowbeam_on.PerformClick();
            }
            else if (e.KeyCode == Keys.I)
            {
                button_lowbeam_off.PerformClick();
            }
            else if (e.KeyCode == Keys.L)
            {
                button_highbeam_on.PerformClick();
            }
            else if (e.KeyCode == Keys.O)
            {
                button_highbeam_off.PerformClick();
            }
            //function
            else if (e.KeyCode == Keys.P)
            {
                拍照ToolStripMenuItem.PerformClick();
                //MessageBox.Show("photo");
            }

        }

        private void Wif_Car_Main_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Q || e.KeyCode == Keys.W || e.KeyCode == Keys.E ||
                e.KeyCode == Keys.A || e.KeyCode == Keys.S || e.KeyCode == Keys.D ||
                e.KeyCode == Keys.Z || e.KeyCode == Keys.X || e.KeyCode == Keys.C)
                {
                button_stop.PerformClick();
                }
            
        }

        void SendData(string data)
        {
            try
            {
                IPAddress ips = IPAddress.Parse(ControlIp.ToString());//("192.168.43.41");
                IPEndPoint ipe = new IPEndPoint(ips, 8888);//把ip和端口转化为IPEndPoint实例
                Socket c = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//创建一个Socket
                c.Connect(ipe);//连接到服务器
                byte[] bs = Encoding.ASCII.GetBytes(data);
                c.Send(bs, bs.Length, 0);//发送测试信息
                c.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void button_forward_Click(object sender, EventArgs e)
        {
            SendData(forward);
            trackBar1.Value = speed;
            this.textBox_speed.Text = Convert.ToString(speed);
        }

        private void button_left_Click(object sender, EventArgs e)
        {
            SendData(left);
            trackBar1.Value = speed;
            this.textBox_speed.Text = Convert.ToString(speed);
        }

        private void button_right_Click(object sender, EventArgs e)
        {
            SendData(right);
            trackBar1.Value = speed;
            this.textBox_speed.Text = Convert.ToString(speed);
        }

        private void button_backward_Click(object sender, EventArgs e)
        {
            SendData(backward);
            trackBar1.Value = speed;
            this.textBox_speed.Text = Convert.ToString(speed);
        }

        private void 系统设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
        }
        //加速
        private void button_speedup_Click(object sender, EventArgs e)
        {
            speed = speed + 50;
            try
            {
                trackBar1.Value = speed;
                this.textBox_speed.Text = Convert.ToString(speed);
                //byte[] ayData = BitConverter.GetBytes(speed);
                //string str = Encoding.Unicode.GetString(ayData);
                //speedup = "SP";
                //speedup += str;
                //speedup += "#";
                SendData(speedup);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        //减速
        private void button_speeddown_Click(object sender, EventArgs e)
        {
            speed = speed - 50;
            try
            {
                trackBar1.Value = speed;
                this.textBox_speed.Text = Convert.ToString(speed);
                //byte[] ayData = BitConverter.GetBytes(speed);
                //string str = Encoding.Unicode.GetString(ayData);
                //speeddown = "$4WD,SP";
                //speeddown += str;
                //speeddown += "#";
                SendData(speeddown);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        //左转向灯开
        private void button_llamp_on_Click(object sender, EventArgs e)
        {
            SendData(leftlampon);
            button_llamp_on.Enabled = false;
            button_llamp_off.Enabled = true;
        }
        //停止
        private void button_stop_Click(object sender, EventArgs e)
        {
            SendData(stop);
            speed = 0;
            trackBar1.Value = speed;
            this.textBox_speed.Text = Convert.ToString(speed);
        }
        //左转向灯关
        private void button_llamp_off_Click(object sender, EventArgs e)
        {
            SendData(leftlampoff);
            button_llamp_off.Enabled = false;
            button_llamp_on.Enabled = true;
        }
        //右转向灯开
        private void button_rlamp_on_Click(object sender, EventArgs e)
        {
            SendData(rightlampon);
            button_rlamp_on.Enabled = false;
            button_rlamp_off.Enabled = true;
        }
        //右转向灯关
        private void button_rlamp_off_Click(object sender, EventArgs e)
        {
            SendData(rightlampoff);
            button_rlamp_off.Enabled = false;
            button_rlamp_on.Enabled = true;
        }
        //近光灯开
        private void button_lowbeam_on_Click(object sender, EventArgs e)
        {
            SendData(lowbeamon);
            //button_lowbeam_on.Enabled = false;
            //button_lowbeam_off.Enabled = true;
        }
        //近光灯关
        private void button_lowbeam_off_Click(object sender, EventArgs e)
        {
            SendData(lowbeamoff);
            //button_lowbeam_off.Enabled = false;
            //button_lowbeam_on.Enabled = true;
        }
        //远光灯开
        private void button_highbeam_on_Click(object sender, EventArgs e)
        {
            SendData(highbeamon);
            //button_highbeam_on.Enabled = false;
            //button_highbeam_off.Enabled = true;
        }
        //远光灯关
        private void button_highbeam_off_Click(object sender, EventArgs e)
        {
            SendData(highbeamoff);
            //button_highbeam_off.Enabled = false;
            //button_highbeam_on.Enabled = true;
        }
       
        private void EnableControlStatus(bool status)
        {
            视频ToolStripMenuItem.Enabled = status;
            // cmbResolution.Enabled = status;
            //btnConnect.Enabled = status;
            拍照ToolStripMenuItem.Enabled = !status;
            btnDisconnect.Enabled = !status;
        }
        private void DisConnect()
        {
            if (vispShoot.VideoSource != null)
            {
                vispShoot.SignalToStop();
                vispShoot.WaitForStop();
                vispShoot.VideoSource = null;
            }
        }
        private void Wifi_Car_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisConnect();
        }

        private void 视频ToolStripMenuItem_Click(object sender, EventArgs e) //连接
        {
            mjpegSource = new MJPEGStream("http://192.168.43.41:8081/stream");
            //if (videoDevice != null)
            //{
               // if ((videoCapabilities != null) && (videoCapabilities.Length != 0))
                //{
                    //videoDevice.VideoResolution = videoCapabilities[cmbResolution.SelectedIndex];
                    vispShoot.VideoSource = mjpegSource;//？？
                    vispShoot.Start();
                    EnableControlStatus(false);
                //}
            //}
        }
        private void 自动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 1;
            textBox_mode.Text = "自动";
            SendData(auto);
        }

        private void 手动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 0;
            textBox_mode.Text = "手动";
            SendData(manual);
        }

        private void button_lforward_Click(object sender, EventArgs e)
        {
            SendData(leftForward);
        }

        private void button_rforward_Click(object sender, EventArgs e)
        {
            SendData(rightForward);
        }

        private void button_lbackward_Click(object sender, EventArgs e)
        {
            SendData(leftBackward);
        }

        private void button_rbackward_Click(object sender, EventArgs e)
        {
            SendData(rightBackward);
        }


        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            DisConnect();
            EnableControlStatus(true);
        }

        private void 拍照ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Bitmap img = vispShoot.GetCurrentVideoFrame();
            picbPreview.Image = img;
        }

        private void button_cam_up_Click(object sender, EventArgs e)
        {
            SendData(cameraup);
        }

        private void button_cam_left_Click(object sender, EventArgs e)
        {
            SendData(cameraleft);
        }

        private void button_cam_down_Click(object sender, EventArgs e)
        {
            SendData(cameradown);
        }

        private void button_cam_right_Click(object sender, EventArgs e)
        {
            SendData(cameraright);
        }

        private void button_cam_stop_Click(object sender, EventArgs e)
        {
            SendData(camerastop);
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            SendData(whistle);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SendData(hot);
        }
    }
}
