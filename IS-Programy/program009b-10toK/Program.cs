using Microsoft.Win32.SafeHandles;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("*************** Převod z desítkové do jiné soustavy ***********************");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("**************************** Antonín Malý *********************************");
    Console.WriteLine("***************************** 26.12.2025 **********************************");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine();

    Console.Write("Zadejte desítkové číslo (přirozené číslo): ");
    uint number10;
    while (!uint.TryParse(Console.ReadLine(), out number10))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte přirozené číslo znovu: ");
    }

    Console.Write("Zadejte do jaké soustavy chcete udělat převod (menší než desítkové): ");
    uint numberX;
    while (!uint.TryParse(Console.ReadLine(), out numberX) || numberX <= 1)
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte přirozené číslo znovu: ");
    }
    Console.WriteLine();

    uint[] myArray = new uint[32]; 
    uint backupNumber10 = number10;
    uint zbytek;

    uint i;
    if (backupNumber10 == 0) 
    {
        Console.Write(0);
    }

    for(i = 0; number10 > 0 ; i++)
    {
        zbytek = number10 % numberX;
        number10 = (number10 - zbytek)/numberX;
        myArray[i] = zbytek;

        Console.WriteLine($"Celá část: {number10}; Zbytek: {zbytek} ");
    }

    Console.WriteLine();
    Console.WriteLine("=============================");
    Console.Write($"Desítkové číslo {backupNumber10} ve {numberX}-kové soustavě je ");
    for(int j = (int)i - 1; j>=0 ;j--)
    {
        Console.Write($"{myArray[j]}");
    }
    Console.WriteLine();


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}                                                   