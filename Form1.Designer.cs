namespace SecOPs_Suite
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            SideMenuPanel = new Panel();
            AntiMalbtn = new Button();
            VPNbtn = new Button();
            SubMenuPanel = new Panel();
            updatebtn = new Button();
            logbtn = new Button();
            configbtn = new Button();
            settingsbtn = new Button();
            homebtn = new Button();
            LogoPanel = new Panel();
            notifyIcon = new NotifyIcon(components);
            contextMenuStrip = new ContextMenuStrip(components);
            MainPanel = new Panel();
            pictureBox1 = new PictureBox();
            ProgressBarpanel = new Panel();
            progressBar1 = new ProgressBar();
            SideMenuPanel.SuspendLayout();
            SubMenuPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ProgressBarpanel.SuspendLayout();
            SuspendLayout();
            // 
            // SideMenuPanel
            // 
            SideMenuPanel.AutoScroll = true;
            SideMenuPanel.BackColor = Color.FromArgb(11, 7, 25);
            SideMenuPanel.Controls.Add(AntiMalbtn);
            SideMenuPanel.Controls.Add(VPNbtn);
            SideMenuPanel.Controls.Add(SubMenuPanel);
            SideMenuPanel.Controls.Add(settingsbtn);
            SideMenuPanel.Controls.Add(homebtn);
            SideMenuPanel.Controls.Add(LogoPanel);
            SideMenuPanel.Dock = DockStyle.Left;
            SideMenuPanel.Location = new Point(0, 0);
            SideMenuPanel.Name = "SideMenuPanel";
            SideMenuPanel.Size = new Size(250, 445);
            SideMenuPanel.TabIndex = 0;
            // 
            // AntiMalbtn
            // 
            AntiMalbtn.Dock = DockStyle.Top;
            AntiMalbtn.FlatAppearance.BorderSize = 0;
            AntiMalbtn.FlatStyle = FlatStyle.Flat;
            AntiMalbtn.ForeColor = Color.Gainsboro;
            AntiMalbtn.Location = new Point(0, 300);
            AntiMalbtn.Name = "AntiMalbtn";
            AntiMalbtn.Padding = new Padding(10, 0, 0, 0);
            AntiMalbtn.Size = new Size(250, 29);
            AntiMalbtn.TabIndex = 5;
            AntiMalbtn.Text = "Scanner";
            AntiMalbtn.TextAlign = ContentAlignment.MiddleLeft;
            AntiMalbtn.UseVisualStyleBackColor = true;
            AntiMalbtn.Click += AntiMalbtn_Click;
            // 
            // VPNbtn
            // 
            VPNbtn.Dock = DockStyle.Top;
            VPNbtn.FlatAppearance.BorderSize = 0;
            VPNbtn.FlatStyle = FlatStyle.Flat;
            VPNbtn.ForeColor = Color.Gainsboro;
            VPNbtn.Location = new Point(0, 271);
            VPNbtn.Name = "VPNbtn";
            VPNbtn.Padding = new Padding(10, 0, 0, 0);
            VPNbtn.Size = new Size(250, 29);
            VPNbtn.TabIndex = 4;
            VPNbtn.Text = "VPN";
            VPNbtn.TextAlign = ContentAlignment.MiddleLeft;
            VPNbtn.UseVisualStyleBackColor = true;
            VPNbtn.Click += VPNbtn_Click;
            // 
            // SubMenuPanel
            // 
            SubMenuPanel.Controls.Add(updatebtn);
            SubMenuPanel.Controls.Add(logbtn);
            SubMenuPanel.Controls.Add(configbtn);
            SubMenuPanel.Dock = DockStyle.Top;
            SubMenuPanel.Location = new Point(0, 183);
            SubMenuPanel.Name = "SubMenuPanel";
            SubMenuPanel.Size = new Size(250, 88);
            SubMenuPanel.TabIndex = 3;
            SubMenuPanel.Visible = false;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.Gray;
            updatebtn.Dock = DockStyle.Top;
            updatebtn.FlatAppearance.BorderSize = 0;
            updatebtn.FlatStyle = FlatStyle.Flat;
            updatebtn.ForeColor = Color.Gainsboro;
            updatebtn.Location = new Point(0, 58);
            updatebtn.Name = "updatebtn";
            updatebtn.Padding = new Padding(35, 0, 0, 0);
            updatebtn.Size = new Size(250, 29);
            updatebtn.TabIndex = 2;
            updatebtn.Text = "Update";
            updatebtn.TextAlign = ContentAlignment.MiddleLeft;
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // logbtn
            // 
            logbtn.BackColor = Color.Gray;
            logbtn.Dock = DockStyle.Top;
            logbtn.FlatAppearance.BorderSize = 0;
            logbtn.FlatStyle = FlatStyle.Flat;
            logbtn.ForeColor = Color.Gainsboro;
            logbtn.Location = new Point(0, 29);
            logbtn.Name = "logbtn";
            logbtn.Padding = new Padding(35, 0, 0, 0);
            logbtn.Size = new Size(250, 29);
            logbtn.TabIndex = 1;
            logbtn.Text = "Logs";
            logbtn.TextAlign = ContentAlignment.MiddleLeft;
            logbtn.UseVisualStyleBackColor = false;
            logbtn.Click += logbtn_Click;
            // 
            // configbtn
            // 
            configbtn.BackColor = Color.Gray;
            configbtn.Dock = DockStyle.Top;
            configbtn.FlatAppearance.BorderSize = 0;
            configbtn.FlatStyle = FlatStyle.Flat;
            configbtn.ForeColor = Color.Gainsboro;
            configbtn.Location = new Point(0, 0);
            configbtn.Name = "configbtn";
            configbtn.Padding = new Padding(35, 0, 0, 0);
            configbtn.Size = new Size(250, 29);
            configbtn.TabIndex = 0;
            configbtn.Text = "Configuration";
            configbtn.TextAlign = ContentAlignment.MiddleLeft;
            configbtn.UseVisualStyleBackColor = false;
            configbtn.Click += configbtn_Click;
            // 
            // settingsbtn
            // 
            settingsbtn.Dock = DockStyle.Top;
            settingsbtn.FlatAppearance.BorderSize = 0;
            settingsbtn.FlatStyle = FlatStyle.Flat;
            settingsbtn.ForeColor = Color.Gainsboro;
            settingsbtn.Location = new Point(0, 154);
            settingsbtn.Name = "settingsbtn";
            settingsbtn.Padding = new Padding(10, 0, 0, 0);
            settingsbtn.Size = new Size(250, 29);
            settingsbtn.TabIndex = 2;
            settingsbtn.Text = "Settings";
            settingsbtn.TextAlign = ContentAlignment.MiddleLeft;
            settingsbtn.UseVisualStyleBackColor = true;
            settingsbtn.Click += settingsbtn_Click;
            // 
            // homebtn
            // 
            homebtn.Dock = DockStyle.Top;
            homebtn.FlatAppearance.BorderSize = 0;
            homebtn.FlatStyle = FlatStyle.Flat;
            homebtn.ForeColor = Color.Gainsboro;
            homebtn.Location = new Point(0, 125);
            homebtn.Name = "homebtn";
            homebtn.Padding = new Padding(10, 0, 0, 0);
            homebtn.Size = new Size(250, 29);
            homebtn.TabIndex = 1;
            homebtn.Text = "Home";
            homebtn.TextAlign = ContentAlignment.MiddleLeft;
            homebtn.UseVisualStyleBackColor = true;
            homebtn.Click += homebtn_Click;
            // 
            // LogoPanel
            // 
            LogoPanel.BackColor = Color.FromArgb(11, 7, 25);
            LogoPanel.Dock = DockStyle.Top;
            LogoPanel.Location = new Point(0, 0);
            LogoPanel.Name = "LogoPanel";
            LogoPanel.Size = new Size(250, 125);
            LogoPanel.TabIndex = 0;
            // 
            // notifyIcon
            // 
            notifyIcon.ContextMenuStrip = contextMenuStrip;
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "SecOPs Suite";
            notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new Size(20, 20);
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(61, 4);
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(11, 7, 25);
            MainPanel.Controls.Add(pictureBox1);
            MainPanel.Location = new Point(249, -1);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(756, 409);
            MainPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(293, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ProgressBarpanel
            // 
            ProgressBarpanel.Controls.Add(progressBar1);
            ProgressBarpanel.Location = new Point(251, 414);
            ProgressBarpanel.Name = "ProgressBarpanel";
            ProgressBarpanel.Size = new Size(754, 31);
            ProgressBarpanel.TabIndex = 3;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(5, 3);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(749, 29);
            progressBar1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 445);
            Controls.Add(ProgressBarpanel);
            Controls.Add(MainPanel);
            Controls.Add(SideMenuPanel);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "SecOPs Suite";
            SideMenuPanel.ResumeLayout(false);
            SubMenuPanel.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ProgressBarpanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel SideMenuPanel;
        private Panel LogoPanel;
        private Button homebtn;
        private Panel SubMenuPanel;
        private Button updatebtn;
        private Button logbtn;
        private Button configbtn;
        private Button settingsbtn;
        private Button VPNbtn;
        private Button AntiMalbtn;
        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenuStrip;
        private Panel MainPanel;
        private Panel ProgressBarpanel;
        private ProgressBar progressBar1;
        private PictureBox pictureBox1;
    }
}