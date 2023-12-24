namespace Library_Management_System.StaffControls
{
    partial class UserControlManageBooks
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
            this.groupBoxAddBooks = new System.Windows.Forms.GroupBox();
            this.groupBoxRemoveBooks = new System.Windows.Forms.GroupBox();
            this.textBoxLanguage = new System.Windows.Forms.TextBox();
            this.labelBookID = new System.Windows.Forms.Label();
            this.labelBookName = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelISBN = new System.Windows.Forms.Label();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.textBoxBookID = new System.Windows.Forms.TextBox();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.labelBookIDRemove = new System.Windows.Forms.Label();
            this.textBoxRemoveID = new System.Windows.Forms.TextBox();
            this.groupBoxAddBooks.SuspendLayout();
            this.groupBoxRemoveBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAddBooks
            // 
            this.groupBoxAddBooks.Controls.Add(this.buttonAdd);
            this.groupBoxAddBooks.Controls.Add(this.textBoxYear);
            this.groupBoxAddBooks.Controls.Add(this.textBoxPublisher);
            this.groupBoxAddBooks.Controls.Add(this.textBoxBookID);
            this.groupBoxAddBooks.Controls.Add(this.textBoxBookName);
            this.groupBoxAddBooks.Controls.Add(this.textBoxAuthor);
            this.groupBoxAddBooks.Controls.Add(this.textBoxISBN);
            this.groupBoxAddBooks.Controls.Add(this.label6);
            this.groupBoxAddBooks.Controls.Add(this.labelPublisher);
            this.groupBoxAddBooks.Controls.Add(this.labelLanguage);
            this.groupBoxAddBooks.Controls.Add(this.labelISBN);
            this.groupBoxAddBooks.Controls.Add(this.labelAuthor);
            this.groupBoxAddBooks.Controls.Add(this.labelBookName);
            this.groupBoxAddBooks.Controls.Add(this.textBoxLanguage);
            this.groupBoxAddBooks.Controls.Add(this.labelBookID);
            this.groupBoxAddBooks.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddBooks.Location = new System.Drawing.Point(6, 3);
            this.groupBoxAddBooks.Name = "groupBoxAddBooks";
            this.groupBoxAddBooks.Size = new System.Drawing.Size(347, 328);
            this.groupBoxAddBooks.TabIndex = 0;
            this.groupBoxAddBooks.TabStop = false;
            this.groupBoxAddBooks.Text = "Add Books";
            // 
            // groupBoxRemoveBooks
            // 
            this.groupBoxRemoveBooks.Controls.Add(this.textBoxRemoveID);
            this.groupBoxRemoveBooks.Controls.Add(this.labelBookIDRemove);
            this.groupBoxRemoveBooks.Controls.Add(this.buttonRemove);
            this.groupBoxRemoveBooks.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRemoveBooks.Location = new System.Drawing.Point(359, 3);
            this.groupBoxRemoveBooks.Name = "groupBoxRemoveBooks";
            this.groupBoxRemoveBooks.Size = new System.Drawing.Size(290, 328);
            this.groupBoxRemoveBooks.TabIndex = 1;
            this.groupBoxRemoveBooks.TabStop = false;
            this.groupBoxRemoveBooks.Text = "Remove Books";
            // 
            // textBoxLanguage
            // 
            this.textBoxLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLanguage.Location = new System.Drawing.Point(144, 161);
            this.textBoxLanguage.Name = "textBoxLanguage";
            this.textBoxLanguage.Size = new System.Drawing.Size(168, 26);
            this.textBoxLanguage.TabIndex = 27;
            // 
            // labelBookID
            // 
            this.labelBookID.AutoSize = true;
            this.labelBookID.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookID.Location = new System.Drawing.Point(6, 30);
            this.labelBookID.Name = "labelBookID";
            this.labelBookID.Size = new System.Drawing.Size(64, 21);
            this.labelBookID.TabIndex = 26;
            this.labelBookID.Text = "Book ID";
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookName.Location = new System.Drawing.Point(6, 65);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(91, 21);
            this.labelBookName.TabIndex = 28;
            this.labelBookName.Text = "Book Name";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor.Location = new System.Drawing.Point(6, 97);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(97, 21);
            this.labelAuthor.TabIndex = 29;
            this.labelAuthor.Text = "Book Author";
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelISBN.Location = new System.Drawing.Point(6, 129);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(44, 21);
            this.labelISBN.TabIndex = 30;
            this.labelISBN.Text = "ISBN";
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLanguage.Location = new System.Drawing.Point(6, 161);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(117, 21);
            this.labelLanguage.TabIndex = 31;
            this.labelLanguage.Text = "Book Language";
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPublisher.Location = new System.Drawing.Point(6, 193);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(75, 21);
            this.labelPublisher.TabIndex = 32;
            this.labelPublisher.Text = "Publisher";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 33;
            this.label6.Text = "Publish Year";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxISBN.Location = new System.Drawing.Point(144, 129);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(168, 26);
            this.textBoxISBN.TabIndex = 34;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuthor.Location = new System.Drawing.Point(144, 97);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(168, 26);
            this.textBoxAuthor.TabIndex = 35;
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookName.Location = new System.Drawing.Point(144, 65);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(168, 26);
            this.textBoxBookName.TabIndex = 36;
            // 
            // textBoxBookID
            // 
            this.textBoxBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookID.Location = new System.Drawing.Point(144, 33);
            this.textBoxBookID.Name = "textBoxBookID";
            this.textBoxBookID.Size = new System.Drawing.Size(168, 26);
            this.textBoxBookID.TabIndex = 37;
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPublisher.Location = new System.Drawing.Point(144, 193);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(168, 26);
            this.textBoxPublisher.TabIndex = 38;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYear.Location = new System.Drawing.Point(144, 225);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(168, 26);
            this.textBoxYear.TabIndex = 39;
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatAppearance.BorderSize = 2;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(237, 283);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(104, 39);
            this.buttonAdd.TabIndex = 40;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.FlatAppearance.BorderSize = 2;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(160, 62);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(104, 39);
            this.buttonRemove.TabIndex = 41;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // labelBookIDRemove
            // 
            this.labelBookIDRemove.AutoSize = true;
            this.labelBookIDRemove.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookIDRemove.Location = new System.Drawing.Point(6, 30);
            this.labelBookIDRemove.Name = "labelBookIDRemove";
            this.labelBookIDRemove.Size = new System.Drawing.Size(64, 21);
            this.labelBookIDRemove.TabIndex = 42;
            this.labelBookIDRemove.Text = "Book ID";
            // 
            // textBoxRemoveID
            // 
            this.textBoxRemoveID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRemoveID.Location = new System.Drawing.Point(96, 30);
            this.textBoxRemoveID.Name = "textBoxRemoveID";
            this.textBoxRemoveID.Size = new System.Drawing.Size(168, 26);
            this.textBoxRemoveID.TabIndex = 41;
            // 
            // UserControlManageBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxRemoveBooks);
            this.Controls.Add(this.groupBoxAddBooks);
            this.Name = "UserControlManageBooks";
            this.Size = new System.Drawing.Size(652, 334);
            this.groupBoxAddBooks.ResumeLayout(false);
            this.groupBoxAddBooks.PerformLayout();
            this.groupBoxRemoveBooks.ResumeLayout(false);
            this.groupBoxRemoveBooks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddBooks;
        private System.Windows.Forms.GroupBox groupBoxRemoveBooks;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.TextBox textBoxLanguage;
        private System.Windows.Forms.Label labelBookID;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.TextBox textBoxBookID;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox textBoxRemoveID;
        private System.Windows.Forms.Label labelBookIDRemove;
    }
}
