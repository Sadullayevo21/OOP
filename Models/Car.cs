namespace Transport.Models
{
    public class Car
    {
        public string Brand;
        public string Model;
        public int Year;

        private double fuelLevel;
        private int speed;
        private string destination;

        public double FuelLevel
        {
            get
            {
                return fuelLevel;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Yoqilg'i manfiy bo'lishi mumkin emas!");
                }
                else if(value > 100)
                {
                    fuelLevel = 100;
                }
                else
                {
                    fuelLevel = value;
                }
            }
        }

        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Tezlik manfiy bo'lmaydi!");
                }
                else
                {
                    speed = value;
                }
            }
        }

        public string Destination
        {
            get
            {
                return destination;
            }
            set
            {
                if(FuelLevel == 0)
                {
                    Console.WriteLine("Yoqilg'i tugagan! Manzilni o'zgartirib bo'lmaydi.");
                }
                else
                {
                    destination = value;
                    Console.WriteLine($"Yangi manzil: {destination}");
                }
            }
        }

        public void IncreaseSpeed(int amount)
        {
            if(amount < 0)
            {
                Console.WriteLine("Musbat son kiriting");
            }
            else
            {
                speed += amount;
                Console.WriteLine($"Tezlik oshdi: {speed}");
            }
        }

        public void DecreaseSpeed(int amount)
        {
            if(amount < 0)
            {
                Console.WriteLine("Musbat son kiriting");
            }
            else
            {
                speed -= amount;

                if(speed < 0)
                    speed = 0;

                Console.WriteLine($"Tezlik kamaydi: {speed}");
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\n>>> Mashina: {Brand} {Model} ({Year}-yil)");
            Console.WriteLine($">>> Yoqilg'i: {FuelLevel}%");
            Console.WriteLine($">>> Tezlik: {Speed} km/h");
            Console.WriteLine($">>> Manzil: {Destination}");
        }

        public void Drive(double distance)
        {
            double neededFuel = distance / 10;

            if(FuelLevel >= neededFuel)
            {
                FuelLevel -= neededFuel;

                Console.WriteLine(
                    $"{distance} km yo'l bosildi. {neededFuel}% yoqilg'i ishlatildi");
            }
            else
            {
                Console.WriteLine("Not enough fuel!");
            }
        }

        public void Refuel(double amount)
        {
            FuelLevel += amount;

            if(FuelLevel > 100)
                FuelLevel = 100;

            Console.WriteLine($"{amount}% yoqilg'i qo'shildi");
        }
    }
}