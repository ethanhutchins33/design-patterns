public class ChocolateBoiler
{
    private bool empty;
    private bool boiled;

    public ChocolateBoiler()
    {
        empty = true;
        boiled = false;
    }

    public void Fill()
    {
        if (IsEmpty())
        {
            // fill the boiler with a milk/chocolate mixture
            empty = false;
            boiled = false;
        }
    }

    public void Drain()
    {
        if (!IsEmpty() && IsBoiled())
        {
            // drain the boiled milk and chocolate
            empty = true;
        }
    }

    public void Boil()
    {
        if (!IsEmpty() && !IsBoiled())
        {
            // bring the contents to a boil
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