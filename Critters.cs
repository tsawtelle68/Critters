using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Critters
{
    public partial class Critters : Form
    {
        DatabaseLibrary databaseLibrary = new DatabaseLibrary();

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
                    productPanel.Visible = false;
                    this.AcceptButton = null;
                    homePanel.Width = 922;
                    homePanel.Height = 508;
                    homePanel.Top = 85;
                    homePanel.Left = 159;
                    break;
                case "loginPanel":
                    homePanel.Visible = false;
                    loginPanel.Visible = true;
                    productPanel.Visible = false;
                    this.AcceptButton = loginButton;
                    userNameTextBox.Focus();
                    loginPanel.Width = 922;
                    loginPanel.Height = 508;
                    loginPanel.Top = 85;
                    loginPanel.Left = 159;
                    break;
                case "productPanel":
                    homePanel.Visible = false;
                    loginPanel.Visible = false;
                    productPanel.Visible = true;
                    productPanel.Width = 922;
                    productPanel.Height = 508;
                    productPanel.Top = 85;
                    productPanel.Left = 159;
                    //                    this.AcceptButton = loginButton;
                    //                    userNameTextBox.Focus();
                    break;
                default:
                    homePanel.Visible = true;
                    loginPanel.Visible = false;
                    productPanel.Visible = false;
                    this.AcceptButton = null;
                    break;
            }
        }

        private void Critters_Load(object sender, EventArgs e)
        {
            ChangePanel("homePanel");


        }

        private void browseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel("productPanel");
            databaseLibrary.GetProducts("All");

            int itemCount = 0;

            itemCount = databaseLibrary.productList.Count;

            productListBox.Items.Add(databaseLibrary.productList[0]);

//            for (each 

        }

        private void loginMenuStripItem_Click(object sender, EventArgs e)
        {
            ChangePanel("loginPanel");
//            userNameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void logoutMenuStripItem_Click(object sender, EventArgs e)
        {
            databaseLibrary.userLoggedIn = false;
            databaseLibrary.userId = 0;
            databaseLibrary.userName = "";
            databaseLibrary.userNameLast = "";
            databaseLibrary.userNameFirst = "";
            databaseLibrary.userAdmin = "N";
            databaseLibrary.userLoggedIn = false;
            myCartMenuStripItem.Enabled = false;
            accountMenuStripItem.Enabled = false;
            loginMenuStripItem.Enabled = true;
            logoutMenuStripItem.Enabled = false;
            ChangePanel("homePanel");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            ChangePanel("homePanel");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string tempUser = userNameTextBox.Text;
            string tempPassword = passwordTextBox.Text;

            databaseLibrary.LoadUser(tempUser, tempPassword);
            if(databaseLibrary.userLoggedIn)
            {
                myCartMenuStripItem.Enabled = true;
                accountMenuStripItem.Enabled = true;
                loginMenuStripItem.Enabled = false;
                logoutMenuStripItem.Enabled=true;
                ChangePanel("homePanel");
            }
        }

        private void accountMenuStripItem_Click(object sender, EventArgs e)
        {

        }
    }
}