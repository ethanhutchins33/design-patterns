namespace SingletonPattern.App;

public class ChocolateBoiler
{
    private bool _empty;
    private bool _boiled;

    private static ChocolateBoiler? _chocolateBoilerInstance;
    private static readonly Lock Padlock = new();

    // We have a static method which will always return the same instance of ChocolateBoiler
    public static ChocolateBoiler GetInstance()
    {
        // Adds simple thread safety
        lock (Padlock)
        {
            _chocolateBoilerInstance ??= new ChocolateBoiler();
            return _chocolateBoilerInstance;
        }
    }

    // The private constructor means nothing can instantiate a new instance of this class
    private ChocolateBoiler()
    {
        _empty = true;
        _boiled = false;
    }

    public void Fill()
    {
        if (!IsEmpty()) return;

        Console.WriteLine("Filling boiler with a milky chocolatey mixture...");
        _empty = false;
        _boiled = false;
    }

    public void Drain()
    {
        if (IsEmpty() || !IsBoiled()) return;

        Console.WriteLine("Draining boiler...");
        _empty = true;
    }

    public void Boil()
    {
        if (IsEmpty() || IsBoiled()) return;

        Console.WriteLine("Boiling the milky chocolatey mixture...");
        _boiled = true;
    }

    private bool IsBoiled()
    {
        return _boiled;
    }

    private bool IsEmpty()
    {
        return _empty;
    }
}