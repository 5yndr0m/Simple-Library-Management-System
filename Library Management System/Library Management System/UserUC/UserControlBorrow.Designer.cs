namespace Library_Management_System.UserUC
{
    partial class UserControlBorrow
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxCodeB1 = new System.Windows.Forms.TextBox();
            this.labelCodeB1 = new System.Windows.Forms.Label();
            this.textBoxCodeB2 = new System.Windows.Forms.TextBox();
            this.labelCodeB2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxCodeB2);
            this.panel1.Controls.Add(this.labelCodeB2);
            this.panel1.Controls.Add(this.textBoxCodeB1);
            this.panel1.Controls.Add(this.labelCodeB1);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Location = new System.Drawing.Point(155, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 142);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(153, 10);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(168, 20);
            this.textBoxUsername.TabIndex = 20;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(18, 10);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(105, 26);
            this.labelUsername.TabIndex = 19;
            this.labelUsername.Text = "Username";
            // 
            // textBoxCodeB1
            // 
            this.textBoxCodeB1.Location = new System.Drawing.Point(153, 36);
            this.textBoxCodeB1.Name = "textBoxCodeB1";
            this.textBoxCodeB1.Size = new System.Drawing.Size(168, 20);
            this.textBoxCodeB1.TabIndex = 22;
            this.textBoxCodeB1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelCodeB1
            // 
            this.labelCodeB1.AutoSize = true;
            this.labelCodeB1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodeB1.Location = new System.Drawing.Point(18, 36);
            this.labelCodeB1.Name = "labelCodeB1";
            this.labelCodeB1.Size = new System.Drawing.Size(129, 26);
            this.labelCodeB1.TabIndex = 21;
            this.labelCodeB1.Text = "Book 1 Code";
            // 
            // textBoxCodeB2
            // 
            this.textBoxCodeB2.Location = new System.Drawing.Point(153, 62);
            this.textBoxCodeB2.Name = "textBoxCodeB2";
            this.textBoxCodeB2.Size = new System.Drawing.Size(168, 20);
            this.textBoxCodeB2.TabIndex = 24;
            // 
            // labelCodeB2
            // 
            this.labelCodeB2.AutoSize = true;
            this.labelCodeB2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodeB2.Location = new System.Drawing.Point(18, 62);
            this.labelCodeB2.Name = "labelCodeB2";
            this.labelCodeB2.Size = new System.Drawing.Size(129, 26);
            this.labelCodeB2.TabIndex = 23;
            this.labelCodeB2.Text = "Book 2 Code";
            // 
            // UserControlBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControlBorrow";
            this.Size = new System.Drawing.Size(652, 334);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxCodeB2;
        private System.Windows.Forms.Label labelCodeB2;
        private System.Windows.Forms.TextBox textBoxCodeB1;
        private System.Windows.Forms.Label labelCodeB1;
    }
}
