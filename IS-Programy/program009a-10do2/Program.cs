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



    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}                                                   