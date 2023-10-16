namespace AddressList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej och välkommen till adresslistan.");
            Console.WriteLine("Skriv 'hjälp' för hjälp!");
            string command;
            do
            {
                Console.Write("Ange ett namn: ");
                command = Console.ReadLine();
                if (command == "HJÄLP")
                {
                    Console.WriteLine($"Tyvärr ej implementerat!");
                }
                else if (command == "sluta")
                {

                }
                else
                {
                    Console.WriteLine($"Okänt kommando: {command}");
                }
            } while (command != "sluta");
            Console.WriteLine("HEJ DÅ!");
        }
    }
}