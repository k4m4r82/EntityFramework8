using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoComplexTypes.Models
{
    public class Alamat
    {              
        [Column("Jalan")]
        public string Jalan { get; set; }

        [Column("Kota")]
        public string Kota { get; set; }

        [Column("Provinsi")]
        public string Provinsi { get; set; }

        [Column("KodePos")]
        public string KodePos { get; set; }
    }
}


