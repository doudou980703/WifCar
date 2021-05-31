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

namespace WifCar
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }
        public string FileName; //INI文件名
        //声明读写INI文件的API函数
        [DllImport("kernel32")]
        private static extern bool WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, byte[] retVal, int size, string filePath);

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveSetting();
            MessageBox.Show("参数设置成功！请重启程序以使设置生效。", "保存提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void SaveSetting()
        {
            //WIFI
            WriteIni("VideoUrl", "videourl", this.textBox_videoadd.Text);
            WriteIni("ControlUrl", "controlurl", this.textBox_conadd.Text);
            WriteIni("Port", "port", this.textBox_port.Text);
            //direction
            WriteIni("Forward", "forward", this.textBox_forward.Text);
            WriteIni("Left", "left", this.textBox_left.Text);
            WriteIni("Right", "right", this.textBox_right.Text);
            WriteIni("Backward", "backward", this.textBox_back.Text);
            WriteIni("Stop", "stop", this.textBox_stop.Text);
            WriteIni("LeftForward", "leftForward", this.textBox_leftforward.Text);
            WriteIni("RightForward", "rightForward", this.textBox_rightforward.Text);
            WriteIni("LeftBackward", "leftBackward", this.textBox_leftbackward.Text);
            WriteIni("RightBackward", "rightBackward", this.textBox_rightbackward.Text);
            //speed
            WriteIni("SpeedUp", "speedup", this.textBox_spup.Text);
            WriteIni("SpeedDown", "speeddown", this.textBox_spdown.Text);
            //camera
            WriteIni("CameraUp", "cameraup", this.textBox_cam_up.Text);
            WriteIni("CameraDown", "cameradown", this.textBox_cam_down.Text);
            WriteIni("CameraLeft", "cameraleft", this.textBox_cam_left.Text);
            WriteIni("CameraRight", "cameraright", this.textBox_cam_right.Text);
            WriteIni("CameraStop", "camerastop", this.textBox_cam_stop.Text);
            //light
            WriteIni("LeftLampOn", "leftlampon", this.textBox_llampon.Text);
            WriteIni("LeftLampOff", "leftlampoff", this.textBox_llampoff.Text);
            WriteIni("RightLampOn", "rightlampon", this.textBox_rlampon.Text);
            WriteIni("RightLampOff", "rightlampoff", this.textBox_rlampoff.Text);
            WriteIni("LowBeamOn", "lowbeamon", this.textBox_lowbeamon.Text);
            WriteIni("LowBeamOff", "lowbeamoff", this.textBox_lowbeamoff.Text);
            WriteIni("HighBeamOn", "highbeamon", this.textBox_highbeamon.Text);
            WriteIni("HighBeamOff", "highbeamoff", this.textBox_highbeamoff.Text);
            //mode
            WriteIni("Auto", "auto", this.textBox_auto.Text);
            WriteIni("Manual", "manual", this.textBox_manual.Text);
            //function
            WriteIni("Whistle", "whistle", this.textBox_whistle.Text);
            WriteIni("Hot", "hot", this.textBox_hot.Text);
        }

        //写INI文件
        public void WriteIni(string Section, string Ident, string Value)
        {
            if (!WritePrivateProfileString(Section, Ident, Value, FileName))
            {

                throw (new ApplicationException("写入配置文件出错"));
            }

        }
        //读取INI文件指定
        public string ReadIni(string Section, string Ident, string Default)
        {
            Byte[] Buffer = new Byte[65535];
            int bufLen = GetPrivateProfileString(Section, Ident, Default, Buffer, Buffer.GetUpperBound(0), FileName);
            //必须设定0（系统默认的代码页）的编码方式，否则无法支持中文
            string s = Encoding.GetEncoding(0).GetString(Buffer);
            s = s.Substring(0, bufLen);
            return s.Trim();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(800, 550);
            GetIni();
        }

        private void GetIni()
        {
            FileName = Application.StartupPath + "\\Setting.ini";
            //WIFI
            this.textBox_videoadd.Text = ReadIni("VideoUrl", "videourl", "");
            this.textBox_conadd.Text = ReadIni("ControlUrl", "controlurl", "");
            this.textBox_port.Text = ReadIni("Port", "port", "");
            //direction
            this.textBox_forward.Text = ReadIni("Forward", "forward", "");
            this.textBox_left.Text = ReadIni("Left", "left", "");
            this.textBox_right.Text = ReadIni("Right", "right", "");
            this.textBox_back.Text = ReadIni("Backward", "backward", "");
            this.textBox_stop.Text = ReadIni("Stop", "stop", "");
            this.textBox_leftforward.Text = ReadIni("LeftForward", "leftForward", "");
            this.textBox_rightforward.Text = ReadIni("RightForward", "rightForward", "");
            this.textBox_leftbackward.Text = ReadIni("LeftBackward", "leftBackward", "");
            this.textBox_rightbackward.Text = ReadIni("RightBackward", "rightBackward", "");
            //speed
            this.textBox_spup.Text = ReadIni("SpeedUp", "speedup", "");
            this.textBox_spdown.Text = ReadIni("SpeedDown", "speeddown", "");
            //light
            this.textBox_llampon.Text = ReadIni("LeftLampOn", "leftlampon", "");
            this.textBox_llampoff.Text = ReadIni("LeftLampOff", "leftlampoff", "");
            this.textBox_rlampon.Text = ReadIni("RightLampOn", "rightlampon", "");
            this.textBox_rlampoff.Text = ReadIni("RightLampOff", "rightlampoff", "");
            this.textBox_lowbeamon.Text = ReadIni("LowBeamOn", "lowbeamon", "");
            this.textBox_lowbeamoff.Text = ReadIni("LowBeamOff", "lowbeamoff", "");
            this.textBox_highbeamon.Text = ReadIni("HighBeamOn", "highbeamon", "");
            this.textBox_highbeamoff.Text = ReadIni("HighBeamOff", "highbeamoff", "");
            //mode
            this.textBox_auto.Text = ReadIni("Auto", "auto", "");
            this.textBox_manual.Text = ReadIni("Manual", "manual", "");
            //function
            this.textBox_whistle.Text = ReadIni("Whistle", "whistle", "");
            this.textBox_hot.Text = ReadIni("Hot", "hot", "");
            //camera
            this.textBox_cam_up.Text = ReadIni("CameraUp", "cameraup", "");
            this.textBox_cam_down.Text = ReadIni("CameraDown", "cameradown", "");
            this.textBox_cam_left.Text = ReadIni("CameraLeft", "cameraleft", "");
            this.textBox_cam_right.Text = ReadIni("CameraRight", "cameraright", "");
            this.textBox_cam_stop.Text = ReadIni("CameraStop", "camerastop", "");
        }
    }
}
