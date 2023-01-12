class Person
{
     public string Name { get; set; }
}

class Car
{
    public string color; // field
    public int year;
    public string model;

    // Class members
    int maxSpeed = 200;          // field
    public Car(string modelName, string modelColor, int modelYear)
    {
        this.model = modelName;
        this.color = modelColor;
        this.year = modelYear;
    }

    public void fullThrottle()   // method
    {
        Console.WriteLine("The car is going as fast as it can!");
    }
}

class Program
{
    static void testCar()
    {
        Car Ford = new Car("mustang", "red", 1969);
        Car Opel = new Car("Astra", "white", 2005);

        Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
        Console.WriteLine(Opel.color + " " + Opel.year + " " + Opel.model);
    }

    static void testPerson()
    {
        Person new_person = new Person();
        new_person.Name = "nameless";
        Console.WriteLine(new_person.Name);
    }
    static void Main(string[] args)
    {
        testCar();
        testPerson();

    }
}