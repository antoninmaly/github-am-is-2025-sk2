using Microsoft.Win32.SafeHandles;

string again = "a";
while (again == "a")
{
    Console.Clear();
    // Metoda pro výpis hlavičky/razítka
    razitko();
    ulong a = nactiCislo("Zadejte přirozené číslo a: ");
    ulong b = nactiCislo("Zadejte přirozené číslo b: ");

    ulong nsd = vypocitatNSD(a,b);
    ulong nsn = vypocitatNSN(a,b,nsd);



    zobrazitVysledky(a, b, nsd, nsn);


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}                                                   


static void razitko()
{
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Výpočet NSD a NSN **************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Antonín Malý *****************");
    Console.WriteLine("************** 11.12.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();
}


static ulong nactiCislo(string zprava)
{
    Console.Write(zprava);
    ulong cislo;
    while (!ulong.TryParse(Console.ReadLine(), out cislo))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte přirozené číslo znovu: ");
    }

    return cislo;
}

static ulong vypocitatNSD(ulong a, ulong b)
{
    while(a != b )
    {
        if (a > b)
            a = a - b;
        else
            b = b - a;
    }

    return a;
}


static void zobrazitVysledky(ulong a, ulong b, ulong nsd, ulong nsn)
{
    Console.WriteLine();
    Console.WriteLine("==================================");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"NSD čísel {a} a {b} je {nsd}");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("----------------------------------");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"NSN čísel {a} a {b} je {nsn}");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("==================================");
    Console.ForegroundColor = ConsoleColor.White;
}

static ulong vypocitatNSN(ulong a, ulong b, ulong nsn)
{   
    return (a*b)/nsn;
}