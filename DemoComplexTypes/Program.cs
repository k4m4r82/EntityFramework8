using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DemoComplexTypes.Models;

namespace DemoComplexTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DemoComplexTypesContext())
            {
                var daftarSiswa = db.Siswas
                                    .OrderBy(f => f.Nama)
                                    .ToList();

                var noUrut = 1;
                foreach (var siswa in daftarSiswa)
                {
                    var alamat = siswa.Alamat; // property Alamat bertipe 'complex types'

                    Console.WriteLine("{0}. {1}, {2}, {3}, {4}", noUrut, siswa.Nis, siswa.Nama, alamat.Jalan, alamat.Kota);

                    noUrut++;
                }
            }

            Console.WriteLine("\n\nPress any key to exit ...");
            Console.ReadKey();
        }
    }
}
