using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using Microsoft.Win32.SafeHandles;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Seřazení dvou čísel ************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Antonín Malý *****************");
    Console.WriteLine("************** 23.10.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    //PRVNÍ BLOK vývojáku, algoritmizace učebníce str. 33
    Console.Write("Zadejte celé číslo A: ");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo znova A: ");
    }

    Console.Write("Zadejte celé číslo B: ");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo znova B: ");
    }

    Console.WriteLine();

    //DRUHÝ BLOK

    int pom;    
    //Chceme seřadit čísla vsestupně
    if(a > b)
    {
        pom = a;
        a = b;
        b = pom;
        Console.WriteLine("Došlo k prohození proměnných");
    }

    //TŘETÍ BLOK
    Console.WriteLine("=========================================");
    Console.WriteLine($"Seřazená čísla: {a}, {b}"); //bez dolaru by nefungovalo (alt + ů)
    Console.WriteLine("=========================================");
    

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}                                                   