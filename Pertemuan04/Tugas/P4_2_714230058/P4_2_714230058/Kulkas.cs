using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230058
{
    public class Kulkas : Bp
    {
        //Constuructor Dari Bp
        public Kulkas (string brand, string model) :base (brand, model)
        { }
        public override void Start()
        {
            Console.WriteLine($"Menjalankan Kulkas {Brand} {Model}. Sistem Pendingin Aktif");
        }
        public override void Stop()
        {
            Console.WriteLine($"Mematikan Kulkas {Brand} {Model}. Sistem Pendingin Mati");
        }
        public override void CheckStatus()
        {
            Console.WriteLine($"Cek {Brand} {Model}. Status kulkas : Temperatur Stabil, Power Normal.");
        }
    }
}
