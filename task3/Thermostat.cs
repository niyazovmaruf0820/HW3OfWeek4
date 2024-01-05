namespace task3;

public class Thermostat : IDevice
{
    public void TurnOff()
    {
        System.Console.WriteLine("The thermostat turned off");

    }

    public void TurnOn()
    {
        System.Console.WriteLine("The thermostat turned on");

    }

}
