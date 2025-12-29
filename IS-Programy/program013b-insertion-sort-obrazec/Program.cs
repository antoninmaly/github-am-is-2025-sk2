using Microsoft.Win32.SafeHandles;
using System.Diagnostics;
using System.Net.Mime;


string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************************************");
    Console.WriteLine("*************** Insertion sort - obrazec **************");
    Console.WriteLine("*******************************************************");
    Console.WriteLine("*******************************************************");
    Console.WriteLine("****************** Antonín Malý ***********************");
    Console.WriteLine("******************* 29.12.2025 ************************");
    Console.WriteLine("*******************************************************");
    Console.WriteLine("*******************************************************");
    Console.WriteLine();

    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
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
    while (!int.TryParse(Console.ReadLine(), out ub) || ub < lb)
    {
        Console.Write($"Nezadali jste celé číslo nebo číslo je menší než {lb}. Zadejte horní mez znovu: ");
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
    myStopwatch.Stop();

    int max = myRandomNumbers[0];
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
            break;
        }   
    }

    double soucet = 0;

    for (int i = 0; i < n; i++)
    {
        soucet = soucet + myRandomNumbers[i]; 
    }

    double prumer = soucet / n;

    Console.WriteLine();
    Console.WriteLine("===============================");
    Console.WriteLine("Seřazené pole: ");
    for(int i = 0; i < n; i++)
    {
        Console.Write("{0};", myRandomNumbers[i]);
    }
    Console.WriteLine();

    Console.WriteLine();
    Console.WriteLine($"Čas seřazení čísel pomocí IS: {myStopwatch.Elapsed}");
    Console.WriteLine();
    Console.WriteLine($"Čtvrté největší číslo je: {fourthMax}");
    Console.WriteLine($"Průměr všech čísel: {prumer}");
    Console.WriteLine();
    
    if ((int)prumer == 0)
    {
        Console.WriteLine("Pokud je průměr nula, obrazec se nevykreslí.");
    }
    //dutý pravoúhlý trojúhleník
    if (prumer < 0)
    {
        prumer = -prumer;
    }

    if (fourthMax < 0)
    {
        fourthMax = -fourthMax;
    }
    
    int sirka = fourthMax;
    int vyska = (int)prumer;

    for (int i = 0; i < vyska; i++)
    {
        for (int j = 0; j < sirka; j++)
        {
            if (i == 0 || i == vyska - 1 ||     
                j == 0 || j == sirka - 1 ||    
                i == j ||                    
                i + j == sirka - 1)       
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}