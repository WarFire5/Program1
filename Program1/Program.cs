using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string clientFirstName;

            Console.WriteLine("Как Вас зовут?");
            clientFirstName = Console.ReadLine();

            string clientAppeal = "Привет," + " " + "*" + clientFirstName + "*" + "!!!";
            Console.WriteLine(clientAppeal);

            Console.ReadLine();
        }
    }
}
