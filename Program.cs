// See https://aka.ms/new-console-template for more information
using References_Mcvey_Zander;

//Makes a reference for the First Sedan.
Sedan myFirstSedan = new Sedan(0);
IAutomobile myAutomobile = myFirstSedan;

//Makes a reference for the Other Sedan.
Sedan myOtherSedan = new Sedan(0);

//Displays how much the First Sedan and Automobile speed increase.
myFirstSedan.IncreaseSpeed();
Console.WriteLine(myFirstSedan.Speed);
Console.WriteLine(myAutomobile.Speed);
Console.WriteLine(myFirstSedan.Equals(myAutomobile));

//Compares the First Sedan and the Other Sedan speed increase.
myOtherSedan.IncreaseSpeed();
Console.WriteLine(myFirstSedan.Speed);
Console.WriteLine(myOtherSedan.Speed);
Console.WriteLine(myFirstSedan.Equals(myOtherSedan));

//Places how fast, how much it weights, and the License Plate of the Truck.
Truck myTruck = new Truck(50, 500, "DewIt");

//Stringifies all the Automobiles.
myFirstSedan.Stringify();
myAutomobile.Stringify();
myOtherSedan.Stringify();
myTruck.Stringify();
