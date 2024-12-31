namespace SingletonPattern.App;

public class ChocolateBoiler
{
    private bool _empty;
    private bool _boiled;

    // Use C# Lazy<T> type to make laziness really simple.
    // Also allows you to check whether the instance has been created yet with the
    // IsValueCreated property
    private static readonly Lazy<ChocolateBoiler> Lazy = new(() => new ChocolateBoiler());

    public static ChocolateBoiler Instance => Lazy.Value;

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