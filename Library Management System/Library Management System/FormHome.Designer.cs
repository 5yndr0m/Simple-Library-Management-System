namespace Library_Management_System
{
    partial class Home
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
            this.panelHead = new System.Windows.Forms.Panel();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.panelSidePanel = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonAccount = new System.Windows.Forms.Button();
            this.buttonReserve = new System.Windows.Forms.Button();
            this.buttonBorrow = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.panelSidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(169)))));
            this.panelHead.Controls.Add(this.labelUser);
            this.panelHead.Controls.Add(this.labelUsername);
            this.panelHead.Controls.Add(this.label2);
            this.panelHead.Controls.Add(this.label1);
            this.panelHead.Controls.Add(this.pictureBoxProfile);
            this.panelHead.Location = new System.Drawing.Point(12, 12);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(776, 86);
            this.panelHead.TabIndex = 0;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(87, 37);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(36, 16);
            this.labelUser.TabIndex = 7;
            this.labelUser.Text = "User";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(87, 13);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(0, 18);
            this.labelUsername.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "University Library Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(554, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dashboard";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackgroundImage = global::Library_Management_System.Properties.Resources.avatar_3814049_1280;
            this.pictureBoxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxProfile.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(78, 80);
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // panelSidePanel
            // 
            this.panelSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.panelSidePanel.Controls.Add(this.buttonLogout);
            this.panelSidePanel.Controls.Add(this.buttonAccount);
            this.panelSidePanel.Controls.Add(this.buttonReserve);
            this.panelSidePanel.Controls.Add(this.buttonBorrow);
            this.panelSidePanel.Controls.Add(this.buttonBrowse);
            this.panelSidePanel.Controls.Add(this.buttonHome);
            this.panelSidePanel.Location = new System.Drawing.Point(12, 104);
            this.panelSidePanel.Name = "panelSidePanel";
            this.panelSidePanel.Size = new System.Drawing.Size(118, 334);
            this.panelSidePanel.TabIndex = 1;
            this.panelSidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSidePanel_Paint);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.buttonLogout.FlatAppearance.BorderSize = 2;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(7, 282);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(104, 39);
            this.buttonLogout.TabIndex = 27;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonAccount
            // 
            this.buttonAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.buttonAccount.FlatAppearance.BorderSize = 2;
            this.buttonAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccount.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccount.Location = new System.Drawing.Point(7, 227);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(104, 39);
            this.buttonAccount.TabIndex = 26;
            this.buttonAccount.Text = "Account";
            this.buttonAccount.UseVisualStyleBackColor = false;
            this.buttonAccount.Click += new System.EventHandler(this.buttonAccount_Click);
            // 
            // buttonReserve
            // 
            this.buttonReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.buttonReserve.FlatAppearance.BorderSize = 2;
            this.buttonReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReserve.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReserve.Location = new System.Drawing.Point(7, 174);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(104, 39);
            this.buttonReserve.TabIndex = 25;
            this.buttonReserve.Text = "Reserve";
            this.buttonReserve.UseVisualStyleBackColor = false;
            this.buttonReserve.Click += new System.EventHandler(this.buttonReserve_Click);
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.buttonBorrow.FlatAppearance.BorderSize = 2;
            this.buttonBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrow.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrow.Location = new System.Drawing.Point(7, 121);
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Size = new System.Drawing.Size(104, 39);
            this.buttonBorrow.TabIndex = 24;
            this.buttonBorrow.Text = "Borrow";
            this.buttonBorrow.UseVisualStyleBackColor = false;
            this.buttonBorrow.Click += new System.EventHandler(this.buttonBorrow_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.buttonBrowse.FlatAppearance.BorderSize = 2;
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowse.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowse.Location = new System.Drawing.Point(7, 68);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(104, 39);
            this.buttonBrowse.TabIndex = 23;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = false;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.buttonHome.FlatAppearance.BorderSize = 2;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.Location = new System.Drawing.Point(7, 13);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(104, 39);
            this.buttonHome.TabIndex = 22;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(169)))));
            this.panelBody.Location = new System.Drawing.Point(136, 104);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(652, 334);
            this.panelBody.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelSidePanel);
            this.Controls.Add(this.panelHead);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load_1);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.panelSidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Panel panelSidePanel;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonAccount;
        private System.Windows.Forms.Button buttonReserve;
        private System.Windows.Forms.Button buttonBorrow;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonHome;
        public System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelUsername;
    }
}