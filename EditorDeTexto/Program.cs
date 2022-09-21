class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();

        int opcao = 0;

        System.Console.WriteLine("-----Editor de Texto-----");
        System.Console.WriteLine("1 - Abrir arquivo existente");
        System.Console.WriteLine("2 - Criar novo arquivo");
        System.Console.WriteLine("0 - Sair da aplicação");
        System.Console.WriteLine("Qual opção deseja: ");
        opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 0: System.Environment.Exit(0); break;
            case 1: Abrir(); break;
            case 2: Editar(); break;
            default: System.Console.WriteLine("Algo foi digitado incorretamente"); Menu(); break;
        }

    }

    static void Abrir()
    {
        Console.Clear();
        System.Console.Write("Qual o caminho do arquivo? ");
        var local = Console.ReadLine();

        using(var arquivo = new StreamReader(local))
        {
            string texto = arquivo.ReadToEnd();
            System.Console.WriteLine(texto);
        }
        System.Console.WriteLine("\nEnter para seguir para o Menu...");
        Console.ReadLine();
        Menu();
    }

    static void Editar()
    {
        Console.Clear();

        System.Console.WriteLine("Digite seu texto (Esc para sair)");
        System.Console.WriteLine("----------------------------------------------------------------");
        string textoUsuario = "";

        do
        {
            textoUsuario += Console.ReadLine();
            textoUsuario += Environment.NewLine;
        }
        while (Console.ReadKey().Key != ConsoleKey.Escape);

        Salvar(textoUsuario);
    }

    static void Salvar(string texto)
    {
        Console.Clear();

        System.Console.Write("Qual caminho para salvar o arquivo? ");
        var local = Console.ReadLine();

        System.Console.Write("Qual o nome do arquivo? ");
        local += "/" + Console.ReadLine() + ".txt";

        using (var arquivo = new StreamWriter(local))
        {
            arquivo.Write(texto);
        }

        System.Console.WriteLine("Arquivo " + (local) + " salvo com Sucesso!");
        Thread.Sleep(2000);
        Menu();
    }
}