namespace MaterialBase
{
    partial class Object
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
            this.objectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.objectTableAdapter = new MaterialBase.materialbaseDataSetTableAdapters.ObjectTableAdapter();
            this.tableAdapterManager = new MaterialBase.materialbaseDataSetTableAdapters.TableAdapterManager();
            this.objectDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.descr = new System.Windows.Forms.TextBox();
            this.cat_CB = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assign_CB = new System.Windows.Forms.ComboBox();
            this.assignmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.categoryTableAdapter = new MaterialBase.materialbaseDataSetTableAdapters.CategoryTableAdapter();
            this.assignmentTableAdapter = new MaterialBase.materialbaseDataSetTableAdapters.AssignmentTableAdapter();
            this.cat_label = new System.Windows.Forms.Label();
            this.assign_label = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.materialbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialbaseDataSet
            // 
            this.materialbaseDataSet.DataSetName = "materialbaseDataSet";
            this.materialbaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // objectBindingSource
            // 
            this.objectBindingSource.DataMember = "Object";
            this.objectBindingSource.DataSource = this.materialbaseDataSet;
            // 
            // objectTableAdapter
            // 
            this.objectTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssignmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.HeadTableAdapter = null;
            this.tableAdapterManager.ObjectTableAdapter = this.objectTableAdapter;
            this.tableAdapterManager.UpdateOrder = MaterialBase.materialbaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // objectDataGridView
            // 
            this.objectDataGridView.AutoGenerateColumns = false;
            this.objectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.objectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.objectDataGridView.DataSource = this.objectBindingSource;
            this.objectDataGridView.Location = new System.Drawing.Point(10, 12);
            this.objectDataGridView.Name = "objectDataGridView";
            this.objectDataGridView.ReadOnly = true;
            this.objectDataGridView.Size = new System.Drawing.Size(541, 289);
            this.objectDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_obj";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_obj";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn3.HeaderText = "description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "category";
            this.dataGridViewTextBoxColumn4.HeaderText = "category";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "assignment";
            this.dataGridViewTextBoxColumn5.HeaderText = "assignment";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 317);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Категория";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Назначение";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(106, 317);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(121, 20);
            this.name.TabIndex = 6;
            // 
            // descr
            // 
            this.descr.Location = new System.Drawing.Point(106, 344);
            this.descr.Multiline = true;
            this.descr.Name = "descr";
            this.descr.Size = new System.Drawing.Size(121, 20);
            this.descr.TabIndex = 7;
            // 
            // cat_CB
            // 
            this.cat_CB.DataSource = this.categoryBindingSource;
            this.cat_CB.DisplayMember = "id_cat";
            this.cat_CB.FormattingEnabled = true;
            this.cat_CB.Location = new System.Drawing.Point(106, 371);
            this.cat_CB.Name = "cat_CB";
            this.cat_CB.Size = new System.Drawing.Size(121, 21);
            this.cat_CB.TabIndex = 8;
            this.cat_CB.ValueMember = "id_cat";
            this.cat_CB.SelectedIndexChanged += new System.EventHandler(this.cat_CB_SelectedIndexChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.materialbaseDataSet;
            // 
            // assign_CB
            // 
            this.assign_CB.DataSource = this.assignmentBindingSource;
            this.assign_CB.DisplayMember = "id_assign";
            this.assign_CB.FormattingEnabled = true;
            this.assign_CB.Location = new System.Drawing.Point(106, 398);
            this.assign_CB.Name = "assign_CB";
            this.assign_CB.Size = new System.Drawing.Size(121, 21);
            this.assign_CB.TabIndex = 9;
            this.assign_CB.ValueMember = "id_assign";
            this.assign_CB.SelectedIndexChanged += new System.EventHandler(this.assign_CB_SelectedIndexChanged);
            // 
            // assignmentBindingSource
            // 
            this.assignmentBindingSource.DataMember = "Assignment";
            this.assignmentBindingSource.DataSource = this.materialbaseDataSet;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(249, 317);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 40);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(476, 398);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "Выйти";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // assignmentTableAdapter
            // 
            this.assignmentTableAdapter.ClearBeforeFill = true;
            // 
            // cat_label
            // 
            this.cat_label.AutoSize = true;
            this.cat_label.Location = new System.Drawing.Point(246, 378);
            this.cat_label.Name = "cat_label";
            this.cat_label.Size = new System.Drawing.Size(35, 13);
            this.cat_label.TabIndex = 12;
            this.cat_label.Text = "label5";
            // 
            // assign_label
            // 
            this.assign_label.AutoSize = true;
            this.assign_label.Location = new System.Drawing.Point(246, 406);
            this.assign_label.Name = "assign_label";
            this.assign_label.Size = new System.Drawing.Size(35, 13);
            this.assign_label.TabIndex = 13;
            this.assign_label.Text = "label6";
            this.assign_label.Click += new System.EventHandler(this.assign_label_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(360, 317);
            this.btn_del.Name = "btn_del";
            this.btn_del.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_del.Size = new System.Drawing.Size(75, 40);
            this.btn_del.TabIndex = 14;
            this.btn_del.Text = "Удалить";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // Object
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 430);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.assign_label);
            this.Controls.Add(this.cat_label);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.assign_CB);
            this.Controls.Add(this.cat_CB);
            this.Controls.Add(this.descr);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.objectDataGridView);
            this.MaximumSize = new System.Drawing.Size(577, 469);
            this.MinimumSize = new System.Drawing.Size(577, 469);
            this.Name = "Object";
            this.Text = "Object";
            this.Load += new System.EventHandler(this.Object_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialbaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private materialbaseDataSet materialbaseDataSet;
        private System.Windows.Forms.BindingSource objectBindingSource;
        private materialbaseDataSetTableAdapters.ObjectTableAdapter objectTableAdapter;
        private materialbaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView objectDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox descr;
        private System.Windows.Forms.ComboBox cat_CB;
        private System.Windows.Forms.ComboBox assign_CB;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private materialbaseDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource assignmentBindingSource;
        private materialbaseDataSetTableAdapters.AssignmentTableAdapter assignmentTableAdapter;
        private System.Windows.Forms.Label cat_label;
        private System.Windows.Forms.Label assign_label;
        private System.Windows.Forms.Button btn_del;
    }
}