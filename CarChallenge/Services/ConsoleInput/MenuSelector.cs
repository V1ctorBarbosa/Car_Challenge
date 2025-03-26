namespace CarChallenge.Services.ConsoleInput;

using Models.Additionals;
using Models.Vehicles;

public static class MenuSelector
{
    public static Vehicle SelectVehicle()
    {
        while (true)
        {
            Console.WriteLine("Choose a vehicle to rent:");
            Console.WriteLine("1 - Car");
            Console.WriteLine("2 - MotorHome");
            Console.Write("Enter your choice: ");
            var input = Console.ReadLine();

            return input switch
            {
                "1" => new Car(),
                "2" => new MotorHome(),
                _ => ShowInvalid()
            };
        }

        Vehicle ShowInvalid()
        {
            Console.WriteLine("❌ Invalid option! Please try again.");
            return SelectVehicle();
        }
    }

    public static List<Additional> SelectAdditionals(Vehicle vehicle)
    {
        List<Additional> additionals = new();

        Console.WriteLine("\nChoose optional items (enter numbers separated by spaces, or press Enter to skip):");
        Console.WriteLine("1 - GPS");
        Console.WriteLine("2 - Child Seat");
        if (vehicle is MotorHome) Console.WriteLine("3 - Refrigerator");

        Console.Write("Selected additionals: ");
        var input = Console.ReadLine()?.Split(' ') ?? Array.Empty<string>();

        foreach (var option in input)
        {
            switch (option.Trim())
            {
                case "1":
                    additionals.Add(new Additional(AdditionalType.GPS, vehicle));
                    break;
                case "2":
                    additionals.Add(new Additional(AdditionalType.CarSeat, vehicle));
                    break;
                case "3" when vehicle is MotorHome:
                    additionals.Add(new Additional(AdditionalType.Refrigerator, vehicle));
                    break;
                default:
                    if (!string.IsNullOrWhiteSpace(option))
                        Console.WriteLine($"⚠️ Invalid option ignored: {option}");
                    break;
            }
        }

        return additionals;
    }
}