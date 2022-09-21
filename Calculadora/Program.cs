class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        Console.WriteLine("-----------");
        Console.Write("Selecione: ");
        int selecao = int.Parse(Console.ReadLine());

        switch (selecao)
        {
            case 0: 
            Console.Clear(); 
            Console.WriteLine("Volte sempre!");  
            System.Environment.Exit(0);
            break;
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Multiplicacao(); break;
            case 4: Divisao(); break;
            default:
                Console.WriteLine("Algo está digitado incorretamente");
                Menu(); break;
        }
    }

    static void Soma()
    {
        double primeiroNumero = 0;
        double segundoNumero = 0;


        Console.Clear();
        Console.Write("Digite um numero: ");
        primeiroNumero = double.Parse(Console.ReadLine());
        Console.Write("Digite outro numero: ");
        segundoNumero = double.Parse(Console.ReadLine());

        Console.WriteLine("A soma entre os dois números é : " + (primeiroNumero + segundoNumero));
        Console.ReadKey();
        Menu();
    }
    static void Subtracao()
    {
        double primeiroNumero = 0;
        double segundoNumero = 0;


        Console.Clear();
        Console.Write("Digite um numero: ");
        primeiroNumero = double.Parse(Console.ReadLine());
        Console.Write("Digite outro numero: ");
        segundoNumero = double.Parse(Console.ReadLine());

        Console.WriteLine("A subtração entre os dois números é : " + (primeiroNumero - segundoNumero));
        Console.ReadKey();
        Menu();
    }

    static void Multiplicacao()
    {
        double primeiroNumero = 0;
        double segundoNumero = 0;


        Console.Clear();
        Console.Write("Digite um numero: ");
        primeiroNumero = double.Parse(Console.ReadLine());
        Console.Write("Digite outro numero: ");
        segundoNumero = double.Parse(Console.ReadLine());

        Console.WriteLine("A multiplicação entre os dois números é : " + (primeiroNumero * segundoNumero));
        Console.ReadKey();
        Menu();
    }

    static void Divisao()
    {
        double primeiroNumero = 0;
        double segundoNumero = 0;


        Console.Clear();
        Console.Write("Digite um numero: ");
        primeiroNumero = double.Parse(Console.ReadLine());
        Console.Write("Digite outro numero: ");
        segundoNumero = double.Parse(Console.ReadLine());

        Console.WriteLine("A divisão entre os dois números é : " + (primeiroNumero / segundoNumero));
        Console.ReadKey();
        Menu();
    }


}