using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230058
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================\n Home Control Application \n=========================");
            Console.WriteLine("Pilih Tipe Alat: 1)Kulkas  2)AC  3)Televisi");
            int tipeAlat = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan Brand: ");
            string brand = Console.ReadLine();

            Console.Write("Masukan Model: ");
            string model = Console.ReadLine();

            Bp bp;
            switch (tipeAlat)
            {
                case 1:
                    bp = new Kulkas(brand, model);
                    break;
                case 2:
                    bp = new AirConditioner(brand, model);
                    break;
                case 3:
                    bp = new Television(brand, model);
                    break;
                default:
                    Console.WriteLine("Masukan Alat yang bener");
                    return;
            }

            Console.WriteLine("==================================");
            bool x = true;
            while (x)
            {
                Console.WriteLine("\nPilih Aksi: 1)Start  2)Stop  3)CheckStatus 4)Keluar Aplikasi");
                int action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        bp.Start();
                        Console.WriteLine("\n=============================");
                        break;

                    case 2:
                        bp.Stop();
                        Console.WriteLine("\n=============================");
                        break;

                    case 3:
                        bp.CheckStatus();
                        Console.WriteLine("\n=============================");
                        break;
                    case 4:
                        x = false;
                        Console.WriteLine("Keluar Dari Aplikasi...");
                        break;
                    default:
                        Console.WriteLine("Masukan Input yang bener");
                        break;
                }
            }
        }
    }
}
