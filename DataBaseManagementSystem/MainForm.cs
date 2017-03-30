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
    public partial class MainForm : Form
    {
        Connection con;
        sqlQueries sqlQue;

        String connectionPath;
        String selectedTable;

        DataSet ds;

        public MainForm()
        {
            InitializeComponent();
        }

        // makes buttons visible
        void openAccess()
        {
            addTable.Visible = true;
            deleteTable.Visible = true;
            addNote.Visible = true;
            ownQueMenu.Enabled = true;
        }

        // access
        String getCP()
        {
            return @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\";
        }

        // what to do to connect software with .mdb file
        public void loadFromMDBFile()
        {
            ds = con.fillDataSet();
            DataTable t;

            listBox.Items.Clear();

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                t = con.loadDataBase();
                t.TableName = r["TABLE_NAME"].ToString();
                listBox.Items.Add(t.TableName);
            }

            foreach (string k in listBox.Items)
            {
                OleDbDataAdapter ad = con.fillDataWeGetBefore(k);
                ad.Fill(ds, k);
            }
        }

        // to load data according selected table
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                DataView dv = new DataView(ds.Tables[listBox.SelectedItem.ToString()]);
                selectedTable = listBox.SelectedItem.ToString();
                mainDataGrid.DataSource = dv;
            }
            else
                MessageBox.Show("Choose a table in table list");
        }

        // data update
        private void mainDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (mainDataGrid.Columns.Count > 1)
            {
                sqlQue.update(selectedTable,
                        mainDataGrid.Columns[mainDataGrid.CurrentCell.ColumnIndex].HeaderText.ToString(),
                        mainDataGrid.CurrentCell.Value.ToString(),
                        mainDataGrid.Columns[0].HeaderText.ToString(),
                        mainDataGrid[0, mainDataGrid.CurrentCell.RowIndex].Value.ToString());

                loadFromMDBFile();
            }
        }

        // data delete
        private void mainDataGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 8) && (mainDataGrid.SelectedRows.Count == 1))
                sqlQue.delete(selectedTable,
                    mainDataGrid.Columns[0].HeaderText.ToString(),
                    mainDataGrid[0, mainDataGrid.SelectedRows[0].Index].Value.ToString());

            loadFromMDBFile();
        }

        // when new row was added
        private void mainDataGrid_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            int k = 0;

            try
            {
                k = int.Parse(mainDataGrid[0, mainDataGrid.CurrentCell.RowIndex - 1].Value.ToString());
                mainDataGrid[0, mainDataGrid.CurrentCell.RowIndex].Value = ++k;
            }
            catch
            { }
        }

        // addind data via inserting it and pressing button
        private void addNote_Click(object sender, EventArgs e)
        {
            int ColCount = mainDataGrid.Columns.Count;
            string ColumnsNames = "";
            string NewData = "";

            for (int i = 0; i < ColCount; i++)
            {
                if (i < ColCount - 1)
                {
                    ColumnsNames = ColumnsNames + "`" + mainDataGrid.Columns[i].HeaderText.ToString() + "`, ";
                    NewData = NewData + "'" + mainDataGrid[i, mainDataGrid.CurrentCell.RowIndex].Value.ToString() + "', ";
                }
                else
                {
                    ColumnsNames = ColumnsNames + "`" + mainDataGrid.Columns[i].HeaderText.ToString() + "`";
                    NewData = NewData + "'" + mainDataGrid[i, mainDataGrid.CurrentCell.RowIndex].Value.ToString() + "'";
                }
            }

            sqlQue.add(selectedTable,
                    ColumnsNames, NewData);

            loadFromMDBFile();
        }

        // allows openin files (only root directory)
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Open database:";
                openFileDialog.Filter = "MBD files only (*.mdb)|*.mdb";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    String uncutted = openFileDialog.FileName;
                    String cutted = uncutted.Remove(0, uncutted.LastIndexOf("\\") + 1);
                    connectionPath = getCP() + cutted;

                    sqlQue = new sqlQueries(connectionPath);
                    con = new Connection(connectionPath);

                    loadFromMDBFile();
                    openAccess();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

        // deletes selected table
        private void deleteTable_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                string message = "Are you sure you want to delete table '" + selectedTable + "'?";
                string caption = "Table delete";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    sqlQue.delete_table(selectedTable);
                    loadFromMDBFile();
                }
            }
            else
                MessageBox.Show("Choose a table in table list");
        }

        // creates special form to add new table
        private void addTable_Click(object sender, EventArgs e)
        {
            newTableAdd obj = new newTableAdd(connectionPath, this);
            obj.Show();
        }

        private void exportToXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customQuery customQue = new customQuery(connectionPath);
            customQue.Show();
        }
    }
}
