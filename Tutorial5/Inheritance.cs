class Vehicle
{
    public string Brand{ get; set; }

    public double Speed { get; set; }

    public void Start()
    {
        Console.WriteLine("Starting............");
    }

    public void Stop()
    {
        Console.WriteLine("Stopping............");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
    }
}

class Car : Vehicle
{
    public int Seats { get; set; }


}

class Bike : Vehicle
{
    public bool HasCarrier { get; set; }

}