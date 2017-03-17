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
    class Connection
    {
        OleDbConnection conn;

        public OleDbDataAdapter fillDataWeGetBefore(String table_name)
        {
            OleDbCommand com = new OleDbCommand("SELECT * FROM " + table_name, conn);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(com);

            return dataAdapter;
        }

        public DataSet fillDataSet()
        {
            conn = new OleDbConnection(MainForm.connectionPath);
            conn.Close();
            conn.Open();

            DataSet ds = new DataSet();
            ds.Tables.Clear();
            ds.Tables.Add(conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" }));

            return ds;
        }

        public System.Data.DataTable loadDataBase()
        {
            System.Data.DataTable t1 = null;

            try
            {
                DataSet ds = fillDataSet();

                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    t1 = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Columns,
                        new object[] { null, null, r["TABLE_NAME"], null });
                }
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }

            return t1;
        }
    }
}
