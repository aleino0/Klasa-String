using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string recenica = "Danas radimo s klasom string.";

            //ispis broja znakova u stringu
            Console.WriteLine("Broj znakova u recenici: {0}",
                recenica.Length);

            //ispi malip i velikim slovima
            Console.WriteLine("\n-Upper & Lower-");
            Console.WriteLine("Ispis velikim slovima: {0}, " +
                "\nIspis malim slovima: {1}",
                recenica.ToUpper(), recenica.ToLower());

            //Substring metoda
            Console.WriteLine("\n-Substring-");
            Console.WriteLine(recenica.Substring(0,5));
            Console.WriteLine(recenica.Substring(recenica.Length - 5, 5));

            //zamjena znakova u stringu
            Console.WriteLine("\n-Zamjena zankova-");
            Console.WriteLine(recenica.Replace("Danas", "Sutra"));

            //razdvajanje stringa
            Console.WriteLine("\n-Razdvajanje-");
            string[] rijec = recenica.Split(' ');

            for(int i=0;i<rijec.Length;i++)
            {
                Console.WriteLine(rijec[i]);
            }

            //umetanje znakova u string

            Console.WriteLine("\n-Umetanje-");
            Console.WriteLine(recenica.Insert(recenica.IndexOf("radimo"), "intenzivno "));

            Console.ReadKey();
        }
    }
}
