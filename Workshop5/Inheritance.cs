class Vehicle
{
    public string Brand { get; set; }
    public double Speed { get; set; }

    public void Start()
    {
        Console.WriteLine($"{Brand} is starting...");
    }

    public void Stop()
    {
        Console.WriteLine($"{Brand} is stopping...");
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
    }
}

class Car : Vehicle
{
    public int Seats { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h, Seats: {Seats}");
    }
}

class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h, Has Sidecar: {HasSidecar}");
    }
}