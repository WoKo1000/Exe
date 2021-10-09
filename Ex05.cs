using System;
					
public class PassiveElectionLaw
{
	public static void Main()
	{
		int age;
		string a = "posłem";
		string b = "premierem";
		string c = "senatorem";
		string d = "prezydentem";
		Console.Write("Podaj swój wiek: ");
		string enterYourAge = Console.ReadLine(); //Dodałem deklarację wieku
		Int32.TryParse(enterYourAge, out age);
		
		{
			if (age>20 && age<30)
			{
				Console.WriteLine("Możesz zostać " + a +", a nawet " + b + ".");
			}
				else if (age>29 && age <35)
				{
				Console.WriteLine("Możesz zostać " + a + ", " + c + " i " + b + ".");
				}
				else if (age==35 || (age > 35 && age < 100))
				{
				Console.WriteLine("Możesz zostać " + d + ", " + a + ", " + c + " i " + b + ".");
				}
				else if (age > 99)
				{
				Console.WriteLine("Ludzie tak długo nie żyją XD");
				}
				else
				{
					if (21 - age == 1)
					Console.WriteLine("Do uzyskania biernego prawa wyborczego brakuje Ci roku.");
					else
					Console.WriteLine("Do uzyskania biernego prawa wyborczego brakuje Ci " + (21 - age) + " lat.");
				}
		
		}		
		
	}
}