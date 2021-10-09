using System;
					
public class Hight
{
	public static void Main()
	{
		string a = "krasnoludem";
		string b = "niewysoki";
		string c = "średni";
		string d = "wysoki";
		string e = "gigantem";
		Console.Write("Podaj swój wzrost w cm: ");
		int hight = int.Parse(Console.ReadLine());
		{
			if (hight>0 && hight<141)
			{
				Console.WriteLine("Jesteś " + a);
			}
				else if (hight>140 && hight<165)
				{
				Console.WriteLine("Jesteś " + b);
				}
				else if (hight>164 && hight<176)
				{
				Console.WriteLine("Jesteś " + c);
				}
				else if (hight>175 && hight<196)
				{
				Console.WriteLine("Jesteś " + d);
				}
				else
				{
					Console.WriteLine("Jesteś " + e);
				}
		
		}	
	
		
	}
		
}		