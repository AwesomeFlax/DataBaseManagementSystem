using System;
using System.Data.OleDb;
using System.Windows;

namespace DataBaseManagementSystem
{
    public class sqlQueries
    {
        OleDbConnection con;

        public sqlQueries(String cP) { con = new OleDbConnection(cP); }

        // update data in current row
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
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        // delete selected row
        public void delete(String TableName, String IDColumn, String CellText)
        {
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM " + TableName + "", con);
            string Del = "DELETE FROM `" + TableName + "` WHERE `" + IDColumn + "` = " + CellText;

            ad.DeleteCommand = new OleDbCommand(Del, con);

            try
            {
                con.Open();
                ad.DeleteCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        // add new line into table
        public void add(string TableName, string ColumnsNames, string NewData)
        {
            string Insert = "INSERT INTO `" + TableName + "` (" + ColumnsNames + ") VALUES ( " + NewData + ")";

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
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        // delete table from DB
        public void delete_table(string TableName)
        {
            string query = "DROP TABLE `" + TableName + "`";

            OleDbDataAdapter ad = new OleDbDataAdapter("Select * FROM " + TableName + "", con);
            ad.DeleteCommand = new OleDbCommand(query, con);

            try
            {
                con.Open();
                ad.DeleteCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        // add new table in DB
        public void add_table(string TableName, string NewColumnName, string Type)
        {
            string query = "CREATE TABLE `" + TableName + "` (`" + NewColumnName + "` " + Type + ")";

            OleDbDataAdapter ad = new OleDbDataAdapter("Select * FROM " + TableName + "", con);
            ad.InsertCommand = new OleDbCommand(query, con);

            try
            {
                con.Open();
                ad.InsertCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
    }
}
