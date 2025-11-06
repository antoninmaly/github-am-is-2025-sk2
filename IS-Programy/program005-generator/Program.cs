using Microsoft.Win32.SafeHandles;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*********************************************************");
    Console.WriteLine("*********** Generátor pseudonáhodných čísel *************");
    Console.WriteLine("*********************************************************");
    Console.WriteLine("*********************************************************");
    Console.WriteLine("********************* Antonín Malý **********************");
    Console.WriteLine("********************** 6.11.2025 ************************");
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

    //kladná, záporná nebo nuly
    int negativeNumbers = 0;
    int positiveNumbers = 0;
    int zeros = 0;

    //sudá nebo lichá
    int evenNumbers = 0;
    int oddNumbers = 0;

    Console.WriteLine();
    Console.WriteLine("Náhodná čísla: ");
    for (int i = 0; i < n; i++)
    {
        myRandomNumbers[i] = myRandomNumber.Next(lb, ub + 1);
        Console.Write("{0};", myRandomNumbers[i]);

        /*
        if (myRandomNumber[i] > 0)
            positiveNumbers++;
        if (myRandomNumber[i] < 0)
            negativeNumbers++;
        if (myRandomNumber[i] == 0)
            zeros++;
        */

        if (myRandomNumbers[i] > 0)
            positiveNumbers++;
        else if (myRandomNumbers[i] < 0)
            negativeNumbers++;
        else zeros++;


        if (myRandomNumbers[i] % 2 == 0)
            evenNumbers++;
        else oddNumbers++;
    }

    Console.WriteLine();
    Console.WriteLine("===============================================");
    Console.WriteLine("===============================================");
    Console.WriteLine($"Počet kladných: {positiveNumbers}");
    Console.WriteLine($"Počet záporných: {negativeNumbers}");
    Console.WriteLine($"Počet nul: {zeros}");
    Console.WriteLine("===============================================");
    Console.WriteLine("===============================================");
    Console.WriteLine($"Počet sudých: {evenNumbers}");
    Console.WriteLine($"Počet lichých: {oddNumbers}");
    Console.WriteLine("===============================================");
    Console.WriteLine("===============================================");
    

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}                                                   