using System;

class Car
{
    private string make;
    private string model;
    private string colour;
    private string registrationNumber;

    public Car(string make, string model, string colour, string registrationNumber)
    {
        this.make = make;
        this.model = model;
        this.colour = colour;
        this.registrationNumber = registrationNumber;
    }

    public string RegistrationNumber => registrationNumber;

    public string Make
    {
        get => make;
        set
        {
            if (!string.IsNullOrEmpty(value))
                make = value;
        }
    }

    public string GetCarInfo()
    {
        return $"Make: {make}, Model: {model}, Colour: {colour}, Registration: {registrationNumber}";
    }

    static void Main()
    {
        Car car1 = new Car("Toyota", "Camry", "Red", "ABC123");
        Car car2 = new Car("Honda", "Civic", "Blue", "XYZ456");
        Car car3 = new Car("Ford", "Mustang", "Black", "LMN789");
        Car car4 = new Car("Chevrolet", "Malibu", "White", "DEF101");
        Car car5 = new Car("Nissan", "Altima", "Gray", "GHI202");

        Console.WriteLine(car1.GetCarInfo());
        Console.WriteLine(car2.GetCarInfo());
        Console.WriteLine(car3.GetCarInfo());
        Console.WriteLine(car4.GetCarInfo());
        Console.WriteLine(car5.GetCarInfo());
    }
}
