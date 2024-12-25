using SingletonPattern.App;

var boiler = ChocolateBoiler.GetInstance();
boiler.Fill();
boiler.Boil();
boiler.Drain();

Console.ReadLine();
