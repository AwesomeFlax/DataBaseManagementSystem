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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expotrToXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox = new System.Windows.Forms.ListBox();
            this.tablesListLabel = new System.Windows.Forms.Label();
            this.addNote = new System.Windows.Forms.Button();
            this.deleteTable = new System.Windows.Forms.Button();
            this.addTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainDataGrid
            // 
            this.mainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGrid.Location = new System.Drawing.Point(175, 78);
            this.mainDataGrid.Name = "mainDataGrid";
            this.mainDataGrid.Size = new System.Drawing.Size(578, 372);
            this.mainDataGrid.TabIndex = 0;
            this.mainDataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainDataGrid_CellValueChanged);
            this.mainDataGrid.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.mainDataGrid_UserAddedRow);
            this.mainDataGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainDataGrid_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.xMLOperationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
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
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open *.mdb";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Open *.XML";
            // 
            // expotrToXMLToolStripMenuItem
            // 
            this.expotrToXMLToolStripMenuItem.Name = "expotrToXMLToolStripMenuItem";
            this.expotrToXMLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.expotrToXMLToolStripMenuItem.Text = "Expotr to XML";
            // 
            // xMLOperationToolStripMenuItem
            // 
            this.xMLOperationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToXMLToolStripMenuItem});
            this.xMLOperationToolStripMenuItem.Name = "xMLOperationToolStripMenuItem";
            this.xMLOperationToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.xMLOperationToolStripMenuItem.Text = "Queries";
            // 
            // exportToXMLToolStripMenuItem
            // 
            this.exportToXMLToolStripMenuItem.Name = "exportToXMLToolStripMenuItem";
            this.exportToXMLToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exportToXMLToolStripMenuItem.Text = "Enter your own";
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(12, 78);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(157, 372);
            this.listBox.TabIndex = 4;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // tablesListLabel
            // 
            this.tablesListLabel.AutoSize = true;
            this.tablesListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tablesListLabel.Location = new System.Drawing.Point(12, 52);
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
            this.addNote.Location = new System.Drawing.Point(713, 27);
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
            this.deleteTable.Location = new System.Drawing.Point(667, 27);
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
            this.addTable.Location = new System.Drawing.Point(624, 27);
            this.addTable.Margin = new System.Windows.Forms.Padding(0);
            this.addTable.Name = "addTable";
            this.addTable.Size = new System.Drawing.Size(40, 40);
            this.addTable.TabIndex = 8;
            this.addTable.UseVisualStyleBackColor = false;
            this.addTable.Visible = false;
            this.addTable.Click += new System.EventHandler(this.addTable_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 460);
            this.Controls.Add(this.addTable);
            this.Controls.Add(this.deleteTable);
            this.Controls.Add(this.addNote);
            this.Controls.Add(this.tablesListLabel);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.mainDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mainDataGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ToolStripMenuItem expotrToXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToXMLToolStripMenuItem;
        private System.Windows.Forms.Label tablesListLabel;
        private System.Windows.Forms.Button addNote;
        private System.Windows.Forms.Button deleteTable;
        private System.Windows.Forms.Button addTable;
    }
}