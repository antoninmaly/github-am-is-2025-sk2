string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("************** Součet cifer ****************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Antonín Malý *****************");
    Console.WriteLine("************** 2.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    // Vstup hodnoty do programu, řešený lépe


    Console.Write("Zadejte číslo: ");
    string vstup = Console.ReadLine();

    int soucet = 0;

    foreach (char znak in vstup)
    {
        if (char.IsDigit(znak))
        {
            soucet += int.Parse(znak.ToString());
        }
    }

    Console.WriteLine("Součet cifer: " + soucet);

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}                                 
