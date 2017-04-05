using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseManagementSystem
{
    public partial class newTableAdd : Form
    {
        sqlQueries sqlQue;
        private MainForm refForm;

        public newTableAdd()
        {
            InitializeComponent();
        }

        public newTableAdd(string cP, MainForm _refForm)
        {
            sqlQue = new sqlQueries(cP);
            this.refForm = _refForm;
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addInDB_Click(object sender, EventArgs e)
        {
            // добавить 2 поле и сделать галочки "ключ/не ключ"
           
            try
            {
                sqlQue.add_table(tableNameTextBox.Text,
                                initFieldNameTextBox.Text,
                                fieldTypeComboBox.Items[fieldTypeComboBox.SelectedIndex].ToString()
                                 );

                refForm.loadFromMDBFile();

                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please ensure you have filled all the fields!");
            }
        }
    }
}
