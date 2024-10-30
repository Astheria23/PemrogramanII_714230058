using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230058
{
    public class Television : Bp
    {
        public Television(string brand, string name) : base(brand, name)
        { }

        public override void Start()
        {
            Console.WriteLine($"Menyalakan TV {Brand} {Model}, Power On");
        }
        public override void Stop() 
        {
            Console.WriteLine($"Mematikan TV {Brand} {Model}, Power Off");
        }

        public override void CheckStatus()
        {
            Console.WriteLine($"Cek status TV {Brand} {Model}, TV Berjalan Normal");
        }

    }
}
