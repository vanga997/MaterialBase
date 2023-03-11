using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialBase
{
    public partial class Head : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=materialbase;Integrated Security=True";
        public Head()
        {
            
            InitializeComponent();
        }

        private void headBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.headBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.materialbaseDataSet);

        }

        private void Head_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "materialbaseDataSet.Head". При необходимости она может быть перемещена или удалена.
            this.headTableAdapter.Fill(this.materialbaseDataSet.Head);

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string surname = textBox_surname.Text;
            string name = textBox_name.Text;
            string lastname = textBox_lastname.Text;
            string post = textBox_post.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand add = new SqlCommand($"INSERT INTO Head(Surname, Name, LastName, Post) VALUES ('{surname}', '{name}', '{lastname}', '{post}')", conn);
                add.ExecuteScalar();

                this.Validate();
                this.headBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.materialbaseDataSet);
                this.headTableAdapter.Fill(this.materialbaseDataSet.Head);
                conn.Close();
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (headDataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = headDataGridView.SelectedRows[0].Index;

                int rowId = int.Parse(headDataGridView[0, selectedIndex].Value.ToString());

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand($"DELETE FROM Head WHERE id_head = '{rowId}'", conn))
                    {
                        cmd.ExecuteScalar();
                        this.headTableAdapter.Fill(this.materialbaseDataSet.Head);
                    }
                    conn.Close();
                }
            }
        }
    }
}
