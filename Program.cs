namespace Chronometer;

class Program{
    public static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("S = Segundo => 10s = 10 segundos");
        Console.WriteLine("M = Minutos => 10m = 10 minutos");
        Console.WriteLine("0 - Sair");

        string data = Console.ReadLine().ToLower();
        if(data == "0"){
            Console.WriteLine("Finalizando programa..");
            Thread.Sleep(1000);
            Console.Clear();
            Environment.Exit(0);     
        }

        char type = char.Parse(data.Substring(data.Length - 1, 1));
        int time = int.Parse(data[..^1]);
        int multiplier = 1;

        if(type == 'm')
            multiplier = 60;
        
        PreStart(time * multiplier);
    }

    static void PreStart(int time){
        Console.Clear();
        Console.WriteLine("Ready?");
        Thread.Sleep(1000);
        Console.WriteLine("Set..");
        Thread.Sleep(1000);
        Console.WriteLine("Go!");
        Thread.Sleep(500);
        Start(time);
    }

    static void Start(int tempo){
        var contador = 0;

        while(contador < tempo){
            Console.Clear();
            contador++;
            Console.WriteLine(contador);
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("Stopwatch finalizado");
        Thread.Sleep(2000);
        Menu();
    }
}
