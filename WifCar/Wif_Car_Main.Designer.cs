namespace WifCar
{
    partial class Wif_Car_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wif_Car_Main));
            this.button_forward = new System.Windows.Forms.Button();
            this.button_backward = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_lforward = new System.Windows.Forms.Button();
            this.button_rforward = new System.Windows.Forms.Button();
            this.button_lbackward = new System.Windows.Forms.Button();
            this.button_rbackward = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.灯光模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.手动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视频ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button_speedup = new System.Windows.Forms.Button();
            this.button_speeddown = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_speed = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_highbeam_off = new System.Windows.Forms.Button();
            this.button_highbeam_on = new System.Windows.Forms.Button();
            this.button_lowbeam_off = new System.Windows.Forms.Button();
            this.button_lowbeam_on = new System.Windows.Forms.Button();
            this.button_rlamp_off = new System.Windows.Forms.Button();
            this.button_rlamp_on = new System.Windows.Forms.Button();
            this.button_llamp_off = new System.Windows.Forms.Button();
            this.button_llamp_on = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_mode = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.vispShoot = new AForge.Controls.VideoSourcePlayer();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.picbPreview = new AForge.Controls.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_cam_up = new System.Windows.Forms.Button();
            this.button_cam_down = new System.Windows.Forms.Button();
            this.button_cam_stop = new System.Windows.Forms.Button();
            this.button_cam_right = new System.Windows.Forms.Button();
            this.button_cam_left = new System.Windows.Forms.Button();
            this.拍照ToolStripMenuItem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbPreview)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_forward
            // 
            this.button_forward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_forward.BackgroundImage")));
            this.button_forward.Location = new System.Drawing.Point(133, 32);
            this.button_forward.Name = "button_forward";
            this.button_forward.Size = new System.Drawing.Size(70, 70);
            this.button_forward.TabIndex = 1;
            this.button_forward.Text = "前进(W)";
            this.button_forward.UseVisualStyleBackColor = true;
            this.button_forward.Click += new System.EventHandler(this.button_forward_Click);
            // 
            // button_backward
            // 
            this.button_backward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_backward.BackgroundImage")));
            this.button_backward.Location = new System.Drawing.Point(133, 208);
            this.button_backward.Name = "button_backward";
            this.button_backward.Size = new System.Drawing.Size(70, 70);
            this.button_backward.TabIndex = 2;
            this.button_backward.Text = "后退(S)";
            this.button_backward.UseVisualStyleBackColor = true;
            this.button_backward.Click += new System.EventHandler(this.button_backward_Click);
            // 
            // button_left
            // 
            this.button_left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_left.BackgroundImage")));
            this.button_left.Location = new System.Drawing.Point(32, 120);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(70, 70);
            this.button_left.TabIndex = 3;
            this.button_left.Text = "左行(A)";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // button_right
            // 
            this.button_right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_right.BackgroundImage")));
            this.button_right.Location = new System.Drawing.Point(237, 120);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(70, 70);
            this.button_right.TabIndex = 4;
            this.button_right.Text = "右行(D)";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // button_stop
            // 
            this.button_stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_stop.BackgroundImage")));
            this.button_stop.Location = new System.Drawing.Point(133, 120);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(70, 70);
            this.button_stop.TabIndex = 5;
            this.button_stop.Text = "停止(X)";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_lforward
            // 
            this.button_lforward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_lforward.BackgroundImage")));
            this.button_lforward.Location = new System.Drawing.Point(32, 32);
            this.button_lforward.Name = "button_lforward";
            this.button_lforward.Size = new System.Drawing.Size(70, 70);
            this.button_lforward.TabIndex = 6;
            this.button_lforward.Text = "左旋(Q)";
            this.button_lforward.UseVisualStyleBackColor = true;
            this.button_lforward.Click += new System.EventHandler(this.button_lforward_Click);
            // 
            // button_rforward
            // 
            this.button_rforward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_rforward.BackgroundImage")));
            this.button_rforward.Location = new System.Drawing.Point(237, 32);
            this.button_rforward.Name = "button_rforward";
            this.button_rforward.Size = new System.Drawing.Size(70, 70);
            this.button_rforward.TabIndex = 7;
            this.button_rforward.Text = "右旋(E)";
            this.button_rforward.UseVisualStyleBackColor = true;
            this.button_rforward.Click += new System.EventHandler(this.button_rforward_Click);
            // 
            // button_lbackward
            // 
            this.button_lbackward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_lbackward.BackgroundImage")));
            this.button_lbackward.Location = new System.Drawing.Point(32, 208);
            this.button_lbackward.Name = "button_lbackward";
            this.button_lbackward.Size = new System.Drawing.Size(70, 70);
            this.button_lbackward.TabIndex = 8;
            this.button_lbackward.Text = "左后(Z)";
            this.button_lbackward.UseVisualStyleBackColor = true;
            this.button_lbackward.Click += new System.EventHandler(this.button_lbackward_Click);
            // 
            // button_rbackward
            // 
            this.button_rbackward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_rbackward.BackgroundImage")));
            this.button_rbackward.Location = new System.Drawing.Point(237, 208);
            this.button_rbackward.Name = "button_rbackward";
            this.button_rbackward.Size = new System.Drawing.Size(70, 70);
            this.button_rbackward.TabIndex = 9;
            this.button_rbackward.Text = "右后(C)";
            this.button_rbackward.UseVisualStyleBackColor = true;
            this.button_rbackward.Click += new System.EventHandler(this.button_rbackward_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_rbackward);
            this.groupBox1.Controls.Add(this.button_lbackward);
            this.groupBox1.Controls.Add(this.button_rforward);
            this.groupBox1.Controls.Add(this.button_lforward);
            this.groupBox1.Controls.Add(this.button_stop);
            this.groupBox1.Controls.Add(this.button_right);
            this.groupBox1.Controls.Add(this.button_left);
            this.groupBox1.Controls.Add(this.button_backward);
            this.groupBox1.Controls.Add(this.button_forward);
            this.groupBox1.Location = new System.Drawing.Point(933, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 302);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "方向";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统设置ToolStripMenuItem,
            this.灯光模式ToolStripMenuItem,
            this.视频ToolStripMenuItem,
            this.toolStripTextBox1,
            this.toolStripMenuItem1,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1305, 32);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.系统设置ToolStripMenuItem.Text = "系统设置";
            this.系统设置ToolStripMenuItem.Click += new System.EventHandler(this.系统设置ToolStripMenuItem_Click);
            // 
            // 灯光模式ToolStripMenuItem
            // 
            this.灯光模式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自动ToolStripMenuItem,
            this.手动ToolStripMenuItem});
            this.灯光模式ToolStripMenuItem.Name = "灯光模式ToolStripMenuItem";
            this.灯光模式ToolStripMenuItem.Size = new System.Drawing.Size(130, 28);
            this.灯光模式ToolStripMenuItem.Text = "远近光灯模式";
            // 
            // 自动ToolStripMenuItem
            // 
            this.自动ToolStripMenuItem.Name = "自动ToolStripMenuItem";
            this.自动ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.自动ToolStripMenuItem.Text = "自动";
            this.自动ToolStripMenuItem.Click += new System.EventHandler(this.自动ToolStripMenuItem_Click);
            // 
            // 手动ToolStripMenuItem
            // 
            this.手动ToolStripMenuItem.Name = "手动ToolStripMenuItem";
            this.手动ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.手动ToolStripMenuItem.Text = "手动";
            this.手动ToolStripMenuItem.Click += new System.EventHandler(this.手动ToolStripMenuItem_Click);
            // 
            // 视频ToolStripMenuItem
            // 
            this.视频ToolStripMenuItem.Name = "视频ToolStripMenuItem";
            this.视频ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.视频ToolStripMenuItem.Text = "视频";
            this.视频ToolStripMenuItem.Click += new System.EventHandler(this.视频ToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(58, 28);
            this.toolStripTextBox1.Text = "鸣笛";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(58, 28);
            this.toolStripMenuItem1.Text = "散热";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.Location = new System.Drawing.Point(32, 41);
            this.trackBar1.Maximum = 300;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(69, 284);
            this.trackBar1.TabIndex = 12;
            // 
            // button_speedup
            // 
            this.button_speedup.Location = new System.Drawing.Point(133, 177);
            this.button_speedup.Name = "button_speedup";
            this.button_speedup.Size = new System.Drawing.Size(80, 55);
            this.button_speedup.TabIndex = 13;
            this.button_speedup.Text = "加速(F)";
            this.button_speedup.UseVisualStyleBackColor = true;
            this.button_speedup.Click += new System.EventHandler(this.button_speedup_Click);
            // 
            // button_speeddown
            // 
            this.button_speeddown.Location = new System.Drawing.Point(133, 260);
            this.button_speeddown.Name = "button_speeddown";
            this.button_speeddown.Size = new System.Drawing.Size(80, 54);
            this.button_speeddown.TabIndex = 14;
            this.button_speeddown.Text = "减速(G)";
            this.button_speeddown.UseVisualStyleBackColor = true;
            this.button_speeddown.Click += new System.EventHandler(this.button_speeddown_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "速度";
            // 
            // textBox_speed
            // 
            this.textBox_speed.Location = new System.Drawing.Point(133, 97);
            this.textBox_speed.Name = "textBox_speed";
            this.textBox_speed.Size = new System.Drawing.Size(80, 28);
            this.textBox_speed.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_speed);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button_speeddown);
            this.groupBox2.Controls.Add(this.button_speedup);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Location = new System.Drawing.Point(664, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 347);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "速度";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_highbeam_off);
            this.groupBox3.Controls.Add(this.button_highbeam_on);
            this.groupBox3.Controls.Add(this.button_lowbeam_off);
            this.groupBox3.Controls.Add(this.button_lowbeam_on);
            this.groupBox3.Controls.Add(this.button_rlamp_off);
            this.groupBox3.Controls.Add(this.button_rlamp_on);
            this.groupBox3.Controls.Add(this.button_llamp_off);
            this.groupBox3.Controls.Add(this.button_llamp_on);
            this.groupBox3.Location = new System.Drawing.Point(32, 499);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(605, 180);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "灯光";
            // 
            // button_highbeam_off
            // 
            this.button_highbeam_off.Location = new System.Drawing.Point(483, 102);
            this.button_highbeam_off.Name = "button_highbeam_off";
            this.button_highbeam_off.Size = new System.Drawing.Size(100, 56);
            this.button_highbeam_off.TabIndex = 7;
            this.button_highbeam_off.Text = "远光灯关(O)";
            this.button_highbeam_off.UseVisualStyleBackColor = true;
            this.button_highbeam_off.Click += new System.EventHandler(this.button_highbeam_off_Click);
            // 
            // button_highbeam_on
            // 
            this.button_highbeam_on.Location = new System.Drawing.Point(483, 27);
            this.button_highbeam_on.Name = "button_highbeam_on";
            this.button_highbeam_on.Size = new System.Drawing.Size(100, 57);
            this.button_highbeam_on.TabIndex = 6;
            this.button_highbeam_on.Text = "远光灯开(L)";
            this.button_highbeam_on.UseVisualStyleBackColor = true;
            this.button_highbeam_on.Click += new System.EventHandler(this.button_highbeam_on_Click);
            // 
            // button_lowbeam_off
            // 
            this.button_lowbeam_off.Location = new System.Drawing.Point(344, 102);
            this.button_lowbeam_off.Name = "button_lowbeam_off";
            this.button_lowbeam_off.Size = new System.Drawing.Size(100, 56);
            this.button_lowbeam_off.TabIndex = 5;
            this.button_lowbeam_off.Text = "近光灯关(I)";
            this.button_lowbeam_off.UseVisualStyleBackColor = true;
            this.button_lowbeam_off.Click += new System.EventHandler(this.button_lowbeam_off_Click);
            // 
            // button_lowbeam_on
            // 
            this.button_lowbeam_on.Location = new System.Drawing.Point(344, 27);
            this.button_lowbeam_on.Name = "button_lowbeam_on";
            this.button_lowbeam_on.Size = new System.Drawing.Size(100, 57);
            this.button_lowbeam_on.TabIndex = 4;
            this.button_lowbeam_on.Text = "近光灯开(K)";
            this.button_lowbeam_on.UseVisualStyleBackColor = true;
            this.button_lowbeam_on.Click += new System.EventHandler(this.button_lowbeam_on_Click);
            // 
            // button_rlamp_off
            // 
            this.button_rlamp_off.Location = new System.Drawing.Point(184, 102);
            this.button_rlamp_off.Name = "button_rlamp_off";
            this.button_rlamp_off.Size = new System.Drawing.Size(120, 56);
            this.button_rlamp_off.TabIndex = 3;
            this.button_rlamp_off.Text = "右转向灯关(U)";
            this.button_rlamp_off.UseVisualStyleBackColor = true;
            this.button_rlamp_off.Click += new System.EventHandler(this.button_rlamp_off_Click);
            // 
            // button_rlamp_on
            // 
            this.button_rlamp_on.Location = new System.Drawing.Point(184, 27);
            this.button_rlamp_on.Name = "button_rlamp_on";
            this.button_rlamp_on.Size = new System.Drawing.Size(120, 57);
            this.button_rlamp_on.TabIndex = 2;
            this.button_rlamp_on.Text = "右转向灯开(J)";
            this.button_rlamp_on.UseVisualStyleBackColor = true;
            this.button_rlamp_on.Click += new System.EventHandler(this.button_rlamp_on_Click);
            // 
            // button_llamp_off
            // 
            this.button_llamp_off.Location = new System.Drawing.Point(25, 102);
            this.button_llamp_off.Name = "button_llamp_off";
            this.button_llamp_off.Size = new System.Drawing.Size(120, 56);
            this.button_llamp_off.TabIndex = 1;
            this.button_llamp_off.Text = "左转向灯关(Y)";
            this.button_llamp_off.UseVisualStyleBackColor = true;
            this.button_llamp_off.Click += new System.EventHandler(this.button_llamp_off_Click);
            // 
            // button_llamp_on
            // 
            this.button_llamp_on.Location = new System.Drawing.Point(25, 27);
            this.button_llamp_on.Name = "button_llamp_on";
            this.button_llamp_on.Size = new System.Drawing.Size(120, 57);
            this.button_llamp_on.TabIndex = 0;
            this.button_llamp_on.Text = "左转向灯开(H)";
            this.button_llamp_on.UseVisualStyleBackColor = true;
            this.button_llamp_on.Click += new System.EventHandler(this.button_llamp_on_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "当前远近光灯模式";
            // 
            // textBox_mode
            // 
            this.textBox_mode.Location = new System.Drawing.Point(198, 36);
            this.textBox_mode.Name = "textBox_mode";
            this.textBox_mode.Size = new System.Drawing.Size(100, 28);
            this.textBox_mode.TabIndex = 20;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // vispShoot
            // 
            this.vispShoot.BackColor = System.Drawing.Color.White;
            this.vispShoot.Location = new System.Drawing.Point(28, 76);
            this.vispShoot.Name = "vispShoot";
            this.vispShoot.Size = new System.Drawing.Size(609, 393);
            this.vispShoot.TabIndex = 21;
            this.vispShoot.Text = "videoSourcePlayer1";
            this.vispShoot.VideoSource = null;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(797, 253);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(80, 37);
            this.btnDisconnect.TabIndex = 23;
            this.btnDisconnect.Text = "断开";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // picbPreview
            // 
            this.picbPreview.BackColor = System.Drawing.Color.White;
            this.picbPreview.Image = null;
            this.picbPreview.Location = new System.Drawing.Point(674, 76);
            this.picbPreview.Name = "picbPreview";
            this.picbPreview.Size = new System.Drawing.Size(217, 160);
            this.picbPreview.TabIndex = 25;
            this.picbPreview.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_cam_up);
            this.groupBox4.Controls.Add(this.button_cam_down);
            this.groupBox4.Controls.Add(this.button_cam_stop);
            this.groupBox4.Controls.Add(this.button_cam_right);
            this.groupBox4.Controls.Add(this.button_cam_left);
            this.groupBox4.Location = new System.Drawing.Point(933, 422);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(338, 257);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "舵机";
            // 
            // button_cam_up
            // 
            this.button_cam_up.Location = new System.Drawing.Point(127, 27);
            this.button_cam_up.Name = "button_cam_up";
            this.button_cam_up.Size = new System.Drawing.Size(80, 60);
            this.button_cam_up.TabIndex = 4;
            this.button_cam_up.Text = "摄像头上";
            this.button_cam_up.UseVisualStyleBackColor = true;
            this.button_cam_up.Click += new System.EventHandler(this.button_cam_up_Click);
            // 
            // button_cam_down
            // 
            this.button_cam_down.Location = new System.Drawing.Point(127, 179);
            this.button_cam_down.Name = "button_cam_down";
            this.button_cam_down.Size = new System.Drawing.Size(80, 60);
            this.button_cam_down.TabIndex = 3;
            this.button_cam_down.Text = "摄像头下";
            this.button_cam_down.UseVisualStyleBackColor = true;
            this.button_cam_down.Click += new System.EventHandler(this.button_cam_down_Click);
            // 
            // button_cam_stop
            // 
            this.button_cam_stop.Location = new System.Drawing.Point(127, 104);
            this.button_cam_stop.Name = "button_cam_stop";
            this.button_cam_stop.Size = new System.Drawing.Size(80, 60);
            this.button_cam_stop.TabIndex = 2;
            this.button_cam_stop.Text = "摄像头停";
            this.button_cam_stop.UseVisualStyleBackColor = true;
            this.button_cam_stop.Click += new System.EventHandler(this.button_cam_stop_Click);
            // 
            // button_cam_right
            // 
            this.button_cam_right.Location = new System.Drawing.Point(230, 104);
            this.button_cam_right.Name = "button_cam_right";
            this.button_cam_right.Size = new System.Drawing.Size(80, 60);
            this.button_cam_right.TabIndex = 1;
            this.button_cam_right.Text = "摄像头右";
            this.button_cam_right.UseVisualStyleBackColor = true;
            this.button_cam_right.Click += new System.EventHandler(this.button_cam_right_Click);
            // 
            // button_cam_left
            // 
            this.button_cam_left.Location = new System.Drawing.Point(25, 104);
            this.button_cam_left.Name = "button_cam_left";
            this.button_cam_left.Size = new System.Drawing.Size(80, 60);
            this.button_cam_left.TabIndex = 0;
            this.button_cam_left.Text = "摄像头左";
            this.button_cam_left.UseVisualStyleBackColor = true;
            this.button_cam_left.Click += new System.EventHandler(this.button_cam_left_Click);
            // 
            // 拍照ToolStripMenuItem
            // 
            this.拍照ToolStripMenuItem.Location = new System.Drawing.Point(696, 253);
            this.拍照ToolStripMenuItem.Name = "拍照ToolStripMenuItem";
            this.拍照ToolStripMenuItem.Size = new System.Drawing.Size(80, 37);
            this.拍照ToolStripMenuItem.TabIndex = 27;
            this.拍照ToolStripMenuItem.Text = "拍照";
            this.拍照ToolStripMenuItem.UseVisualStyleBackColor = true;
            this.拍照ToolStripMenuItem.Click += new System.EventHandler(this.拍照ToolStripMenuItem_Click_1);
            // 
            // Wif_Car_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1305, 698);
            this.Controls.Add(this.拍照ToolStripMenuItem);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.picbPreview);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.vispShoot);
            this.Controls.Add(this.textBox_mode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Wif_Car_Main";
            this.Text = "Wif_Car_Main";
            this.Load += new System.EventHandler(this.Wif_Car_Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Wif_Car_Main_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Wif_Car_Main_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbPreview)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_forward;
        private System.Windows.Forms.Button button_backward;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_lforward;
        private System.Windows.Forms.Button button_rforward;
        private System.Windows.Forms.Button button_lbackward;
        private System.Windows.Forms.Button button_rbackward;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button_speedup;
        private System.Windows.Forms.Button button_speeddown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_speed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_highbeam_off;
        private System.Windows.Forms.Button button_highbeam_on;
        private System.Windows.Forms.Button button_lowbeam_off;
        private System.Windows.Forms.Button button_lowbeam_on;
        private System.Windows.Forms.Button button_rlamp_off;
        private System.Windows.Forms.Button button_rlamp_on;
        private System.Windows.Forms.Button button_llamp_off;
        private System.Windows.Forms.Button button_llamp_on;
        private System.Windows.Forms.ToolStripMenuItem 视频ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 灯光模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自动ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 手动ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_mode;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private AForge.Controls.VideoSourcePlayer vispShoot;
        private System.Windows.Forms.Button btnDisconnect;
        private AForge.Controls.PictureBox picbPreview;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button 拍照ToolStripMenuItem;
        private System.Windows.Forms.Button button_cam_up;
        private System.Windows.Forms.Button button_cam_down;
        private System.Windows.Forms.Button button_cam_stop;
        private System.Windows.Forms.Button button_cam_right;
        private System.Windows.Forms.Button button_cam_left;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}