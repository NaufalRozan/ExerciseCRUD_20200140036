using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcerciseCRUDpabd
{
    public partial class Form2 : Form
    {
        DataTable dt, dd, df ;
        DataRow dr, de, dv;
        string code;
        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exerciseCRUDpabdDataSet.Nilai' table. You can move, or remove it, as needed.
            this.nilaiTableAdapter.Fill(this.exerciseCRUDpabdDataSet.Nilai);
            // TODO: This line of code loads data into the 'exerciseCRUDpabdDataSet.MataKuliah' table. You can move, or remove it, as needed.
            this.mataKuliahTableAdapter.Fill(this.exerciseCRUDpabdDataSet.MataKuliah);
            // TODO: This line of code loads data into the 'exerciseCRUDpabdDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.exerciseCRUDpabdDataSet.Mahasiswa);

        }

        private void Add1_Click(object sender, EventArgs e)
        {
            save1.Enabled = true;
            textBox1.Enabled = true;
            textBox3.Enabled = true;
            textBox2.Enabled = true;
            textBox1.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";

            int ctr, len;
            string codeval;
            dt = exerciseCRUDpabdDataSet.Tables["Mahasiswa"];
            len = dt.Rows.Count - 1;
            dr = dt.Rows[len];
            code = dr["NamaMahasiswa"].ToString();
            codeval = code.Substring(1, 3);
            Add1.Enabled = false;
        }

        private void save1_Click(object sender, EventArgs e)
        {
            dt = exerciseCRUDpabdDataSet.Tables["Mahasiswa"];
            dr = dt.NewRow();
            dr[0] = textBox1.Text;
            dr[1] = textBox3.Text;
            dr[2] = textBox2.Text;
            dt.Rows.Add(dr);
            mahasiswaTableAdapter.Update(exerciseCRUDpabdDataSet);
            textBox1.Text = System.Convert.ToString(dr[0]);
            textBox1.Enabled = false;
            textBox3.Enabled = false;
            textBox2.Enabled = false;
            this.mahasiswaTableAdapter.Fill(this.exerciseCRUDpabdDataSet.Mahasiswa);
            Add1.Enabled = true;
            save1.Enabled = false;
        }

        private void delete1_Click(object sender, EventArgs e)
        {
            string code;
            code = textBox1.Text;
            dr = exerciseCRUDpabdDataSet.Tables["Mahasiswa"].Rows.Find(code);
            dr.Delete();
            mahasiswaTableAdapter.Update(exerciseCRUDpabdDataSet);
        }

        private void add2_Click(object sender, EventArgs e)
        {
            save2.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

            int ctr, len;
            string codeval;
            dd = exerciseCRUDpabdDataSet.Tables["MataKuliah"];
            len = dd.Rows.Count - 1;
            de = dd.Rows[len];
            code = de["NamaMK"].ToString();
            codeval = code.Substring(1, 3);
            add2.Enabled = false;
        }

        private void add3_Click(object sender, EventArgs e)
        {
            save3.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";

            int ctr, len;
            string codeval;
            df = exerciseCRUDpabdDataSet.Tables["Nilai"];
            len = df.Rows.Count - 1;
            dv = df.Rows[len];
            code = dv["KodeMK"].ToString();
            codeval = code.Substring(1, 3);
            add3.Enabled = false;
        }

        private void update1_Click(object sender, EventArgs e)
        {

        }

        private void save2_Click(object sender, EventArgs e)
        {
            dd = exerciseCRUDpabdDataSet.Tables["MataKuliah"];
            de = dd.NewRow();
            de[0] = textBox4.Text;
            de[1] = textBox5.Text;
            de[2] = textBox6.Text;
            de[3] = textBox7.Text;
            dd.Rows.Add(dr);
            mataKuliahTableAdapter.Update(exerciseCRUDpabdDataSet);
            textBox4.Text = System.Convert.ToString(de[0]);
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            this.mataKuliahTableAdapter.Fill(this.exerciseCRUDpabdDataSet.MataKuliah);
            add2.Enabled = true;
            save2.Enabled = false;
        }

        private void delete2_Click(object sender, EventArgs e)
        {
            string code;
            code = textBox4.Text;
            de = exerciseCRUDpabdDataSet.Tables["MataKuliah"].Rows.Find(code);
            de.Delete();
            mataKuliahTableAdapter.Update(exerciseCRUDpabdDataSet);
        }

        private void save3_Click(object sender, EventArgs e)
        {
            df = exerciseCRUDpabdDataSet.Tables["Nilai"];
            dv = df.NewRow();
            dv[0] = textBox8.Text;
            dv[1] = textBox9.Text;
            dv[2] = textBox10.Text;
            dv[3] = textBox11.Text;
            df.Rows.Add(dv);
            nilaiTableAdapter.Update(exerciseCRUDpabdDataSet);
            textBox8.Text = System.Convert.ToString(dv[0]);
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            this.nilaiTableAdapter.Fill(this.exerciseCRUDpabdDataSet.Nilai);
            add3.Enabled = true;
            save3.Enabled = false;
        }

        private void delete3_Click(object sender, EventArgs e)
        {

            string code;
            code = textBox8.Text;
            dv = exerciseCRUDpabdDataSet.Tables["Nilai"].Rows.Find(code);
            dv.Delete();
            nilaiTableAdapter.Update(exerciseCRUDpabdDataSet);
        }
    }
}
