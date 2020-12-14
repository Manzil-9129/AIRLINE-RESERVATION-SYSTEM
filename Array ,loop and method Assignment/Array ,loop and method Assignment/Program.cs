using System;

namespace Array__loop_and_method_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Random ernd = new Random();
            int[] FCseats = new int[] { 1, 2, 3, 4, 5 };
            int[] ECseats = new int[] { 6, 7, 8, 9, 10 };
            bool[] emptyseats = { false, false, false, false, false, false, false, false, false, false, false };// Intializing all the elements to false


            int Menu = 0;

            while (Menu <= 10)//Menu will loop 10 times
            {
                Console.WriteLine("AIRLINE RESERVATION ");
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++ ");
                Console.WriteLine();
                Console.WriteLine("1-First Class ");
                Console.WriteLine("2-Economy Class ");
                Console.WriteLine("3-Exit ");
                Console.WriteLine("--------------------------------------- ");
                Console.WriteLine("Select from (1-3) ");

                int select;


                //Using Switch case 
                switch (select = Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Your boarding pass ");
                        Console.WriteLine("+=+=+=++++++=======");
                        Console.WriteLine("You Selected First class ");

                        //Assigning a First class seat
                        bool Dseats = false;
                        int a;
                        a = rnd.Next(1, 5);//Generating the Random seats 

                        //Code to prevent the re assigning of the seat
                        while (!Dseats)
                        {
                            Dseats = true;
                            a = rnd.Next(1, 5);
                            if (emptyseats[a] == true)
                                Dseats = false;
                        }
                        emptyseats[a] = true;//Declaring the new seat assign to true
                        Console.WriteLine("The seat number is " + a);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("Your boarding pass ");
                        Console.WriteLine("+=+=+=++++++=======");
                        Console.WriteLine("You Selected Economy class ");

                        //Code to check if all the Economy seats are full
                        if (emptyseats[6] && true & emptyseats[7] && true && emptyseats[8] && true && emptyseats[9] && true)
                        {
                            Console.WriteLine("Sorry the economy section is full");
                            Console.WriteLine("Would you like to book in first Class (Y/N) ");
                            string input;
                            string ans = "yes";
                            string anw = "No";
                            input = Console.ReadLine();
                            if (input == ans)
                            {

                                goto case 1;

                            }
                            else if (input == anw)
                            {
                                Console.WriteLine("The next flight departs in 3 hours ");
                            }
                            break;
                        }
                        
                        //Assigning a Second Class seat
                        bool Deseats = false;
                        int b;
                        b = ernd.Next(6, 11);
                        //Code to prevent the Re-assigning of the seats
                        while (!Deseats)
                        {
                            Deseats = true;
                            b = ernd.Next(6, 11);
                            if (emptyseats[b] == true)
                                Deseats = false;

                        }
                        emptyseats[b] = true;
                        Console.WriteLine("The seat number is " + b);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("Press any button to exit ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("OOPS Something went wrong ");
                        break;

                }


                Console.ReadKey();

            }

        }
    }

        
        
    
}
