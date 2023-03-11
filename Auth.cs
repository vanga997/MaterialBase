using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MaterialBase
{
    public partial class Auth : Form
    {
        static public string login;
        static public string password;
        //tatic public string connectionString = "";
        public Auth()
        {
            
            InitializeComponent();
        }

        public void btn_enter_Click(object sender, EventArgs e)
        {
            login = login_box.Text;
            password = pass_box.Text;

            string user_type;

            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = materialbase; Integrated Security = True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Post from Employee WHERE Login='{login}' AND Password='{password}'", conn);
                user_type = (string)cmd.ExecuteScalar();

                if (login == "" || password == "")
                    MessageBox.Show("Пожалуйста, введите логин и/или пароль!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (user_type == "Администратор")
                {
                    this.Hide();
                    Menu menu = new Menu();
                    menu.Show();
                    Console.WriteLine("Вход выполнен!");
                }
                else if (user_type == "Пользователь")
                {
                    this.Hide();
                    Menu menu = new Menu();
                    menu.Show();
                    Console.WriteLine("Вход выполнен!");

                }
                else
                    Console.WriteLine("Данного пользователя не существует");
               
            }

            
        }

        public void getAuth(string login, string password)
        {
            if (login == login_box.Text || password == pass_box.Text)
            {
                Console.WriteLine("test");
            }
            else
                Console.WriteLine("Error");
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            pass_box.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
