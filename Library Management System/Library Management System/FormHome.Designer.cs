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
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.panelSidePanel = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
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
            this.panelHead.Controls.Add(this.pictureBoxProfile);
            this.panelHead.Location = new System.Drawing.Point(12, 12);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(776, 86);
            this.panelHead.TabIndex = 0;
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
            this.panelSidePanel.Controls.Add(this.buttonBack);
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
            // 
            // buttonBack
            // 
            this.buttonBack.FlatAppearance.BorderSize = 2;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(3, 273);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(104, 39);
            this.buttonBack.TabIndex = 28;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.FlatAppearance.BorderSize = 2;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(3, 228);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(104, 39);
            this.buttonLogout.TabIndex = 27;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonAccount
            // 
            this.buttonAccount.FlatAppearance.BorderSize = 2;
            this.buttonAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccount.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccount.Location = new System.Drawing.Point(3, 183);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(104, 39);
            this.buttonAccount.TabIndex = 26;
            this.buttonAccount.Text = "Account";
            this.buttonAccount.UseVisualStyleBackColor = true;
            this.buttonAccount.Click += new System.EventHandler(this.buttonAccount_Click);
            // 
            // buttonReserve
            // 
            this.buttonReserve.FlatAppearance.BorderSize = 2;
            this.buttonReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReserve.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReserve.Location = new System.Drawing.Point(3, 138);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(104, 39);
            this.buttonReserve.TabIndex = 25;
            this.buttonReserve.Text = "Reserve";
            this.buttonReserve.UseVisualStyleBackColor = true;
            this.buttonReserve.Click += new System.EventHandler(this.buttonReserve_Click);
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.FlatAppearance.BorderSize = 2;
            this.buttonBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrow.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrow.Location = new System.Drawing.Point(3, 93);
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Size = new System.Drawing.Size(104, 39);
            this.buttonBorrow.TabIndex = 24;
            this.buttonBorrow.Text = "Borrow";
            this.buttonBorrow.UseVisualStyleBackColor = true;
            this.buttonBorrow.Click += new System.EventHandler(this.buttonBorrow_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.FlatAppearance.BorderSize = 2;
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowse.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowse.Location = new System.Drawing.Point(3, 48);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(104, 39);
            this.buttonBrowse.TabIndex = 23;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderSize = 2;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.Location = new System.Drawing.Point(3, 3);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(104, 39);
            this.buttonHome.TabIndex = 22;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panelBody
            // 
            this.panelBody.Location = new System.Drawing.Point(136, 104);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(652, 334);
            this.panelBody.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelSidePanel);
            this.Controls.Add(this.panelHead);
            this.Name = "Home";
            this.Text = "Home";
            this.panelHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.panelSidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Panel panelSidePanel;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonAccount;
        private System.Windows.Forms.Button buttonReserve;
        private System.Windows.Forms.Button buttonBorrow;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonHome;
        public System.Windows.Forms.Panel panelBody;
    }
}