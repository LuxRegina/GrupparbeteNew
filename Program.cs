﻿namespace AddressList
{
    internal class Program
    {
        public class person
        {
            private string name;
            public string phoneNR, adress;

            public person(string Name)
            {
                name = Name;
            }

            public void print()
            {
                Console.WriteLine($"Namn: {name},\n    Telefonnummer: {phoneNR}, \n    Adress: {adress}");
            }

        }

        static List<person> personList = new List<person>(); 

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
                //Kommandot "arne" ska skriva ut arnes uppgifter.
                else if (command == "arne")
                {
                    string text = File.ReadAllText(C:\\adresslista.txt);
                    string[] lines = File.ReadAllLines(
                    Console.WriteLine(text);
                }
                else if(command == "berith")
                {
                    Console.WriteLine($"Okänt kommando: {command}");
                }
            } while (command != "sluta");
            Console.WriteLine("HEJ DÅ!");
        }
    }
}