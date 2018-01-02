using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication35
{
    class Program
    {
        static void Main(string[] args)
        {
        
          // Oklid(a,b)
//Özyinelemeli Öklid Algoritması kullanarak OBEB bulma algoritması

 PozıtıfTamSayi Oklid(PozıtıfTamSayi a,PozıtıfTamSayi b)
{
    if (a == 0)
        return b;
    if (b == 0)
        return a;

    if (a > b)
        return Oklid(a % b, b);
    else
        return Oklid(a, b % a);

}
       }
     }
   }
