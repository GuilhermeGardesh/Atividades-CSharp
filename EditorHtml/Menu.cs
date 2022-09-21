namespace EditorHtml
{
    public static class Menu
    {
        public static void Exibir()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            DesenhoDeTela();
            Opçcoes();
            var opcao = int.Parse(Console.ReadLine());
            ManipulacaoDeOpcao(opcao);

        }

        public static void Opçcoes()
        {
            Console.SetCursorPosition(2, 1);
            System.Console.WriteLine("Editor Html");
            Console.SetCursorPosition(2, 2);
            System.Console.WriteLine("================");
            Console.SetCursorPosition(2, 3);
            System.Console.WriteLine("Selecione uma opção");
            Console.SetCursorPosition(2, 5);
            System.Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(2, 6);
            System.Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(2, 7);
            System.Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(2, 9);
            System.Console.Write("Opção: ");
        }


        public static void DesenhoDeTela()
        {
            MargemSuperiorInferior();
            MargemLateral();
            MargemSuperiorInferior();
        }
        public static void MargemSuperiorInferior()
        {
            System.Console.Write("+");
            for (int linha = 0; linha < 30; linha++)
            {
                System.Console.Write("-");
            }
            System.Console.Write("+");
            System.Console.WriteLine();


        }
        public static void MargemLateral()
        {
            for (int i = 0; i < 10; i++)
            {
                System.Console.Write("|");

                for (int coluna = 0; coluna < 30; coluna++)
                {
                    System.Console.Write(" ");
                }

                System.Console.WriteLine("|");
            }
        }

        public static void ManipulacaoDeOpcao(int opcao)
        {
            switch (opcao)
            {
                case 1: Editor.Mostrar(); break;
                case 2: ; break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0); break;
                    }
                default: Exibir(); break;
            }
        }

    }
}