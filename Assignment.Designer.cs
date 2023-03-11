namespace MaterialBase
{
    partial class Assignment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.materialbaseDataSet = new MaterialBase.materialbaseDataSet();
            this.assignmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignmentTableAdapter = new MaterialBase.materialbaseDataSetTableAdapters.AssignmentTableAdapter();
            this.tableAdapterManager = new MaterialBase.materialbaseDataSetTableAdapters.TableAdapterManager();
            this.assignmentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_assign = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.add_assign = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.materialbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // materialbaseDataSet
            // 
            this.materialbaseDataSet.DataSetName = "materialbaseDataSet";
            this.materialbaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assignmentBindingSource
            // 
            this.assignmentBindingSource.DataMember = "Assignment";
            this.assignmentBindingSource.DataSource = this.materialbaseDataSet;
            // 
            // assignmentTableAdapter
            // 
            this.assignmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssignmentTableAdapter = this.assignmentTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.HeadTableAdapter = null;
            this.tableAdapterManager.ObjectTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MaterialBase.materialbaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // assignmentDataGridView
            // 
            this.assignmentDataGridView.AutoGenerateColumns = false;
            this.assignmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.assignmentDataGridView.DataSource = this.assignmentBindingSource;
            this.assignmentDataGridView.Location = new System.Drawing.Point(12, 12);
            this.assignmentDataGridView.Name = "assignmentDataGridView";
            this.assignmentDataGridView.ReadOnly = true;
            this.assignmentDataGridView.Size = new System.Drawing.Size(291, 220);
            this.assignmentDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_assign";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_assign";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Назначение";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_assign
            // 
            this.textBox_assign.Location = new System.Drawing.Point(12, 265);
            this.textBox_assign.Multiline = true;
            this.textBox_assign.Name = "textBox_assign";
            this.textBox_assign.Size = new System.Drawing.Size(142, 20);
            this.textBox_assign.TabIndex = 4;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(228, 291);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // add_assign
            // 
            this.add_assign.Location = new System.Drawing.Point(12, 291);
            this.add_assign.Name = "add_assign";
            this.add_assign.Size = new System.Drawing.Size(68, 23);
            this.add_assign.TabIndex = 7;
            this.add_assign.Text = "Добавить";
            this.add_assign.UseVisualStyleBackColor = true;
            this.add_assign.Click += new System.EventHandler(this.add_assign_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(86, 291);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(68, 23);
            this.btn_del.TabIndex = 8;
            this.btn_del.Text = "Удалить";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 326);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.add_assign);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.textBox_assign);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.assignmentDataGridView);
            this.Name = "Assignment";
            this.Text = "Assignment";
            this.Load += new System.EventHandler(this.Assignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialbaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private materialbaseDataSet materialbaseDataSet;
        private System.Windows.Forms.BindingSource assignmentBindingSource;
        private materialbaseDataSetTableAdapters.AssignmentTableAdapter assignmentTableAdapter;
        private materialbaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView assignmentDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_assign;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button add_assign;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btn_del;
    }
}