using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayac = 1;
            //while (sayac <= 5)
            //{
            //    Console.WriteLine("Hello life");
            //    sayac++;
            //}
            //***********************************************


            // 1 - 20 arasi sayilari listeleyen while dongusu

            //int sayi = 1;
            //while (sayi <= 20)
            //{
            //    Console.WriteLine(sayi);
            //    sayi++;
            //}
            //***********************************************


            // 1 - 10 arasi sayilarin toplamini hesaplayan while dongusu

            int sayi = 1;
            int toplam = 0;
            while (sayi <= 10)
            {
                toplam += sayi;
                sayi++;
                Console.WriteLine(toplam);
            }
            Console.WriteLine();
            Console.WriteLine("Toplam : " + toplam);
            //************************************************




            Console.Read();
        }
    }
}
