using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Online
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NPM: " + textBox1.Text +
                "\nNama Mahasiswa: " + textBox5.Text +
                "\nJurusan Mahasiswa: " + textBox4.Text +
                "\nPenjelasan Jurusan: " + textBox3.Text +
                "\nDosen Wali: " + textBox2.Text,
                "Data Mahasiswa",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox5.Text = "";
            this.textBox4.Text = "";
            this.textBox3.Text = "";
            this.textBox2.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
