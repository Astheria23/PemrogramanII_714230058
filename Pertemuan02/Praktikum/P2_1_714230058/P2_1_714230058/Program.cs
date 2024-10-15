using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_714230058
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan Angka Pertama :");
          double angkaPertama = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan Angka Kedua :");
          angkaPertama = (angkaPertama);
          int angkaKedua =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ========= HASIL ========== ");
            Console.WriteLine("Angka Pertama " + angkaPertama);
            Console.WriteLine("Angka Kedua " + angkaKedua);
            Console.WriteLine($" {angkaPertama} +  {angkaKedua} = {angkaPertama + angkaKedua}" );
            Console.WriteLine($" {angkaPertama} -  {angkaKedua} = {angkaPertama - angkaKedua}");
            Console.WriteLine($" {angkaPertama} *  {angkaKedua} = {angkaPertama * angkaKedua}");
            Console.WriteLine($" {angkaPertama} /  {angkaKedua} = {angkaPertama / angkaKedua}");
            Console.ReadLine();






        }
    }
}
