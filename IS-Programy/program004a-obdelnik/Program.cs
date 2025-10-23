using Microsoft.Win32.SafeHandles;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Vykreslení obdélníku ***********");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Antonín Malý *****************");
    Console.WriteLine("************** 23.10.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Zadejte šířku obdélníka: ");
    int width;
    while (!int.TryParse(Console.ReadLine(), out width))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte šířku obdélníka znovu: ");
    }

    Console.Write("Zadejte výšku obdélníka: ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte výšku obdélníka znovu: ");
    }

    for (int i = 1; i <= height; i++) //i++ znamená, že se zvětšuje o 1
    {
        for (int j = 1; j <= width; j++)
        {
            Console.Write("* ");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(500)); //zpomalení programu, půl sekundy se bude vypisovat jeden znak
        }
        Console.WriteLine();
    } 

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}                                                   