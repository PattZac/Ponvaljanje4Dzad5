using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponvaljanje4Dzad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi URL adresu: ");
            string link=Console.ReadLine();
            if (link.Substring(0,4)=="www."&&link.Substring(link.Length-3,3)==".hr")
            {
                Console.WriteLine("URL adresu je pravilan.");
            }
            else
            {
                Console.WriteLine("URL adresu nije pravilan.");
            }
            Console.ReadLine();
        }
    }
}
