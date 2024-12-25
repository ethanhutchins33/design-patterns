namespace SingletonPattern.App;

public class ChocolateBoiler
{
    private bool empty;
    private bool boiled;

    private static ChocolateBoiler ChocolateBoilerInstance;

    public static ChocolateBoiler GetInstance()
    {
        ChocolateBoilerInstance ??= new ChocolateBoiler();
        return ChocolateBoilerInstance;
    }

    private ChocolateBoiler()
    {
        empty = true;
        boiled = false;
    }

    public void Fill()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Filling boiler with a milky chocolatey mixture...");
            empty = false;
            boiled = false;
        }
    }

    public void Drain()
    {
        if (!IsEmpty() && IsBoiled())
        {
            Console.WriteLine("Draining boiler...");
            empty = true;
        }
    }

    public void Boil()
    {
        if (!IsEmpty() && !IsBoiled())
        {
            Console.WriteLine("Boiling the milky chocolatey mixture...");
            boiled = true;
        }
    }

    private bool IsBoiled()
    {
        return boiled;
    }

    private bool IsEmpty()
    {
        return empty;
    }
}