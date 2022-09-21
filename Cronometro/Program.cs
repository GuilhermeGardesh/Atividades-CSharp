class Program
{
    static void Main(string[] args)
    {
        Menu();
    }


    static void Menu()
    {
        Console.WriteLine("s = segundo  =>  10s = 10 segundos");
        Console.WriteLine("m = minuto  =>  10m = 10 minutos");
        Console.WriteLine("0 = Sair");
        Console.Write("Digite o tempo que deseja cronometrar: ");

        string tempoEMedida = Console.ReadLine().ToLower(); //passando toda string para Lowercase
        char medida = char.Parse(tempoEMedida.Substring(tempoEMedida.Length - 1, 1)); //Segundo ou Minuto
        int tempo = int.Parse(tempoEMedida.Substring(0, tempoEMedida.Length - 1));  //Número de tempo
        int multiplicador = 1;
        if (tempo == 0)
        {
            System.Environment.Exit(0);
        }

        if (medida != 'm' && medida != 's')
        {
            Console.WriteLine("A medida de tempo está digitada incorretamente, Tente novamente.");
            Menu();
        }

        if (medida == 'm')
        {
            multiplicador = 60;
        }

        Start(tempo * multiplicador);


    }
    static void Start(int tempo)
    {
        int currentTime = 0;

        while (currentTime != tempo)
        {

            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime + "s");
            Thread.Sleep(1000);
        }
        Console.Clear();
        Console.WriteLine("Tempo finalizado!");
        Thread.Sleep(2500);

        Menu();
    }
}