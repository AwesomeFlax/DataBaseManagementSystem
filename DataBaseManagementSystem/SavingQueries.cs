using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseManagementSystem
{
    class SavingQueries
    {
        public static void SaveData(string data)
        {
            if (IsUnique(data))
            {
                File.AppendAllText("queries.txt", data);
                File.AppendAllText("queries.txt", "\n");
            }
        }

        public static List<string> GetData()
        {
            List<string> queries = new List<string>();

            if (File.Exists("queries.txt") == false)
            {
                File.Create("queries.txt");
            }

            FileStream queryList = new FileStream("queries.txt", FileMode.Open);
            StreamReader reader = new StreamReader(queryList);

            string Input = null;
            while ((Input = reader.ReadLine()) != null)
            {
                queries.Add(Input);
            }
            reader.Close();

            return queries;
        }

        public static bool IsUnique(string data)
        {
            List<string> queries = GetData();

            if (queries.Contains(data))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
