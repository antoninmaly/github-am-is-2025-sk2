using Microsoft.Win32.SafeHandles;
using System.Diagnostics;
using System.Net.Mime;


string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************************************");
    Console.WriteLine("*************** Selection sort - obrazec **************");
    Console.WriteLine("*******************************************************");
    Console.WriteLine("*******************************************************");
    Console.WriteLine("****************** Antonín Malý ***********************");
    Console.WriteLine("******************* 29.12.2025 ************************");
    Console.WriteLine("*******************************************************");
    Console.WriteLine("*******************************************************");
    Console.WriteLine();

    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
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

    Stopwatch myStopwatch = new Stopwatch();

    myStopwatch.Start();
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
    myStopwatch.Stop();

    int min = myRandomNumbers[0];
    int secMin = 0;
    int thirdMin = 0;
    int nalezeneHodnoty = 1;

    for (int i = 1; i < n; i++)
    {
        if (myRandomNumbers[i] > min && nalezeneHodnoty == 1)
        {
            secMin = myRandomNumbers[i];
            nalezeneHodnoty = 2;
        }
        else if (myRandomNumbers[i] > secMin && nalezeneHodnoty == 2)
        {
            thirdMin = myRandomNumbers[i];
            nalezeneHodnoty = 3;
            break;
        }
    }

    double median;

    if (n % 2 != 0)
    {
        median = myRandomNumbers[n/2];
    }
    else
    {
        int stred1 = myRandomNumbers[(n/2)-1];
        int stred2 = myRandomNumbers[n/2];
        median = (stred1 + stred2)/2.0;
    }

    Console.WriteLine();
    Console.WriteLine("===============================");
    Console.WriteLine("Seřazené pole: ");
    for(int i = 0; i < n; i++)
    {
        Console.Write("{0};", myRandomNumbers[i]);
    }
    Console.WriteLine();

    Console.WriteLine();
    Console.WriteLine($"Čas seřazení čísel pomocí SS: {myStopwatch.Elapsed}");
    Console.WriteLine();
    Console.WriteLine($"Třetí nejmenší číslo je: {thirdMin}");
    Console.WriteLine($"Medián hodnot v poli je: {median}");
    Console.WriteLine();
    
    if (median < 0)
    {
        median = - median;
    }
    
    if (thirdMin < 0)
    {
        thirdMin = - thirdMin;  
    }

    int vyska = thirdMin;
    int sirka = (int)median;

    for (int i = 0; i < vyska; i++)
    {
        for (int j = 0; j < sirka; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }

    for (int i = 0; i < vyska; i++)
    {
        for (int j = 0; j < sirka*2; j++)
        {
            if (j < sirka)
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


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}                                                   