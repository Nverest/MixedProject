using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using Microsoft.VisualBasic;

class Program 
{
    
    static void Main(string[] args)
    {

        List<string> Groceries = new();
                
        bool exit = true;
        while (exit)
        {
            Console.WriteLine("===========Choose what to do==========");
            Console.WriteLine("Show [L]ist");
            Console.WriteLine("[A]dd Item");
            Console.WriteLine("[R]emove item");
            Console.WriteLine("[S]earch item");
            Console.WriteLine("[E]xit list");
            Console.WriteLine("===============================");

            char choice = char.Parse(Console.ReadLine());
            
            
            switch(choice)
            {
                case 'l':
                case 'L':
                Console.WriteLine("=====Groceries=====");
                foreach(string item in Groceries)
                {
                    Console.WriteLine(item);
                }
                break;
                
                case 'a':
                case 'A':
                Console.WriteLine("===Add your item to the list===");
                string AddList = Console.ReadLine();
                Groceries.Add(AddList);
                Console.WriteLine("Would yo like to add more?");
                string answer = Console.ReadLine();
                if (answer=="yes")
                {
                    Console.ReadLine();
                    Groceries.Add(AddList);
                }
                
                Console.Clear();
                break;
                
                case 'r':
                case 'R':
                Console.WriteLine("===Remove Item from list===");
                string RemoveList = Console.ReadLine();
                Groceries.Remove(RemoveList);
                break;

                case 's':
                case 'S':
                Console.WriteLine("===Search Item in List===");
                string itemcheck = Console.ReadLine();
                if (Groceries.Contains(itemcheck))
                {
                    Console.WriteLine("This item already exist");
                }
                if (!Groceries.Contains(itemcheck))
                {
                    Console.WriteLine("This is not on the list. \nDo you want to add the item?");
                   answer = Console.ReadLine();
                    if (answer=="yes")
                    {
                        Groceries.Add(itemcheck);
                        Console.Clear();                     
                    }   
                }
                break;

                case 'e':
                case 'E':
                exit = false;
                break;

                default:
                Console.WriteLine("Invalid input");
                break;
            }

        }

    }
}
