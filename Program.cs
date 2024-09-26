using System.Formats.Asn1;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
/*
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
                    string AddList = Console.ReadLine().ToUpper();
                    if (Groceries.Contains(AddList))
                    {
                        Console.WriteLine("This item Already exist");
                    }
                    else
                    {
                        Groceries.Add(AddList);
                    }
                
                break;
                
                case 'r':
                case 'R':
                Console.ForegroundColor= ConsoleColor.DarkCyan;
                Console.WriteLine("==Remove Item from list===");
                Console.ForegroundColor= ConsoleColor.Gray;
                foreach(string item in Groceries)
                {
                    Console.WriteLine(item);
                }
                string RemoveList = Console.ReadLine().ToUpper();
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
                   string answer = Console.ReadLine();
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
*/
static class Program
{
    static void Main(string[]args)
    {

        List<string> travelLog = new();
        var running = true;

        while (running)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==========Travel Log==========");
            Console.ResetColor();
            Console.WriteLine("[A]dd Travel destinaion\n[R]emove Travel destination\n[S]how all Destinations\n[C]lear Travel Log\n[Q]uit");
            
            char choice = char.Parse(Console.ReadLine().ToUpper());
            switch(choice)
            {
                case 'A':
                    TravelLog.Addtravel(travelLog);
                break;

                case 'R':
                    TravelLog.Printtravel(travelLog);
                    TravelLog.RemoveTravel(travelLog);
                break;

                case 'S':
                    TravelLog.Printtravel(travelLog);
                break;

                case 'C':
                    travelLog.Clear();
                break;

                case 'Q':
                    running=false;
                break;

                default:
                    Console.WriteLine("Try Someting Else");
                break;

            }
        }   
    }
}
public class TravelLog
{
    public static void Addtravel(List<string> travelist)
    {
        Console.Write("Enter a destination for the log: ");
        travelist.Add(Console.ReadLine());
    }
    public static void Printtravel(List<string> travelist)
    {
        Console.WriteLine("=====TravelDestinations=====");
            foreach (string destinaion in travelist)
            {
                Console.ForegroundColor=ConsoleColor.Magenta;
                Console.WriteLine($"{destinaion.ToUpper()}");
                Console.ResetColor();
            }
    }
    public static void RemoveTravel (List <string> travelist)
    {
        Console.WriteLine("Delete TravelLog Destination: ");
        travelist.Remove(Console.ReadLine().ToLower());      
    }
}