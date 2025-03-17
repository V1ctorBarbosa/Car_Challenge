namespace CarChallenge.Models.Vehicles;

public abstract class Vehicle
{
    public required string Name { get; set; }
    public required decimal DailyRate { get; set; }
    public required decimal CostPerKilometer { get; set; }
    public abstract decimal CalculateRentalCost(int days, decimal kilometers);
}