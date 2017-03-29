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

        public customQuery()
        {
            InitializeComponent();
        }

        public customQuery(String CP)
        {
            sqlQue = new sqlQueries(CP);
            con = new Connection(CP);
            InitializeComponent();

            DataSet ds = new DataSet();
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

        private void sendQuery_Click(object sender, EventArgs e)
        {
            customDataGrid.AutoGenerateColumns = true;
            customDataGrid.DataSource = sqlQue.custom_que(userQuery.Text, listBox.SelectedItem.ToString());
            customDataGrid.DataMember = listBox.SelectedItem.ToString();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            userQuery.Text = "SELECT * FROM " + listBox.SelectedItem.ToString();
        }
    }
}
