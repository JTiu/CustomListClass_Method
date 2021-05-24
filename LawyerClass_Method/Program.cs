using System;
using System.Linq;

namespace LawyerClass_Method
{
    class Program
    {
        static void Main(string[] args)
        {//starts menu
         

            Menu startMenu = new Menu();
            int optionPicked;
            optionPicked = startMenu.DrawMenu(); //

            while (optionPicked != 14)
            {
                Console.Clear();
                startMenu.DirectUser(optionPicked);
                Console.Clear();
                optionPicked = startMenu.DrawMenu();
            }
            //ends menu
            Console.WriteLine("Press any button to exit application");

            Console.ReadLine();
            Console.Clear();
            
        }
    }
}
