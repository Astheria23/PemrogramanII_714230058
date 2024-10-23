using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714230058
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                Console.Write("MENENTUKAN INDEKS PRESTASI MAHASISWA \n--------------------------------------------");
                Console.Write("\nMasukan Nama Mahasiswa: ");
                String nama = Console.ReadLine();

                Console.Write("Masukan Nilai : ");
                int nilai = Convert.ToInt16(Console.ReadLine());

                String[] grade = { "A", "B", "C", "D" };

                if (nilai >= 85)
                {
                    Console.WriteLine("Indeks Nilai {0} Adalah {1}", nama, grade[0]);
                }
                else if (nilai >= 70 && nilai < 85)
                {
                    Console.WriteLine("Indeks Nilai {0} Adalah {1}", nama, grade[1]);
                }
                else if (nilai > 60 && nilai < 70)
                {
                    Console.WriteLine("Indeks Nilai {0} Adalah {1}", nama, grade[2]);
                }
                else
                {
                    Console.WriteLine("Indeks Nilai {0} Adalah {1}", nama, grade[3]);
                }
                Console.Write("\nMasukan indeks yang akan ditampilkan : ");
                char indeks = Convert.ToChar(Console.ReadLine());
                Console.Write("Indeks Prestasi {0} adalah", nama);

                prestasi(indeks);
                Console.Write("\nIngin mengulang kembali? (Y/T)");

            }
            while (Console.ReadLine() == "Y");
        }
        
        private static void prestasi (char indeks)
        {
            switch (indeks)
            {
                case 'A':
                    Console.WriteLine("Sangat Baik");
                    break;
                case 'B':
                    Console.WriteLine("Baik");
                    break;
                case 'C':
                    Console.WriteLine("Cukup");
                    break;
                case 'D':
                    Console.WriteLine("Buruk");
                    break;
                default:
                    Console.WriteLine("Invalid Indeks Prestrasi");
                    break;
            }
        }
    }
}
