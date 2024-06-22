namespace SecOPs_Suite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Design();
        }

        private void Design()
        {
            SubMenuPanel.Visible = false;

        }
        private void hideSubmenu()
        {
            if (SubMenuPanel.Visible == true) SubMenuPanel.Visible = false;
        }
        private void showSubmenu(Panel subMenu)
        {
            if (SubMenuPanel.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void settingsbtn_Click(object sender, EventArgs e)
        {
            showSubmenu(SubMenuPanel);
        }

        private void configbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            //..
            //code
            //..
            hideSubmenu();
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            //..
            //code
            //..
            hideSubmenu();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            //..
            //code
            //..
            hideSubmenu();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            //..
            //code
            //..
            hideSubmenu();
        }

        private void VPNbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            //..
            //code
            //..
            hideSubmenu();
        }

        private void AntiMalbtn_Click(object sender, EventArgs e)
        {
            //..
            //code
            //..
            hideSubmenu();
        }


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) 
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(childForm);
            MainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }
    }
}