namespace Library_Management_System.UserUC
{
    partial class UserControlBrowse
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
            this.components = new System.ComponentModel.Container();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelHead = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.databaseUsersDataSet = new Library_Management_System.DatabaseUsersDataSet();
            this.databaseUsersDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelBody.SuspendLayout();
            this.panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUsersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUsersDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.dataGridViewBooks);
            this.panelBody.Location = new System.Drawing.Point(3, 51);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(646, 280);
            this.panelBody.TabIndex = 0;
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(169)))));
            this.panelHead.Controls.Add(this.textBoxSearch);
            this.panelHead.Controls.Add(this.buttonSearch);
            this.panelHead.Location = new System.Drawing.Point(3, 3);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(646, 42);
            this.panelHead.TabIndex = 1;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(248, 14);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(296, 20);
            this.textBoxSearch.TabIndex = 51;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.buttonSearch.FlatAppearance.BorderSize = 2;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(560, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(83, 35);
            this.buttonSearch.TabIndex = 50;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AutoGenerateColumns = false;
            this.dataGridViewBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(169)))));
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.DataSource = this.databaseUsersDataSetBindingSource;
            this.dataGridViewBooks.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.Size = new System.Drawing.Size(646, 280);
            this.dataGridViewBooks.TabIndex = 0;
            // 
            // databaseUsersDataSet
            // 
            this.databaseUsersDataSet.DataSetName = "DatabaseUsersDataSet";
            this.databaseUsersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseUsersDataSetBindingSource
            // 
            this.databaseUsersDataSetBindingSource.DataSource = this.databaseUsersDataSet;
            this.databaseUsersDataSetBindingSource.Position = 0;
            // 
            // UserControlBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.panelBody);
            this.Name = "UserControlBrowse";
            this.Size = new System.Drawing.Size(652, 334);
            this.Load += new System.EventHandler(this.UserControlBrowse_Load);
            this.panelBody.ResumeLayout(false);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUsersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUsersDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.BindingSource databaseUsersDataSetBindingSource;
        private DatabaseUsersDataSet databaseUsersDataSet;
    }
}
