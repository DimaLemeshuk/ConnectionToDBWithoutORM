using DBProject_tele_company_.Classes;
using DBProject_tele_company_.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject_tele_company_
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            DBConection.ConectionDB();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login = this.login.Text;
            string password = this.password.Text;

            if (login.Length == 0 || password.Length ==0)
            {
                this.InfoLabel.Text = "Заповніть усі поля !";
            }
            else
            {
                Authorization.Login(login, password);
                switch (Authorization.typeUser)
                {
                    case null:
                        {
                            this.InfoLabel.Text = "Дані введені невірно.\nПеревірте правильність паролю та логіну!";
                            break;
                        }
                    case "1":
                        {
                            MessageBox.Show("11111111111");
                            break;
                        }
                    case "2":
                        {
                            MessageBox.Show("22222222222");
                            break;
                        }

                }
            }
        }
    }
}
