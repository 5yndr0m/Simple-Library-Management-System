namespace Library_Management_System
{
    partial class FormStaffControls
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
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonBookManagement = new System.Windows.Forms.Button();
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
            this.panelHead.TabIndex = 3;
            this.panelHead.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHead_Paint);
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
            this.panelSidePanel.Controls.Add(this.buttonLogout);
            this.panelSidePanel.Controls.Add(this.buttonUsers);
            this.panelSidePanel.Controls.Add(this.buttonBookManagement);
            this.panelSidePanel.Controls.Add(this.buttonHome);
            this.panelSidePanel.Location = new System.Drawing.Point(12, 104);
            this.panelSidePanel.Name = "panelSidePanel";
            this.panelSidePanel.Size = new System.Drawing.Size(118, 334);
            this.panelSidePanel.TabIndex = 4;
            this.panelSidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSidePanel_Paint);
            // 
            // buttonLogout
            // 
            this.buttonLogout.FlatAppearance.BorderSize = 2;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(3, 138);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(104, 39);
            this.buttonLogout.TabIndex = 27;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonUsers
            // 
            this.buttonUsers.FlatAppearance.BorderSize = 2;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsers.Location = new System.Drawing.Point(3, 93);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(104, 39);
            this.buttonUsers.TabIndex = 25;
            this.buttonUsers.Text = "Users";
            this.buttonUsers.UseVisualStyleBackColor = true;
            // 
            // buttonBookManagement
            // 
            this.buttonBookManagement.FlatAppearance.BorderSize = 2;
            this.buttonBookManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBookManagement.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBookManagement.Location = new System.Drawing.Point(3, 48);
            this.buttonBookManagement.Name = "buttonBookManagement";
            this.buttonBookManagement.Size = new System.Drawing.Size(104, 39);
            this.buttonBookManagement.TabIndex = 24;
            this.buttonBookManagement.Text = "Books";
            this.buttonBookManagement.UseVisualStyleBackColor = true;
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
            // 
            // panelBody
            // 
            this.panelBody.Location = new System.Drawing.Point(136, 104);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(652, 334);
            this.panelBody.TabIndex = 5;
            this.panelBody.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBody_Paint);
            // 
            // FormStaffControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.panelSidePanel);
            this.Controls.Add(this.panelBody);
            this.Name = "FormStaffControls";
            this.Text = "StaffControls";
            this.panelHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.panelSidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Panel panelSidePanel;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonBookManagement;
        private System.Windows.Forms.Button buttonHome;
        public System.Windows.Forms.Panel panelBody;
    }
}