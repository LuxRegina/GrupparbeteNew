using System;

namespace AddressList
{
    using Microsoft.VisualBasic;
    using System.IO;
    using System.Security.Cryptography;
    using System.Xml;


    internal class Program
    {
        public class Person
        {
            private string name { get; set; }
            public string phoneNR { get; set; }
            public string adress { get; set; }

            public Person(string Name, string PhoneNR, string Adress)
            {
                name = Name;
                phoneNR = PhoneNR;
                adress = Adress;
            }

            public void Print()
            {
                Console.WriteLine();
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


                Console.Write("Ange ett kommando: ");
                command = Console.ReadLine();
                if (command == "HJÄLP")
                {
                    Console.WriteLine($"Tyvärr ej implementerat!");
                }
                else if (command == "sluta")
                {

                }

                else if (command == "load")
                {
                    string[] text = File.ReadAllLines("Adresser.txt");


                    foreach (var line in text)
                    {

                        string[] personDataArray = line.Split(',');

                        string name = personDataArray[0];
                        string phoneNR = personDataArray[1];
                        string adress = personDataArray[2];

                        Person person = new Person(name, phoneNR, adress);

                        personList.Add(person);

                    }

                }

                else if (command == "list")
                {

                    foreach (Person person in personList)
                    {
                        person.Print();
                    }

                }

                else if (command == "add")
                {
                    Console.WriteLine("Lägg till ett namn: ");
                    string newInputName = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Lägg till ett telefonnr: ");
                    string newInputphoneNr = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Lägg till adress: ");
                    string newInputAdress = Console.ReadLine();

                    string name = newInputName;
                    string phoneNR = newInputphoneNr;
                    string adress = newInputAdress;

                    Person person = new Person(name, phoneNR, adress);

                    personList.Add(person);





                    String personString = $"{newInputName}, {newInputphoneNr}, {newInputAdress}";
                    //StreamWriter save = new StreamWriter("Adresser.txt", true);

                    using (StreamWriter writer = new StreamWriter(Adresser.txt, true)) ;
                    {
                        writer.WriteLine(personString);
                        //File.AppendText(${name})
                    }
                }



                else if (command == "save")
                {

                }


            } while (command != "sluta");
            Console.WriteLine("HEJ DÅ!");



        }
    }
}