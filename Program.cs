using System;
using System.Collections.Generic;

namespace ConsoleAppLearning
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Human> persons = new List<Human>();
            persons.Add(new Human("Anna", "Liepa", 16, "Blue"));
            persons.Add(new Human("Bob", "Lopez", 25, "Brown"));
            persons.Add(new Human("Mikelis", "Johnson", 14, "Green"));
            persons.Add(new Human("Agnese", "Egle", 20, "Gray"));


            persons[0].Introduce(); // first person
            persons[1].Introduce(); // second person
            persons[2].Introduce(); // third person
            persons[3].Introduce();

            for(int i = 0; i < persons.Count; i++)
            {
                persons[i].Introduce();
            }

            foreach(var person in persons)
            {
                person.Introduce();
            }


            // bank account
            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(new BankAccount("Jenifer", 200, "EUR"));
            accounts[0].PrintInfo();
            accounts.Add(new BankAccount("Anna", 5000, "EUR"));
            accounts[1].PrintInfo();
            accounts.Add(new BankAccount("John", 2000, "EUR"));
            accounts[2].PrintInfo();

        }
    }


}
