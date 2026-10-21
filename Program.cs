class Program
{
    static void Main()
    {
        List<string> berakningar = new List<string>
        {
            "Addition (+)",
            "Subtraktion (-)",
            "Multiplikation (*)",
            "Division (/)"
        };

        Console.WriteLine("MINIRÄKNARE");

        for (int i = 0; i < berakningar.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {berakningar[i]}");
        }

        Console.Write("Välj beräkning (1-4): ");
        int val = int.TryParse(Console.ReadLine(), out int parsedVal) ? parsedVal : 0;

        Console.Write("Ange första talet: ");
        double tal1 = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

        Console.Write("Ange andra talet: ");
        double tal2 = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

        if (val == 1)
        {
            Console.WriteLine($"Resultat: {tal1 + tal2}");
        }
        else if (val == 2)
        {
            Console.WriteLine($"Resultat: {tal1 - tal2}");
        }
        else if (val == 3)
        {
            Console.WriteLine($"Resultat: {tal1 * tal2}");
        }
        else if (val == 4)
        {
            if (tal2 != 0)
            {
                Console.WriteLine($"Resultat: {tal1 / tal2}");
            }
            else
            {
                Console.WriteLine("Du kan inte dividera med noll!");
            }
        }
        else
        {
            Console.WriteLine("Ogiltigt val!");
        }
    }
}