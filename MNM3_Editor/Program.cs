internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("O que você deseja fazer? ");
        Console.WriteLine("1 - Abrir arquivo.");
        Console.WriteLine("2 - Criar novo arquivo.");
        Console.WriteLine("0 - Sair.");

        string input = Console.ReadLine();
        if (input != null)
        {
            short option = short.Parse(input);

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Edit(); break;
                default: Menu(); break;
            }
        }
        else
        {
            // Tratar caso em que a entrada é nula
            Console.WriteLine("Entrada inválida. Por favor, tente novamente.");
            Menu();
        }
    }

    static void Open()
    {
        Console.Clear();
        Console.WriteLine("Digite o caminho do arquivo que você deseja abrir:");
        string path = Console.ReadLine();

        using(var file = new StreamReader(path))
        {
            string text = file.ReadToEnd();
            Console.WriteLine(text);
        }
    }

    static void Edit()
    {
        Console.Clear();
        Console.WriteLine("Digite seu texto abaixo. (ESC para sair)");
        Console.WriteLine("_________________");

        string text = "";

        do
        { 
            text += Console.ReadLine() + "\n";
            // text += Environment.NewLine;
        }
        while (Console.ReadKey().Key != ConsoleKey.Escape);

        Save(text);
    }

    static void Save(string text)
    {
        Console.Clear();
        Console.WriteLine("Onde você quer salvar o arquivo?");
        var path = Console.ReadLine();

        using(var file = new StreamWriter(path))
        {
            file.Write(text);
        }

        Console.WriteLine($"Arquivo {path} salvo com sucesso!");
        Menu();
    }
}
