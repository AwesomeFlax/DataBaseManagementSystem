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
using System.Windows.Controls;

namespace DataBaseManagementSystem
{
    class sqlQueries
    {
        OleDbConnection con = new OleDbConnection(MainForm.connectionPath);

        public void update (String TableName, String ColumnName, String TextInCell, String IDColumn, String CellText)
        {
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM " + TableName + "", con);

            string Change = "UPDATE " + TableName + " SET " + ColumnName + " = '" + TextInCell + "' WHERE " + IDColumn + " = " + CellText + "";

            ad.UpdateCommand = new OleDbCommand(Change, con);

            MessageBox.Show(Change);

            //con.Open();
            //ad.UpdateCommand.ExecuteNonQuery();
            //con.Close();
        }
    }
}
