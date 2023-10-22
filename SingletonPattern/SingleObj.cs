namespace SingletonPattern;
class SingleObj
{
    private static SingleObj? single;

    private SingleObj() { }

    public static SingleObj GetInstance()
    {
        single ??= new SingleObj();
        return single;
    }

    public void SayHello()
    {
        Console.WriteLine("Hello!");
    }
}