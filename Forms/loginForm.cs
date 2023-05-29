using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using informationSystemN.Forms;
using informationSystemN.Functions;
using informationSystemN.Entities;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace informationSystemN
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void showPasswordButton_Click(object sender, EventArgs e)
        {
            if(passwordTextBox.UseSystemPasswordChar == true)
            {
                passwordTextBox.UseSystemPasswordChar = false;

            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        public static User userClass = new User();
        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            getDatabaseColonum getDatabaseColonum = new getDatabaseColonum();
            int type = getDatabaseColonum.getExectColonum<int>($"SELECT UserRole FROM [User] WHERE UserID = '{login}' and UserPassword = '{password}'", "UserRole");
            string userName = getDatabaseColonum.getExectColonum<string>($"SELECT UserName FROM [User] WHERE UserID = '{login}' and UserPassword = '{password}'", "UserName");
            string userSurname = getDatabaseColonum.getExectColonum<string>($"SELECT UserSurname FROM [User] WHERE UserID = '{login}' and UserPassword = '{password}'", "UserSurname");
            int userId = getDatabaseColonum.getExectColonum<int>($"SELECT UserID FROM [User] WHERE UserID = '{login}' and UserPassword = '{password}'", "UserID");
            fullNameHideLabel.Text = $"{userName} {userSurname}";
            DatabaseID.Text = userId.ToString();
            if (type !=0)
            {
                if(captchaTextBox.Text=="aaaa")
                {
                    if(type ==1)
                    { 
                        userClass.UserID = Int32.Parse(loginTextBox.Text);
                        userClass.UserPassword = passwordTextBox.Text;
                        MessageBox.Show("Вы вошли в систему","Вход выполнен",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Hide();
                        ownerForm form1 = new ownerForm();
                        form1.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка при вводе капчи!", "Ошибка входа!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Thread.Sleep(2000);
                }
            }
            else 
            {
                MessageBox.Show("Ошибка при вводе логина/пароля", "Ошибка входа!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Thread.Sleep(2000);
            }

        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            fullNameHideLabel.Hide();
            DatabaseID.Hide();
                loginTextBox.Text = userClass.UserID.ToString();
                passwordTextBox.Text = userClass.UserPassword;
        }

        private void captchaPicture_Click(object sender, EventArgs e)
        {
            var path = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../Resources", "fotoOrg1.jpg"));
            Bitmap capthca = new Bitmap(Image.FromFile(path));
            captchaPicture.Image = capthca;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            entryPoint entryPoint = new entryPoint();
            entryPoint.ShowDialog();
        }
    }
}
