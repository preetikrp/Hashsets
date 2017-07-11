using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashsets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> showroom = new HashSet<string>()
            {
                "Mercedes-Benz", "Audi", "BMW", "Porsche"



            };

            Console.WriteLine(showroom.Count);
            Console.ReadLine();

            showroom.Add("Audi");
            foreach (string item in showroom)
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }



            HashSet<string> UsedLot = new HashSet<string>() {
                "Honda", "Lexus"

            };
            foreach (string item in UsedLot)
            {
                Console.WriteLine(item);
                Console.ReadLine();
                showroom.UnionWith(UsedLot);
                showroom.Remove("Honda");
                
                Console.WriteLine(showroom.Count);
                Console.ReadLine();
            }

            HashSet<string> Junkyard = new HashSet<string>()
            {
                "BMW", "Nissan Altima", "Toyota Camry"

            };

            Console.WriteLine(Junkyard.Count);
            Console.ReadLine();
            Junkyard.IntersectWith(Junkyard);
            foreach (string item in showroom)
            {
                Console.WriteLine(item);
                Console.ReadLine();
                Junkyard.Remove("BMW");



            }

            foreach (string item in showroom)
            {

                Console.WriteLine(item);
                Console.ReadLine();

            }
        }

    }
}
            

            





    
    

