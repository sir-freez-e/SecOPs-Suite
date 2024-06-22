namespace SecOPs_Suite
{
    partial class Form3
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
            panel1 = new Panel();
            UsernameBox = new TextBox();
            PasswordBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Connectbtn = new Button();
            Cancelbtn = new Button();
            comboBox1 = new ComboBox();
            ProfileList = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(ProfileList);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(Cancelbtn);
            panel1.Controls.Add(Connectbtn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(PasswordBox);
            panel1.Controls.Add(UsernameBox);
            panel1.Location = new Point(34, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(672, 331);
            panel1.TabIndex = 0;
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(41, 47);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(269, 27);
            UsernameBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(43, 110);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(267, 27);
            PasswordBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 18);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 82);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // Connectbtn
            // 
            Connectbtn.Location = new Point(46, 158);
            Connectbtn.Name = "Connectbtn";
            Connectbtn.Size = new Size(94, 29);
            Connectbtn.TabIndex = 4;
            Connectbtn.Text = "Connect";
            Connectbtn.UseVisualStyleBackColor = true;
            // 
            // Cancelbtn
            // 
            Cancelbtn.Location = new Point(210, 158);
            Cancelbtn.Name = "Cancelbtn";
            Cancelbtn.Size = new Size(94, 29);
            Cancelbtn.TabIndex = 5;
            Cancelbtn.Text = "Cancel";
            Cancelbtn.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(344, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(285, 28);
            comboBox1.TabIndex = 6;
            // 
            // ProfileList
            // 
            ProfileList.AutoSize = true;
            ProfileList.Location = new Point(347, 19);
            ProfileList.Name = "ProfileList";
            ProfileList.Size = new Size(58, 20);
            ProfileList.TabIndex = 7;
            ProfileList.Text = "Profiles";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 362);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox PasswordBox;
        private TextBox UsernameBox;
        private Label ProfileList;
        private ComboBox comboBox1;
        private Button Cancelbtn;
        private Button Connectbtn;
    }
}