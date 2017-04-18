using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseManagementSystem
{
    public partial class editExistingTable : Form
    {
        sqlQueries sqlQue;
        private MainForm refForm;

        Connection con;
        DataSet ds;

        public editExistingTable()
        {
            InitializeComponent();
        }
        
        // constuctor to access req fields and methods
        public editExistingTable(string CP, MainForm _refForm)
        {
            this.refForm = _refForm;

            sqlQue = new sqlQueries(CP);
            con = new Connection(CP);
            InitializeComponent();

            ds = new DataSet();
            ds = con.fillDataSet();
            DataTable t;

            listBoxAddColumn.Items.Clear();
            listBoxDeleteColumn.Items.Clear();
            listBoxRenameColumn.Items.Clear();

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                t = con.loadDataBase();
                t.TableName = r["TABLE_NAME"].ToString();
                listBoxAddColumn.Items.Add(t.TableName);
                listBoxDeleteColumn.Items.Add(t.TableName);
                listBoxRenameColumn.Items.Add(t.TableName);
            }

            foreach (string k in listBoxAddColumn.Items)
            {
                OleDbDataAdapter ad = con.fillDataWeGetBefore(k);
                ad.Fill(ds, k);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sqlQue.add_column_to_table(
                listBoxAddColumn.SelectedItem.ToString(),
                textBoxAddColumn.Text,
                fieldTypeComboBoxAdd.SelectedItem.ToString());

                refForm.loadFromMDBFile();
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                sqlQue.delete_column_from_table(
                listBoxDeleteColumn.SelectedItem.ToString(),
                textBoxDeleteColumn.Text);

                refForm.loadFromMDBFile();
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            try
            {
                sqlQue.rename_column_in_table(
                listBoxRenameColumn.SelectedItem.ToString(),
                textBoxDeleteColumn.Text,
                textBoxNewColumnName.Text,
                comboBoxColumnTypeRename.SelectedItem.ToString());

                refForm.loadFromMDBFile();
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
