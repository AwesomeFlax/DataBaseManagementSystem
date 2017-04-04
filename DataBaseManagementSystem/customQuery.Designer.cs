namespace DataBaseManagementSystem
{
    partial class customQuery
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
            this.customDataGrid = new System.Windows.Forms.DataGridView();
            this.sendQuery = new System.Windows.Forms.Button();
            this.userQuery = new System.Windows.Forms.TextBox();
            this.informer = new System.Windows.Forms.Label();
            this.columnList = new System.Windows.Forms.ComboBox();
            this.searchGB = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.whatToSearch = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGrid)).BeginInit();
            this.searchGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // customDataGrid
            // 
            this.customDataGrid.AllowUserToAddRows = false;
            this.customDataGrid.AllowUserToDeleteRows = false;
            this.customDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customDataGrid.Location = new System.Drawing.Point(176, 67);
            this.customDataGrid.Name = "customDataGrid";
            this.customDataGrid.ReadOnly = true;
            this.customDataGrid.Size = new System.Drawing.Size(522, 260);
            this.customDataGrid.TabIndex = 1;
            // 
            // sendQuery
            // 
            this.sendQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.sendQuery.Location = new System.Drawing.Point(610, 33);
            this.sendQuery.Name = "sendQuery";
            this.sendQuery.Size = new System.Drawing.Size(88, 23);
            this.sendQuery.TabIndex = 2;
            this.sendQuery.Text = "Send query";
            this.sendQuery.UseVisualStyleBackColor = true;
            this.sendQuery.Click += new System.EventHandler(this.sendQuery_Click);
            // 
            // userQuery
            // 
            this.userQuery.Location = new System.Drawing.Point(13, 36);
            this.userQuery.Name = "userQuery";
            this.userQuery.Size = new System.Drawing.Size(591, 20);
            this.userQuery.TabIndex = 3;
            // 
            // informer
            // 
            this.informer.AutoSize = true;
            this.informer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.informer.Location = new System.Drawing.Point(12, 16);
            this.informer.Name = "informer";
            this.informer.Size = new System.Drawing.Size(385, 17);
            this.informer.TabIndex = 4;
            this.informer.Text = "Enter your query and try it. The result will be shown in table:";
            // 
            // columnList
            // 
            this.columnList.FormattingEnabled = true;
            this.columnList.Location = new System.Drawing.Point(67, 25);
            this.columnList.Name = "columnList";
            this.columnList.Size = new System.Drawing.Size(149, 21);
            this.columnList.TabIndex = 5;
            // 
            // searchGB
            // 
            this.searchGB.Controls.Add(this.searchButton);
            this.searchGB.Controls.Add(this.whatToSearch);
            this.searchGB.Controls.Add(this.columnList);
            this.searchGB.Enabled = false;
            this.searchGB.Location = new System.Drawing.Point(12, 333);
            this.searchGB.Name = "searchGB";
            this.searchGB.Size = new System.Drawing.Size(686, 63);
            this.searchGB.TabIndex = 6;
            this.searchGB.TabStop = false;
            this.searchGB.Text = "Search:";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.searchButton.Location = new System.Drawing.Point(598, 22);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // whatToSearch
            // 
            this.whatToSearch.Location = new System.Drawing.Point(247, 25);
            this.whatToSearch.Name = "whatToSearch";
            this.whatToSearch.Size = new System.Drawing.Size(186, 20);
            this.whatToSearch.TabIndex = 6;
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(13, 67);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(157, 260);
            this.listBox.TabIndex = 7;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // customQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 406);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.searchGB);
            this.Controls.Add(this.informer);
            this.Controls.Add(this.userQuery);
            this.Controls.Add(this.sendQuery);
            this.Controls.Add(this.customDataGrid);
            this.Name = "customQuery";
            this.Text = "User queries module";
            ((System.ComponentModel.ISupportInitialize)(this.customDataGrid)).EndInit();
            this.searchGB.ResumeLayout(false);
            this.searchGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customDataGrid;
        private System.Windows.Forms.Button sendQuery;
        private System.Windows.Forms.TextBox userQuery;
        private System.Windows.Forms.Label informer;
        private System.Windows.Forms.ComboBox columnList;
        private System.Windows.Forms.GroupBox searchGB;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox whatToSearch;
        private System.Windows.Forms.ListBox listBox;
    }
}