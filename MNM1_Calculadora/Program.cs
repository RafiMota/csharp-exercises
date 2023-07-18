class Program
{
    static void Main(string[] args)
    {
        Menu();
    }
    
    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("Qual operação você deseja fazer?");
        Console.WriteLine("1 - soma");
        Console.WriteLine("2 - subtracao");
        Console.WriteLine("3 - divisao");
        Console.WriteLine("4 - multiplicacao");

        Console.WriteLine("_________________");
        Console.WriteLine("");

        string escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1" or "soma":
                Soma();
                break;

            case "2" or  "subtracao":
                Subtracao();
                break;

            case "3" or "divisao":
                Divisao();
                break;

            case "4" or "multiplicacao":
                Multiplicacao();
                break;

            default:
                break;
        }
    }

    static void Soma()
    {
        Console.Clear();

        Console.Write("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.Write("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.Write(v1 + v2);
    }

    static void Subtracao()
    {
        Console.Clear();

        Console.Write("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.Write("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.Write(v1 - v2);
    }

    static void Divisao()
    {
        Console.Clear();

        Console.Write("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.Write("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.Write(v1 / v2);
    }

    static void Multiplicacao()
    {
        Console.Clear();

        Console.Write("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.Write("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.Write(v1 * v2);
    }
}