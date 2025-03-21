using CarChallenge.Models.Vehicles;
using CarChallenge.Models.Additionals;
using CarChallenge.Models.Rental;

class Program
{
    static void Main()
    {
        // Criando um carro e escolhendo adicionais
        Car myCar = new Car();
        List<Additional> carAdditionals = new List<Additional>
        {
            new Additional(AdditionalType.GPS, myCar),
            new Additional(AdditionalType.CarSeat, myCar)
        };

        // Criando o aluguel do carro
        Rental carRental = new Rental(myCar, 3, 200, carAdditionals);
        Console.WriteLine(carRental);

        Console.WriteLine("\n---------------------\n");

        // Criando um MotorHome e escolhendo adicionais
        MotorHome myMotorHome = new MotorHome();
        List<Additional> motorHomeAdditionals = new List<Additional>
        {
            new Additional(AdditionalType.GPS, myMotorHome),
            new Additional(AdditionalType.Refrigerator, myMotorHome)
        };

        // Criando o aluguel do MotorHome
        Rental motorHomeRental = new Rental(myMotorHome, 2, 850, motorHomeAdditionals);
        Console.WriteLine(motorHomeRental);
    }
}