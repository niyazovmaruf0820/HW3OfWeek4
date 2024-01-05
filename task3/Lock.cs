namespace task3;

public class Lock : IDevice
{
    public void TurnOff()
    {
        System.Console.WriteLine("The lock isn't working");

    }

    public void TurnOn()
    {
        System.Console.WriteLine("The lock is working");

    }

}
