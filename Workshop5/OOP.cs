// Abstract Base Class
abstract class ElectronicDevice
{
    private string brand;
    private double price;
    // Constructor
    public ElectronicDevice(string brand, double price)
    {
        this.brand = brand;
        this.price = price;
    }
    // Properties (Encapsulation)
    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }
    public double Price
    {
        get { return price; }
        set 
        { 
            if (value > 0)
                price = value;
        }
    }
    // Abstract method
    public abstract void ShowInfo();
}

// Derived Class: Laptop
class Laptop : ElectronicDevice
{
    public Laptop(string brand, double price) : base(brand, price)
    {
    }
    public void TurnOnBattery()
    {
        Console.WriteLine($"{Brand} laptop battery is turned on");
    }
    public override void ShowInfo()
    {
        Console.WriteLine($"Laptop - Brand: {Brand}, Price: ${Price}");
    }
}

// Derived Class: Smartphone
class Smartphone : ElectronicDevice
{
    public Smartphone(string brand, double price) : base(brand, price)
    {
    }
    public void EnableCamera()
    {
        Console.WriteLine($"{Brand} smartphone camera is enabled");
    }
    public override void ShowInfo()
    {
        Console.WriteLine($"Smartphone - Brand: {Brand}, Price: ${Price}");
    }
}

// Store Class
class ElectronicsStore
{
    private List<ElectronicDevice> devices;
    public ElectronicsStore()
    {
        devices = new List<ElectronicDevice>();
    }
    public void AddDevice(ElectronicDevice device)
    {
        devices.Add(device);
        Console.WriteLine($"{device.Brand} added to the store");
    }
    public void RemoveDevice(ElectronicDevice device)
    {
        if (devices.Remove(device))
        {
            Console.WriteLine($"{device.Brand} removed from the store");
        }
        else
        {
            Console.WriteLine("Device not found in the store");
        }
    }

    public void ShowAllDeviceDetails()
    {
        Console.WriteLine("\n========== Store Inventory ==========");
        if (devices.Count == 0)
        {
            Console.WriteLine("No devices in store");
            return;
        }
        foreach (var device in devices)
        {
            device.ShowInfo();
            // Downcast to call child-specific methods
            if (device is Laptop)
            {
                Laptop laptop = (Laptop)device;
                laptop.TurnOnBattery();
            }
            else if (device is Smartphone)
            {
                Smartphone smartphone = (Smartphone)device;
                smartphone.EnableCamera();
            }
            Console.WriteLine("-------------------------------------");
        }
    }
}