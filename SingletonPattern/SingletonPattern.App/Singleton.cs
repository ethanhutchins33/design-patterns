namespace SingletonPattern.App;

public class Singleton
{
    private static Singleton? _uniqueInstance;
    private Singleton() { }
    public static Singleton? GetInstance()
    {
        _uniqueInstance ??= new Singleton();
        return _uniqueInstance;
    }
}