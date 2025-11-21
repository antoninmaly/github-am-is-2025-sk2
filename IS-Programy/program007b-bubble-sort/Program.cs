using Microsoft.Win32.SafeHandles;
using System.Diagnostics;


string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*********************************************************");
    Console.WriteLine("******************** Bubble Sort ************************");
    Console.WriteLine("*********************************************************");
    Console.WriteLine("*********************************************************");
    Console.WriteLine("******************** Antonín Malý ***********************");
    Console.WriteLine("********************* 20.11.2025 ************************");
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

    Stopwatch myStopwatch = new Stopwatch();

    int compare = 0; // počet porovnávání
    int change = 0; // počet výměn


    myStopwatch.Start();
    for(int i=0; i < n - 1 ; i++)
    {
        // tento cyklus musí zajistit porovnávání dvou sousedních hodnot
        // musí dále zajistit, aby se zmenšoval počet porovnávaných hodnot
        for(int j = 0; j < n - i - 1 ; j++)
            if(myRandomNumbers[j] < myRandomNumbers[j+1])
            {
                int tmp = myRandomNumbers[j+1];
                myRandomNumbers[j+1] = myRandomNumbers[j];
                myRandomNumbers[j] = tmp;
                change++;
            }
            compare++;
    }
    myStopwatch.Stop();

    for (int i = 0; i < n; i++)
    int max = myRandomNumbers[i];
    int smax = myRandomNumbers[i+1];
    {
        
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
    Console.WriteLine($"Počet porovnávání: {compare}");
    Console.WriteLine($"Počet výměn: {change}");
    Console.WriteLine();
    Console.WriteLine($"Čas seřazení čísel pomocí BS: {myStopwatch.Elapsed}");
    


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}                                                   