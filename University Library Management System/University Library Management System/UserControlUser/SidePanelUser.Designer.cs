namespace University_Library_Management_System
{
    partial class SidePanelUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonAccount = new System.Windows.Forms.Button();
            this.buttonLibraryInfo = new System.Windows.Forms.Button();
            this.buttonReserve = new System.Windows.Forms.Button();
            this.buttonBorrow = new System.Windows.Forms.Button();
            this.buttonCatalog = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(176, 272);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(76, 40);
            this.buttonLogout.TabIndex = 20;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonAccount
            // 
            this.buttonAccount.Location = new System.Drawing.Point(3, 272);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(76, 40);
            this.buttonAccount.TabIndex = 19;
            this.buttonAccount.Text = "Account";
            this.buttonAccount.UseVisualStyleBackColor = true;
            // 
            // buttonLibraryInfo
            // 
            this.buttonLibraryInfo.Location = new System.Drawing.Point(51, 193);
            this.buttonLibraryInfo.Name = "buttonLibraryInfo";
            this.buttonLibraryInfo.Size = new System.Drawing.Size(150, 40);
            this.buttonLibraryInfo.TabIndex = 18;
            this.buttonLibraryInfo.Text = "Library Information";
            this.buttonLibraryInfo.UseVisualStyleBackColor = true;
            // 
            // buttonReserve
            // 
            this.buttonReserve.Location = new System.Drawing.Point(51, 147);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(150, 40);
            this.buttonReserve.TabIndex = 17;
            this.buttonReserve.Text = "Reserve and Hold";
            this.buttonReserve.UseVisualStyleBackColor = true;
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.Location = new System.Drawing.Point(51, 101);
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Size = new System.Drawing.Size(150, 40);
            this.buttonBorrow.TabIndex = 16;
            this.buttonBorrow.Text = "Borrow and Return";
            this.buttonBorrow.UseVisualStyleBackColor = true;
            // 
            // buttonCatalog
            // 
            this.buttonCatalog.Location = new System.Drawing.Point(51, 55);
            this.buttonCatalog.Name = "buttonCatalog";
            this.buttonCatalog.Size = new System.Drawing.Size(150, 40);
            this.buttonCatalog.TabIndex = 15;
            this.buttonCatalog.Text = "Catalogue";
            this.buttonCatalog.UseVisualStyleBackColor = true;
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(51, 9);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(150, 40);
            this.buttonHome.TabIndex = 14;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            // 
            // SidePanelUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonAccount);
            this.Controls.Add(this.buttonLibraryInfo);
            this.Controls.Add(this.buttonReserve);
            this.Controls.Add(this.buttonBorrow);
            this.Controls.Add(this.buttonCatalog);
            this.Controls.Add(this.buttonHome);
            this.Name = "SidePanelUser";
            this.Size = new System.Drawing.Size(255, 320);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonAccount;
        private System.Windows.Forms.Button buttonLibraryInfo;
        private System.Windows.Forms.Button buttonReserve;
        private System.Windows.Forms.Button buttonBorrow;
        private System.Windows.Forms.Button buttonCatalog;
        private System.Windows.Forms.Button buttonHome;
    }
}
