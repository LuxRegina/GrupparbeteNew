using System;

namespace AddressList
{
    using System.IO;
    using System.Xml;

    internal class Program
    {
        public class Person
        {
            private string name {  get; set; }
            public string phoneNR {  get; set; }
            public string adress {  get; set; }

            public Person(string Name, string PhoneNR, string Adress)
            {
                name = Name;
                phoneNR = PhoneNR;
                adress = Adress;
            }

            public void Print()
            {
                Console.WriteLine($"Namn: {name},\n    Telefonnummer: {phoneNR}, \n    Adress: {adress}");
            }
            
        }


        static List<Person> personList = new List<Person>(); 
        static List<Person> splitList = new List<Person>();

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
                        
                        splitList = line.Split(",");
                        Console.WriteLine(line);
                        Person n = new Person();
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