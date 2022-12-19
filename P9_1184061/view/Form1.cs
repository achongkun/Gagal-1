using P9_1184061.controller;

namespace P9_1184061
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();
        
        public void Tampil()
        {
            //Query DB
            DataMahasiswa.DataSource = koneksi.ShowData("ISI QUERY UNTUK MENAMPILKAN DATA DISNI");
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Memanggil Method
            Tampil();
        }
    }
}