using Microsoft.Win32.SafeHandles;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("**************************************");
    Console.WriteLine("********** Vykreselení hada **********");
    Console.WriteLine("**************************************");
    Console.WriteLine("**************************************");
    Console.WriteLine("************ Antonín Malý ************");
    Console.WriteLine("************* 26.12.2025 *************");
    Console.WriteLine("**************************************");
    Console.WriteLine("**************************************");
    Console.WriteLine();

    int n;
    while (true)
    {
        Console.Write("Zadejte velikost: ");
        if (int.TryParse(Console.ReadLine(), out n) && n > 0)
            break;
        Console.WriteLine("Neplatný vstup, zadejte velikost znovu.");
    }

    for (int i = 0; i < n; i++)
    {
        if (i % 2 == 0)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        if (i % 4 == 1)
        {
            for (int j = 0; j < n-1; j++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            Console.WriteLine();
        }
        if (i % 4 == 3)
        {
            Console.Write("*");
            Console.WriteLine();
        }
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}                                                   