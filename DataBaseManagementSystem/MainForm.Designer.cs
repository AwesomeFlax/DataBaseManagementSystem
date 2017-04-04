namespace DataBaseManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainDataGrid = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expotrToXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ownQueMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox = new System.Windows.Forms.ListBox();
            this.tablesListLabel = new System.Windows.Forms.Label();
            this.addNote = new System.Windows.Forms.Button();
            this.deleteTable = new System.Windows.Forms.Button();
            this.addTable = new System.Windows.Forms.Button();
            this.searchGB = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.whatToSearch = new System.Windows.Forms.TextBox();
            this.columnList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).BeginInit();
            this.menu.SuspendLayout();
            this.searchGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainDataGrid
            // 
            this.mainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGrid.Location = new System.Drawing.Point(175, 78);
            this.mainDataGrid.Name = "mainDataGrid";
            this.mainDataGrid.Size = new System.Drawing.Size(578, 324);
            this.mainDataGrid.TabIndex = 0;
            this.mainDataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainDataGrid_CellValueChanged);
            this.mainDataGrid.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.mainDataGrid_UserAddedRow);
            this.mainDataGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainDataGrid_KeyPress);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.xMLOperationToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(765, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.expotrToXMLToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.openToolStripMenuItem.Text = "Open *.mdb";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "Open *.XML";
            // 
            // expotrToXMLToolStripMenuItem
            // 
            this.expotrToXMLToolStripMenuItem.Name = "expotrToXMLToolStripMenuItem";
            this.expotrToXMLToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.expotrToXMLToolStripMenuItem.Text = "Expotr to XML";
            // 
            // xMLOperationToolStripMenuItem
            // 
            this.xMLOperationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ownQueMenu});
            this.xMLOperationToolStripMenuItem.Name = "xMLOperationToolStripMenuItem";
            this.xMLOperationToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.xMLOperationToolStripMenuItem.Text = "Queries";
            // 
            // ownQueMenu
            // 
            this.ownQueMenu.Enabled = false;
            this.ownQueMenu.Name = "ownQueMenu";
            this.ownQueMenu.Size = new System.Drawing.Size(154, 22);
            this.ownQueMenu.Text = "Enter your own";
            this.ownQueMenu.Click += new System.EventHandler(this.exportToXMLToolStripMenuItem_Click);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(12, 78);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(157, 324);
            this.listBox.TabIndex = 4;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // tablesListLabel
            // 
            this.tablesListLabel.AutoSize = true;
            this.tablesListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tablesListLabel.Location = new System.Drawing.Point(12, 54);
            this.tablesListLabel.Name = "tablesListLabel";
            this.tablesListLabel.Size = new System.Drawing.Size(136, 15);
            this.tablesListLabel.TabIndex = 5;
            this.tablesListLabel.Text = "Tables in DataBase:";
            // 
            // addNote
            // 
            this.addNote.FlatAppearance.BorderSize = 0;
            this.addNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNote.Image = ((System.Drawing.Image)(resources.GetObject("addNote.Image")));
            this.addNote.Location = new System.Drawing.Point(264, 29);
            this.addNote.Name = "addNote";
            this.addNote.Size = new System.Drawing.Size(40, 40);
            this.addNote.TabIndex = 6;
            this.addNote.UseVisualStyleBackColor = true;
            this.addNote.Visible = false;
            this.addNote.Click += new System.EventHandler(this.addNote_Click);
            // 
            // deleteTable
            // 
            this.deleteTable.FlatAppearance.BorderSize = 0;
            this.deleteTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTable.Image = ((System.Drawing.Image)(resources.GetObject("deleteTable.Image")));
            this.deleteTable.Location = new System.Drawing.Point(218, 29);
            this.deleteTable.Name = "deleteTable";
            this.deleteTable.Size = new System.Drawing.Size(40, 40);
            this.deleteTable.TabIndex = 7;
            this.deleteTable.UseVisualStyleBackColor = true;
            this.deleteTable.Visible = false;
            this.deleteTable.Click += new System.EventHandler(this.deleteTable_Click);
            // 
            // addTable
            // 
            this.addTable.BackColor = System.Drawing.Color.Transparent;
            this.addTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addTable.FlatAppearance.BorderSize = 0;
            this.addTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTable.Image = ((System.Drawing.Image)(resources.GetObject("addTable.Image")));
            this.addTable.Location = new System.Drawing.Point(175, 29);
            this.addTable.Margin = new System.Windows.Forms.Padding(0);
            this.addTable.Name = "addTable";
            this.addTable.Size = new System.Drawing.Size(40, 40);
            this.addTable.TabIndex = 8;
            this.addTable.UseVisualStyleBackColor = false;
            this.addTable.Visible = false;
            this.addTable.Click += new System.EventHandler(this.addTable_Click);
            // 
            // searchGB
            // 
            this.searchGB.Controls.Add(this.searchButton);
            this.searchGB.Controls.Add(this.whatToSearch);
            this.searchGB.Controls.Add(this.columnList);
            this.searchGB.Enabled = false;
            this.searchGB.Location = new System.Drawing.Point(15, 408);
            this.searchGB.Name = "searchGB";
            this.searchGB.Size = new System.Drawing.Size(738, 63);
            this.searchGB.TabIndex = 9;
            this.searchGB.TabStop = false;
            this.searchGB.Text = "Search:";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.searchButton.Location = new System.Drawing.Point(652, 22);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
            // 
            // whatToSearch
            // 
            this.whatToSearch.Location = new System.Drawing.Point(247, 25);
            this.whatToSearch.Name = "whatToSearch";
            this.whatToSearch.Size = new System.Drawing.Size(186, 20);
            this.whatToSearch.TabIndex = 6;
            // 
            // columnList
            // 
            this.columnList.FormattingEnabled = true;
            this.columnList.Location = new System.Drawing.Point(67, 25);
            this.columnList.Name = "columnList";
            this.columnList.Size = new System.Drawing.Size(149, 21);
            this.columnList.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 478);
            this.Controls.Add(this.searchGB);
            this.Controls.Add(this.addTable);
            this.Controls.Add(this.deleteTable);
            this.Controls.Add(this.addNote);
            this.Controls.Add(this.tablesListLabel);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.mainDataGrid);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.TransparencyKey = System.Drawing.Color.Red;
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.searchGB.ResumeLayout(false);
            this.searchGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mainDataGrid;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ToolStripMenuItem expotrToXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ownQueMenu;
        private System.Windows.Forms.Label tablesListLabel;
        private System.Windows.Forms.Button addNote;
        private System.Windows.Forms.Button deleteTable;
        private System.Windows.Forms.Button addTable;
        private System.Windows.Forms.GroupBox searchGB;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox whatToSearch;
        private System.Windows.Forms.ComboBox columnList;
    }
}