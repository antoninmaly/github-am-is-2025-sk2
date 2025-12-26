using System.Drawing;
using Microsoft.Win32.SafeHandles;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("=========================================");
    Console.WriteLine("===== FOTBALOVÝ PENALTOVÝ ROZSTŘEL ======");
    Console.WriteLine("=========================================");
    Console.WriteLine();
    Console.WriteLine("V této hře máte za úkol vstřelit co nejvíce gólů z 5-ti penalt.");
    Console.WriteLine();

    Random numbs = new Random();
    int pocetKol = 5;
    int skore = 0;

    for (int i = 0; i < pocetKol; i++)
    {
        Console.WriteLine($"{i + 1}. PENALTA    Kam vystřelíš? (1 - Vlevo | 0 - Doprostřed | 2 - Vpravo)");
        Console.WriteLine();
        
        int hracStrelba;
        while (!int.TryParse(Console.ReadLine(), out hracStrelba)|| hracStrelba < 0 || hracStrelba > 2)
        {
        Console.Write("Nezadali jste jedno z čísel 1, 0, 2. Zkuste to znovu: ");
        }
        
        int brankarSkok = numbs.Next(0, 3); 
        Console.WriteLine("Rozbíháš se...");
        Thread.Sleep(1000);
        Console.WriteLine();

        if (hracStrelba == brankarSkok)
        {
            Console.WriteLine("BRANKÁŘ TO CHYTIL!");
        }
        else
        {
            skore++;
            int nahodnaHlaska = numbs.Next(1, 3);
            
            if (hracStrelba == 0)
            {
                Console.WriteLine("GÓÓÓL! Brankář to nevydržel a skočil.");
            }
            else
            {
                if(nahodnaHlaska == 1)
                {
                    Console.WriteLine("GÓÓÓL! Brankář skočil na druhou stranu.");
                }
                else
                {
                    Console.WriteLine("GÓÓÓL! Brankář zůstal stát uprostřed.");
                }
            }
        }
        Console.WriteLine();
    }

    Console.WriteLine("=== KONEC PENALT ===");
    Console.WriteLine($"Celkové skóre: {skore} / {pocetKol}");
    Console.WriteLine();

    Console.WriteLine();
    Console.WriteLine("Pokud si chcete zahrát znovu - stiskněte klávesu a");
    again = Console.ReadLine();

}                                                   