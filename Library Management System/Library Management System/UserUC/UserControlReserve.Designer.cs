namespace Library_Management_System.UserUC
{
    partial class UserControlReserve
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBorrow = new System.Windows.Forms.Button();
            this.textBoxCodeB1 = new System.Windows.Forms.TextBox();
            this.labelCodeB1 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(169)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonBorrow);
            this.panel1.Controls.Add(this.textBoxCodeB1);
            this.panel1.Controls.Add(this.labelCodeB1);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Location = new System.Drawing.Point(161, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 152);
            this.panel1.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Reserve Books";
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.buttonBorrow.FlatAppearance.BorderSize = 2;
            this.buttonBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrow.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrow.Location = new System.Drawing.Point(217, 97);
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Size = new System.Drawing.Size(104, 38);
            this.buttonBorrow.TabIndex = 29;
            this.buttonBorrow.Text = "Reserve";
            this.buttonBorrow.UseVisualStyleBackColor = false;
            this.buttonBorrow.Click += new System.EventHandler(this.buttonBorrow_Click);
            // 
            // textBoxCodeB1
            // 
            this.textBoxCodeB1.Location = new System.Drawing.Point(153, 71);
            this.textBoxCodeB1.Name = "textBoxCodeB1";
            this.textBoxCodeB1.Size = new System.Drawing.Size(168, 20);
            this.textBoxCodeB1.TabIndex = 22;
            // 
            // labelCodeB1
            // 
            this.labelCodeB1.AutoSize = true;
            this.labelCodeB1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodeB1.Location = new System.Drawing.Point(18, 71);
            this.labelCodeB1.Name = "labelCodeB1";
            this.labelCodeB1.Size = new System.Drawing.Size(82, 18);
            this.labelCodeB1.TabIndex = 21;
            this.labelCodeB1.Text = "Book Code";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(153, 45);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(168, 20);
            this.textBoxUsername.TabIndex = 20;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(18, 45);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(81, 18);
            this.labelUsername.TabIndex = 19;
            this.labelUsername.Text = "Username";
            // 
            // UserControlReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.Controls.Add(this.panel1);
            this.Name = "UserControlReserve";
            this.Size = new System.Drawing.Size(652, 334);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBorrow;
        private System.Windows.Forms.TextBox textBoxCodeB1;
        private System.Windows.Forms.Label labelCodeB1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
    }
}
