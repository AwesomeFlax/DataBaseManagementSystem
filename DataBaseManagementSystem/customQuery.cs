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
    public partial class customQuery : Form
    {
        sqlQueries sqlQue;
        Connection con;

        DataView dv;
        DataSet ds;

        private string selectedTable = "";
        private List<string> queries;

        public customQuery()
        {
            InitializeComponent();
        }

        // constuctor to setup and upload everything
        public customQuery(String CP)
        {
            sqlQue = new sqlQueries(CP);
            con = new Connection(CP);
            InitializeComponent();

            ds = new DataSet();
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

            queries = new List<string>();
            queries = SavingQueries.GetData();

            if (queries.Count > 0)
            {
                foreach (string i in queries)
                {
                    userQuery.Items.Add(i);
                }
            }

            listBox.SelectedIndex = 0;
        }

        // to get table 
        string getSelectedTable()
        {
            return selectedTable;
        }

        // to set table
        void setSelectedTable(string _selectedTable)
        {
            selectedTable = _selectedTable;
        }

        // to get data according to SQL query
        private void sendQuery_Click(object sender, EventArgs e)
        {
            setSelectedTable(listBox.SelectedItem.ToString());
            searchGB.Enabled = true;

            columnList.Items.Clear();

            for (int i = 0; i < ds.Tables[getSelectedTable()].Columns.Count; i++)
            {
                columnList.Items.Add(ds.Tables[getSelectedTable()].Columns[i].ToString());
            }

            customDataGrid.AutoGenerateColumns = true;
            customDataGrid.DataSource = sqlQue.custom_que(userQuery.Text, getSelectedTable());

            try
            {
                customDataGrid.DataMember = getSelectedTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (SaveQuery.Checked == true)
            {
                try
                {
                    SavingQueries.SaveData(userQuery.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // set up default string into string query
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            userQuery.Text = "SELECT * FROM " + listBox.SelectedItem.ToString();
        }

        // try search data that equals data in textbox
        private void searchButton_Click(object sender, EventArgs e)
        {
            dv = new DataView(ds.Tables[getSelectedTable()]);
            customDataGrid.DataSource = dv;

            try
            {
                dv.RowFilter = columnList.Text + "= '" + whatToSearch.Text + "'";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
