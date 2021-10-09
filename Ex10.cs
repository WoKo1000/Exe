using System;

public class Trójkąt
	//Aby z trzech odcinków zbudować trójkąt, najdłuższy z nich musi być krótszy niż suma długość dwóch pozostałych.
{
	public static void Main()
	{
		int a = 40, b = 55, c = 65;
		if (c < (a + b))
		{
		Console.WriteLine("Można zbudować trójkąt");
		}
		else
		{
		Console.WriteLine("Nie da się z boków tej długości zbudować trójkąta");
		}
	}
}