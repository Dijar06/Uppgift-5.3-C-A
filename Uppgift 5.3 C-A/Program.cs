using System;

namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frågor = new string[4] { "Hur många toaletter i skolan?", "Största landet i världen?", "Bäst?", "Sämst?" };
            string[] svar = new string[4] {"100", "ryssland", "dijar", "younis"};

            Console.WriteLine("Välj en fråga, 1-4");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    {
                        Console.WriteLine(frågor[0]);
                        string y = Console.ReadLine().ToLower();
                        if (y == svar[0])
                        {
                            Console.WriteLine("Rätt");
                        }
                        else
                        {
                            Console.WriteLine("Fel");
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(frågor[1]);
                        string y = Console.ReadLine().ToLower();
                        if (y == svar[1])
                        {
                            Console.WriteLine("Rätt");
                        }
                        else
                        {
                            Console.WriteLine("Fel");
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(frågor[2]);
                        string y = Console.ReadLine().ToLower();
                        if (y == svar[2])
                        {
                            Console.WriteLine("Rätt");
                        }
                        else
                        {
                            Console.WriteLine("Fel");
                        }
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine(frågor[3]);
                        string y = Console.ReadLine().ToLower();
                        if (y == svar[3])
                        {
                            Console.WriteLine("Rätt");
                        }
                        else
                        {
                            Console.WriteLine("Fel");
                        }
                        break;
                    }
            }
        }
    }
}