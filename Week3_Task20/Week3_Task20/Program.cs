using System;
using System.Runtime.InteropServices;



namespace Week3_Task20
{
    class Program
    {


        
        static void Main(string[] args)
        {
            {
                bool ch = true;
                while (ch == true)
                {
                    Console.WriteLine("Computer Locker");
                    Console.WriteLine("");
                    Console.WriteLine("Do you want to lock your computer?Y/N");
                    string decision = Console.ReadLine();
                    string d = decision.ToLower();
                    if (d == "y" || d == "n")
                    {
                        switch (d)
                        {
                            case "y":
                                Win32.LockWorkStation();
                                break;
                            case "n":
                                Environment.Exit(0);
                                break;
                            default:
                                break;
                        }

                    }

                    else
                    {
                        ch = false;
                        Console.WriteLine("Your information is wrong. Use only y/n!");
                        ch = true;
                    }
                    
                }

            }
                
            
            Console.ReadKey();
        }
    }
}
