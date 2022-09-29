
namespace kursovaya
{
    partial class Admin
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицыИзмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.закупочнаяЦенаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db = new kursovaya.db();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.товарTableAdapter = new kursovaya.dbTableAdapters.ТоварTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(882, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(877, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "Найти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(33, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 43);
            this.button4.TabIndex = 4;
            this.button4.Text = "Выйти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTDataGridViewTextBoxColumn,
            this.категорияDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.единицыИзмеренияDataGridViewTextBoxColumn,
            this.закупочнаяЦенаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.товарBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(816, 475);
            this.dataGridView1.TabIndex = 6;
            // 
            // iDTDataGridViewTextBoxColumn
            // 
            this.iDTDataGridViewTextBoxColumn.DataPropertyName = "IDT";
            this.iDTDataGridViewTextBoxColumn.HeaderText = "IDT";
            this.iDTDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDTDataGridViewTextBoxColumn.Name = "iDTDataGridViewTextBoxColumn";
            this.iDTDataGridViewTextBoxColumn.Width = 50;
            // 
            // категорияDataGridViewTextBoxColumn
            // 
            this.категорияDataGridViewTextBoxColumn.DataPropertyName = "Категория";
            this.категорияDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.категорияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.категорияDataGridViewTextBoxColumn.Name = "категорияDataGridViewTextBoxColumn";
            this.категорияDataGridViewTextBoxColumn.Width = 150;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            this.наименованиеDataGridViewTextBoxColumn.Width = 200;
            // 
            // единицыИзмеренияDataGridViewTextBoxColumn
            // 
            this.единицыИзмеренияDataGridViewTextBoxColumn.DataPropertyName = "ЕдиницыИзмерения";
            this.единицыИзмеренияDataGridViewTextBoxColumn.HeaderText = "ЕдиницыИзмерения";
            this.единицыИзмеренияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.единицыИзмеренияDataGridViewTextBoxColumn.Name = "единицыИзмеренияDataGridViewTextBoxColumn";
            this.единицыИзмеренияDataGridViewTextBoxColumn.Width = 150;
            // 
            // закупочнаяЦенаDataGridViewTextBoxColumn
            // 
            this.закупочнаяЦенаDataGridViewTextBoxColumn.DataPropertyName = "Закупочная цена";
            this.закупочнаяЦенаDataGridViewTextBoxColumn.HeaderText = "Закупочная цена";
            this.закупочнаяЦенаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.закупочнаяЦенаDataGridViewTextBoxColumn.Name = "закупочнаяЦенаDataGridViewTextBoxColumn";
            this.закупочнаяЦенаDataGridViewTextBoxColumn.Width = 150;
            // 
            // товарBindingSource
            // 
            this.товарBindingSource.DataMember = "Товар";
            this.товарBindingSource.DataSource = this.db;
            // 
            // db
            // 
            this.db.DataSetName = "db";
            this.db.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(882, 404);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(187, 43);
            this.button6.TabIndex = 7;
            this.button6.Text = "Сохранить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(882, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "Добавить значения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(895, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 26);
            this.textBox2.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(895, 230);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(156, 26);
            this.textBox4.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(895, 133);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(156, 28);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(895, 198);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(156, 28);
            this.comboBox3.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.textBox1.Location = new System.Drawing.Point(551, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 26);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Поиск:";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 637);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Admin";
            this.Text = "Панель администратора";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox1;
        private db db;
        private System.Windows.Forms.BindingSource товарBindingSource;
        private dbTableAdapters.ТоварTableAdapter товарTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицыИзмеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn закупочнаяЦенаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}