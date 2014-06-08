using System;
using System.Collections.Generic;

namespace DemoComplexTypes.Models
{
    public partial class Guru
    {
        public Guru()
        {
            Alamat = new Alamat();
        }

        public string Nik { get; set; }
        public string Nama { get; set; }
        public Nullable<int> JumlahJamMengajar { get; set; }
        public Alamat Alamat { get; set; }
    }
}
