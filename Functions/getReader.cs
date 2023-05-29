using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace informationSystemN.Functions
{
    public class getReader
    {
        public SqlDataReader getReadDatabase(string querry)
        {
            
            var path = Path.GetFileName(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Resources", "1.jpg"));
            Bitmap bmp = new Bitmap(Image.FromFile(path));

            string connectString = "Data Source=localhost;Initial Catalog=DBS;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectString);
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(querry, sqlConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = cmd;
            dataAdapter.Fill(dataTable);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
