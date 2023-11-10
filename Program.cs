namespace Program;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World!");
        Random random = new();
        int years = random.Next(0, 100);

        if (years == 0)
        {
            Console.WriteLine($"See you tomorrow, {Environment.UserName}!");
        }
        else
        {
            Console.WriteLine($"See you in {years} years, {Environment.UserName}!");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
