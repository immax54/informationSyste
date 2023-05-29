using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using informationSystemN.Functions;
namespace informationSystemN.Forms
{
    public partial class ownerForm : Form
    {
        public ownerForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var a = Application.OpenForms["loginForm"];
                userFullName.Text = ((loginForm)a).fullNameHideLabel.Text;
            var idForm = Application.OpenForms["loginForm"];
            int idUser = Int32.Parse(((loginForm)idForm).DatabaseID.Text);
            getDatabaseColonum read = new getDatabaseColonum();
            string photo = read.getExectColonum<string>($"SELECT UserPhoto FROM [User] WHERE UserID={idUser}", "UserPhoto");

            var path = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,@"..\..\Resources", $"{photo}")); 
            Bitmap bmp = new Bitmap(Image.FromFile(path));
            pictureBox1.Image = bmp;


            DateTime today = System.DateTime.Now;
            if(today.Hour>=9)
            {
                dayTimeLabel.Text = "Доброе утро";
            }
            if (today.Hour>=11)
            {
                dayTimeLabel.Text = "Добрый день";
            }
            if (today.Hour>=18&today.Minute>=1)
            {
                dayTimeLabel.Text = "Добрый вечер";
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            loginForm loginForm = new loginForm();
            loginForm.ShowDialog();
        }

        private void eventButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            entryPoint entryPoint = new entryPoint();
            entryPoint.ShowDialog();
        }
    }
}
