namespace Library_Management_System
{
    partial class FormRegistration
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
            this.labelRegistration = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.comboBoxFaculty = new System.Windows.Forms.ComboBox();
            this.textBoxRegistrationNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxConNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHaveAccount = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.panelHead.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(169)))));
            this.panelHead.Controls.Add(this.labelRegistration);
            this.panelHead.Controls.Add(this.label6);
            this.panelHead.Controls.Add(this.label7);
            this.panelHead.Location = new System.Drawing.Point(12, 12);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(374, 141);
            this.panelHead.TabIndex = 2;
            this.panelHead.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHead_Paint);
            // 
            // labelRegistration
            // 
            this.labelRegistration.AutoSize = true;
            this.labelRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistration.Location = new System.Drawing.Point(78, 98);
            this.labelRegistration.Name = "labelRegistration";
            this.labelRegistration.Size = new System.Drawing.Size(216, 29);
            this.labelRegistration.TabIndex = 10;
            this.labelRegistration.Text = "User Registration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(319, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "University Library Management System";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(343, 42);
            this.label7.TabIndex = 8;
            this.label7.Text = "Welcome to ULMS";
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.panelLogin);
            this.panelBody.Location = new System.Drawing.Point(12, 159);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(374, 391);
            this.panelBody.TabIndex = 3;
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(169)))));
            this.panelLogin.Controls.Add(this.comboBoxFaculty);
            this.panelLogin.Controls.Add(this.textBoxRegistrationNo);
            this.panelLogin.Controls.Add(this.label5);
            this.panelLogin.Controls.Add(this.textBoxConNumber);
            this.panelLogin.Controls.Add(this.label4);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.textBoxEmail);
            this.panelLogin.Controls.Add(this.textBoxName);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.labelHaveAccount);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.buttonBack);
            this.panelLogin.Controls.Add(this.buttonRegister);
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.textBoxUsername);
            this.panelLogin.Controls.Add(this.labelPassword);
            this.panelLogin.Controls.Add(this.labelUsername);
            this.panelLogin.Location = new System.Drawing.Point(3, 3);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(368, 382);
            this.panelLogin.TabIndex = 0;
            // 
            // comboBoxFaculty
            // 
            this.comboBoxFaculty.FormattingEnabled = true;
            this.comboBoxFaculty.Items.AddRange(new object[] {
            "Choose a Faculty",
            "Faculty of Applied Science",
            "Faculty of Business Studies",
            "Faculty of Technological Studies"});
            this.comboBoxFaculty.Location = new System.Drawing.Point(169, 164);
            this.comboBoxFaculty.Name = "comboBoxFaculty";
            this.comboBoxFaculty.Size = new System.Drawing.Size(168, 21);
            this.comboBoxFaculty.TabIndex = 34;
            // 
            // textBoxRegistrationNo
            // 
            this.textBoxRegistrationNo.Location = new System.Drawing.Point(169, 127);
            this.textBoxRegistrationNo.Name = "textBoxRegistrationNo";
            this.textBoxRegistrationNo.Size = new System.Drawing.Size(168, 20);
            this.textBoxRegistrationNo.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "Registration No";
            // 
            // textBoxConNumber
            // 
            this.textBoxConNumber.Location = new System.Drawing.Point(169, 235);
            this.textBoxConNumber.Name = "textBoxConNumber";
            this.textBoxConNumber.Size = new System.Drawing.Size(168, 20);
            this.textBoxConNumber.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Contact No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Faculty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(169, 200);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(168, 20);
            this.textBoxEmail.TabIndex = 26;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(169, 18);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(168, 20);
            this.textBoxName.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Name";
            // 
            // labelHaveAccount
            // 
            this.labelHaveAccount.AutoSize = true;
            this.labelHaveAccount.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHaveAccount.Location = new System.Drawing.Point(66, 272);
            this.labelHaveAccount.Name = "labelHaveAccount";
            this.labelHaveAccount.Size = new System.Drawing.Size(238, 16);
            this.labelHaveAccount.TabIndex = 23;
            this.labelHaveAccount.Text = "Already have an account? Then Login";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.buttonLogin.FlatAppearance.BorderSize = 2;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(190, 335);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(104, 39);
            this.buttonLogin.TabIndex = 22;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.buttonBack.FlatAppearance.BorderSize = 2;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(80, 335);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(104, 39);
            this.buttonBack.TabIndex = 21;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.buttonRegister.FlatAppearance.BorderSize = 2;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(80, 291);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(214, 39);
            this.buttonRegister.TabIndex = 20;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(169, 90);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(168, 20);
            this.textBoxPassword.TabIndex = 19;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(169, 54);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(168, 20);
            this.textBoxUsername.TabIndex = 18;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(64, 90);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(87, 18);
            this.labelPassword.TabIndex = 17;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(58, 54);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(92, 18);
            this.labelUsername.TabIndex = 16;
            this.labelUsername.Text = "Username";
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(398, 556);
            this.ControlBox = false;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHead);
            this.Name = "FormRegistration";
            this.Text = "Registration";
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label labelHaveAccount;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRegistrationNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxFaculty;
        private System.Windows.Forms.TextBox textBoxConNumber;
        private System.Windows.Forms.Label labelRegistration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}