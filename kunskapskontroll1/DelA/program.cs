// En lista med namn List<string>

using Microsoft.VisualBasic;

List<string> names = ["Mjölk", "Bröd", "Ost", "Flingor"];

// En lista med priser List<int> - där samma index hör ihop (names[i] kostar prices[i]).

List<int> prices = [15, 32, 89, 25];


// Programmet ska snurra i en loop som hela tiden visar listan, totalsumman och ber användaren om input.
/*Programmet ska hela tiden visa listan som en numrerad lista med totalsumma, t.ex.:
1. Mjölk - 15 kr
2. Bröd - 32 kr
3. Ost - 89 kr
Totalt: 136 kr
*/
int totalSum = 0;
for(int i = 0; i < names.Count; i++)
{
    Console.WriteLine($"{i + 1}. {names[i]} - {prices[i]}kr");
    totalSum += prices[i];
}
Console.WriteLine($"Totalt: {totalSum} kr");