namespace Car_Race.Threads.Labb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Ermin", 120);
            Car car2 = new Car("Oskar", 120);

            Race race = new Race();
            race.StartTheRace(car1, car2);
        }
    }
}
