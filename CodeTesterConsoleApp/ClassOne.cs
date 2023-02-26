using CodeTesterConsoleApp;

namespace CodeTesterConsoleApp;

public class ClassOne : ClassTwo
{
    
}

public abstract class ClassTwo
{
    PartialClass test = new();

    public void tester()
    {
        PartialClass.tester();
        Console.WriteLine("test");
    }
}