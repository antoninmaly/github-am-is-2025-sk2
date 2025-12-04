using Microsoft.Win32.SafeHandles;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("*********** Převod z desítkové do binární (dvojkové) soustavy *************");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("**************************** Antonín Malý *********************************");
    Console.WriteLine("***************************** 27.11.2025 **********************************");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine();

    Console.Write("Zadejte desítkové číslo (přirozené číslo): ");
    uint number10;
    while (!uint.TryParse(Console.ReadLine(), out number10))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte přirozené číslo znovu: ");
    }

    uint[] myArray = new uint[32]; //32 je počet buňek pro maximální hodnotu
    uint backupNumber10 = number10;
    uint zbytek;

    uint i;
    for(i = 0; number10 > 0 ; i++)
    {
        zbytek = number10 % 2;
        number10 = (number10 - zbytek)/2;
        myArray[i] = zbytek;

        Console.WriteLine($"Celá část: {number10}; Zbytek: {zbytek} ");
    }

    Console.WriteLine();
    Console.WriteLine("=============================");
    Console.WriteLine($"Desítkové číslo {backupNumber10} ve dvojkové soustavě je ");
    for(uint j = i - 1; j>=0 ;j--)
    {
        Console.Write($"{myArray[j]}");
    }






    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}                                                   