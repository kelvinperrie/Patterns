// See https://aka.ms/new-console-template for more information
using Patterns.Adapter;
using Patterns.Adapter.Models;

Console.WriteLine("Hello, World!");

// the adapter pattern is all about wrapping a class in an 'adapter' class so that the adapter class can present a certain
// interface.

// I think that there would often be a bit of blurring between this pattern and the facade pattern
// I've kind of used this on services to extract documents from differing document repositories

// our Truck class doesn't implement the IVehicle, and can't because it doesn't have the correct methods. Assuming for some reason
// we couldn't change the truck class, we create a TruckAdapter class that does impement the IVehicle and internally has a truck
// class


var truck = new Truck();
var car = new Car();
var truckAdapter = new TruckAdapter();

var myVehicles = new List<IVehicle>();

// the car class implements the IVehicle interface
car.Start();
car.GoForward();
car.Start();
myVehicles.Add(car);

// can't do this because truck doesn't implement IVehicle
//truck.Start();
//truck.GoForward();
//truck.Start();
//myVehicles.Add(truck);

// but truckAdapter does implement IVehcile
truckAdapter.Start();
truckAdapter.GoForward();
truckAdapter.Stop();
myVehicles.Add(truckAdapter);