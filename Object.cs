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
    public partial class Object : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=materialbase;Integrated Security=True";
        public Object()
        {
            InitializeComponent();
        }

        private void objectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.objectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.materialbaseDataSet);

        }

        private void Object_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "materialbaseDataSet.Assignment". При необходимости она может быть перемещена или удалена.
            this.assignmentTableAdapter.Fill(this.materialbaseDataSet.Assignment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "materialbaseDataSet.Category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.materialbaseDataSet.Category);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "materialbaseDataSet.Object". При необходимости она может быть перемещена или удалена.
            this.objectTableAdapter.Fill(this.materialbaseDataSet.Object);

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
            string Descr = descr.Text;
            var Cat = cat_CB.SelectedValue;
            var Assign = assign_CB.SelectedValue;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand($"INSERT INTO Object (name, description, category, assignment) VALUES('{Name}', '{Descr}', '{Cat}', '{Assign}')", conn))
                {
                    cmd.ExecuteScalar();
                    //MessageBox.Show("success","task", MessageBoxButtons.OK);
                    this.objectTableAdapter.Fill(this.materialbaseDataSet.Object);
                }

                conn.Close();
            }
        }

        private void cat_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cat_cb = cat_CB.SelectedValue;
            //MessageBox.Show(Convert.ToString(head_cb));

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand($"SELECT name FROM Category WHERE id_cat='{cat_cb}'", conn))
                {
                    //cmd.ExecuteScalar();

                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {

                            //MessageBox.Show("Test", "Test", MessageBoxButtons.OK);
                            cat_label.Text = ($"{rd.GetValue(0).ToString()}");

                        }
                    }
                    conn.Close();
                }
            }
        }

        private void assign_label_Click(object sender, EventArgs e)
        {
            
        }

        private void assign_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var assign_cb = assign_CB.SelectedValue;
            //MessageBox.Show(Convert.ToString(head_cb));

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand($"SELECT name FROM Assignment WHERE id_assign='{assign_cb}'", conn))
                {
                    //cmd.ExecuteScalar();

                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {

                            //MessageBox.Show("Test", "Test", MessageBoxButtons.OK);
                            assign_label.Text = ($"{rd.GetValue(0).ToString()}");

                        }
                    }
                    
                }
                conn.Close();
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
           /* foreach (DataGridViewRow row in objectDataGridView.SelectedRows)
            {
                Console.WriteLine(row);
                objectDataGridView.Rows.RemoveAt(row.Index);
            }*/
           if (objectDataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = objectDataGridView.SelectedRows[0].Index;

                int rowId = int.Parse(objectDataGridView[0, selectedIndex].Value.ToString());

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand($"DELETE FROM Object WHERE id_obj = '{rowId}'", conn))
                    {
                        cmd.ExecuteScalar();
                        this.objectTableAdapter.Fill(this.materialbaseDataSet.Object);
                    }
                    conn.Close();
                }
            }
        }
    }
}
