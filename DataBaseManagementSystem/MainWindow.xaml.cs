using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using System.Reflection;
using System.Windows;

namespace DataBaseManagementSystem
{
    public partial class MainWindow : Window
    {
        Connection con = new Connection();
        static String connectionPath = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\test.mdb";

        public MainWindow()
        {
            InitializeComponent();

            DataSet ds = con.fillDataSet(connectionPath);
            System.Data.DataTable t;

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                t = con.loadDataBase(connectionPath);
                t.TableName = r["TABLE_NAME"].ToString();
                tablesList.Items.Add(t.TableName);
            }
        }

        // при выборе пункта combox грузит соответствующую таблицу
        private void tablesList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            OleDbDataAdapter dataAdapter = con.fillDataWeGetBefore(tablesList.SelectedValue.ToString());
            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);
            mainDataGrid.ItemsSource = dataTable.DefaultView;
        }
    }
}
