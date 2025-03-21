namespace CarChallenge.Models.Rental;
using CarChallenge.Models.Additionals;
using CarChallenge.Models.Vehicles;

public class Rental
{
    public Vehicle Vehicle { get; } 
    public int Days { get; } 
    public decimal Kilometers { get; }  
    public List<Additional> Additionals { get; } 

    public Rental(Vehicle vehicle, int days, decimal kilometers, List<Additional> additionals)
    {
        Vehicle = vehicle;
        Days = days;
        Kilometers = kilometers;
        Additionals = additionals;
    }
    public decimal CalculateTotalCost()
    {
        decimal total = Vehicle.CalculateRentalCost(Days, Kilometers);
        total += Additionals.Sum(additional => additional.Cost);
        return total;
    }

    public override string ToString()
    {
        string additionalDetails = Additionals.Count > 0
            ? string.Join(", ", Additionals.Select(a => a.ToString()))
            : "Nenhum";

        return $"Tipo do Veículo: {Vehicle.Name}\n" +
               $"Quantidade de Diárias: {Days}\n" +
               $"Valor Total das Diárias: R$ {(Days * Vehicle.DailyRate):F2}\n" +
               $"Estimativa de Quilometragem: R$ {(Kilometers * Vehicle.CostPerKilometer):F2}\n" +
               $"Adicionais: {additionalDetails}\n" +
               $"Valor Total do Aluguel: R$ {CalculateTotalCost():F2}";
    }
}