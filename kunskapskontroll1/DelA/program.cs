// En lista med namn List<string>

using Microsoft.VisualBasic;

List<string> names = ["Mjölk", "Bröd", "Ost", "Flingor"];

// En lista med priser List<int> - där samma index hör ihop (names[i] kostar prices[i]).

List<int> prices = [15, 32, 89, 25];


// Programmet snurrar i en loop som hela tiden visar listan, totalsumman och ber användaren om input.
// att använda string[] instructions = [] snodde jag iden från föreläsnignen isätllet för flera Console.WriteLine.

string[] instructions = [
    "Varulistan:!",
    "",
    "* Lägg till en vara i listan genom att skriva namn och sedan pris: ",
    "* Ta bort varan från listan genom att skriva dens numer.",
    ""

];
Console.Clear();
Console.WriteLine(string.Join("\n", instructions));

// Loopen börjar med att lista upp våran lista som vi redan förberett så den är ej tom från början.
while(true)
{
    int totalSum = 0;
    for(int i = 0; i < names.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {names[i]} - {prices[i]}kr");
        totalSum += prices[i];
    }
    Console.WriteLine($"Totalt: {totalSum} kr");
    // kollar av om listan skulle vara tom så får vi ett meddelande tillbaka.
    if(names.Count == 0)
    {
     Console.WriteLine("Du har inga varor i listan än!");
    }
     // input från användaren, Ta bort, lägga till vara med både namn och sedan pris
    Console.WriteLine("");
    Console.Write("\nLägg till / Ta bort: ");
    string? input = Console.ReadLine(); 

    if (int.TryParse(input, out int inputAsNumber))
    {
    // Vi kan ta bort vara samt priset (memo; ändra så att man tar bort både vara och pris samtidigt och inte var för sig):
        if (inputAsNumber > 0 && inputAsNumber <= names.Count)
        {
            int indexToRemove = inputAsNumber - 1;
            names.RemoveAt(indexToRemove);
            prices.RemoveAt(indexToRemove);
        }
        else
        {
            Console.WriteLine("Det finns ingen vara med det numret!");
        }
    }
    else
    {
        // Här får vi input i form av namn och pris.
        Console.Write($"Ange pris för {input} i kr: ");
        string? priceInput = Console.ReadLine();

        if (int.TryParse(priceInput, out int price))
        {
            names.Add(input!);
            prices.Add(price);
            Console.WriteLine($"{input} lades till {price} kr!");
        }
        // Vi har även en else sats som berättar om talet/priset är giltligt.
        else
        {
            Console.WriteLine("Ogiltigt pris! Varan lades inte till.");
        }
    }
}