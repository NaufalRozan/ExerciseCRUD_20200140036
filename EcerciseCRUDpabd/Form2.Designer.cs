
namespace EcerciseCRUDpabd
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Add1 = new System.Windows.Forms.Button();
            this.save1 = new System.Windows.Forms.Button();
            this.delete1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exerciseCRUDpabdDataSet = new EcerciseCRUDpabd.ExerciseCRUDpabdDataSet();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.delete2 = new System.Windows.Forms.Button();
            this.save2 = new System.Windows.Forms.Button();
            this.add2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.mataKuliahBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.delete3 = new System.Windows.Forms.Button();
            this.save3 = new System.Windows.Forms.Button();
            this.add3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.nilaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.mahasiswaTableAdapter = new EcerciseCRUDpabd.ExerciseCRUDpabdDataSetTableAdapters.MahasiswaTableAdapter();
            this.mahasiswaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mataKuliahTableAdapter = new EcerciseCRUDpabd.ExerciseCRUDpabdDataSetTableAdapters.MataKuliahTableAdapter();
            this.nilaiTableAdapter = new EcerciseCRUDpabd.ExerciseCRUDpabdDataSetTableAdapters.NilaiTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomorIndukMahasiswaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaMahasiswaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noHpMhsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kodeMKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaMKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sKSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDNilaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomorIndukMahasiswaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeMKDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nilaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update1 = new System.Windows.Forms.Button();
            this.update2 = new System.Windows.Forms.Button();
            this.update3 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseCRUDpabdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataKuliahBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nilaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // Add1
            // 
            this.Add1.Location = new System.Drawing.Point(35, 25);
            this.Add1.Name = "Add1";
            this.Add1.Size = new System.Drawing.Size(75, 23);
            this.Add1.TabIndex = 0;
            this.Add1.Text = "Add";
            this.Add1.UseVisualStyleBackColor = true;
            this.Add1.Click += new System.EventHandler(this.Add1_Click);
            // 
            // save1
            // 
            this.save1.Location = new System.Drawing.Point(127, 25);
            this.save1.Name = "save1";
            this.save1.Size = new System.Drawing.Size(75, 23);
            this.save1.TabIndex = 1;
            this.save1.Text = "Save";
            this.save1.UseVisualStyleBackColor = true;
            this.save1.Click += new System.EventHandler(this.save1_Click);
            // 
            // delete1
            // 
            this.delete1.Location = new System.Drawing.Point(221, 25);
            this.delete1.Name = "delete1";
            this.delete1.Size = new System.Drawing.Size(75, 23);
            this.delete1.TabIndex = 2;
            this.delete1.Text = "Delete";
            this.delete1.UseVisualStyleBackColor = true;
            this.delete1.Click += new System.EventHandler(this.delete1_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "NomorIndukMahasiswa", true));
            this.textBox1.Location = new System.Drawing.Point(35, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.exerciseCRUDpabdDataSet;
            // 
            // exerciseCRUDpabdDataSet
            // 
            this.exerciseCRUDpabdDataSet.DataSetName = "ExerciseCRUDpabdDataSet";
            this.exerciseCRUDpabdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "NoHpMhs", true));
            this.textBox2.Location = new System.Drawing.Point(345, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "NamaMahasiswa", true));
            this.textBox3.Location = new System.Drawing.Point(191, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nomor Induk Mahasiswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nama Mahasiswa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telepon Mahasiswa";
            // 
            // delete2
            // 
            this.delete2.Location = new System.Drawing.Point(221, 177);
            this.delete2.Name = "delete2";
            this.delete2.Size = new System.Drawing.Size(75, 23);
            this.delete2.TabIndex = 12;
            this.delete2.Text = "Delete";
            this.delete2.UseVisualStyleBackColor = true;
            this.delete2.Click += new System.EventHandler(this.delete2_Click);
            // 
            // save2
            // 
            this.save2.Location = new System.Drawing.Point(127, 177);
            this.save2.Name = "save2";
            this.save2.Size = new System.Drawing.Size(75, 23);
            this.save2.TabIndex = 11;
            this.save2.Text = "Save";
            this.save2.UseVisualStyleBackColor = true;
            this.save2.Click += new System.EventHandler(this.save2_Click);
            // 
            // add2
            // 
            this.add2.Location = new System.Drawing.Point(35, 177);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(75, 23);
            this.add2.TabIndex = 10;
            this.add2.Text = "Add";
            this.add2.UseVisualStyleBackColor = true;
            this.add2.Click += new System.EventHandler(this.add2_Click);
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mataKuliahBindingSource, "KodeMK", true));
            this.textBox4.Location = new System.Drawing.Point(35, 244);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 13;
            // 
            // mataKuliahBindingSource
            // 
            this.mataKuliahBindingSource.DataMember = "MataKuliah";
            this.mataKuliahBindingSource.DataSource = this.exerciseCRUDpabdDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Kode Mata Kuliah";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mataKuliahBindingSource, "NamaMK", true));
            this.textBox5.Location = new System.Drawing.Point(191, 244);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nama Mata Kuliah";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mataKuliahBindingSource, "Semester", true));
            this.textBox6.Location = new System.Drawing.Point(345, 244);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Semester";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(518, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "SKS";
            // 
            // delete3
            // 
            this.delete3.Location = new System.Drawing.Point(221, 344);
            this.delete3.Name = "delete3";
            this.delete3.Size = new System.Drawing.Size(75, 23);
            this.delete3.TabIndex = 23;
            this.delete3.Text = "Delete";
            this.delete3.UseVisualStyleBackColor = true;
            this.delete3.Click += new System.EventHandler(this.delete3_Click);
            // 
            // save3
            // 
            this.save3.Location = new System.Drawing.Point(127, 344);
            this.save3.Name = "save3";
            this.save3.Size = new System.Drawing.Size(75, 23);
            this.save3.TabIndex = 22;
            this.save3.Text = "Save";
            this.save3.UseVisualStyleBackColor = true;
            this.save3.Click += new System.EventHandler(this.save3_Click);
            // 
            // add3
            // 
            this.add3.Location = new System.Drawing.Point(35, 344);
            this.add3.Name = "add3";
            this.add3.Size = new System.Drawing.Size(75, 23);
            this.add3.TabIndex = 21;
            this.add3.Text = "Add";
            this.add3.UseVisualStyleBackColor = true;
            this.add3.Click += new System.EventHandler(this.add3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(518, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Nilai";
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nilaiBindingSource, "Nilai", true));
            this.textBox8.Location = new System.Drawing.Point(486, 406);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 30;
            // 
            // nilaiBindingSource
            // 
            this.nilaiBindingSource.DataMember = "Nilai";
            this.nilaiBindingSource.DataSource = this.exerciseCRUDpabdDataSet;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(335, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Kode Mata Kuliah";
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nilaiBindingSource, "KodeMK", true));
            this.textBox9.Location = new System.Drawing.Point(345, 406);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(163, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Nomor Induk Mahasiswa";
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nilaiBindingSource, "NomorIndukMahasiswa", true));
            this.textBox10.Location = new System.Drawing.Point(191, 406);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 22);
            this.textBox10.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(60, 386);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Id Nilai";
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nilaiBindingSource, "IDNilai", true));
            this.textBox11.Location = new System.Drawing.Point(35, 406);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 22);
            this.textBox11.TabIndex = 24;
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // mahasiswaBindingSource1
            // 
            this.mahasiswaBindingSource1.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource1.DataSource = this.exerciseCRUDpabdDataSet;
            // 
            // mataKuliahTableAdapter
            // 
            this.mataKuliahTableAdapter.ClearBeforeFill = true;
            // 
            // nilaiTableAdapter
            // 
            this.nilaiTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomorIndukMahasiswaDataGridViewTextBoxColumn,
            this.namaMahasiswaDataGridViewTextBoxColumn,
            this.noHpMhsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mahasiswaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(606, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(455, 150);
            this.dataGridView1.TabIndex = 32;
            // 
            // nomorIndukMahasiswaDataGridViewTextBoxColumn
            // 
            this.nomorIndukMahasiswaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nomorIndukMahasiswaDataGridViewTextBoxColumn.DataPropertyName = "NomorIndukMahasiswa";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nomorIndukMahasiswaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.nomorIndukMahasiswaDataGridViewTextBoxColumn.HeaderText = "Nomor Induk Mahasiswa";
            this.nomorIndukMahasiswaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomorIndukMahasiswaDataGridViewTextBoxColumn.Name = "nomorIndukMahasiswaDataGridViewTextBoxColumn";
            this.nomorIndukMahasiswaDataGridViewTextBoxColumn.Width = 173;
            // 
            // namaMahasiswaDataGridViewTextBoxColumn
            // 
            this.namaMahasiswaDataGridViewTextBoxColumn.DataPropertyName = "NamaMahasiswa";
            this.namaMahasiswaDataGridViewTextBoxColumn.HeaderText = "Nama Mahasiswa";
            this.namaMahasiswaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaMahasiswaDataGridViewTextBoxColumn.Name = "namaMahasiswaDataGridViewTextBoxColumn";
            this.namaMahasiswaDataGridViewTextBoxColumn.Width = 125;
            // 
            // noHpMhsDataGridViewTextBoxColumn
            // 
            this.noHpMhsDataGridViewTextBoxColumn.DataPropertyName = "NoHpMhs";
            this.noHpMhsDataGridViewTextBoxColumn.HeaderText = "Telepon Mahasiswa";
            this.noHpMhsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noHpMhsDataGridViewTextBoxColumn.Name = "noHpMhsDataGridViewTextBoxColumn";
            this.noHpMhsDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeMKDataGridViewTextBoxColumn,
            this.namaMKDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn,
            this.sKSDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.mataKuliahBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(606, 168);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(455, 150);
            this.dataGridView2.TabIndex = 33;
            // 
            // kodeMKDataGridViewTextBoxColumn
            // 
            this.kodeMKDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.kodeMKDataGridViewTextBoxColumn.DataPropertyName = "KodeMK";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.kodeMKDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.kodeMKDataGridViewTextBoxColumn.HeaderText = "Kode Mata Kuliah";
            this.kodeMKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodeMKDataGridViewTextBoxColumn.Name = "kodeMKDataGridViewTextBoxColumn";
            this.kodeMKDataGridViewTextBoxColumn.Width = 136;
            // 
            // namaMKDataGridViewTextBoxColumn
            // 
            this.namaMKDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.namaMKDataGridViewTextBoxColumn.DataPropertyName = "NamaMK";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.namaMKDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.namaMKDataGridViewTextBoxColumn.HeaderText = "Nama Mata Kuliah";
            this.namaMKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaMKDataGridViewTextBoxColumn.Name = "namaMKDataGridViewTextBoxColumn";
            this.namaMKDataGridViewTextBoxColumn.Width = 139;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.semesterDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Semester";
            this.semesterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            this.semesterDataGridViewTextBoxColumn.Width = 97;
            // 
            // sKSDataGridViewTextBoxColumn
            // 
            this.sKSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sKSDataGridViewTextBoxColumn.DataPropertyName = "SKS";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sKSDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.sKSDataGridViewTextBoxColumn.HeaderText = "SKS";
            this.sKSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sKSDataGridViewTextBoxColumn.Name = "sKSDataGridViewTextBoxColumn";
            this.sKSDataGridViewTextBoxColumn.Width = 64;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDNilaiDataGridViewTextBoxColumn,
            this.nomorIndukMahasiswaDataGridViewTextBoxColumn1,
            this.kodeMKDataGridViewTextBoxColumn1,
            this.nilaiDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.nilaiBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(606, 326);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(455, 150);
            this.dataGridView3.TabIndex = 34;
            // 
            // iDNilaiDataGridViewTextBoxColumn
            // 
            this.iDNilaiDataGridViewTextBoxColumn.DataPropertyName = "IDNilai";
            this.iDNilaiDataGridViewTextBoxColumn.HeaderText = "IDNilai";
            this.iDNilaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDNilaiDataGridViewTextBoxColumn.Name = "iDNilaiDataGridViewTextBoxColumn";
            this.iDNilaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomorIndukMahasiswaDataGridViewTextBoxColumn1
            // 
            this.nomorIndukMahasiswaDataGridViewTextBoxColumn1.DataPropertyName = "NomorIndukMahasiswa";
            this.nomorIndukMahasiswaDataGridViewTextBoxColumn1.HeaderText = "NomorIndukMahasiswa";
            this.nomorIndukMahasiswaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nomorIndukMahasiswaDataGridViewTextBoxColumn1.Name = "nomorIndukMahasiswaDataGridViewTextBoxColumn1";
            this.nomorIndukMahasiswaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // kodeMKDataGridViewTextBoxColumn1
            // 
            this.kodeMKDataGridViewTextBoxColumn1.DataPropertyName = "KodeMK";
            this.kodeMKDataGridViewTextBoxColumn1.HeaderText = "KodeMK";
            this.kodeMKDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.kodeMKDataGridViewTextBoxColumn1.Name = "kodeMKDataGridViewTextBoxColumn1";
            this.kodeMKDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nilaiDataGridViewTextBoxColumn
            // 
            this.nilaiDataGridViewTextBoxColumn.DataPropertyName = "Nilai";
            this.nilaiDataGridViewTextBoxColumn.HeaderText = "Nilai";
            this.nilaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nilaiDataGridViewTextBoxColumn.Name = "nilaiDataGridViewTextBoxColumn";
            this.nilaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // update1
            // 
            this.update1.Location = new System.Drawing.Point(318, 25);
            this.update1.Name = "update1";
            this.update1.Size = new System.Drawing.Size(75, 23);
            this.update1.TabIndex = 35;
            this.update1.Text = "Update";
            this.update1.UseVisualStyleBackColor = true;
            this.update1.Click += new System.EventHandler(this.update1_Click);
            // 
            // update2
            // 
            this.update2.Location = new System.Drawing.Point(318, 177);
            this.update2.Name = "update2";
            this.update2.Size = new System.Drawing.Size(75, 23);
            this.update2.TabIndex = 36;
            this.update2.Text = "Update";
            this.update2.UseVisualStyleBackColor = true;
            // 
            // update3
            // 
            this.update3.Location = new System.Drawing.Point(318, 344);
            this.update3.Name = "update3";
            this.update3.Size = new System.Drawing.Size(75, 23);
            this.update3.TabIndex = 37;
            this.update3.Text = "Update";
            this.update3.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mataKuliahBindingSource, "SKS", true));
            this.textBox7.Location = new System.Drawing.Point(486, 244);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 38;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1073, 488);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.update3);
            this.Controls.Add(this.update2);
            this.Controls.Add(this.update1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.delete3);
            this.Controls.Add(this.save3);
            this.Controls.Add(this.add3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.delete2);
            this.Controls.Add(this.save2);
            this.Controls.Add(this.add2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.delete1);
            this.Controls.Add(this.save1);
            this.Controls.Add(this.Add1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseCRUDpabdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataKuliahBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nilaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add1;
        private System.Windows.Forms.Button save1;
        private System.Windows.Forms.Button delete1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button delete2;
        private System.Windows.Forms.Button save2;
        private System.Windows.Forms.Button add2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button delete3;
        private System.Windows.Forms.Button save3;
        private System.Windows.Forms.Button add3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox11;
        private ExerciseCRUDpabdDataSet exerciseCRUDpabdDataSet;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private ExerciseCRUDpabdDataSetTableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource1;
        private System.Windows.Forms.BindingSource mataKuliahBindingSource;
        private ExerciseCRUDpabdDataSetTableAdapters.MataKuliahTableAdapter mataKuliahTableAdapter;
        private System.Windows.Forms.BindingSource nilaiBindingSource;
        private ExerciseCRUDpabdDataSetTableAdapters.NilaiTableAdapter nilaiTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorIndukMahasiswaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaMahasiswaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noHpMhsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeMKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaMKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sKSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNilaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorIndukMahasiswaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeMKDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nilaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button update1;
        private System.Windows.Forms.Button update2;
        private System.Windows.Forms.Button update3;
        private System.Windows.Forms.TextBox textBox7;
    }
}