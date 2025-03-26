using CarChallenge.Models.Rental;
using CarChallenge.Services.ConsoleInput;

namespace CarChallenge.Services;

public static class RentalFlow
{
    public static void Start()
    {
        Console.WriteLine("🚗 Welcome to the Vehicle Rental System! 🚐\n");

        var vehicle = MenuSelector.SelectVehicle();
        var days = InputReader.ReadInteger("How many days do you want to rent the vehicle? ");
        var km = InputReader.ReadDecimal("How many kilometers do you expect to drive? ");
        var additionals = MenuSelector.SelectAdditionals(vehicle);

        var rental = new Rental(vehicle, days, km, additionals);

        Console.WriteLine("\n🔹 Rental Summary 🔹");
        Console.WriteLine(rental);
    }
}