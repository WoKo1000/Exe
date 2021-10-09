//Rok jest przestępny, gdy jego numer dzieli się przez 4, ale nie dzieli się przez 100 lub gdy dzieli się przez 400.
using System;
					
public class LeapYear
{
	public static void Main()
	{
		Console.Write("Wprowadź rok do sprawdzenia: ");
		int year = int.Parse(Console.ReadLine());
		if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) 
   		Console.WriteLine(year + " jest rokiem przestępnym");
		else
    	Console.WriteLine(year + " nie jest rokiem przestępnym");
		
	}
}