using klasac;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            IKlasa klasa = new Klasa();
            klasa.Test("Dziala OK");
        }
    }
}
