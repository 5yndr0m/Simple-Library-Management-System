namespace Library_Management_System.UserUC
{
    partial class UserControlHome
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
            this.groupBoxMessages = new System.Windows.Forms.GroupBox();
            this.groupBoxNewwBook = new System.Windows.Forms.GroupBox();
            this.groupBoxReview = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // groupBoxMessages
            // 
            this.groupBoxMessages.Location = new System.Drawing.Point(3, 3);
            this.groupBoxMessages.Name = "groupBoxMessages";
            this.groupBoxMessages.Size = new System.Drawing.Size(281, 164);
            this.groupBoxMessages.TabIndex = 0;
            this.groupBoxMessages.TabStop = false;
            this.groupBoxMessages.Text = "Messages";
            // 
            // groupBoxNewwBook
            // 
            this.groupBoxNewwBook.Location = new System.Drawing.Point(3, 173);
            this.groupBoxNewwBook.Name = "groupBoxNewwBook";
            this.groupBoxNewwBook.Size = new System.Drawing.Size(281, 158);
            this.groupBoxNewwBook.TabIndex = 1;
            this.groupBoxNewwBook.TabStop = false;
            this.groupBoxNewwBook.Text = "New Books";
            // 
            // groupBoxReview
            // 
            this.groupBoxReview.Location = new System.Drawing.Point(290, 3);
            this.groupBoxReview.Name = "groupBoxReview";
            this.groupBoxReview.Size = new System.Drawing.Size(359, 328);
            this.groupBoxReview.TabIndex = 1;
            this.groupBoxReview.TabStop = false;
            this.groupBoxReview.Text = "Review";
            // 
            // UserControlHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxReview);
            this.Controls.Add(this.groupBoxNewwBook);
            this.Controls.Add(this.groupBoxMessages);
            this.Name = "UserControlHome";
            this.Size = new System.Drawing.Size(652, 334);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMessages;
        private System.Windows.Forms.GroupBox groupBoxNewwBook;
        private System.Windows.Forms.GroupBox groupBoxReview;
    }
}
