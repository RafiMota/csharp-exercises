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
        int time = int.Parse(Console.ReadLine());

        if (time != 0)
        {
            Start(time);
        }
        else
        {
            Menu();
        }
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