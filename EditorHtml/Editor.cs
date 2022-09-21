using System.Text;


namespace EditorHtml
{
    public static class Editor
    {
        public static void Mostrar()
        {
            Console.Clear();
            System.Console.WriteLine("MODO EDITOR");
            System.Console.WriteLine("------------");
            Start();
        }

        public static void Start()
        {
            var arquivo = new StringBuilder();

            do
            {
                arquivo.Append(Console.ReadLine());
                arquivo.Append(Environment.NewLine);

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            System.Console.WriteLine(" Deseja salvar? ");
            Visualizador.Mostar(arquivo.ToString());
        }

    }
}