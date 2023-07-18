internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Isso aqui é um cronômetro.");
        Console.Write("Informe o tempo que você quer contar: ");

        string data = Console.ReadLine().ToLower();
        int time = int.Parse(data.Substring(0, data.Length - 1));
        char type = char.Parse(data.Substring(data.Length - 1, 1));

        switch (type)
        {
            case 'm': PreStart(time * 60); break;
            case 's': PreStart(time); break;
            
            default: Menu(); break;
        }
    }

    static void PreStart(int time)
    {
        Console.Clear();
        Console.WriteLine("Ready...");

        Thread.Sleep(1000);
        Console.WriteLine("Set...");
        
        Thread.Sleep(1000);
        Console.WriteLine("Go!");
        Thread.Sleep(500);


        Start(time);
    }

    static void Start(int time)
    {
        int currentTime = 0;

        while (currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }

        Console.WriteLine("Cronômetro finalizado.");

    }
}