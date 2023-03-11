namespace MaterialBase
{
    partial class Category
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
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new MaterialBase.materialbaseDataSetTableAdapters.CategoryTableAdapter();
            this.tableAdapterManager = new MaterialBase.materialbaseDataSetTableAdapters.TableAdapterManager();
            this.headTableAdapter = new MaterialBase.materialbaseDataSetTableAdapters.HeadTableAdapter();
            this.categoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.headBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.head = new System.Windows.Forms.ComboBox();
            this.head_name = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.materialbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialbaseDataSet
            // 
            this.materialbaseDataSet.DataSetName = "materialbaseDataSet";
            this.materialbaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.materialbaseDataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssignmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = this.categoryTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.HeadTableAdapter = this.headTableAdapter;
            this.tableAdapterManager.ObjectTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MaterialBase.materialbaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // headTableAdapter
            // 
            this.headTableAdapter.ClearBeforeFill = true;
            // 
            // categoryDataGridView
            // 
            this.categoryDataGridView.AutoGenerateColumns = false;
            this.categoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.categoryDataGridView.DataSource = this.categoryBindingSource;
            this.categoryDataGridView.Location = new System.Drawing.Point(11, 12);
            this.categoryDataGridView.Name = "categoryDataGridView";
            this.categoryDataGridView.ReadOnly = true;
            this.categoryDataGridView.Size = new System.Drawing.Size(343, 231);
            this.categoryDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_cat";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_cat";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "head";
            this.dataGridViewTextBoxColumn3.HeaderText = "head";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Заведующий";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(124, 274);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(136, 20);
            this.name.TabIndex = 4;
            // 
            // headBindingSource
            // 
            this.headBindingSource.DataMember = "Head";
            this.headBindingSource.DataSource = this.materialbaseDataSet;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(286, 274);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 29);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(286, 367);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Выйти";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // head
            // 
            this.head.DataSource = this.headBindingSource;
            this.head.DisplayMember = "id_head";
            this.head.FormattingEnabled = true;
            this.head.Location = new System.Drawing.Point(124, 315);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(136, 21);
            this.head.TabIndex = 8;
            this.head.ValueMember = "id_head";
            this.head.SelectedIndexChanged += new System.EventHandler(this.head_SelectedIndexChanged);
            // 
            // head_name
            // 
            this.head_name.AutoSize = true;
            this.head_name.Location = new System.Drawing.Point(124, 343);
            this.head_name.Name = "head_name";
            this.head_name.Size = new System.Drawing.Size(35, 13);
            this.head_name.TabIndex = 9;
            this.head_name.Text = "label3";
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(286, 312);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 10;
            this.btn_del.Text = "Удалить";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 402);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.head_name);
            this.Controls.Add(this.head);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryDataGridView);
            this.MaximumSize = new System.Drawing.Size(382, 441);
            this.MinimumSize = new System.Drawing.Size(382, 441);
            this.Name = "Category";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialbaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private materialbaseDataSet materialbaseDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private materialbaseDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private materialbaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView categoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_exit;
        private materialbaseDataSetTableAdapters.HeadTableAdapter headTableAdapter;
        private System.Windows.Forms.BindingSource headBindingSource;
        private System.Windows.Forms.ComboBox head;
        private System.Windows.Forms.Label head_name;
        private System.Windows.Forms.Button btn_del;
    }
}