using Transport.Models;

Car nexia = new Car();

nexia.Brand = "Chevrolet";
nexia.Model = "Nexia 3";
nexia.Year = 2019;

nexia.FuelLevel = 20;


// Speed
nexia.Speed = 50;
nexia.IncreaseSpeed(30);
nexia.DecreaseSpeed(20);


// Destination
nexia.Destination = "Toshkent";

nexia.ShowInfo();


// Drive
nexia.Drive(200);


// yoqilg'i qolmasa
nexia.Destination = "Samarqand";

nexia.ShowInfo();


// yoqilg'i quyish
nexia.Refuel(50);

nexia.Destination = "Samarqand";

nexia.ShowInfo();