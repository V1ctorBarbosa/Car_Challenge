namespace CarChallenge.Models.Vehicles;

public class Car : Vehicle
{
    public Car()
    {
        Name = "Car";
        DailyRate = 50m;
        CostPerKilometer = 0.50m;
    }
    public override decimal CalculateRentalCost(int days, decimal kilometers)
    {
        return days * DailyRate + kilometers * CostPerKilometer;
    }
}