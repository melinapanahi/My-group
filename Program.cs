// Lista för att spara beräkningshistorik
List<string> history = new List<string>();

bool running = true;

// Huvudmeny
while (running)
{
    Console.WriteLine("\n========== Miniräknare ==========");
    Console.WriteLine("1. Addition \n2. Subtraktion \n3. Multiplikation \n4. Divition \n5. Potens \n6. Visa historik \n0. Avsluta");

    int val = ReadInt("\nVälj alternativ: ");

    if (val >= 1 && val <= 5)
    {
        Calculate(val, history);
    }
    else if (val == 6)
    {
        ShowHistory(history);
    }
    else if (val == 0)
    {
        running = false;
        Console.WriteLine("Programmet avslutas. Hej då!");
    }
    else
    {
        Console.WriteLine("Ogiltigt val! Försǒk igen.");
    }
}

// Method 1: Kontrollera inmatning
static int ReadInt(string message)
{
    while (true)
    {
        Console.Write(message);
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Ogiltig inmatning! Ange ett heltal");
        }
    }
}

// Method 2: Utföra beräkning

static void Calculate(int val, List<string> history)
{
    int tal1 = ReadInt("\nAnge första talet: ");
    int tal2 = ReadInt("Ange andra talet: ");

    Calculator number = new Calculator()
    {
        tal1 = tal1,
        tal2 = tal2
    };

    double result = 0;
    string operation = "";

    switch (val)
    {
        case 1:
            result = number.Addition();
            operation = "+";
            break;

        case 2:
            result = number.Subtraktion();
            operation = "-";
            break;

        case 3:
            result = number.Multiplikation();
            operation = "*";
            break;

        case 4:
            if (tal2 == 0)
            {
                Console.WriteLine("Det går inte att dividera med 0!");
                return;
            }
            else
            {
                result = number.Divition();
                operation = "/";
            }
            break;
        
        case 5:
        if (tal1 == 0 && tal2 < 0)
            {
                Console.WriteLine("Beräkingen kan inte genomförs");
                return;
            } else {
                result = number.Potens();
                operation = "^";
                break;
            }
    }

    string calculation = $"{tal1} {operation} {tal2} = {result}";
    Console.WriteLine($"\nResultat: {calculation}");

    // Sparar beräkningen i listan
    history.Add(calculation);
}

// Method 3 : Visa historik

static void ShowHistory(List<string> history)
{
    Console.WriteLine("\n---------- HISTORIK ----------");

    if (history.Count == 0)
    {
        Console.WriteLine("Ingen historik finns ännu.");
    }
    else
    {
        foreach (string calculation in history)
        {
            Console.WriteLine(calculation);
        }
    }
}

// Klass: Calculator
class Calculator
{
    public int tal1 {get; set;}
    public int tal2 {get; set;}

    public double Addition()
    {
        return tal1 + tal2;
    }

    public double Subtraktion()
    {
        return tal1 -tal2;
    }

    public double Multiplikation()
    {
        return tal1 * tal2;
    }

    public double Divition()
    {
        return (double)tal1 / tal2;
    }

    public double Potens()
    {
        return Math.Pow(tal1,tal2);
    }
}