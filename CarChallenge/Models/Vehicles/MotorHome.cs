namespace CarChallenge.Models.Vehicles;

public class MotorHome : Vehicle
{
    public MotorHome() : base("MotorHome", 300m, 0.65m) { }

    public override decimal CalculateRentalCost(int days, decimal kilometers)
    {
        return (days * DailyRate) + (kilometers * CostPerKilometer);
    }
}