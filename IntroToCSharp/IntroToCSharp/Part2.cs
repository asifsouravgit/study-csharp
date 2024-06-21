using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    class Part2
    {
        static void MainOfPart2()
        {
            Console.WriteLine("Please enter your name below.");
            string userName = Console.ReadLine();

            Console.WriteLine("Hello " + userName); //Using Concatenation
            Console.WriteLine("Hello {0}", userName); //Using Placeholder
            
            Console.ReadLine(); //For Pause

            Console.WriteLine("Please enter your first name below.");
            string firstName = Console.ReadLine();
            
            Console.WriteLine("Please enter your last name below.");
            string lastName = Console.ReadLine();
            
            Console.WriteLine("Hello {0} {1}", firstName, lastName);
            Console.ReadLine(); //For Pause
        }
    }
}
