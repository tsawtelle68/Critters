namespace Critters
{
    partial class Critters
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
            this.components = new System.ComponentModel.Container();
            this.menu1Strip = new System.Windows.Forms.MenuStrip();
            this.logoutMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spacer1MenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myCartMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchForItemsMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menu2Strip = new System.Windows.Forms.MenuStrip();
            this.browseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseByPetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseDogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseCatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseFishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseBirdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homePanel = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.loginPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productPanel = new System.Windows.Forms.Panel();
            this.productListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menu1Strip.SuspendLayout();
            this.menu2Strip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.loginPanel.SuspendLayout();
            this.productPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu1Strip
            // 
            this.menu1Strip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu1Strip.AutoSize = false;
            this.menu1Strip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(152)))), ((int)(((byte)(214)))));
            this.menu1Strip.Dock = System.Windows.Forms.DockStyle.None;
            this.menu1Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutMenuStripItem,
            this.spacer1MenuStripItem,
            this.loginMenuStripItem,
            this.myCartMenuStripItem,
            this.accountMenuStripItem,
            this.searchForItemsMenuStripItem});
            this.menu1Strip.Location = new System.Drawing.Point(159, 46);
            this.menu1Strip.Name = "menu1Strip";
            this.menu1Strip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menu1Strip.Size = new System.Drawing.Size(922, 38);
            this.menu1Strip.TabIndex = 13;
            this.menu1Strip.Text = "menuStrip1";
            // 
            // logoutMenuStripItem
            // 
            this.logoutMenuStripItem.AutoSize = false;
            this.logoutMenuStripItem.Enabled = false;
            this.logoutMenuStripItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logoutMenuStripItem.Name = "logoutMenuStripItem";
            this.logoutMenuStripItem.Size = new System.Drawing.Size(64, 34);
            this.logoutMenuStripItem.Text = "Logout";
            this.logoutMenuStripItem.Click += new System.EventHandler(this.logoutMenuStripItem_Click);
            // 
            // spacer1MenuStripItem
            // 
            this.spacer1MenuStripItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.spacer1MenuStripItem.Name = "spacer1MenuStripItem";
            this.spacer1MenuStripItem.Size = new System.Drawing.Size(26, 34);
            this.spacer1MenuStripItem.Text = "/";
            // 
            // loginMenuStripItem
            // 
            this.loginMenuStripItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginMenuStripItem.Name = "loginMenuStripItem";
            this.loginMenuStripItem.Size = new System.Drawing.Size(55, 34);
            this.loginMenuStripItem.Text = "Login";
            this.loginMenuStripItem.Click += new System.EventHandler(this.loginMenuStripItem_Click);
            // 
            // myCartMenuStripItem
            // 
            this.myCartMenuStripItem.Enabled = false;
            this.myCartMenuStripItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.myCartMenuStripItem.Name = "myCartMenuStripItem";
            this.myCartMenuStripItem.Size = new System.Drawing.Size(68, 34);
            this.myCartMenuStripItem.Text = "My Cart";
            // 
            // accountMenuStripItem
            // 
            this.accountMenuStripItem.Enabled = false;
            this.accountMenuStripItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accountMenuStripItem.Name = "accountMenuStripItem";
            this.accountMenuStripItem.Size = new System.Drawing.Size(93, 34);
            this.accountMenuStripItem.Text = "My Account";
            this.accountMenuStripItem.Click += new System.EventHandler(this.accountMenuStripItem_Click);
            // 
            // searchForItemsMenuStripItem
            // 
            this.searchForItemsMenuStripItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchForItemsMenuStripItem.Name = "searchForItemsMenuStripItem";
            this.searchForItemsMenuStripItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchForItemsMenuStripItem.Size = new System.Drawing.Size(120, 34);
            this.searchForItemsMenuStripItem.Text = "Search for Items";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(157)))), ((int)(((byte)(245)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1081, 45);
            this.label1.TabIndex = 16;
            this.label1.Text = "Chloe\'s Cute Critters";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menu2Strip
            // 
            this.menu2Strip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.menu2Strip.AutoSize = false;
            this.menu2Strip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            this.menu2Strip.Dock = System.Windows.Forms.DockStyle.None;
            this.menu2Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseAllToolStripMenuItem,
            this.browseByPetToolStripMenuItem,
            this.browseDogToolStripMenuItem,
            this.browseCatToolStripMenuItem,
            this.browseFishToolStripMenuItem,
            this.browseBirdToolStripMenuItem});
            this.menu2Strip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menu2Strip.Location = new System.Drawing.Point(0, 46);
            this.menu2Strip.Name = "menu2Strip";
            this.menu2Strip.Padding = new System.Windows.Forms.Padding(5, 20, 0, 2);
            this.menu2Strip.Size = new System.Drawing.Size(159, 547);
            this.menu2Strip.TabIndex = 17;
            this.menu2Strip.Text = "menuStrip1";
            // 
            // browseAllToolStripMenuItem
            // 
            this.browseAllToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.browseAllToolStripMenuItem.Name = "browseAllToolStripMenuItem";
            this.browseAllToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.browseAllToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.browseAllToolStripMenuItem.Text = "Browse All Items";
            this.browseAllToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.browseAllToolStripMenuItem.Click += new System.EventHandler(this.browseAllToolStripMenuItem_Click);
            // 
            // browseByPetToolStripMenuItem
            // 
            this.browseByPetToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.browseByPetToolStripMenuItem.Name = "browseByPetToolStripMenuItem";
            this.browseByPetToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.browseByPetToolStripMenuItem.Text = "Browse By Pet";
            this.browseByPetToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // browseDogToolStripMenuItem
            // 
            this.browseDogToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.browseDogToolStripMenuItem.Image = global::Critters.Properties.Resources._22215_dog_icon;
            this.browseDogToolStripMenuItem.Name = "browseDogToolStripMenuItem";
            this.browseDogToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.browseDogToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.browseDogToolStripMenuItem.Text = "Dog";
            this.browseDogToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // browseCatToolStripMenuItem
            // 
            this.browseCatToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.browseCatToolStripMenuItem.Image = global::Critters.Properties.Resources._22221_cat_icon;
            this.browseCatToolStripMenuItem.Name = "browseCatToolStripMenuItem";
            this.browseCatToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.browseCatToolStripMenuItem.Text = "Cat";
            this.browseCatToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // browseFishToolStripMenuItem
            // 
            this.browseFishToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.browseFishToolStripMenuItem.Image = global::Critters.Properties.Resources._22294_tropical_fish_icon;
            this.browseFishToolStripMenuItem.Name = "browseFishToolStripMenuItem";
            this.browseFishToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.browseFishToolStripMenuItem.Text = "Fish";
            this.browseFishToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // browseBirdToolStripMenuItem
            // 
            this.browseBirdToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.browseBirdToolStripMenuItem.Image = global::Critters.Properties.Resources._22271_bird_icon;
            this.browseBirdToolStripMenuItem.Name = "browseBirdToolStripMenuItem";
            this.browseBirdToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.browseBirdToolStripMenuItem.Text = "Bird";
            // 
            // homePanel
            // 
            this.homePanel.AutoSize = true;
            this.homePanel.Location = new System.Drawing.Point(159, 85);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(359, 508);
            this.homePanel.TabIndex = 19;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.label4);
            this.loginPanel.Controls.Add(this.closeButton);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.passwordTextBox);
            this.loginPanel.Controls.Add(this.userNameTextBox);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.label3);
            this.loginPanel.Location = new System.Drawing.Point(159, 85);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(359, 508);
            this.loginPanel.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(44, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Please Login";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(161, 174);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(11, 174);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(86, 118);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(150, 23);
            this.passwordTextBox.TabIndex = 8;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(86, 69);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(150, 23);
            this.userNameTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "User Name:";
            // 
            // productPanel
            // 
            this.productPanel.BackColor = System.Drawing.Color.White;
            this.productPanel.Controls.Add(this.productListBox);
            this.productPanel.Controls.Add(this.label5);
            this.productPanel.Location = new System.Drawing.Point(159, 85);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(921, 508);
            this.productPanel.TabIndex = 23;
            // 
            // productListBox
            // 
            this.productListBox.FormattingEnabled = true;
            this.productListBox.ItemHeight = 15;
            this.productListBox.Location = new System.Drawing.Point(11, 87);
            this.productListBox.Name = "productListBox";
            this.productListBox.Size = new System.Drawing.Size(901, 409);
            this.productListBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(915, 45);
            this.label5.TabIndex = 0;
            this.label5.Text = "Products (All)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Critters
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 592);
            this.Controls.Add(this.productPanel);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu1Strip);
            this.Controls.Add(this.menu2Strip);
            this.Controls.Add(this.homePanel);
            this.IsMdiContainer = true;
            this.Name = "Critters";
            this.Text = "Chloe\'s Cute Critters";
            this.Load += new System.EventHandler(this.Critters_Load);
            this.menu1Strip.ResumeLayout(false);
            this.menu1Strip.PerformLayout();
            this.menu2Strip.ResumeLayout(false);
            this.menu2Strip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.productPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menu1Strip;
        private ToolStripMenuItem logoutMenuStripItem;
        private ToolStripMenuItem spacer1MenuStripItem;
        private ToolStripMenuItem loginMenuStripItem;
        private ToolStripMenuItem myCartMenuStripItem;
        private ToolStripMenuItem searchForItemsMenuStripItem;
        private Label label1;
        private MenuStrip menu2Strip;
        private ToolStripMenuItem browseAllToolStripMenuItem;
        private ToolStripMenuItem browseByPetToolStripMenuItem;
        private ToolStripMenuItem browseDogToolStripMenuItem;
        private ToolStripMenuItem browseCatToolStripMenuItem;
        private ToolStripMenuItem browseFishToolStripMenuItem;
        private Panel homePanel;
        private ToolStripMenuItem browseBirdToolStripMenuItem;
        private ErrorProvider errorProvider1;
        private Panel loginPanel;
        private Button closeButton;
        private Button loginButton;
        private TextBox passwordTextBox;
        private TextBox userNameTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel productPanel;
        private ToolStripMenuItem accountMenuStripItem;
        private Label label5;
        private ListBox productListBox;
    }
}