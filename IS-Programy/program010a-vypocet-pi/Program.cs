using Microsoft.Win32.SafeHandles;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("***** Konvergentní řady - výpočet Pí *******");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Antonín Malý *****************");
    Console.WriteLine("************** 4.12.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Zadejte přesnost (reálné číslo - čím menší, tím větší přesnost): ");
    double presnost;
    while (!double.TryParse(Console.ReadLine(), out presnost))
    {
        Console.Write("Nezadali jste reálné číslo. Zadejte přesnost znovu: ");
    }

    double i = 1;
    double piCtvrt = 1;
    double znamenko = 1;
    double pi;

    while (1/i>=presnost)
    {
        i = i+2;
        znamenko = - znamenko;
        piCtvrt = piCtvrt + znamenko (*1/i);
    }

   
    pi = 4*piCtvrt;
    Console.WriteLine();
    Console.WriteLine($"Hodnota Pí je: {pi}");








    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}                                                   