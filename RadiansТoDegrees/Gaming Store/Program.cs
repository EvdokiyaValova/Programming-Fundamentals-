using System;

namespace Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            string inputGame = Console.ReadLine();
            bool flag = true;

            double spentOnGames = 0;

            while (inputGame != "Game Time")
            {
                string currentGame = inputGame;

                

                if (currentGame == "OutFall 4")
                {
                    if (currentBalance >= 39.99)
                    {
                        currentBalance -= 39.99;
                        spentOnGames += 39.99;
                        Console.WriteLine($"Bought {currentGame}");
                    }
                    else if (currentBalance < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }
                else if (currentGame == "CS: OG")
                {
                    if (currentBalance >= 15.99)
                    {
                        currentBalance -= 15.99;
                        spentOnGames += 15.99;
                        Console.WriteLine($"Bought {currentGame}");
                    }
                    else if (currentBalance < 15.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }
                else if (currentGame == "Zplinter Zell")
                {
                    if (currentBalance >= 19.99)
                    {
                        currentBalance -= 19.99;
                        spentOnGames += 19.99;
                        Console.WriteLine($"Bought {currentGame}");
                    }
                    else if (currentBalance < 19.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }
                else if (currentGame == "Honored 2")
                {
                    if (currentBalance >= 59.99)
                    {
                        currentBalance -= 59.99;
                        spentOnGames += 59.99;
                        Console.WriteLine($"Bought {currentGame}");
                    }
                    else if (currentBalance < 59.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }
                else if (currentGame == "RoverWatch")
                {
                    if (currentBalance >= 29.99)
                    {
                        currentBalance -= 29.99;
                        spentOnGames += 29.99;
                        Console.WriteLine($"Bought {currentGame}");
                    }
                    else if (currentBalance < 29.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }
                else if (currentGame == "RoverWatch Origins Edition")
                {
                    if (currentBalance >= 39.99)
                    {
                        currentBalance -= 39.99;
                        spentOnGames += 39.99;
                        Console.WriteLine($"Bought {currentGame}");
                    }
                    else if (currentBalance < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }
                else
                {
                    Console.WriteLine("Not Found");
                    
                }

                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    flag = false;
                    break;
                }

                inputGame = Console.ReadLine();
            }

            if (flag)
            {
                Console.WriteLine($"Total spent: ${spentOnGames:f2}. Remaining: ${currentBalance:f2}");
            }
        }
    }
}
