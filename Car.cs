using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Race.Threads.Labb2
{
    internal class Car
    {
        public string Name { get; set; }
        public int Distance { get; set; }
        public int Speed { get; set; }
        public bool Finish { get; set; }

        public Car(string name, int speed)
        {
            Name = name;
            Distance = 0;
            Speed = speed;
            Finish = false;
        }

        public void RoadDrive()
        {
            while (!Finish && Distance <1000)
            {
                Thread.Sleep(1000);

                Random random = new Random();
                int carBump = random.Next(1, 51);

                if (carBump == 1) 
                {
                    Console.WriteLine($"{Name} has no fuel and needs to refuel!");
                    Thread.Sleep(20000);
                }

                else if (carBump <= 17)
                {
                    Console.WriteLine($"{Name} got a puncture and needs to change tire!");
                    Thread.Sleep(3000);
                }

                else if ( carBump >= 40)
                {
                    Console.WriteLine($"{Name} has hit a bird and needs to clean the windowshield!");
                    Thread.Sleep(4000);
                }

                else if ( carBump <= 7)
                {
                    Console.WriteLine($"{Name} has a preoblem with the engine and is slowed down by 1km/h");
                    Speed--;
                }

                Distance += Speed;
                Console.WriteLine($"{Name} has driven {Distance} m during the race");
            }

            if (Distance >= 1000)
            {
                Finished();
            }
        }

        public void Finished()
        {
            Finish = true;
            Console.WriteLine($"{Name} has finished the race!");
        }

    }
}
