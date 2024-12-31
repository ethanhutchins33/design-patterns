using SingletonPattern.App;

var boiler = ChocolateBoiler.Instance;
boiler.Fill();
boiler.Boil();
boiler.Drain();

Console.ReadLine();
