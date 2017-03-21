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
    public class sqlQueries
    {
        OleDbConnection con;

        public sqlQueries (String cP) { con = new OleDbConnection(cP); }

        public void update(String TableName, String ColumnName, String TextInCell, String IDColumn, String CellText)
        {
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM " + TableName + "", con);
            string Change = "UPDATE `" + TableName + "` SET `" + ColumnName + "` = '" + TextInCell + "' WHERE `" + IDColumn + "` = " + CellText;

            ad.UpdateCommand = new OleDbCommand(Change, con);

            try
            {
                con.Open();
                ad.UpdateCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }

        public void delete(String TableName, String IDColumn, String CellText)
        {
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM " + TableName + "", con);
            string Del = "DELETE FROM `" + TableName + "` WHERE `" + IDColumn + "` = " + CellText;

            ad.DeleteCommand = new OleDbCommand(Del, con);

            try
            {
                con.Open();
                ad.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show("Success!");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }

        
        public void add(string TableName, string ColumnsNames, string NewData)
        {
            string Insert = "INSERT INTO `" + TableName + "` ( " + ColumnsNames + " ) VALUES ( " + NewData + ")";
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM " + TableName + "", con);

            ad.InsertCommand = new OleDbCommand(Insert, con);

            try
            {
                con.Open();
                ad.InsertCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }
    }
}
