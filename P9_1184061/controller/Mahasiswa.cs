using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace P9_1184061.controller
{
    internal class Mahasiswa
    {
        class Mahasiswa
        {
            //Memanggil class koneksi dan sebuah objek baru
            Koneksi koneksi = new Koneksi();

            //Method Insert
            public bool Insert(M_mahasiswa mahasiswa) 
            {
                Boolean status = false;
                try
                {
                    koneksi.OpenConnection();
                    koneksi.ExecuteQuery("INSERT INTO t_mahasiswa
                    (npm, nama, angkatan, alamat, email, nohp) VALUES('" + mahasiswa.Npm + "', '" +
                    mahasiswa.Nama + "','" + mahasiswa.Angkatan + "','" + mahasiswa.Alamat +
                    "','" + mahasiswa.Email + "','" + mahasiswa.Nohp + "')");
                    status = true;
                    MessageBox.Show("Data berhasil ditambahkan", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    koneksi.CloseConnection();

                }
                catch
                {
                    MessageBox.Show(e.Message,"Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return status;
            }
        }
    }
}
