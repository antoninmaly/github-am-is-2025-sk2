using Microsoft.Win32.SafeHandles;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("********** Vykreselení obrazce N ***********");
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
            Console.Write("Zadej velikost výšky obrazce N (kladné celé číslo > 3): ");
            if (int.TryParse(Console.ReadLine(), out velikost) && velikost > 3)
                break;
            Console.WriteLine("Neplatný vstup, zadej prosím kladné celé číslo > 3 znovu.");
        }

        // Vykreslení obrazce N
        Console.WriteLine();
        Console.WriteLine();
        for (int i = 0; i < velikost; i++)
        {
            for (int j = 0; j < velikost; j++)
            {
                if (j == 0 || j == velikost - 1 || j == i)
                Console.Write("*");
                else
                Console.Write(" ");
            }
    Console.WriteLine();
        }   
    }


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}                                                   