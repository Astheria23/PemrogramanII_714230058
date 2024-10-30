using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230058
{
    public class AirConditioner : Bp
    {
        public AirConditioner(String brand,String name) : base(brand, name) { }

        public override void Start()
        {
            Console.WriteLine($"Menyalakan AC {Brand} {Model}.");
        }
        public override void Stop()
        {
            Console.WriteLine($"Mematikan AC {Brand} {Model}.");
        }
        public override void CheckStatus()
        {
            Console.WriteLine($"Checking {Brand} {Model} AC");
        }
    }
}
