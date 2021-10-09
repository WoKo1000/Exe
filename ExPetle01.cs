using System;

public class Program
{
    public static void Main()
    {
int zlicz = 0;
for (int liczba = 2; liczba <10; liczba++)
            {
                
                for (int dzielnik = 1; dzielnik < 10; dzielnik++)
                {
                   bool a = (liczba != dzielnik) && (dzielnik != 0) && (liczba % 4 != 0) && (liczba % 6 != 0) && (liczba % 9 != 0);
                   if (a == true)
                    {
                        Console.WriteLine(liczba);
                        zlicz++;
                        break;
                    }
                }
                
     
            }

            for (int liczba2 = 11; liczba2 <100; liczba2++)
            {
                
                for (int dzielnik2 = 1; dzielnik2 < 10; dzielnik2++)
                {
                   bool a2 = (liczba2 != dzielnik2) && (liczba2 % 2 != 0) && (dzielnik2 != 0) && (liczba2 % 3 != 0) && (liczba2 % 5 != 0) && (liczba2 % 7 != 0) && (liczba2 % 9 != 0);
                   if (a2 == true)
                    {
                        Console.WriteLine(liczba2);
                        zlicz++;
                        break;
                    }
                }
                
                
            }
               Console.WriteLine ("\nLiczb pierwszych w zakresie 0 - 100 jest: " + zlicz);
    }
}