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
                int panjang;
                int lebar;
                Console.Write("=== MENU PERSEGI PANJANG === \n");
                Console.Write("1.Hitung Luas \n2.Hitung Keliling \n3.Keluar \n Pilih Menu (1-3) : ");
                int command = Convert.ToInt32(Console.ReadLine());
                if (command == 1)
                {
                    Console.Write("Panjang Persegi : ");
                    panjang = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Lebar Persegi : ");
                    lebar = Convert.ToInt32(Console.ReadLine());
                    luasPersegi(panjang,lebar);
                }
                else if (command == 2){
                    Console.Write("Panjang Persegi : ");
                    panjang = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Lebar Persegi : ");
                    lebar = Convert.ToInt32(Console.ReadLine());
                    kelilingPersegi(panjang, lebar);
                }
                else if (command == 3){
                    return;
                }
                else {
                    Console.Write("Menu Tidak Tersedia, Silahkan pilih menu yang tersedia\n");
                }
                Console.Write("Ingin Mengulang Kembali (Y/T)? ");
            }
             while (Console.ReadLine() == "Y");
        }
         static int luasPersegi(int a,int b)
        {
            int jumlahLuas = (a * b);
            Console.WriteLine("Luas Persegi Panjang : " + jumlahLuas);
            return jumlahLuas;
        }
         static int kelilingPersegi(int a, int b)
        {
            int jumlahKeliling = (2 * (a + b));
            Console.WriteLine("Keliling Persegi Panjang : " + jumlahKeliling);
            return jumlahKeliling;
        }
    }
}
    
