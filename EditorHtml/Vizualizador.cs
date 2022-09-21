using System.Text.RegularExpressions;

namespace EditorHtml
{
    public static class Visualizador
    {
        public static void Mostar(string texto)
        {
            Console.Clear();
            System.Console.WriteLine("MODO DE VISUALIZAÇÃO");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            System.Console.WriteLine("--------------------");
            Substituir(texto);
            System.Console.WriteLine("--------------------");
            Console.ReadKey();
            Menu.Exibir();
        }

        public static void Substituir(string texto)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var palavras = texto.Split(' ');

            for (int i = 0; i < palavras.Length; i++)
            {
                if (strong.IsMatch(palavras[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    System.Console.Write(

                        palavras[i].Substring(

                        palavras[i].IndexOf('>') + 1,
                    ((palavras[i].LastIndexOf('<') - 1) - palavras[i].IndexOf('>'))
                    )
                    );

                    System.Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.Write(palavras[i]);
                    System.Console.Write(" ");
                }
            }
        }
    }
}