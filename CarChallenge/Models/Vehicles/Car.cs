namespace CarChallenge.Models.Vehicles;

public class Car : Vehicle
{
    public Car() : base("Car", 50m, 0.50m) { }

    public override decimal CalculateRentalCost(int days, decimal kilometers)
    {
        return (days * DailyRate) + (kilometers * CostPerKilometer);
    }
}