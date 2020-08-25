using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static int TOP;
        static int StackLength;
        static int[] Stack;
        static void Main(string[] args)
        {
            TOP = 0;
            StackLength = 0;
            int c;
            c = 0;
            Console.Title = "Stack";
            do
            {                
                c = menu();

                switch (c)
                {
                    case 1:
                        StackLength = get_number();
                        Stack = new int[StackLength];
                        TOP = 0;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("\n\tStack is created");
                        Console.Write("\n\tPress any key to continue...");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.ReadKey();
                        break;
                    //PUSH
                    case 2:
                        if (TOP == StackLength)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n\tStack is full");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("\n\tPress any key to continue...");
                            Console.ReadKey();
                        }//if stack is full
                        else {
                            int value = get_number();
                            Stack[TOP] = value;
                            TOP++;
                        }//else if stack is not empty
                        break;
                    //POP
                    case 3:
                        if (TOP == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\n\tStack is Empty");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("\n\tPress any key to continue...");
                            Console.ReadKey();
                        }//if stack is empty
                        else {
                            int value = Stack[TOP - 1];
                            TOP--;
                            show_number(value);
                        }//else
                        break;
                    default:
                        break;
                }//switch



            } while (c != 0);


        }//Main
        //---------------------------------------------------------------------------
        static int menu()
        {
            int choice = 0;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\t0)Exit");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\t1)Create Stack");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\t2)Push Data");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\t3)Pop");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n\t=========================================");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("\n\tEnter your choice:");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }//menu
        //---------------------------------------------------------------------------
        static int get_number()
        {
            int intN;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\tEnter a number:");
            Console.ForegroundColor = ConsoleColor.Gray;
            intN = int.Parse(Console.ReadLine());
            return intN;
        }//get_number
        //---------------------------------------------------------------------------
        static void show_number(int value)
        {            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\tPoped value={0}",value);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("\n\tPress any key to continue...");
            Console.ReadKey();
        }//get_number
         //---------------------------------------------------------------------------

        //---------------------------------------------------------------------------

    }//Program


}//Stack
