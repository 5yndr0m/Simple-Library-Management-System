namespace Library_Management_System.StaffControls
{
    partial class UserControlManageUsers
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
            this.groupBoxRemoveBooks = new System.Windows.Forms.GroupBox();
            this.labelregNo = new System.Windows.Forms.Label();
            this.textBoxRegno = new System.Windows.Forms.TextBox();
            this.textBoxRemoveUser = new System.Windows.Forms.TextBox();
            this.labelBookUsername = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxRemoveID = new System.Windows.Forms.TextBox();
            this.labelBookIDRemove = new System.Windows.Forms.Label();
            this.buttonRemoveBooks = new System.Windows.Forms.Button();
            this.groupBoxRemoveBooks.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRemoveBooks
            // 
            this.groupBoxRemoveBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(169)))));
            this.groupBoxRemoveBooks.Controls.Add(this.labelregNo);
            this.groupBoxRemoveBooks.Controls.Add(this.textBoxRegno);
            this.groupBoxRemoveBooks.Controls.Add(this.textBoxRemoveUser);
            this.groupBoxRemoveBooks.Controls.Add(this.labelBookUsername);
            this.groupBoxRemoveBooks.Controls.Add(this.buttonRemove);
            this.groupBoxRemoveBooks.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRemoveBooks.Location = new System.Drawing.Point(330, 3);
            this.groupBoxRemoveBooks.Name = "groupBoxRemoveBooks";
            this.groupBoxRemoveBooks.Size = new System.Drawing.Size(319, 198);
            this.groupBoxRemoveBooks.TabIndex = 2;
            this.groupBoxRemoveBooks.TabStop = false;
            this.groupBoxRemoveBooks.Text = "Remove User";
            // 
            // labelregNo
            // 
            this.labelregNo.AutoSize = true;
            this.labelregNo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelregNo.Location = new System.Drawing.Point(11, 94);
            this.labelregNo.Name = "labelregNo";
            this.labelregNo.Size = new System.Drawing.Size(118, 18);
            this.labelregNo.TabIndex = 44;
            this.labelregNo.Text = "Registration No";
            // 
            // textBoxRegno
            // 
            this.textBoxRegno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegno.Location = new System.Drawing.Point(136, 94);
            this.textBoxRegno.Name = "textBoxRegno";
            this.textBoxRegno.Size = new System.Drawing.Size(168, 26);
            this.textBoxRegno.TabIndex = 43;
            // 
            // textBoxRemoveUser
            // 
            this.textBoxRemoveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRemoveUser.Location = new System.Drawing.Point(136, 62);
            this.textBoxRemoveUser.Name = "textBoxRemoveUser";
            this.textBoxRemoveUser.Size = new System.Drawing.Size(168, 26);
            this.textBoxRemoveUser.TabIndex = 41;
            // 
            // labelBookUsername
            // 
            this.labelBookUsername.AutoSize = true;
            this.labelBookUsername.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookUsername.Location = new System.Drawing.Point(8, 62);
            this.labelBookUsername.Name = "labelBookUsername";
            this.labelBookUsername.Size = new System.Drawing.Size(81, 18);
            this.labelBookUsername.TabIndex = 42;
            this.labelBookUsername.Text = "Username";
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.buttonRemove.FlatAppearance.BorderSize = 2;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(200, 126);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(104, 39);
            this.buttonRemove.TabIndex = 41;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(169)))));
            this.groupBox1.Controls.Add(this.textBoxRemoveID);
            this.groupBox1.Controls.Add(this.labelBookIDRemove);
            this.groupBox1.Controls.Add(this.buttonRemoveBooks);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 198);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remove Books";
            // 
            // textBoxRemoveID
            // 
            this.textBoxRemoveID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRemoveID.Location = new System.Drawing.Point(108, 62);
            this.textBoxRemoveID.Name = "textBoxRemoveID";
            this.textBoxRemoveID.Size = new System.Drawing.Size(168, 26);
            this.textBoxRemoveID.TabIndex = 41;
            // 
            // labelBookIDRemove
            // 
            this.labelBookIDRemove.AutoSize = true;
            this.labelBookIDRemove.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookIDRemove.Location = new System.Drawing.Point(18, 62);
            this.labelBookIDRemove.Name = "labelBookIDRemove";
            this.labelBookIDRemove.Size = new System.Drawing.Size(65, 18);
            this.labelBookIDRemove.TabIndex = 42;
            this.labelBookIDRemove.Text = "Book ID";
            // 
            // buttonRemoveBooks
            // 
            this.buttonRemoveBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.buttonRemoveBooks.FlatAppearance.BorderSize = 2;
            this.buttonRemoveBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveBooks.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveBooks.Location = new System.Drawing.Point(172, 94);
            this.buttonRemoveBooks.Name = "buttonRemoveBooks";
            this.buttonRemoveBooks.Size = new System.Drawing.Size(104, 39);
            this.buttonRemoveBooks.TabIndex = 41;
            this.buttonRemoveBooks.Text = "Remove";
            this.buttonRemoveBooks.UseVisualStyleBackColor = false;
            this.buttonRemoveBooks.Click += new System.EventHandler(this.buttonRemoveBooks_Click);
            // 
            // UserControlManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxRemoveBooks);
            this.Name = "UserControlManageUsers";
            this.Size = new System.Drawing.Size(652, 204);
            this.groupBoxRemoveBooks.ResumeLayout(false);
            this.groupBoxRemoveBooks.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRemoveBooks;
        private System.Windows.Forms.TextBox textBoxRemoveUser;
        private System.Windows.Forms.Label labelBookUsername;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label labelregNo;
        private System.Windows.Forms.TextBox textBoxRegno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxRemoveID;
        private System.Windows.Forms.Label labelBookIDRemove;
        private System.Windows.Forms.Button buttonRemoveBooks;
    }
}
