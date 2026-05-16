namespace Transport.Models
{
    public class Car
    {
        public string Brand;
        public string Model;
        public int Year;
        public double FuelLevel;

        public void ShowInfo()
        {
            Console.WriteLine($"\n Mashina: {Brand} {Model} ({Year}-yil)");
            Console.WriteLine($"Yoqilg'i darajasi: {FuelLevel}%");
        }

        public void Drive(double distance)
        {
            double needed = distance / 10;
            if (FuelLevel >= needed)
            {
                FuelLevel -= needed;
                Console.WriteLine($"{distance} km yo'l bosildi. -{needed}% yoqilg'i");
            }
            else
            {
                Console.WriteLine("Not enough fuel!");
            }
        }

        public void Refuel(double amount)
        {
            FuelLevel += amount;
            if (FuelLevel > 100) FuelLevel = 100;
            Console.WriteLine($"{amount}% yoqilg'i qo'shildi");
        }
    }
}