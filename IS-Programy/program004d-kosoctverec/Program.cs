using System.Security.Cryptography;
using Microsoft.Win32.SafeHandles;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("********** Vykreslení kosočtverce **********");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Antonín Malý *****************");
    Console.WriteLine("************** 26.12.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Zadejte velikost: ");
     int n;
     while (true)
        {
            Console.Write("Zadej velikost kosočtverce (kladné celé číslo): ");
            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                break;
            Console.WriteLine("Neplatný vstup, zadej prosím kladné celé číslo.");
            Console.WriteLine();
        }
   
    int stred = n/2;
    Console.WriteLine();

    for (int i = 0; i <= stred; i++)
    {
        for (int j = 0; j < stred - i; j++)
        {
            Console.Write(" ");
        }
        Console.Write("*");
        if (i > 0)
        {
            for (int j = 0; j < (2 * i - 1); j++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
        }
        Console.WriteLine();
    }
    
    for (int i = stred - 1; i >= 0; i--)
    {
        for (int j = 0; j < stred - i; j++)
        {
            Console.Write(" ");
        }
        Console.Write("*");

        if (i > 0)
        {
            for (int j = 0; j < (2 * i - 1); j++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
        }

        Console.WriteLine();
    }


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}                                                   