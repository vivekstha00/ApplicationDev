abstract class VehicleAbstract
{
    public abstract void StartEngine();
    public abstract void StopEngine();

    public void Display()
    {
        Console.WriteLine("This is a vehicle");
    }
}

class CarAbstract : VehicleAbstract
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started with ignition key");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Car engine stopped");
    }
}

class BikeAbstract : VehicleAbstract
{
    public override void StartEngine()
    {
        Console.WriteLine("Bike engine started with kick or self-start");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Bike engine stopped");
    }
}