using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critters
{
    public partial class Critters : Form
    {
        SecurityLibrary security;
        DatabaseLibrary database;

        public bool UserLoggedIn { get; set; }
        public string UserName = "";
        public double UserId = 0;


        public Critters()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Switch active panel
        /// </summary>
        /// <param name="panelName"></param>
        public void ChangePanel(string panelName)
        {
            Panel showPanel = new Panel();

            showPanel.Name = panelName;
            showPanel.Size = new System.Drawing.Size(922, 508);
            showPanel.Location = new System.Drawing.Point(160, 85);


            switch (panelName)
            {
                case "homePanel":
                    homePanel.Visible = true;
                    loginPanel.Visible = false;
                    break;
                case "loginPanel":
                    homePanel.Visible = false;
                    loginPanel.Visible = true;
                    break;
                default:
                    homePanel.Visible = true;
                    loginPanel.Visible = false;
                    break;
            }
        }

        private void Critters_Load(object sender, EventArgs e)
        {
            ChangePanel("homePanel");

        }

        private void browseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginMenuStripItem_Click(object sender, EventArgs e)
        {
            ChangePanel("loginPanel");
        }

        private void logoutMenuStripItem_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            ChangePanel("homePanel");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string tempUser = userNameTextBox.Text;
            string tempPassword = passwordTextBox.Text;
            if (security==null)
            {
                security = new SecurityLibrary();
                SecurityLibrary.ProcessLogin(tempUser, tempPassword);
            }
        }

    }
}