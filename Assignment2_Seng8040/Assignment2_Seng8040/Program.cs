using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Seng8040
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Go();
        }

        public static int ValidateOptions()
        {
            string menu = "";
            bool validMenu = false;
            while (validMenu == false)
            {
                Console.WriteLine();
                Console.WriteLine("1.Enter triangle dimensions\n2.Exit");
                Console.WriteLine("Select option by entering a number:");
                menu = Console.ReadLine();
                if (menu != "1" && menu != "2")
                {
                    Console.WriteLine("Invalid Option.Try Again");
                }
                else
                {
                    validMenu = true;
                }

            }
            return int.Parse(menu);
        }

       public static int ValidateSide(string s)
        {
            int number = 1;
            bool valid = false;
            while (valid == false)
            {
                Console.WriteLine("Please enter {0} of triangle:", s);
                string length = Console.ReadLine();
                bool result = int.TryParse(length, out number);
                if (result == false)
                {
                    Console.WriteLine("Invalid input. Try again");
                }
                else if (number < 0)
                {
                    Console.WriteLine("{0} cannot be less than 0. Try Again", s);
                }
                else if (number == 0)
                {
                    Console.WriteLine("{0} cannot be 0. Try Again", s);
                }
                else
                {
                    valid = true;
                    Console.WriteLine("{0} is now {1}", s, number);

                }

            }
            return number;
        }
        public void Go()
        {
            int option;
            do
            {
                option = Program.ValidateOptions();
                if (option == 1)
                {
                    int side1 = Program.ValidateSide("side1");
                    int side2 = Program.ValidateSide("side2");
                    int side3 = Program.ValidateSide("side3");
                    string result = TriangleSolver.Analyze(side1, side2, side3);
                    Console.WriteLine(result);
                }
            } while (option != 2);
           
        }
    }
}
