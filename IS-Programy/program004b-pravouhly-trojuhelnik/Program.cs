using Microsoft.Win32.SafeHandles;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*** Vykreslení pravoúhlého trojúhelníka ****");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Antonín Malý *****************");
    Console.WriteLine("************** 5.11.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

     {

        int velikost;

        // Zadání jedné kladné hodnoty
        while (true)
        {
            Console.Write("Zadej velikost trojúhelníku (kladné celé číslo): ");
            if (int.TryParse(Console.ReadLine(), out velikost) && velikost > 0)
                break;
            Console.WriteLine("Neplatný vstup, zadej prosím kladné celé číslo.");
        }

        // Vykreslení trojúhelníku
        Console.WriteLine();
        Console.WriteLine();
        for (int i = 1; i <= velikost; i++)
        {
            Console.WriteLine(new string('*', i));
        }
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}                                                   