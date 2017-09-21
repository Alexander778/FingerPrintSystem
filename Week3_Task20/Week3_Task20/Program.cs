using System;

namespace Week3_Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Computer Locker");
                Console.WriteLine("");
                while (true)
                {
                    Console.WriteLine("Do you want to lock your computer? Y/N");
                    string decision = Console.ReadLine()?.ToLower();
                    switch (decision)
                    {
                        case "y":
                            Win32.LockWorkStation();
                            Environment.Exit(0);
                            break;
                        case "n":
                            Environment.Exit(0);
                            break;
                        default:
                            continue;
                    }
                }
            }
        }
    }
}
