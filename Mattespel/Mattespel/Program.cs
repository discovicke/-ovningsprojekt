// See https://aka.ms/new-console-template for more information

while (true)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine("VÄLKOMMEN TILL MARCUS MAGISKA MATTESPEL!");
    Console.ResetColor();
    Console.WriteLine("VÄLJ EN TABELL DU VILL TRÄNA PÅ\n");

    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("0: Nollans tabell");
    Console.ForegroundColor = ConsoleColor.Green;    Console.WriteLine("1: Ettans tabell");
    Console.ForegroundColor = ConsoleColor.Yellow;   Console.WriteLine("2: Tvåans tabell");
    Console.ForegroundColor = ConsoleColor.Blue;     Console.WriteLine("3: Treans tabell");
    Console.ForegroundColor = ConsoleColor.Cyan;     Console.WriteLine("4: Fyrans tabell");
    Console.ForegroundColor = ConsoleColor.Magenta;  Console.WriteLine("5: Femmans tabell");
    Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("6: Sexans tabell");
    Console.ForegroundColor = ConsoleColor.DarkGreen;Console.WriteLine("7: Sjuans tabell");
    Console.ForegroundColor = ConsoleColor.DarkRed;  Console.WriteLine("8: Åttans tabell");
    Console.ForegroundColor = ConsoleColor.DarkYellow;Console.WriteLine("9: Nians tabell");
    Console.ForegroundColor = ConsoleColor.Gray;     Console.WriteLine("10: Tians tabell");
    
    Console.ForegroundColor = ConsoleColor.DarkBlue; Console.WriteLine("A: Avsluta");
    Console.ResetColor();

    Console.Write("\nDitt val: \n");
    string val = Console.ReadLine().ToUpperInvariant();

    if (val == "A")
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Vad tråkigt att du vill säga hejdå, vi ses snart igen!");
        Console.ResetColor();
        return;
    }

    if (!int.TryParse(val, out int tabellNummer) || tabellNummer < 0 || tabellNummer > 10)
    {
        Console.WriteLine("Välj ett tal mellan 0–10 eller A för att avsluta.");
        Console.WriteLine("Tryck valfri tangent för att fortsätta...");
        Console.ReadKey(true);
        continue;
    }

    
    switch (val)
    {
        case "0":
        case "1":
        case "2":
        case "3":
        case "4":
        case "5":
        case "6":
        case "7":
        case "8":
        case "9":
        case "10":
            break;
        default:
            Console.WriteLine("Välj ett tal mellan 0–10 eller A för att avsluta.");
            Console.WriteLine("Tryck valfri tangent för att fortsätta...");
            Console.ReadKey(true);
            continue;
            tabellNummer = int.Parse(val);
    }

    int tio = 10;
    int antalRätt = 0;
    int antalFel = 0;
    for (int räknare = 0; räknare <= tio; räknare++)
    {
        int rättSvar = tabellNummer * räknare;
        int svar;


        while (true)
        {
            Console.Write($"Vad är {tabellNummer} * {räknare}? ");
            var s = Console.ReadLine();
            if (!int.TryParse(s, out svar))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;;
                Console.WriteLine("Skriv ett heltal tack.");
                Console.ResetColor();
                continue;
            }

            if (svar == rättSvar)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Rätt!");
                Console.ResetColor();
                antalRätt++;
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fel! Testa igen :)");
                Console.ResetColor();
                antalFel++;
            }
        }
    }
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\nKlar med tabellen!");
    Console.ResetColor();
    Console.Write("Du hade ");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(antalRätt);
    Console.ResetColor();
    Console.Write(" rätt och ");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write(antalFel);
    Console.ResetColor();
    Console.WriteLine(" fel.");
    Console.WriteLine("Tryck valfri tangent + Enter för att återgå till menyn eller A + Enter för att avsluta.");

    var avslut = Console.ReadLine().ToUpperInvariant();
    if (avslut == "A")
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Väl kämpat, vi ses igen någon annan gång! :)");
        Console.ResetColor();
        return;
    }
}