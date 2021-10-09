using System;

public class Matura
{
	public static void Main()
	{
		int mat = 80;
		int fiz = 71;
		int chem = 0;
		if (mat > 70 && fiz > 55 && chem > 45 && (mat + fiz + chem > 180))
		{
			Console.WriteLine("Kandydat dopuszczony do rekrutacji na podstawie warunku nr 1");
		}	
			else if (mat + fiz > 150 || mat + chem > 150 || fiz + chem > 150)
			{
			Console.WriteLine("Kandydat dopuszczony do rekrutacji na podstawie warunku nr 2");
			}
			
	}
}