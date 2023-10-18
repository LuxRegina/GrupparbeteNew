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
                string[] text = File.ReadAllLines("Adresser.txt");
                List<string> personList = text.ToList();

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
                                     
                    foreach (string line in personList)
                    {
                        line.Split(",");
                        Console.WriteLine(line);
                    }
                    
                }
                                
                else if (command == "list")
                {
                    
                    for (int i = 0; i< personList.Count; i++)
                    {
                        Console.WriteLine(i);
                    }
                                     
                                     
                }

            } while (command != "sluta");
            Console.WriteLine("HEJ DÅ!");



        }
    }
}