using System;

public enum oceny //Wykorzystanie typu wyliczeniowego 'enum'
		{
			niedostateczny = 1, //Zmiana indexu na odpowiadający kolejności ocen
			dopuszczający,
			dostateczny,
			dobry,
			bardzoDobry,
			celujący
		}

public class Oceny

{
	
	public static void Main()
	{
		
		Console.Write("Podaj ocenę w wartości liczbowej: ");
		int ocenaNum = Convert.ToInt32(Console.ReadLine());
		oceny ocena = (oceny)ocenaNum;
		if (ocenaNum < 1 || ocenaNum > 6)
			Console.WriteLine("Nie ma takiej oceny, spróbuj ponownie.");
		else
		Console.WriteLine(ocena);
		
	}
			
		
		
}