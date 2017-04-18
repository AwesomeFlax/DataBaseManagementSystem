namespace DataBaseManagementSystem
{
    partial class editExistingTable
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.addNewColumn = new System.Windows.Forms.TabPage();
            this.labelColumnNameAdd = new System.Windows.Forms.Label();
            this.labelColumnTypeAdd = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.fieldTypeComboBoxAdd = new System.Windows.Forms.ComboBox();
            this.textBoxAddColumn = new System.Windows.Forms.TextBox();
            this.listBoxAddColumn = new System.Windows.Forms.ListBox();
            this.deleteColumn = new System.Windows.Forms.TabPage();
            this.labelColumnNameDel = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxDeleteColumn = new System.Windows.Forms.TextBox();
            this.listBoxDeleteColumn = new System.Windows.Forms.ListBox();
            this.renameColumn = new System.Windows.Forms.TabPage();
            this.textBoxNewColumnName = new System.Windows.Forms.TextBox();
            this.labelNewColumnName = new System.Windows.Forms.Label();
            this.labelColumnNameRename = new System.Windows.Forms.Label();
            this.labelColumnTypeRename = new System.Windows.Forms.Label();
            this.buttonRename = new System.Windows.Forms.Button();
            this.comboBoxColumnTypeRename = new System.Windows.Forms.ComboBox();
            this.textBoxColumnNameRename = new System.Windows.Forms.TextBox();
            this.listBoxRenameColumn = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.addNewColumn.SuspendLayout();
            this.deleteColumn.SuspendLayout();
            this.renameColumn.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.addNewColumn);
            this.tabControl.Controls.Add(this.deleteColumn);
            this.tabControl.Controls.Add(this.renameColumn);
            this.tabControl.Location = new System.Drawing.Point(1, 1);
            this.tabControl.Margin = new System.Windows.Forms.Padding(1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(350, 304);
            this.tabControl.TabIndex = 0;
            // 
            // addNewColumn
            // 
            this.addNewColumn.Controls.Add(this.labelColumnNameAdd);
            this.addNewColumn.Controls.Add(this.labelColumnTypeAdd);
            this.addNewColumn.Controls.Add(this.buttonAdd);
            this.addNewColumn.Controls.Add(this.fieldTypeComboBoxAdd);
            this.addNewColumn.Controls.Add(this.textBoxAddColumn);
            this.addNewColumn.Controls.Add(this.listBoxAddColumn);
            this.addNewColumn.Location = new System.Drawing.Point(4, 22);
            this.addNewColumn.Name = "addNewColumn";
            this.addNewColumn.Padding = new System.Windows.Forms.Padding(3);
            this.addNewColumn.Size = new System.Drawing.Size(342, 278);
            this.addNewColumn.TabIndex = 0;
            this.addNewColumn.Text = "Add column";
            this.addNewColumn.UseVisualStyleBackColor = true;
            // 
            // labelColumnNameAdd
            // 
            this.labelColumnNameAdd.AutoSize = true;
            this.labelColumnNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColumnNameAdd.Location = new System.Drawing.Point(157, 6);
            this.labelColumnNameAdd.Name = "labelColumnNameAdd";
            this.labelColumnNameAdd.Size = new System.Drawing.Size(96, 16);
            this.labelColumnNameAdd.TabIndex = 7;
            this.labelColumnNameAdd.Text = "Column Name:";
            // 
            // labelColumnTypeAdd
            // 
            this.labelColumnTypeAdd.AutoSize = true;
            this.labelColumnTypeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColumnTypeAdd.Location = new System.Drawing.Point(157, 48);
            this.labelColumnTypeAdd.Name = "labelColumnTypeAdd";
            this.labelColumnTypeAdd.Size = new System.Drawing.Size(91, 16);
            this.labelColumnTypeAdd.TabIndex = 6;
            this.labelColumnTypeAdd.Text = "Column Type:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(223, 233);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(113, 37);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // fieldTypeComboBoxAdd
            // 
            this.fieldTypeComboBoxAdd.FormattingEnabled = true;
            this.fieldTypeComboBoxAdd.Items.AddRange(new object[] {
            "INT",
            "FLOAT",
            "DATE",
            "VARCHAR(100)",
            "BOOL"});
            this.fieldTypeComboBoxAdd.Location = new System.Drawing.Point(160, 67);
            this.fieldTypeComboBoxAdd.Name = "fieldTypeComboBoxAdd";
            this.fieldTypeComboBoxAdd.Size = new System.Drawing.Size(157, 21);
            this.fieldTypeComboBoxAdd.TabIndex = 4;
            // 
            // textBoxAddColumn
            // 
            this.textBoxAddColumn.Location = new System.Drawing.Point(160, 25);
            this.textBoxAddColumn.Name = "textBoxAddColumn";
            this.textBoxAddColumn.Size = new System.Drawing.Size(157, 20);
            this.textBoxAddColumn.TabIndex = 1;
            // 
            // listBoxAddColumn
            // 
            this.listBoxAddColumn.FormattingEnabled = true;
            this.listBoxAddColumn.Location = new System.Drawing.Point(7, 6);
            this.listBoxAddColumn.Name = "listBoxAddColumn";
            this.listBoxAddColumn.Size = new System.Drawing.Size(144, 264);
            this.listBoxAddColumn.TabIndex = 0;
            // 
            // deleteColumn
            // 
            this.deleteColumn.Controls.Add(this.labelColumnNameDel);
            this.deleteColumn.Controls.Add(this.buttonDelete);
            this.deleteColumn.Controls.Add(this.textBoxDeleteColumn);
            this.deleteColumn.Controls.Add(this.listBoxDeleteColumn);
            this.deleteColumn.Location = new System.Drawing.Point(4, 22);
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.Padding = new System.Windows.Forms.Padding(3);
            this.deleteColumn.Size = new System.Drawing.Size(342, 278);
            this.deleteColumn.TabIndex = 1;
            this.deleteColumn.Text = "Delete column";
            this.deleteColumn.UseVisualStyleBackColor = true;
            // 
            // labelColumnNameDel
            // 
            this.labelColumnNameDel.AutoSize = true;
            this.labelColumnNameDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColumnNameDel.Location = new System.Drawing.Point(157, 6);
            this.labelColumnNameDel.Name = "labelColumnNameDel";
            this.labelColumnNameDel.Size = new System.Drawing.Size(96, 16);
            this.labelColumnNameDel.TabIndex = 13;
            this.labelColumnNameDel.Text = "Column Name:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(223, 233);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(113, 37);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxDeleteColumn
            // 
            this.textBoxDeleteColumn.Location = new System.Drawing.Point(160, 26);
            this.textBoxDeleteColumn.Name = "textBoxDeleteColumn";
            this.textBoxDeleteColumn.Size = new System.Drawing.Size(157, 20);
            this.textBoxDeleteColumn.TabIndex = 9;
            // 
            // listBoxDeleteColumn
            // 
            this.listBoxDeleteColumn.FormattingEnabled = true;
            this.listBoxDeleteColumn.Location = new System.Drawing.Point(7, 6);
            this.listBoxDeleteColumn.Name = "listBoxDeleteColumn";
            this.listBoxDeleteColumn.Size = new System.Drawing.Size(144, 264);
            this.listBoxDeleteColumn.TabIndex = 8;
            // 
            // renameColumn
            // 
            this.renameColumn.Controls.Add(this.textBoxNewColumnName);
            this.renameColumn.Controls.Add(this.labelNewColumnName);
            this.renameColumn.Controls.Add(this.labelColumnNameRename);
            this.renameColumn.Controls.Add(this.labelColumnTypeRename);
            this.renameColumn.Controls.Add(this.buttonRename);
            this.renameColumn.Controls.Add(this.comboBoxColumnTypeRename);
            this.renameColumn.Controls.Add(this.textBoxColumnNameRename);
            this.renameColumn.Controls.Add(this.listBoxRenameColumn);
            this.renameColumn.Location = new System.Drawing.Point(4, 22);
            this.renameColumn.Name = "renameColumn";
            this.renameColumn.Padding = new System.Windows.Forms.Padding(3);
            this.renameColumn.Size = new System.Drawing.Size(342, 278);
            this.renameColumn.TabIndex = 2;
            this.renameColumn.Text = "Rename column";
            this.renameColumn.UseVisualStyleBackColor = true;
            // 
            // textBoxNewColumnName
            // 
            this.textBoxNewColumnName.Location = new System.Drawing.Point(160, 71);
            this.textBoxNewColumnName.Name = "textBoxNewColumnName";
            this.textBoxNewColumnName.Size = new System.Drawing.Size(157, 20);
            this.textBoxNewColumnName.TabIndex = 15;
            // 
            // labelNewColumnName
            // 
            this.labelNewColumnName.AutoSize = true;
            this.labelNewColumnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewColumnName.Location = new System.Drawing.Point(157, 52);
            this.labelNewColumnName.Name = "labelNewColumnName";
            this.labelNewColumnName.Size = new System.Drawing.Size(126, 16);
            this.labelNewColumnName.TabIndex = 14;
            this.labelNewColumnName.Text = "New Column Name:";
            // 
            // labelColumnNameRename
            // 
            this.labelColumnNameRename.AutoSize = true;
            this.labelColumnNameRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColumnNameRename.Location = new System.Drawing.Point(157, 6);
            this.labelColumnNameRename.Name = "labelColumnNameRename";
            this.labelColumnNameRename.Size = new System.Drawing.Size(96, 16);
            this.labelColumnNameRename.TabIndex = 13;
            this.labelColumnNameRename.Text = "Column Name:";
            // 
            // labelColumnTypeRename
            // 
            this.labelColumnTypeRename.AutoSize = true;
            this.labelColumnTypeRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColumnTypeRename.Location = new System.Drawing.Point(157, 94);
            this.labelColumnTypeRename.Name = "labelColumnTypeRename";
            this.labelColumnTypeRename.Size = new System.Drawing.Size(91, 16);
            this.labelColumnTypeRename.TabIndex = 12;
            this.labelColumnTypeRename.Text = "Column Type:";
            // 
            // buttonRename
            // 
            this.buttonRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRename.Location = new System.Drawing.Point(223, 233);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(113, 37);
            this.buttonRename.TabIndex = 11;
            this.buttonRename.Text = "Rename";
            this.buttonRename.UseVisualStyleBackColor = true;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // comboBoxColumnTypeRename
            // 
            this.comboBoxColumnTypeRename.FormattingEnabled = true;
            this.comboBoxColumnTypeRename.Items.AddRange(new object[] {
            "INT",
            "FLOAT",
            "DATE",
            "VARCHAR(100)",
            "BOOL"});
            this.comboBoxColumnTypeRename.Location = new System.Drawing.Point(160, 113);
            this.comboBoxColumnTypeRename.Name = "comboBoxColumnTypeRename";
            this.comboBoxColumnTypeRename.Size = new System.Drawing.Size(157, 21);
            this.comboBoxColumnTypeRename.TabIndex = 10;
            // 
            // textBoxColumnNameRename
            // 
            this.textBoxColumnNameRename.Location = new System.Drawing.Point(160, 25);
            this.textBoxColumnNameRename.Name = "textBoxColumnNameRename";
            this.textBoxColumnNameRename.Size = new System.Drawing.Size(157, 20);
            this.textBoxColumnNameRename.TabIndex = 9;
            // 
            // listBoxRenameColumn
            // 
            this.listBoxRenameColumn.FormattingEnabled = true;
            this.listBoxRenameColumn.Location = new System.Drawing.Point(7, 6);
            this.listBoxRenameColumn.Name = "listBoxRenameColumn";
            this.listBoxRenameColumn.Size = new System.Drawing.Size(144, 264);
            this.listBoxRenameColumn.TabIndex = 8;
            // 
            // editExistingTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 306);
            this.Controls.Add(this.tabControl);
            this.Name = "editExistingTable";
            this.Text = "Edit Table";
            this.tabControl.ResumeLayout(false);
            this.addNewColumn.ResumeLayout(false);
            this.addNewColumn.PerformLayout();
            this.deleteColumn.ResumeLayout(false);
            this.deleteColumn.PerformLayout();
            this.renameColumn.ResumeLayout(false);
            this.renameColumn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage addNewColumn;
        private System.Windows.Forms.TabPage deleteColumn;
        private System.Windows.Forms.TabPage renameColumn;
        private System.Windows.Forms.TextBox textBoxAddColumn;
        private System.Windows.Forms.ListBox listBoxAddColumn;
        private System.Windows.Forms.ComboBox fieldTypeComboBoxAdd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelColumnNameAdd;
        private System.Windows.Forms.Label labelColumnTypeAdd;
        private System.Windows.Forms.Label labelColumnNameDel;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxDeleteColumn;
        private System.Windows.Forms.ListBox listBoxDeleteColumn;
        private System.Windows.Forms.Label labelColumnNameRename;
        private System.Windows.Forms.Label labelColumnTypeRename;
        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.ComboBox comboBoxColumnTypeRename;
        private System.Windows.Forms.TextBox textBoxColumnNameRename;
        private System.Windows.Forms.ListBox listBoxRenameColumn;
        private System.Windows.Forms.TextBox textBoxNewColumnName;
        private System.Windows.Forms.Label labelNewColumnName;
    }
}