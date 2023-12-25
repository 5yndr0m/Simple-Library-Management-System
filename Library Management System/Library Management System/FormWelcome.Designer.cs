namespace Library_Management_System
{
    partial class FormWelcome
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
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonStaff = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelBody.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(169)))));
            this.panelHead.Location = new System.Drawing.Point(12, 12);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(776, 141);
            this.panelHead.TabIndex = 0;
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(169)))));
            this.panelBody.Controls.Add(this.panelButtons);
            this.panelBody.Location = new System.Drawing.Point(12, 159);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(776, 239);
            this.panelBody.TabIndex = 1;
            this.panelBody.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBody_Paint);
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.panelButtons.Controls.Add(this.buttonStaff);
            this.panelButtons.Controls.Add(this.buttonExit);
            this.panelButtons.Controls.Add(this.buttonRegister);
            this.panelButtons.Controls.Add(this.buttonLogin);
            this.panelButtons.Location = new System.Drawing.Point(626, 17);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(126, 206);
            this.panelButtons.TabIndex = 1;
            // 
            // buttonStaff
            // 
            this.buttonStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.buttonStaff.FlatAppearance.BorderSize = 2;
            this.buttonStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStaff.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStaff.Location = new System.Drawing.Point(12, 106);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Size = new System.Drawing.Size(104, 38);
            this.buttonStaff.TabIndex = 8;
            this.buttonStaff.Text = "Staff";
            this.buttonStaff.UseVisualStyleBackColor = false;
            this.buttonStaff.Click += new System.EventHandler(this.buttonStaff_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.buttonExit.FlatAppearance.BorderSize = 2;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(12, 150);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(104, 38);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.buttonRegister.FlatAppearance.BorderSize = 2;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(12, 62);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(104, 38);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.buttonLogin.FlatAppearance.BorderSize = 2;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(12, 18);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(104, 38);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // FormWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(800, 404);
            this.ControlBox = false;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHead);
            this.Name = "FormWelcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.FormWelcome_Load);
            this.panelBody.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonStaff;
    }
}

