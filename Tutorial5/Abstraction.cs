public abstract class Motors
{
    public abstract void StartEngine();
    public abstract void StopEngine();

    public void Display()
    {
        Console.WriteLine("This is a motor vehicle");
    }
}

public class Bus : Motors
{
    public override void StartEngine()
    {
        Console.WriteLine("Starts engine with Diesel");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Stops engine with Diesel");
    }
}

public class SuperBike : Motors
{
    public override void StartEngine()
    {
        Console.WriteLine("Starts engine with Self Start");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Engine stopped for SuperBike");
    }
}