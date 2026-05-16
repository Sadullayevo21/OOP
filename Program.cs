using Transport.Models;

Car nexia = new Car();
nexia.Brand = "Chevrolet";
nexia.Model = "Nexia 3";
nexia.Year = 2019;
nexia.FuelLevel = 30;

nexia.ShowInfo();
nexia.Drive(200); 
nexia.Refuel(15);
nexia.ShowInfo();

Console.WriteLine("\n-----------------------");

Car tesla = new Car 
{ 
    Brand = "Tesla", 
    Model = "Model S", 
    Year = 2023, 
    FuelLevel = 15 
};

tesla.ShowInfo();
tesla.Drive(250);
tesla.Refuel(80);
tesla.ShowInfo();