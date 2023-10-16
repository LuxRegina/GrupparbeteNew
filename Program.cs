using System;

namespace AddressList
{
    using System.IO;
    internal class Program
    {
        public class Person
        {
            private string name;
            public string phoneNR, adress;

            public Person(string Name)
            {
                name = Name;
            }

            public void Print()
            {
                Console.WriteLine($"Namn: {name},\n    Telefonnummer: {phoneNR}, \n    Adress: {adress}");
            }

        }

        static List<Person> personList = new List<Person>(); 

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
                else if (command == "load")
                {
                    string[] text = File.ReadAllLines("Adresser.txt");
                    foreach(string str in text)
                    {
                        str.Split(",");
                    }
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