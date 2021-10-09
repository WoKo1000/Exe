using System;

public class Calc //Za pomocą instrukcji 'switch'

{
	
	public static void Main()
	{
		Console.WriteLine("Podaj pierwszą liczbę:");
		float pierwsza = float.Parse(Console.ReadLine());
		Console.WriteLine("Podaj drugą liczbę:");
		float druga = float.Parse(Console.ReadLine());
		Console.WriteLine("Podaj numer operacji do wykonania: \n 1. dodawanie \n 2. odejmowanie \n 3. mnożenie \n 4. dzielenie");
		int kalkulacja = int.Parse(Console.ReadLine());
		
		switch (kalkulacja)
		{
			case 1:
				Console.WriteLine("Wynik dodawania to: " + (pierwsza + druga));
				break;
			case 2:
				Console.WriteLine("Wynik odejmowania to: " + (pierwsza - druga));
				break;
			case 3:
				Console.WriteLine("Wynik mnożenia to: " + (pierwsza * druga));
				break;
			case 4:
				Console.WriteLine("Wynik dzielenia to: " + (pierwsza / druga));
				break;
			default:
				Console.WriteLine("Wprowadziłeś błędna dane, spróbuj jeszcze raz");
				break;
				
		}
	
	}
			
				
}