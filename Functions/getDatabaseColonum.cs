using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace informationSystemN.Functions
{
    public class getDatabaseColonum
    {
        /// <typeparam name="T">
        /// Ввод типа значения ...
        /// </typeparam>
        /// <param name="querry">
        /// Запрос в базу данных
        /// </param>
        /// <param name="property">
        /// Поиск по определенному атрибуту в базе данных
        /// </param>
        public T getExectColonum<T>(string querry, string property)
        {
            string connectString = "Data Source=localhost;Initial Catalog=DBS;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectString);
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(querry,sqlConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = cmd;
            dataAdapter.Fill(dataTable);
            SqlDataReader reader = cmd.ExecuteReader();
            T value = (from DataRow dataRow in dataTable.Rows select (T)dataRow[$"{property}"]).FirstOrDefault();
            sqlConnection.Close();
            return value;
        }
    }
}
