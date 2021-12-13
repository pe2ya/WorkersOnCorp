using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Firma firma = new Firma();
            /*
            firma.AddH((Position)2, "Palmer", "William", 10000, new DateTime(2008, 11, 14), false);
            firma.AddH(0, "Andrii", "Petii", 2500, new DateTime(2010, 11, 14), true);
            firma.AddH(0, "Mason", "Bryany", 1100, new DateTime(2010, 11, 14), false);
            firma.AddH(0, "Coleman", "Fredrica", 3500, new DateTime(2009, 10, 14), false);
            firma.AddH(0, "Elliott", "Tam", 2000, new DateTime(2014, 11, 14), true);
            firma.AddH(0, "Payne", "Fedora", 2700, new DateTime(2015, 11, 14), false);
            firma.AddH(0, "Burns", "Simone", 1800, new DateTime(2008, 11, 14), false);
            firma.AddH(0, "Martin", "Judith", 2500, new DateTime(2010, 11, 14), true);
            firma.AddH((Position)1, "Stevens", "Albert", 4500, new DateTime(2015, 11, 14), false);
            firma.AH((Position)1, "Olson", "Gary", 5000, new DateTime(2019, 11, 14), false);
            */

      
            firma.Generate(12);
           
            Console.WriteLine(firma);

            foreach (var x in firma.HeightestSalary())
            {
                Console.Write(x + "\n");
            }
            Console.Write("\n");

            Console.WriteLine(firma.AvarageSalary());
            Console.Write("\n");

            Console.WriteLine(firma.AvarageSalaryForPosition((Position)0));
            Console.Write("\n");

            foreach (var x in firma.LowestSalary())
            {
                Console.Write(x + "\n");
            }
            Console.Write("\n");

            foreach (var x in firma.TimeInWork())
            {
                Console.Write(x + "\n");
            }
            Console.Write("\n");

            foreach (var x in firma.OnVacation())
            {
                Console.Write(x + "\n");
            }


        }
    }

}
