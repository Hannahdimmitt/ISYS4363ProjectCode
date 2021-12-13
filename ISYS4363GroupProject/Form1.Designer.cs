
namespace ISYS4363GroupProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Label_MRTool = new System.Windows.Forms.Label();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Btn_CreateAcct = new System.Windows.Forms.Button();
            this.ReportPanel = new System.Windows.Forms.Panel();
            this.Movie_Metascore = new System.Windows.Forms.TextBox();
            this.Movie_Genre = new System.Windows.Forms.TextBox();
            this.Movie_Actors = new System.Windows.Forms.TextBox();
            this.Movie_Directors = new System.Windows.Forms.TextBox();
            this.Movie_Rating = new System.Windows.Forms.TextBox();
            this.Movie_Title = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.TxtBox_Search = new System.Windows.Forms.TextBox();
            this.PicBox_Report_2 = new System.Windows.Forms.PictureBox();
            this.PicBox_Report = new System.Windows.Forms.PictureBox();
            this.AccountPanel = new System.Windows.Forms.Panel();
            this.TxtBox_Name = new System.Windows.Forms.TextBox();
            this.Btn_CASubmit = new System.Windows.Forms.Button();
            this.TxtBox_Password = new System.Windows.Forms.TextBox();
            this.TxtBox_Username = new System.Windows.Forms.TextBox();
            this.TxtBox_Email = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.Submitbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.txtLoginEmail = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPanel.SuspendLayout();
            this.ReportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Report_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Report)).BeginInit();
            this.AccountPanel.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuPanel.Controls.Add(this.Btn_Search);
            this.MenuPanel.Controls.Add(this.Label_MRTool);
            this.MenuPanel.Controls.Add(this.Btn_Login);
            this.MenuPanel.Controls.Add(this.Btn_CreateAcct);
            this.MenuPanel.Location = new System.Drawing.Point(20, 309);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(202, 126);
            this.MenuPanel.TabIndex = 0;
            this.MenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuPanel_Paint);
            // 
            // Btn_Search
            // 
            this.Btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Search.Location = new System.Drawing.Point(-13, 108);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(203, 104);
            this.Btn_Search.TabIndex = 3;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Label_MRTool
            // 
            this.Label_MRTool.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_MRTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_MRTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MRTool.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_MRTool.Location = new System.Drawing.Point(-106, -162);
            this.Label_MRTool.Name = "Label_MRTool";
            this.Label_MRTool.Size = new System.Drawing.Size(390, 90);
            this.Label_MRTool.TabIndex = 2;
            this.Label_MRTool.Text = "Movie Rating Tool";
            this.Label_MRTool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_MRTool.Click += new System.EventHandler(this.Label_MRTool_Click);
            // 
            // Btn_Login
            // 
            this.Btn_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.Location = new System.Drawing.Point(122, -27);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(203, 104);
            this.Btn_Login.TabIndex = 1;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Btn_CreateAcct
            // 
            this.Btn_CreateAcct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_CreateAcct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CreateAcct.Location = new System.Drawing.Point(-155, -27);
            this.Btn_CreateAcct.Name = "Btn_CreateAcct";
            this.Btn_CreateAcct.Size = new System.Drawing.Size(203, 104);
            this.Btn_CreateAcct.TabIndex = 0;
            this.Btn_CreateAcct.Text = "Create Account";
            this.Btn_CreateAcct.UseVisualStyleBackColor = true;
            this.Btn_CreateAcct.Click += new System.EventHandler(this.Btn_CreateAcct_Click);
            // 
            // ReportPanel
            // 
            this.ReportPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReportPanel.Controls.Add(this.Movie_Metascore);
            this.ReportPanel.Controls.Add(this.Movie_Genre);
            this.ReportPanel.Controls.Add(this.Movie_Actors);
            this.ReportPanel.Controls.Add(this.Movie_Directors);
            this.ReportPanel.Controls.Add(this.Movie_Rating);
            this.ReportPanel.Controls.Add(this.Movie_Title);
            this.ReportPanel.Controls.Add(this.dataGridView1);
            this.ReportPanel.Controls.Add(this.Searchbtn);
            this.ReportPanel.Controls.Add(this.button1);
            this.ReportPanel.Controls.Add(this.SearchLabel);
            this.ReportPanel.Controls.Add(this.Btn_Submit);
            this.ReportPanel.Controls.Add(this.TxtBox_Search);
            this.ReportPanel.Controls.Add(this.PicBox_Report_2);
            this.ReportPanel.Controls.Add(this.PicBox_Report);
            this.ReportPanel.Location = new System.Drawing.Point(-9, 235);
            this.ReportPanel.Name = "ReportPanel";
            this.ReportPanel.Size = new System.Drawing.Size(630, 522);
            this.ReportPanel.TabIndex = 1;
            // 
            // Movie_Metascore
            // 
            this.Movie_Metascore.Location = new System.Drawing.Point(505, 123);
            this.Movie_Metascore.Name = "Movie_Metascore";
            this.Movie_Metascore.Size = new System.Drawing.Size(100, 20);
            this.Movie_Metascore.TabIndex = 18;
            this.Movie_Metascore.Text = "Movie Metascore";
            // 
            // Movie_Genre
            // 
            this.Movie_Genre.Location = new System.Drawing.Point(412, 123);
            this.Movie_Genre.Name = "Movie_Genre";
            this.Movie_Genre.Size = new System.Drawing.Size(100, 20);
            this.Movie_Genre.TabIndex = 17;
            this.Movie_Genre.Text = "Movie Genre";
            // 
            // Movie_Actors
            // 
            this.Movie_Actors.Location = new System.Drawing.Point(315, 123);
            this.Movie_Actors.Name = "Movie_Actors";
            this.Movie_Actors.Size = new System.Drawing.Size(100, 20);
            this.Movie_Actors.TabIndex = 16;
            this.Movie_Actors.Text = "Movie Actors";
            // 
            // Movie_Directors
            // 
            this.Movie_Directors.Location = new System.Drawing.Point(221, 123);
            this.Movie_Directors.Name = "Movie_Directors";
            this.Movie_Directors.Size = new System.Drawing.Size(100, 20);
            this.Movie_Directors.TabIndex = 15;
            this.Movie_Directors.Text = "Movie Directors";
            // 
            // Movie_Rating
            // 
            this.Movie_Rating.Location = new System.Drawing.Point(131, 123);
            this.Movie_Rating.Name = "Movie_Rating";
            this.Movie_Rating.Size = new System.Drawing.Size(100, 20);
            this.Movie_Rating.TabIndex = 14;
            this.Movie_Rating.Text = "Movie Rating";
            // 
            // Movie_Title
            // 
            this.Movie_Title.Location = new System.Drawing.Point(34, 123);
            this.Movie_Title.Name = "Movie_Title";
            this.Movie_Title.Size = new System.Drawing.Size(100, 20);
            this.Movie_Title.TabIndex = 13;
            this.Movie_Title.Text = "Movie Title";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(802, 360);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Searchbtn
            // 
            this.Searchbtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.Searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Searchbtn.Location = new System.Drawing.Point(89, 72);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(121, 45);
            this.Searchbtn.TabIndex = 11;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = false;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ratings by Actors";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SearchLabel
            // 
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchLabel.Location = new System.Drawing.Point(304, 53);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(244, 24);
            this.SearchLabel.TabIndex = 0;
            this.SearchLabel.Text = "Search for movies here:";
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.Location = new System.Drawing.Point(215, 583);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(144, 25);
            this.Btn_Submit.TabIndex = 9;
            this.Btn_Submit.Text = "Ratings by Genre";
            this.Btn_Submit.UseVisualStyleBackColor = true;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // TxtBox_Search
            // 
            this.TxtBox_Search.Location = new System.Drawing.Point(221, 86);
            this.TxtBox_Search.Name = "TxtBox_Search";
            this.TxtBox_Search.Size = new System.Drawing.Size(397, 20);
            this.TxtBox_Search.TabIndex = 1;
            // 
            // PicBox_Report_2
            // 
            this.PicBox_Report_2.Image = global::ISYS4363GroupProject.Properties.Resources.adsfwerqtdfh;
            this.PicBox_Report_2.Location = new System.Drawing.Point(503, 496);
            this.PicBox_Report_2.Name = "PicBox_Report_2";
            this.PicBox_Report_2.Size = new System.Drawing.Size(149, 81);
            this.PicBox_Report_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox_Report_2.TabIndex = 3;
            this.PicBox_Report_2.TabStop = false;
            // 
            // PicBox_Report
            // 
            this.PicBox_Report.Image = global::ISYS4363GroupProject.Properties.Resources.adsffffffffffffff;
            this.PicBox_Report.Location = new System.Drawing.Point(215, 496);
            this.PicBox_Report.Name = "PicBox_Report";
            this.PicBox_Report.Size = new System.Drawing.Size(150, 81);
            this.PicBox_Report.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox_Report.TabIndex = 2;
            this.PicBox_Report.TabStop = false;
            this.PicBox_Report.Click += new System.EventHandler(this.PicBox_Report_Click);
            // 
            // AccountPanel
            // 
            this.AccountPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AccountPanel.Controls.Add(this.TxtBox_Name);
            this.AccountPanel.Controls.Add(this.Btn_CASubmit);
            this.AccountPanel.Controls.Add(this.TxtBox_Password);
            this.AccountPanel.Controls.Add(this.TxtBox_Username);
            this.AccountPanel.Controls.Add(this.TxtBox_Email);
            this.AccountPanel.Controls.Add(this.PasswordLabel);
            this.AccountPanel.Controls.Add(this.UsernameLabel);
            this.AccountPanel.Controls.Add(this.EmailLabel);
            this.AccountPanel.Controls.Add(this.NameLabel);
            this.AccountPanel.Location = new System.Drawing.Point(81, 40);
            this.AccountPanel.Name = "AccountPanel";
            this.AccountPanel.Size = new System.Drawing.Size(407, 305);
            this.AccountPanel.TabIndex = 7;
            // 
            // TxtBox_Name
            // 
            this.TxtBox_Name.Location = new System.Drawing.Point(331, 199);
            this.TxtBox_Name.Name = "TxtBox_Name";
            this.TxtBox_Name.Size = new System.Drawing.Size(272, 20);
            this.TxtBox_Name.TabIndex = 1;
            // 
            // Btn_CASubmit
            // 
            this.Btn_CASubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CASubmit.Location = new System.Drawing.Point(314, 396);
            this.Btn_CASubmit.Name = "Btn_CASubmit";
            this.Btn_CASubmit.Size = new System.Drawing.Size(289, 121);
            this.Btn_CASubmit.TabIndex = 6;
            this.Btn_CASubmit.Text = "Create Account";
            this.Btn_CASubmit.UseVisualStyleBackColor = true;
            this.Btn_CASubmit.Click += new System.EventHandler(this.Btn_CASubmit_Click);
            // 
            // TxtBox_Password
            // 
            this.TxtBox_Password.Location = new System.Drawing.Point(331, 347);
            this.TxtBox_Password.Name = "TxtBox_Password";
            this.TxtBox_Password.Size = new System.Drawing.Size(272, 20);
            this.TxtBox_Password.TabIndex = 4;
            // 
            // TxtBox_Username
            // 
            this.TxtBox_Username.Location = new System.Drawing.Point(331, 291);
            this.TxtBox_Username.Name = "TxtBox_Username";
            this.TxtBox_Username.Size = new System.Drawing.Size(272, 20);
            this.TxtBox_Username.TabIndex = 3;
            // 
            // TxtBox_Email
            // 
            this.TxtBox_Email.Location = new System.Drawing.Point(331, 239);
            this.TxtBox_Email.Name = "TxtBox_Email";
            this.TxtBox_Email.Size = new System.Drawing.Size(272, 20);
            this.TxtBox_Email.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(215, 341);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(119, 37);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(209, 285);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(119, 35);
            this.UsernameLabel.TabIndex = 4;
            this.UsernameLabel.Text = "Username:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(253, 239);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(72, 24);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "Email:";
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(247, 195);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(87, 27);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoginPanel.Controls.Add(this.Submitbtn);
            this.LoginPanel.Controls.Add(this.label2);
            this.LoginPanel.Controls.Add(this.label21);
            this.LoginPanel.Controls.Add(this.label17);
            this.LoginPanel.Controls.Add(this.txtLoginPassword);
            this.LoginPanel.Controls.Add(this.txtLoginEmail);
            this.LoginPanel.Location = new System.Drawing.Point(611, 285);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(731, 601);
            this.LoginPanel.TabIndex = 3;
            // 
            // Submitbtn
            // 
            this.Submitbtn.Location = new System.Drawing.Point(406, 427);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(110, 45);
            this.Submitbtn.TabIndex = 15;
            this.Submitbtn.Text = "Submit";
            this.Submitbtn.UseVisualStyleBackColor = true;
            this.Submitbtn.Click += new System.EventHandler(this.Submitbtn_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(200, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(522, 95);
            this.label2.TabIndex = 14;
            this.label2.Text = "Account Login";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.Control;
            this.label21.Location = new System.Drawing.Point(199, 380);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(92, 24);
            this.label21.TabIndex = 13;
            this.label21.Text = "Password";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(160, 359);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(132, 24);
            this.label17.TabIndex = 12;
            this.label17.Text = "Email Address";
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(296, 384);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(358, 20);
            this.txtLoginPassword.TabIndex = 11;
            // 
            // txtLoginEmail
            // 
            this.txtLoginEmail.Location = new System.Drawing.Point(296, 362);
            this.txtLoginEmail.Name = "txtLoginEmail";
            this.txtLoginEmail.Size = new System.Drawing.Size(358, 20);
            this.txtLoginEmail.TabIndex = 10;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1408, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(51, 22);
            this.toolStripDropDownButton1.Text = "Menu";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 757);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.AccountPanel);
            this.Controls.Add(this.ReportPanel);
            this.Controls.Add(this.MenuPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuPanel.ResumeLayout(false);
            this.ReportPanel.ResumeLayout(false);
            this.ReportPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Report_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Report)).EndInit();
            this.AccountPanel.ResumeLayout(false);
            this.AccountPanel.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Button Btn_CreateAcct;
        private System.Windows.Forms.Label Label_MRTool;
        private System.Windows.Forms.Panel ReportPanel;
        private System.Windows.Forms.PictureBox PicBox_Report_2;
        private System.Windows.Forms.PictureBox PicBox_Report;
        private System.Windows.Forms.Panel AccountPanel;
        private System.Windows.Forms.TextBox TxtBox_Password;
        private System.Windows.Forms.TextBox TxtBox_Username;
        private System.Windows.Forms.TextBox TxtBox_Email;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.TextBox TxtBox_Search;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button Btn_CASubmit;
        private System.Windows.Forms.TextBox TxtBox_Name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button Submitbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.TextBox txtLoginEmail;
        private System.Windows.Forms.TextBox Movie_Metascore;
        private System.Windows.Forms.TextBox Movie_Genre;
        private System.Windows.Forms.TextBox Movie_Actors;
        private System.Windows.Forms.TextBox Movie_Directors;
        private System.Windows.Forms.TextBox Movie_Rating;
        private System.Windows.Forms.TextBox Movie_Title;
    }
}

