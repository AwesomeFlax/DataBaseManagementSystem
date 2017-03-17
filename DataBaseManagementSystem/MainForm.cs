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
        Connection con = new Connection();
        sqlQueries sqlQue = new sqlQueries();
        DataSet ds;

        public static String connectionPath = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\test.mdb";

        public MainForm()
        {
            InitializeComponent();
        }

        private void tablesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(ds.Tables[tablesList.SelectedIndex]);
            mainDataGrid.DataSource = dv;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ds = con.fillDataSet();
            System.Data.DataTable t;
            bool skipOneTable = false;

            tablesList.Items.Add("Все таблицы");

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                t = con.loadDataBase();
                t.TableName = r["TABLE_NAME"].ToString();
                tablesList.Items.Add(t.TableName);
            }

            foreach (string k in tablesList.Items)
            {
                if (skipOneTable)
                {
                    OleDbDataAdapter ad = con.fillDataWeGetBefore(k);
                    ad.Fill(ds, k);
                }
                else skipOneTable = true;
            }
        }
    }
}
