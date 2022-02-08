using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************");
            Console.WriteLine("*1)--------Start game--------*");
            Console.WriteLine("*2)-----------Info-----------*");
            Console.WriteLine("*3)-----------Exit-----------*");
            Console.WriteLine("******************************");

            int menuOption = int.Parse(Console.ReadLine());

            switch (menuOption)
            {
                case (1):
                    {
                        Console.Write("\nWelcome, please enter your name: ");
                        string name = Console.ReadLine();

                        Console.WriteLine("Ah, welcome to your new adventure " + name);
                        Console.ReadLine();

                        break;
                    }

                case (2):
                    {
                        Console.WriteLine("a text based RPG game");

                        break;
                    }

                case (3):
                    {
                        Environment.Exit(0);

                        break;
                    }
            }

        }
    }
}
