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
    public partial class Category : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=materialbase;Integrated Security=True";
        public Category()
        {
            
            InitializeComponent();
        }

        private void categoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.materialbaseDataSet);

        }

        private void Category_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "materialbaseDataSet.Head". При необходимости она может быть перемещена или удалена.
            this.headTableAdapter.Fill(this.materialbaseDataSet.Head);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "materialbaseDataSet.Category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.materialbaseDataSet.Category);

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            string Name = name.Text;
            var head_cb = head.Text;
            //MessageBox.Show(Name, head_cb);
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand($"INSERT INTO category (name, head) VALUES ('{Name}', '{head_cb}')", conn);
                cmd.ExecuteScalar();
                this.categoryTableAdapter.Fill(this.materialbaseDataSet.Category);
                conn.Close();
            }
        }

        /*private void head_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            *//*using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                
            }*//*
        }*/

        private void head_SelectedIndexChanged(object sender, EventArgs e)
        {
            var head_cb = head.SelectedValue;
            //MessageBox.Show(Convert.ToString(head_cb));

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand($"SELECT Surname, Post FROM Head WHERE id_head='{head_cb}'", conn))
                {
                    //cmd.ExecuteScalar();

                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {

                            //MessageBox.Show("Test", "Test", MessageBoxButtons.OK);
                            head_name.Text = ($"{rd.GetValue(0).ToString()}" + ' ' + $"{rd.GetValue(1).ToString()}");

                        }
                    }
                    conn.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (categoryDataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = categoryDataGridView.SelectedRows[0].Index;

                int rowId = int.Parse(categoryDataGridView[0, selectedIndex].Value.ToString());

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand($"DELETE FROM Category WHERE id_cat = '{rowId}'", conn))
                    {
                        cmd.ExecuteScalar();
                        this.categoryTableAdapter.Fill(this.materialbaseDataSet.Category);
                    }
                    conn.Close();
                }
            }
        }
    }
}
