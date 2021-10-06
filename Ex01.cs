//Zadanie nr 1:
// Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie. Dane testowe: a : 5 b : 5 
//Rezultat w terminalu : 5 i 5 są równe
using System;					
public class Rowne
{
	public static void Main()
	{
		int a =5;
        int b = 5;
            
           		 if (a == b)
            		Console.WriteLine(a + " i " + b + " są równe");
               	 else
                	Console.WriteLine(a + " i " + b + " nie są równe");
		
	}
}