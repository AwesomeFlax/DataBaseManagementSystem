using System;
using System.Data;
using System.Data.OleDb;

namespace DataBaseManagementSystem
{
    public class Connection
    {
        OleDbConnection con;

        public Connection(String cP) { con = new OleDbConnection(cP); }

        // filling data apadter
        public OleDbDataAdapter fillDataWeGetBefore(String table_name)
        {
            OleDbCommand com = new OleDbCommand("SELECT * FROM " + table_name, con);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(com);

            return dataAdapter;
        }

        // filling data set
        public DataSet fillDataSet()
        {
            con.Close();
            con.Open();

            DataSet ds = new DataSet();
            ds.Tables.Clear();
            ds.Tables.Add(con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" }));

            return ds;
        }

        // filling data table
        public DataTable loadDataBase()
        {
            DataTable t1 = null;

            try
            {
                DataSet ds = fillDataSet();

                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    t1 = con.GetOleDbSchemaTable(OleDbSchemaGuid.Columns,
                        new object[] { null, null, r["TABLE_NAME"], null });
                }
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }

            return t1;
        }
    }
}
