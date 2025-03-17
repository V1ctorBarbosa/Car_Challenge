namespace CarChallenge.Models.Vehicles;

public class MotorHome : Vehicle
{
    public MotorHome()
    {
        Name = "MotorHome";
        DailyRate = 300m;
        CostPerKilometer = 0.65m;
    }
    public override decimal CalculateRentalCost(int days, decimal kilometers)
    {
        return days * DailyRate + kilometers * CostPerKilometer;
    }
}