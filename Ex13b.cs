//Wersja z instrukcją ‘if’
using System;

public class Calc

{
	
	public static void Main()
	{
		Console.WriteLine("Podaj pierwszą liczbę:");
		float pierwsza = float.Parse(Console.ReadLine());
		Console.WriteLine("Podaj drugą liczbę:");
		float druga = float.Parse(Console.ReadLine());
		Console.WriteLine("Podaj numer operacji do wykonania: \n 1. dodawanie \n 2. odejmowanie \n 3. mnożenie \n 4. dzielenie");
		int kalkulacja = int.Parse(Console.ReadLine());
		
		if (kalkulacja == 1)
		{
			Console.WriteLine("Wynik dodawania to: " + (pierwsza + druga));
		}
		else if (kalkulacja == 2)
		{
		Console.WriteLine("Wynik odejmowania to: " + (pierwsza - druga));
		}
		else if (kalkulacja == 3)
		{
		Console.WriteLine("Wynik mnożenia to: " + (pierwsza * druga));
		}
		else if (kalkulacja == 4)
		{
		Console.WriteLine("Wynik dzielenia to: " + (pierwsza / druga));
		}
			
		else
			Console.WriteLine("Wprowadziłeś błędne dane, spróbuj jeszcze raz");
				
		}
	
	}