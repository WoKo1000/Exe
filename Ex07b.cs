using System;
using System.Collections.Generic; //Alternatywny kod przy użyciu kolekcji 'list'

public class MinMax
{
	public static void Main()
	{
		Console.Write("Podaj pierwszą liczbę całkowitą: ");
		int no1 = Int32.Parse(Console.ReadLine());
		Console.Write("Podaj drugą liczbę całkowitą: ");
		int no2 = Int32.Parse(Console.ReadLine());
		Console.Write("Podaj pierwszą trzecią całkowitą: ");
		int no3 = Int32.Parse(Console.ReadLine());
		
		var numbers = new List <int> { no1, no2, no3};

		numbers.Sort();
		numbers.Reverse();
		Console.WriteLine("Największa liczba to " + numbers[0]); //Kod zwraca pierwszą liczbę z posortwanej malejąco listy
	}
}