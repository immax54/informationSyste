using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace informationSystemN.Functions
{
    public class f
    {
        public T getColonumFromDatabase<T>(string querry, string property)
        {
            string connString = "Data Source=localhost;Initial Catalog=DBS;Integrated Security=True";
            SqlConnection sqlConnect = new SqlConnection(connString);
            DataTable Table = new DataTable();
            sqlConnect.Open();
            SqlCommand cmd = new SqlCommand(querry,sqlConnect);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(Table);
            SqlDataReader reader = cmd.ExecuteReader();
            T value = (from DataRow dr in Table.Rows select (T)dr[$"{property}"]).FirstOrDefault();
            sqlConnect.Close();
            return value;
        }
    }
}
