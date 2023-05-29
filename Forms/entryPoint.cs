using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using informationSystemN.ElementsUI;
namespace informationSystemN.Forms
{
    public partial class entryPoint : Form
    {
        public entryPoint()
        {
            InitializeComponent();
        }
        List<eventCard> listOfCards = new List<eventCard>();

        private void entryPoint_Load(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0; 
            string connectString = "Data Source=localhost;Initial Catalog=DBS;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectString);
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT EventName, EventDate, EventPhoto,EventBranch FROM Event", sqlConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = cmd;
            dataAdapter.Fill(dataTable);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read()){
                eventCard eventField = new eventCard();
                listOfCards.Add(eventField);
                this.Controls.Add(eventField);
                eventField.Location = new Point(x, y);
                y+=200;
                //  eventCard.Anchor = AnchorStyles.Left;
                eventField.AutoScroll = true;
                var pathToPhoto =  Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../EventPhoto", $"{(string)reader["EventPhoto"]}"));
                eventField.eventPicture.Image = Image.FromFile(pathToPhoto);
                eventField.eventName.Text = $"{(string)reader["EventName"]}";
                eventField.eventDate.Text = $"{(string)reader["EventDate"]}";
                eventField.eventBranch.Text = $"{(string)reader["EventBranch"]}";
            }
        }

        private void branchesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < listOfCards.Count; i++) 
            {
                listOfCards[i].Dispose();
            }
            listOfCards.Clear();
            int x = 0;
            int y = 0;
            string connectString = "Data Source=localhost;Initial Catalog=DBS;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectString);
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand($"SELECT EventName, EventDate, EventPhoto,EventBranch FROM Event WHERE EventBranch = '{branchesBox.GetItemText(branchesBox.SelectedItem)}'", sqlConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = cmd;
            dataAdapter.Fill(dataTable);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                eventCard eventField = new eventCard();
                this.Controls.Add(eventField);
                eventField.Location = new Point(x, y);
                y+=200;
                listOfCards.Add(eventField);
                eventField.AutoScroll = true;
                var pathToPhoto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../EventPhoto", $"{(string)reader["EventPhoto"]}"));
                eventField.eventPicture.Image = Image.FromFile(pathToPhoto);
                eventField.eventName.Text = $"{(string)reader["EventName"]}";
                eventField.eventDate.Text = $"{(string)reader["EventDate"]}";
                eventField.eventBranch.Text = $"{(string)reader["EventBranch"]}";
            }
        }

        private void entryPoint_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm loginForm = new loginForm();
            loginForm.ShowDialog();

        }
    }
}
