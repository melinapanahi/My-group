Console.WriteLine("1. Addition \n2. Subtraktion \n3. Multiplikation \n4. Divition \n5. Potens");

Console.WriteLine("Välj din beräkningssätt");
int? val = int.TryParse(Console.ReadLine(), out int val1) ? val1 : null;

Console.WriteLine("Ange första talet/ täljare / bas (om du väljer potens)");
int? ftal = int.TryParse(Console.ReadLine(), out int ftalet)? ftalet : null;

Console.WriteLine("Ange andra talet/ nämnare / potens (om du väljer potens)");
int? stal = int.TryParse(Console.ReadLine(), out int stalet)? stalet : null;

Calculator numbers = new(){ tal1 = ftalet , tal2 = stalet};

switch (val)
{
    case 1 : Console.WriteLine($"{ftalet} + {stalet} = {numbers.Addition()}");
    break;
    case 2 : Console.WriteLine($"{ftalet} - {stalet} = {numbers.Subtraktion()}");
    break;
    case 3 : Console.WriteLine($"{ftalet} * {stalet} = {numbers.Multiplikation()}");
    break;
    case 4 : Console.WriteLine($"{ftalet} / {stalet} = {numbers.Divition()}");
    break;
    case 5 : Console.WriteLine($"{ftalet} ^ {stalet} = {numbers.Potens()}");
    break;

    default : Console.WriteLine("Fel val");
    break;
    
}




class Calculator
{
    public int tal1{get;set;}
    public int tal2 {get;set;}

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
        if (tal2 == 0)
        {
            Console.WriteLine("Det är inte tillåtet att dividera med 0");
            return 0;
        }

        return (double)tal1 / tal2;
    }

    public double Potens()
    {
        return Math.Pow(tal1,tal2);
    }
}