using Transport.Models;

Car nexia = new Car();

nexia.Brand = "Chevrolet";
nexia.Model = "Nexia 3";
nexia.Year = 2019;

nexia.FuelLevel = 20;

nexia.Speed = 50;
nexia.IncreaseSpeed(30);
nexia.DecreaseSpeed(20);

nexia.Destination = "Toshkent";
nexia.ShowInfo();

nexia.Drive(200);

nexia.Destination = "Samarqand";
nexia.ShowInfo();

nexia.Refuel(50);
nexia.Destination = "Samarqand";
nexia.ShowInfo();