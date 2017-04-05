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
            this.deleteColumn = new System.Windows.Forms.TabPage();
            this.renameColumn = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
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
            this.tabControl.Size = new System.Drawing.Size(477, 304);
            this.tabControl.TabIndex = 0;
            // 
            // addNewColumn
            // 
            this.addNewColumn.Location = new System.Drawing.Point(4, 22);
            this.addNewColumn.Name = "addNewColumn";
            this.addNewColumn.Padding = new System.Windows.Forms.Padding(3);
            this.addNewColumn.Size = new System.Drawing.Size(469, 278);
            this.addNewColumn.TabIndex = 0;
            this.addNewColumn.Text = "Add column";
            this.addNewColumn.UseVisualStyleBackColor = true;
            // 
            // deleteColumn
            // 
            this.deleteColumn.Location = new System.Drawing.Point(4, 22);
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.Padding = new System.Windows.Forms.Padding(3);
            this.deleteColumn.Size = new System.Drawing.Size(469, 278);
            this.deleteColumn.TabIndex = 1;
            this.deleteColumn.Text = "Delete column";
            this.deleteColumn.UseVisualStyleBackColor = true;
            // 
            // renameColumn
            // 
            this.renameColumn.Location = new System.Drawing.Point(4, 22);
            this.renameColumn.Name = "renameColumn";
            this.renameColumn.Padding = new System.Windows.Forms.Padding(3);
            this.renameColumn.Size = new System.Drawing.Size(469, 278);
            this.renameColumn.TabIndex = 2;
            this.renameColumn.Text = "Rename column";
            this.renameColumn.UseVisualStyleBackColor = true;
            // 
            // editExistingTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 306);
            this.Controls.Add(this.tabControl);
            this.Name = "editExistingTable";
            this.Text = "Edit Table";
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage addNewColumn;
        private System.Windows.Forms.TabPage deleteColumn;
        private System.Windows.Forms.TabPage renameColumn;
    }
}