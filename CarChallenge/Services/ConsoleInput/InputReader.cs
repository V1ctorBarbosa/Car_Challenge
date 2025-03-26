namespace CarChallenge.Services.ConsoleInput;

public static class InputReader
{
    public static int ReadInteger(string message)
    {
        while (true)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out int value) && value > 0)
                return value;

            Console.WriteLine("❌ Invalid input! Please enter a positive whole number.");
        }
    }

    public static decimal ReadDecimal(string message)
    {
        while (true)
        {
            Console.Write(message);
            if (decimal.TryParse(Console.ReadLine(), out decimal value) && value >= 0)
                return value;

            Console.WriteLine("❌ Invalid input! Please enter a positive decimal number.");
        }
    }
}