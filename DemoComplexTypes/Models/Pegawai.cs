using System;
using System.Collections.Generic;

namespace DemoComplexTypes.Models
{
    public partial class Pegawai
    {
        public Pegawai()
        {
            Alamat = new Alamat();
        }

        public string Nik { get; set; }
        public string Nama { get; set; }
        public Alamat Alamat { get; set; }
    }
}
