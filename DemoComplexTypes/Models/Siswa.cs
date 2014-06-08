using System;
using System.Collections.Generic;

namespace DemoComplexTypes.Models
{
    public partial class Siswa
    {
        public Siswa()
        {
            Alamat = new Alamat();
        }

        public string Nis { get; set; }
        public string Nama { get; set; }
        public Alamat Alamat { get; set; }
    }
}
