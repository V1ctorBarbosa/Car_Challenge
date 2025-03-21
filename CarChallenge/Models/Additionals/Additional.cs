namespace CarChallenge.Models.Additionals;
using CarChallenge.Models.Vehicles; // Para acessar Car, MotorHome e Vehicle

public class Additional
{
    public AdditionalType Type { get; }  
    public decimal Cost { get; }  

    public Additional(AdditionalType type, Vehicle vehicle)
    {
        Type = type;
        Cost = GetCostByVehicleAndType(vehicle, type);
    }

    private static decimal GetCostByVehicleAndType(Vehicle vehicle, AdditionalType type)
    {
        if (vehicle is Car)
        {
            return type switch
            {
                AdditionalType.GPS => 25m,
                AdditionalType.CarSeat => 65m,
                _ => 0m
            };
        }
        if (vehicle is MotorHome)
        {
            return type switch
            {
                AdditionalType.GPS => 35m,
                AdditionalType.CarSeat => 75m,
                AdditionalType.Refrigerator => 250m,
                _ => 0m
            };
        }

        return 0m;
    }

    public override string ToString()
    {
        return $"{Type}: R$ {Cost:F2}";
    }
}