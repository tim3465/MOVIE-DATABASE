using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVIE_DATABASE
{
    public class MenuBuyNumber
    {
        public static string MenuSelect(string[] menus)
        {
            Console.Clear();
            while (true)
            {
                //Displays the menu 
                for (int i = 1; i < menus.Length+1; i++)
                {
                    Console.WriteLine("{0,3} \t{1}", i, menus[i-1]);
                }
                int result;
                Console.WriteLine("Pleas select a number");

                //Validates the number 
                while (!int.TryParse(Console.ReadLine().ToLower().Trim(), out result) || result < 0 || result > menus.Length)
                {
                    Console.WriteLine("Invalid input. Try again with a positive number.");
                }

                //Rewrite the enter number and the selected category before returning  
                Console.Clear();
                Console.WriteLine("\n{0,3} \t{1}", result, menus[result - 1]);
                Console.WriteLine("====================");
                return menus[result-1];
            }
        }
    }
}

    

