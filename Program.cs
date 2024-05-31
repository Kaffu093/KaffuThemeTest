namespace KaffuThemeTest;

public static class Program
{
	private static void Main()
	{
		// Greet the user
		Console.WriteLine($"Hello {Environment.UserName}! Welcome to the calculator.");

		// Ask the user to input two numbers
		Console.Write("Enter the first number: ");
		decimal num1;
		try
		{
			num1 = Convert.ToDecimal(Console.ReadLine());
		}
		catch (FormatException)
		{
			Console.WriteLine("Invalid input. Please enter a valid decimal number.");
			return;
		}

		Console.Write("Enter the second number: ");
		decimal num2;
		try
		{
			num2 = Convert.ToDecimal(Console.ReadLine());
		}
		catch (FormatException)
		{
			Console.WriteLine("Invalid input. Please enter a valid decimal number.");
			return;
		}

		// Ask the user to select an operation
		Console.WriteLine("Select an operation:");
		Console.WriteLine("\t1. Add");
		Console.WriteLine("\t2. Subtract");
		Console.WriteLine("\t3. Multiply");
		Console.WriteLine("\t4. Divide");

		byte option;
		try
		{
			option = Convert.ToByte(Console.ReadLine());
		}
		catch (FormatException)
		{
			Console.WriteLine("Invalid input. Please enter a valid option number.");
			return;
		}

		// Perform the selected operation and display the result
		switch (option)
		{
			case 1:
				Console.WriteLine($"The result of the addition is: {num1 + num2}");
				break;
			case 2:
				Console.WriteLine($"The result of the subtraction is: {num1 - num2}");
				break;
			case 3:
				Console.WriteLine($"The result of the multiplication is: {num1 * num2}");
				break;
			case 4:
				try
				{
					Console.WriteLine($"The result of the division is: {num1 / num2}");
				}
				catch (DivideByZeroException)
				{
					Console.WriteLine("Cannot divide by zero. Please enter a non-zero second number.");
					return;
				}
				break;
			default:
				Console.WriteLine("Invalid option");
				break;
		}

		// Wait for the user to press a key to exit
		Console.WriteLine("Press any key to exit...");
		Console.ReadKey();
	}
}
