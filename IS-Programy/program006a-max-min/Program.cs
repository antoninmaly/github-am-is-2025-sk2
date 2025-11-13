using Microsoft.Win32.SafeHandles;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*********************************************************");
    Console.WriteLine("********** Maximum, minimum, vykreslení obrazce *********");
    Console.WriteLine("*********************************************************");
    Console.WriteLine("*********************************************************");
    Console.WriteLine("********************* Antonín Malý **********************");
    Console.WriteLine("********************** 13.11.2025 ***********************");
    Console.WriteLine("*********************************************************");
    Console.WriteLine("*********************************************************");
    Console.WriteLine();

    Console.Write("Zadejte počet generovanýxh čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu: ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lb; // Dolní mez, lowerbound
    while (!int.TryParse(Console.ReadLine(), out lb))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int ub; // Horní mez, upperbound
    while (!int.TryParse(Console.ReadLine(), out ub))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
    }


    Console.WriteLine();
    Console.WriteLine("==================================================");
    Console.WriteLine("Zadané hodnoty");
    Console.WriteLine($"Počet čísel: {n}, Dolní mez: {lb}, Horní mez:{ub}");
    Console.WriteLine("==================================================");
    Console.WriteLine();

    //deklarace pole(array)
    int[] myRandomNumbers = new int[n];

    //příprava pro využití třídy Random
    Random myRandomNumber = new Random();
    //Random myRandomNumber = new Random(15); //pořád generuje stejný čísla při stejných hodnotách

    Console.WriteLine();
    Console.WriteLine("Náhodná čísla: ");
    for (int i = 0;i < n; i++)
    {
        myRandomNumbers[i] = myRandomNumber.Next(lb, ub+1);
        Console.Write("{0};", myRandomNumbers[i]);
    }
    Console.WriteLine();

    // Hledání maxima, pozice maxima, minima, pozice minima
    int max = myRandomNumbers[0];
    int min = myRandomNumbers[0];
    int posMax = 0;
    int posMin = 0;

    for (int i = 1; i < n; i++)
    {
        if (myRandomNumbers[i] > max)
        {
            max = myRandomNumbers[i];
            posMax = i;
        }

        if (myRandomNumbers[i] < min)
        {
            min = myRandomNumbers[i];
            posMin = i;
        }

    }

    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"Maximum: {max}");
    Console.WriteLine($"Pozice maxima: {posMax}");
    Console.WriteLine($"Minimum: {min}");
    Console.WriteLine($"Pozice minima: {posMin}");
    Console.WriteLine("====================================");
    Console.WriteLine();

    // Vykreslování přesýpacích hodin

    if (max >= 3)
    {
        Console.WriteLine("================================");
        Console.WriteLine();
        Console.WriteLine($"Přesýpací hodiny o velikosti: {max}");
        Console.WriteLine();

        // Tento cyklus se stará o to, aby se vykreslil správný počet řádků
        for (int i = 0; i < max; i++)
        {
            int spaces, stars;

            if (i < max / 2)
            {
                // horní polovina - počet mezer v i-tém řádku (pouze zleva)
                spaces = i;

                // horní polovina - s každým dalším řádkem ubývají 2 hvězdičky (po jedná z každé řady)
                stars = max - 2 * i;

                // 10 - 2.0 = 1O
                // 10 - 2.1 = 8
                // 10 - 2.2 = 6
            }
            else
            {
                // dolní polovina - počet mezer v i-tém řádku (pouze zleva)
                spaces = max - i - 1;
                if (max % 2 == 1)
                {
                    stars = 2 * (i - max / 2) + 1;
                }
                else
                {
                    stars = 2 * (i - max / 2) + 2;
                }
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            // vykreslení správného počtu mezer pro každý řádek
            for (int sp = 0; sp < spaces; sp++)
                Console.Write(" ");

            // vykreslení správného počtu hvězdiček pro každý řádek
            for (int st = 0; st < stars; st++)
                Console.Write("*");

            Console.WriteLine();
        }
        Console.ResetColor();

    }
    else
    {
        Console.WriteLine("Maximum je menší než 3 => obrazec nelze vykreslit!");
    }


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}                                                   