using System;
using System.Collections.Generic;
using System.Linq;

namespace Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> mobileMileage = new Dictionary<string, int>();
            Dictionary<string, int> mobileFuel = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|");

                string car = input[0];
                int mileage = int.Parse(input[1]);
                int fuel = int.Parse(input[2]);

                if (!mobileMileage.ContainsKey(car))
                {
                    mobileMileage.Add(car, mileage);
                    mobileFuel.Add(car, fuel);
                }
            }

            //  Console.WriteLine(string.Join(" ", mobileMileage));
            //  Console.WriteLine(string.Join(" ", mobileFuel));

            while (true)
            {
                string currentComand = Console.ReadLine();

                if (currentComand == "Stop")
                {
                    break;
                }

                List<string> comand = currentComand.Split(" : ").ToList();

                if (comand[0] == "Drive")
                {
                    string car = comand[1];
                    int distance = int.Parse(comand[2]);
                    int fuel = int.Parse(comand[3]);

                    int fuelCar = mobileFuel[car];

                    if (fuelCar >= fuel)
                    {
                        mobileFuel[car] -= fuel;
                        mobileMileage[car] += distance;

                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                        if (mobileMileage[car] >= 100000)
                        {
                            mobileMileage.Remove(car);
                            mobileFuel.Remove(car);
                            Console.WriteLine($"Time to sell the {car}!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                }
                else if (comand[0] == "Refuel")
                {
                    string car = comand[1];
                    int fuel = int.Parse(comand[2]);
                    int fuelCar = mobileFuel[car];

                    if (fuelCar + fuel > 75)
                    {
                        int refueled = 75 - fuelCar;
                        mobileFuel[car] += refueled;

                        Console.WriteLine($"{car} refueled with {refueled} liters");
                    }
                    else
                    {
                        mobileFuel[car] += fuel;
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }
                }
                else if(comand[0] == "Revert")
                {
                    string car = comand[1];
                    int mileage = int.Parse(comand[2]);
                    mobileMileage[car] -= mileage;

                    if (mobileMileage[car] < 10000)
                    {
                        mobileMileage[car] = 10000;
                    }

                    Console.WriteLine($"{car} mileage decreased by {mileage} kilometers");
                }                
            }

            Dictionary<string, int> sortedMileage = mobileMileage
                    .OrderByDescending(c => c.Value)
                    .ThenBy(c => c.Key)
                    .ToDictionary(c => c.Key, c => c.Value);

            foreach (var item in sortedMileage)
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value} kms, Fuel in the tank: {mobileFuel[item.Key]} lt.");
            }
        }
    }
}
