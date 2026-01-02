using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Security.Authentication.ExtendedProtection;
using Microsoft.Win32.SafeHandles;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*********************************************************");
    Console.WriteLine("****************** Kombinovaná úloha ********************");
    Console.WriteLine("*********************************************************");
    Console.WriteLine("*********************************************************");
    Console.WriteLine("********************* Antonín Malý **********************");
    Console.WriteLine("********************** 11.12.2025 ***********************");
    Console.WriteLine("*********************************************************");
    Console.WriteLine("*********************************************************");
    Console.WriteLine();

    Console.Write("Zadejte počet generovanýxh čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu: ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lb; // Dolní mez, lowerbound
    while (!int.TryParse(Console.ReadLine(), out lb))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int ub; // Horní mez, upperbound
    while (!int.TryParse(Console.ReadLine(), out ub))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
    }


    Console.WriteLine();
    Console.WriteLine("==================================================");
    Console.WriteLine("Zadané hodnoty");
    Console.WriteLine($"Počet čísel: {n}, Dolní mez: {lb}, Horní mez:{ub}");
    Console.WriteLine("==================================================");
    Console.WriteLine();

    //deklarace pole(array)
    int[] myRandomNumbers = new int[n];

    //příprava pro využití třídy Random
    Random myRandomNumber = new Random();
    //Random myRandomNumber = new Random(15); //pořád generuje stejný čísla při stejných hodnotách

    Console.WriteLine();
    Console.WriteLine("Náhodná čísla: ");
    for(int i = 0;i < n; i++)
    {
        myRandomNumbers[i] = myRandomNumber.Next(lb, ub+1);
        Console.Write("{0};", myRandomNumbers[i]);
    }
    Console.WriteLine();

    //max, min
    int max = myRandomNumbers[0];
    int min = myRandomNumbers[0];

    for (int i = 1; i < n; i++)
    {
        if(myRandomNumbers[i] > max)
        {
            max = myRandomNumbers[i];
        }

        if (myRandomNumbers[i] < min)
        {
            min = myRandomNumbers[i];
        }
    }

    Console.WriteLine();
    Console.Write($"Maximum: {max}, všechny pozice maxima: ");

    for(int i = 0; i < n; i++)
    {
        if(myRandomNumbers[i] == max)
        {
            Console.Write($"{i};");
        }
    }
    Console.WriteLine();
    Console.Write($"Minimum: {min}, všechny pozice minima: ");

     for(int i = 0; i < n; i++)
    {
        if(myRandomNumbers[i] == min)
        {
            Console.Write($"{i};");
        }
    }
    Console.WriteLine();

    //selection sort, bubble sort, insertion sort
    /*selection sort:

    for (int i = 0; i < n - 1; i++)
    {
        int indexMinima = i;

        for (int j = i + 1; j < n; j++)
        {
            if (myRandomNumbers[j] < myRandomNumbers[indexMinima])
            {
                indexMinima = j;
            }
        }

        int docasnaPromenna = myRandomNumbers[indexMinima];
        myRandomNumbers[indexMinima] = myRandomNumbers[i];
        myRandomNumbers[i] = docasnaPromenna;

    }

    Console.WriteLine();
    Console.WriteLine("=============================================================");
    Console.WriteLine("Seřazená čísla pomocí Selection sortu: ");
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{myRandomNumbers[i]}; ");
    }
    Console.WriteLine();*/

    //bubble sort:
    /*
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        
            if (myRandomNumbers[j] > myRandomNumbers[j + 1])
            {
                int docasnaPromenna = myRandomNumbers[j];
                myRandomNumbers[j] = myRandomNumbers[j+1];
                myRandomNumbers[j+1] = docasnaPromenna;
            }
    }

    Console.WriteLine();
    Console.WriteLine("========================================");
    Console.WriteLine("Seřazená čísla pomocí Bubble sortu: ");
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{myRandomNumbers[i]}; ");
    }
    Console.WriteLine();*/

    //insertion sort
    for (int i = 0; i < n; i++)
    {
        int key = myRandomNumbers[i];
        int j = i - 1;

        while (j >= 0 && myRandomNumbers[j] < key )
        {
            myRandomNumbers[j + 1] = myRandomNumbers[j];
            j = j - 1;
        }

        myRandomNumbers[j + 1] = key;
    }

    Console.WriteLine();
    Console.WriteLine("===========================================================");
    Console.WriteLine("Seřazená čísla pomocí Insertion sortu: ");
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{myRandomNumbers[i]}; ");
    }
    Console.WriteLine();

    //druhé, třetí a čtvrté největší číslo

    int secMax = 0;
    int thirdMax = 0;
    int fourthMax = 0;
    int nalezeneHodnoty = 1;

    for (int i = 1; i < n; i++)
    {
        if (myRandomNumbers[i] < max && nalezeneHodnoty == 1)
        {
            secMax = myRandomNumbers[i];
            nalezeneHodnoty = 2;
        }
        else if (myRandomNumbers[i] < secMax && nalezeneHodnoty == 2)
        {
            thirdMax = myRandomNumbers[i];
            nalezeneHodnoty = 3;
        }
        else if (myRandomNumbers[i] < thirdMax && nalezeneHodnoty == 3)
        {
            fourthMax = myRandomNumbers[i];
            nalezeneHodnoty = 4;
            break;
        }
    }

    Console.WriteLine();
    Console.WriteLine("===========================================================");
    Console.WriteLine($"Druhý největší prvek: {secMax}");
    Console.WriteLine($"Třetí největší prvek: {thirdMax}");
    Console.WriteLine($"Čtvrtý největší prvek: {fourthMax}");
    Console.WriteLine();

    //medián
    double median;

    if (n % 2 != 0)
    {
        median = myRandomNumbers[n/2];
    }
    else
    {
        int stred1 = myRandomNumbers[(n/2) - 1];
        int stred2 = myRandomNumbers[n/2];
        median = (stred1 + stred2)/2.0;
    }

    Console.WriteLine();
    Console.WriteLine("===========================================================");
    Console.WriteLine($"Medián čísel je: {median}");
    Console.WriteLine();
    Console.WriteLine("===========================================================");
    

    //převod do binární soustavy čtvrtého největšího čísla
    int cisloProPrevod = fourthMax; 
    int[] binarniPole = new int[32];
    int k = 0;

    if (cisloProPrevod < 0) 
    {
        cisloProPrevod = -cisloProPrevod;
    }

    if (cisloProPrevod == 0)
    {
        Console.WriteLine("Binární podoba čísla: 0");
    }
    else
    {
        while (cisloProPrevod > 0)
        {
            binarniPole[k] = cisloProPrevod % 2;
            cisloProPrevod = cisloProPrevod / 2;
            k++;
        }
        Console.Write("Binární podoba čtvtého nejvyššího čísla: ");
        for (int j = k - 1; j >= 0; j--)
        {
            Console.Write(binarniPole[j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("======================================");
    Console.WriteLine();
    
    //obrazec, výška - medián, šířka - třetí nejvyšší číslo
    int sirka = thirdMax;
    int vyska = (int)median;

    if (sirka < 5 || vyska < 5)
    {
        Console.WriteLine("Pokud výška nebo šířka bude menší než 5, tak obrazec nelze vykreslit.");
    }
    else
    {
        for (int i = 0; i < vyska; i++)
        {
            if (i < 2 || i >= vyska - 2)
            {
                for (int j = 0; j < sirka; j++)
                {
                    if (j < 2 || j >= sirka - 2)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                for (int j = 0; j < sirka; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine();
    
    //obrazec, výška - medián, šířka - třetí nejvyšší číslo
    int sirka2 = (int)median;
    int vyska2 = thirdMax;
    if (sirka2 < 5 || vyska2 < 5)
    {
        Console.WriteLine("Pokud výška nebo šířka bude menší než 5, tak obrazec nelze vykreslit.");
    }
    else
    {
        for (int i = 0; i < vyska2; i++)
        {
            if (i < 2 || i >= vyska2 - 2)
            {
                for (int j = 0; j < sirka2; j++)
                {
                    if (j < 2 || j >= sirka2 - 2)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                for (int j = 0; j < sirka2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}