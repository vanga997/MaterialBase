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
    public partial class Assignment : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=materialbase;Integrated Security=True";
        public Assignment()
        {
            InitializeComponent();
        }

        private void assignmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.assignmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.materialbaseDataSet);

        }

        private void Assignment_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "materialbaseDataSet.Assignment". При необходимости она может быть перемещена или удалена.
            this.assignmentTableAdapter.Fill(this.materialbaseDataSet.Assignment);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void add_assign_Click(object sender, EventArgs e)
        {
            string assign = textBox_assign.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand add = new SqlCommand($"INSERT INTO Assignment(name) VALUES ('{assign}')", conn);
                add.ExecuteScalar();
                /*this.Validate();
                this.assignmentBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.materialbaseDataSet);*/
                this.assignmentTableAdapter.Fill(this.materialbaseDataSet.Assignment);
                conn.Close();
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (assignmentDataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = assignmentDataGridView.SelectedRows[0].Index;

                int rowId = int.Parse(assignmentDataGridView[0, selectedIndex].Value.ToString());

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand($"DELETE FROM Assignment WHERE id_assign = '{rowId}'", conn))
                    {
                        cmd.ExecuteScalar();
                        this.assignmentTableAdapter.Fill(this.materialbaseDataSet.Assignment);
                    }
                    conn.Close();
                }
            }
        }
    }
}
