namespace DataBaseManagementSystem
{
    partial class newTableAdd
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
            this.tableName = new System.Windows.Forms.Label();
            this.initFieldName = new System.Windows.Forms.Label();
            this.fieldType = new System.Windows.Forms.Label();
            this.tableNameTextBox = new System.Windows.Forms.TextBox();
            this.initFieldNameTextBox = new System.Windows.Forms.TextBox();
            this.fieldTypeComboBox = new System.Windows.Forms.ComboBox();
            this.addInDB = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tableName
            // 
            this.tableName.AutoSize = true;
            this.tableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableName.Location = new System.Drawing.Point(54, 45);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(89, 18);
            this.tableName.TabIndex = 0;
            this.tableName.Text = "Table name:";
            // 
            // initFieldName
            // 
            this.initFieldName.AutoSize = true;
            this.initFieldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.initFieldName.Location = new System.Drawing.Point(54, 81);
            this.initFieldName.Name = "initFieldName";
            this.initFieldName.Size = new System.Drawing.Size(101, 18);
            this.initFieldName.TabIndex = 0;
            this.initFieldName.Text = "Init field name:";
            // 
            // fieldType
            // 
            this.fieldType.AutoSize = true;
            this.fieldType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fieldType.Location = new System.Drawing.Point(54, 120);
            this.fieldType.Name = "fieldType";
            this.fieldType.Size = new System.Drawing.Size(74, 18);
            this.fieldType.TabIndex = 0;
            this.fieldType.Text = "Field type:";
            // 
            // tableNameTextBox
            // 
            this.tableNameTextBox.Location = new System.Drawing.Point(196, 42);
            this.tableNameTextBox.Name = "tableNameTextBox";
            this.tableNameTextBox.Size = new System.Drawing.Size(157, 20);
            this.tableNameTextBox.TabIndex = 1;
            // 
            // initFieldNameTextBox
            // 
            this.initFieldNameTextBox.Location = new System.Drawing.Point(196, 78);
            this.initFieldNameTextBox.Name = "initFieldNameTextBox";
            this.initFieldNameTextBox.Size = new System.Drawing.Size(157, 20);
            this.initFieldNameTextBox.TabIndex = 2;
            // 
            // fieldTypeComboBox
            // 
            this.fieldTypeComboBox.FormattingEnabled = true;
            this.fieldTypeComboBox.Items.AddRange(new object[] {
            "INT",
            "FLOAT",
            "DATE",
            "VARCHAR(100)",
            "BOOL"});
            this.fieldTypeComboBox.Location = new System.Drawing.Point(196, 117);
            this.fieldTypeComboBox.Name = "fieldTypeComboBox";
            this.fieldTypeComboBox.Size = new System.Drawing.Size(157, 21);
            this.fieldTypeComboBox.TabIndex = 3;
            // 
            // addInDB
            // 
            this.addInDB.Location = new System.Drawing.Point(116, 176);
            this.addInDB.Name = "addInDB";
            this.addInDB.Size = new System.Drawing.Size(75, 23);
            this.addInDB.TabIndex = 4;
            this.addInDB.Text = "Add in DB";
            this.addInDB.UseVisualStyleBackColor = true;
            this.addInDB.Click += new System.EventHandler(this.addInDB_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(212, 176);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // newTableAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 218);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.addInDB);
            this.Controls.Add(this.fieldTypeComboBox);
            this.Controls.Add(this.initFieldNameTextBox);
            this.Controls.Add(this.tableNameTextBox);
            this.Controls.Add(this.fieldType);
            this.Controls.Add(this.initFieldName);
            this.Controls.Add(this.tableName);
            this.Name = "newTableAdd";
            this.Text = "Add new table in database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tableName;
        private System.Windows.Forms.Label initFieldName;
        private System.Windows.Forms.Label fieldType;
        private System.Windows.Forms.TextBox tableNameTextBox;
        private System.Windows.Forms.TextBox initFieldNameTextBox;
        private System.Windows.Forms.ComboBox fieldTypeComboBox;
        private System.Windows.Forms.Button addInDB;
        private System.Windows.Forms.Button cancel;
    }
}