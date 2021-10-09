using System;

public class Max
{
	public static void Main()
	{
		Console.Write("Podaj pierwszą liczbę całkowitą: ");
		int no1 = Int32.Parse(Console.ReadLine());
		Console.Write("Podaj drugą liczbę całkowitą: ");
		int no2 = Int32.Parse(Console.ReadLine());
		Console.Write("Podaj pierwszą trzecią całkowitą: ");
		int no3 = Int32.Parse(Console.ReadLine());
		
		if (no1 > no2 && no1 > no3)
		Console.WriteLine(no1 + " jest największa z podanych.");
		else if (no2 > no1 && no2 > no3)
	    Console.WriteLine(no2 + " jest największa z podanych.");
	    else
	    Console.WriteLine(no3 + " jest największa z podanych.");
	    
	}
}