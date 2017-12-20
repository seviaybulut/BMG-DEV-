using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, kalan;
            string yazikalan = "";
            Console.WriteLine("99<iki sayı girin<999");
            Console.Write("sayıyı giriniz..:");
            sayi1 = int.Parse(Console.ReadLine());
            while (sayi1 != 0)
            {
                kalan = sayi1 % 2;
                sayi1 = sayi1 / 2;

                yazikalan =
                yazikalan = kalan.ToString() + yazikalan;
                //console.writeLine("2'lik Sistem:{0},kalan);
            }
            Console.WriteLine("2'lik Sistemdeki Karşılığı : {0}", yazikalan);
            Console.ReadKey();

        }
    }
}
