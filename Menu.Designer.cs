namespace MaterialBase
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.categories = new System.Windows.Forms.Button();
            this.assignments = new System.Windows.Forms.Button();
            this.headers = new System.Windows.Forms.Button();
            this.objects = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать!";
            // 
            // categories
            // 
            this.categories.Location = new System.Drawing.Point(265, 72);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(83, 23);
            this.categories.TabIndex = 4;
            this.categories.Text = "Категории";
            this.categories.UseVisualStyleBackColor = true;
            this.categories.Click += new System.EventHandler(this.categories_Click);
            // 
            // assignments
            // 
            this.assignments.Location = new System.Drawing.Point(265, 101);
            this.assignments.Name = "assignments";
            this.assignments.Size = new System.Drawing.Size(83, 23);
            this.assignments.TabIndex = 5;
            this.assignments.Text = "Назначения";
            this.assignments.UseVisualStyleBackColor = true;
            this.assignments.Click += new System.EventHandler(this.assignments_Click);
            // 
            // headers
            // 
            this.headers.Location = new System.Drawing.Point(265, 133);
            this.headers.Name = "headers";
            this.headers.Size = new System.Drawing.Size(83, 23);
            this.headers.TabIndex = 6;
            this.headers.Text = "Заведующие";
            this.headers.UseVisualStyleBackColor = true;
            this.headers.Click += new System.EventHandler(this.headers_Click);
            // 
            // objects
            // 
            this.objects.Location = new System.Drawing.Point(265, 43);
            this.objects.Name = "objects";
            this.objects.Size = new System.Drawing.Size(83, 23);
            this.objects.TabIndex = 7;
            this.objects.Text = "Объекты";
            this.objects.UseVisualStyleBackColor = true;
            this.objects.Click += new System.EventHandler(this.objects_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(265, 187);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(83, 23);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(13, 43);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(35, 13);
            this.name_label.TabIndex = 9;
            this.name_label.Text = "label2";
            this.name_label.Click += new System.EventHandler(this.name_label_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 224);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.objects);
            this.Controls.Add(this.headers);
            this.Controls.Add(this.assignments);
            this.Controls.Add(this.categories);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(376, 263);
            this.MinimumSize = new System.Drawing.Size(376, 263);
            this.Name = "Menu";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button categories;
        private System.Windows.Forms.Button assignments;
        private System.Windows.Forms.Button headers;
        private System.Windows.Forms.Button objects;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label name_label;
    }
}