namespace CarChallenge.Models.Vehicles;

public abstract class Vehicle
{
    public string Name { get; init; } 
    public decimal DailyRate { get; init; }
    public decimal CostPerKilometer { get; init; }

    protected Vehicle(string name, decimal dailyRate, decimal costPerKilometer)
    {
        Name = name;
        DailyRate = dailyRate;
        CostPerKilometer = costPerKilometer;
    }

    public abstract decimal CalculateRentalCost(int days, decimal kilometers);
}