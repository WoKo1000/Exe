using System;

public class Oceny

{
	public static void Main()
	{
		Console.WriteLine("Podaj ocenę wyrażoną liczbowo: ");
		string ocenaNazwa = Console.ReadLine();
		if (ocenaNazwa == "1")
		{
		Console.WriteLine("Niedostateczny");
		}
		else if (ocenaNazwa == "2")
		{
		Console.WriteLine("Dopuszczający");
		}
		else if (ocenaNazwa == "3")
		{
		Console.WriteLine("Dostateczny");
		}
		else if (ocenaNazwa == "4")
		{
		Console.WriteLine("Dobry");
		}	
		else if (ocenaNazwa == "5")
		{
		Console.WriteLine("Bardzo dobry");
		}	
		else if (ocenaNazwa == "6")
		{
		Console.WriteLine("Celujący");
		}
		else
		{
		Console.WriteLine("Nie ma takiej oceny, spróbuj jeszcze raz");
		}
		
		
	}
}