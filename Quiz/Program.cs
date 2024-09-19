



using System.Globalization;
using System.Numerics;

int score = 0;
Console.WriteLine("Hej! Välkommen till denna frågesport, vad heter du?");
Console.Write("Svar: ");
string name = Console.ReadLine();
Console.WriteLine($"Vad kul att du kunde komma hit, käraste {name}!");
Console.WriteLine("Jag tänker att vi kör på direkt! Vad tycker du om det?");
Console.WriteLine("Möjligheter: Bra, Dåligt");
Console.Write("Svar: ");
string answer = Console.ReadLine();
if (answer == "Bra") 
{
    Console.WriteLine("Jätte kul, då börjar vi med första frågran.");
}

else 
{
    Console.WriteLine("Jag bryr mig inte, vi kör ändå.");
}

Console.WriteLine("Först frågan, Vad är Sveriges huvudstad?");
Console.Write("Svar:");
string answer2 = Console.ReadLine();
if (answer2.ToLower() == "stockholm")
{
    Console.WriteLine("Gratulationer, du kan vårt lands vackra huvudstad! Denna fråga är värd 2 poäng.");
    score += 2;
}
else {
    Console.WriteLine("Tyvärr är det fel, inga poäng denna gång.");
}

Console.WriteLine("Andra frågan, Vad är Norges hucudstad?");
Console.Write("Svar:");
string answer3 = Console.ReadLine();
if (answer3.ToLower() == "oslo")
{
    Console.WriteLine("Korrekt, dock tror jag att vi alla kan vara eniga om att det egetligen borde vara Stockholm!");
    score += 2;
}
else {
    Console.WriteLine("Bättre lycka nästa gång, inga poäng denna gång.");
}

Console.WriteLine("Tredje och sista frågan för ikväll, Vad är Tysklands huvudstad?");
Console.Write("Svar:");
string answer4 = Console.ReadLine();
if (answer4.ToLower() == "berlin")
{
    Console.WriteLine("Ja, den staden är helt klart en turist attraktion utan tvekan.");
    score += 2;
}
else {
    Console.WriteLine("Fel denna gång.");
}

Console.WriteLine($"Det var allt för denna kväll. Käraste {name}, Du fick totalt {score} poäng!");

if  (score == 2)
{
   Console.WriteLine("Du svarade rätt på 1 fråga, inte helt hemskt.");
}

if  (score == 4)
{
   Console.WriteLine("Du svarade rätt på 2 frågor, stabilt!.");
}

if  (score == 6)
{
   Console.WriteLine("Du svarade rätt på alla 3 frågor, inte så konstigt med tanke på att huvudstäderna är väl kända bland folk.");
}

if  (score == 0)
{
   Console.WriteLine($"Du är en besvikelse för din familj, {score} är extremt pinsamt!");
}

Console.ReadLine();