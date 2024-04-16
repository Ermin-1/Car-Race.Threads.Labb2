using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Race.Threads.Labb2
{
    internal class Race
    {
        public void StartTheRace(params Car[] cars) //params för att kunna ta fler parametrar/ bilar i racet
        {
            Console.WriteLine("GO! GO! GO!");

            Thread[] threads = new Thread[cars.Length];

            for (int i = 0; i < cars.Length; i++)
            {
                threads[i] = new Thread(cars[i].RoadDrive);
                threads[i].Start();
            }

            // Wait for all threads to finish
            foreach (Thread item in threads)
            {
                item.Join();
            }

            // Find the winner
            int winnerDistance = 0;
            Car winner = null;
            foreach (Car item in cars)
            {
                if (item.Distance > winnerDistance)
                {
                    winnerDistance = item.Distance;
                    winner = item;
                }
            }

            Console.WriteLine($"The winner is {winner.Name}!");
        }
    }
}
