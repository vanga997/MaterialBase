using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MaterialBase
{
    public partial class Menu : Form
    {
        string login = Auth.login.ToString();
        string password = Auth.password.ToString();
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=materialbase;Integrated Security=True";
            string user_type;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var cmd = new SqlCommand($"SELECT Surname, Name, LastName FROM Employee WHERE Login='{login}' AND Password='{password}'", connection))
                {
                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            
                            //MessageBox.Show("Test", "Test", MessageBoxButtons.OK);
                            name_label.Text = ($"{rd.GetValue(0).ToString()}" + ' ' + $"{rd.GetValue(1).ToString()}" + ' ' + $"{rd.GetValue(2).ToString()}");

                        }
                    }
                }

                using (var cmd = new SqlCommand($"SELECT Post FROM Employee WHERE Login='{login}' AND Password='{password}'", connection))
                {
                    user_type = (string)cmd.ExecuteScalar();

                    if (user_type == "Администратор")
                    {
                        //MessageBox.Show("Вы вошли как администратор", "Сообщение", MessageBoxButtons.OK);
                    }
                    else if (user_type == "Пользователь")
                    {
                        categories.Hide();
                        assignments.Hide();
                        headers.Hide();

                        //MessageBox.Show("Вы вошли как пользователь", "Сообщение", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Ошибка доступа!", "Ошибка!", MessageBoxButtons.OK);
                }

                connection.Close();


            }
        }

        private void name_label_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Auth auth = new Auth();
            auth.Show();
        }

        private void objects_Click(object sender, EventArgs e)
        {
            this.Close();
            Object obj = new Object();
            obj.Show();
        }

        private void categories_Click(object sender, EventArgs e)
        {
            this.Close();
            Category cat = new Category();
            cat.Show();
        }

        private void assignments_Click(object sender, EventArgs e)
        {
            this.Close();
            Assignment assign = new Assignment();
            assign.Show();
        }

        private void headers_Click(object sender, EventArgs e)
        {
            this.Close();
            Head head = new Head();
            head.Show();
        }

        public void set()
        {

        }
    }
}
