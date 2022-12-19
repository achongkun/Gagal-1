using Org.BouncyCastle.Asn1.IsisMtt.X509;
using Org.BouncyCastle.Math.EC;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_1184061.model
{
    internal class M_mahasiswa
    {
        class M_mahasiswa
        {
            string npm, nama, angkatan, alamat, email, nohp;

            public string Npm { get => npm; set => npm = value; }
            public string Nama { get => nama; set => nama = value; }
            public string Angkatan { get => angkatan; set => angkatan = value; }
            public string Alamat { get => alamat; set => alamat = value; }
            public string Email { get => email; set => email = value; }
            public string Nohp { get => nohp; set => nohp = value; }
        }
        public M_mahasiswa() 
        {
            this.npm = npm;
            this.name = nama;
            this.angkatan = angkatan;
            this.alamat = alamat;
            this.email = email;
            this.nohp = nohp;
        }

    }
}
