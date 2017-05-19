﻿using System;
using System.Data;
using System.Data.OleDb;
using System.Windows;

namespace DataBaseManagementSystem
{
    public class sqlQueries
    {
        OleDbConnection con;
        OleDbDataAdapter ad;

        OleDbDataAdapter ad1;
        OleDbDataAdapter ad2;
        OleDbDataAdapter ad3;


        public sqlQueries(String cP) { con = new OleDbConnection(cP); }

        // update data in current row
        public void update(String TableName, String ColumnName, String TextInCell, String IDColumn, String CellText)
        {
            ad = new OleDbDataAdapter("Select * FROM " + TableName, con);
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
            ad = new OleDbDataAdapter("Select * FROM " + TableName, con);
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

            ad = new OleDbDataAdapter("Select * FROM " + TableName, con);
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

            ad = new OleDbDataAdapter("Select * FROM " + TableName, con);
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
            ad = new OleDbDataAdapter("Select * FROM " + TableName, con);

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

        public void add_column_to_table(string TableName, string ColumnName, string Type)
        {
            string query = "ALTER TABLE `" + TableName + "` ADD `" + ColumnName + "` " + Type + "";

            ad = new OleDbDataAdapter("Select * FROM " + TableName + "", con);
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

        public void delete_column_from_table(string TableName, string ColumnName)
        {
            string query = "ALTER TABLE `" + TableName + "` DROP `" + ColumnName + "`";

            ad = new OleDbDataAdapter("Select * FROM " + TableName + "", con);
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

        public void rename_column_in_table(string TableName, string ColumnName, string NewColumnName, string Type)
        {
            add_column_to_table(TableName, NewColumnName, Type);

            string queryUpdate = "UPDATE `" + TableName + "` SET `" + NewColumnName + "` = `" + ColumnName + "`";

            ad = new OleDbDataAdapter("Select * FROM " + TableName, con);
            ad.UpdateCommand = new OleDbCommand(queryUpdate, con);

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

            delete_column_from_table(TableName, ColumnName);
        }

        public DataSet custom_que(String query, String TableName)
        {
            ad = new OleDbDataAdapter(query, con);
            DataSet ds = new DataSet();

            try
            {
                ad.Fill(ds, TableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ds;
        }
    }
}
