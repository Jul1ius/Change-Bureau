using System;
using System.Globalization;

namespace Cat_Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int minutesPerDay = int.Parse(Console.ReadLine());
            int numWalksDay = int.Parse(Console.ReadLine());
            int caloriesDay = int.Parse(Console.ReadLine());

            double minutesOut = minutesPerDay * numWalksDay;
            double totalBurndedCalories = minutesOut * 5;
            double caloriesPerDay = caloriesDay * 0.5;

            if (totalBurndedCalories >= caloriesPerDay)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalBurndedCalories}.");
            }
            else if (totalBurndedCalories < caloriesPerDay)
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalBurndedCalories}.");
            }
        }
    }
}
