using System;
using System.Collections.Generic;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*PERSON*/
            //Person person = new Person();
            List<Person> persons = new List<Person>();
            PersonHandler personHandler = new PersonHandler();
            Person person1 = personHandler.CreatePerson(20, "Anna", "A", 170, 60);
            Person person2 = personHandler.CreatePerson(25, "John", "J", 180, 80);

            persons.Add(person1);
            persons.Add(person2);

            Console.WriteLine("*************************PERSONS INFO*************************");
            WritePersonsInfoToConsole(persons);

            personHandler.SetAge(person1, 70);
            personHandler.SetAge(person2, 75);

            Console.WriteLine("\nAfter calling SetAge Method:");
            WritePersonsInfoToConsole(persons);

            /*ANIMAL*/
            List<Animal> animals = new List<Animal>();
            Horse horse = new Horse(true, "Horsii", 100, 8);
            Dog dog = new Dog(true, "Doggii", 20, 5);
            Hedgehog hedgehog = new Hedgehog(120, "Hedgehogii", 2, 1.5);
            Bird bird = new Bird(40, "Birdii", 3, 4);
            Pelican pelican = new Pelican(true, 60, "Pelicanii", 6, 2.5);
            Flamingo flamingo = new Flamingo("White", 65, "Flamingoii", 5, 6);
            Swan swan = new Swan("Yellow", 50, "Swanii", 2.5, 1);

            animals.Add(horse);
            animals.Add(dog);
            animals.Add(hedgehog);
            animals.Add(bird);
            animals.Add(pelican);
            animals.Add(flamingo);
            animals.Add(swan);

            Console.WriteLine("\n*************************ANIMALS NAMES*************************");
            WriteAnimalsNameToConsole(animals);

            Console.WriteLine("\n\n*************************ANIMALS INFO*************************");
            WriteAnimalsInfoToConsole(animals);

            /*Dog*/
            List<Dog> dogs = new List<Dog>();
            // below commented code does not work because of not appropriate type 
            // dogs.Add(horse);  

            Console.WriteLine("\n*************************DOG SPEAKS*************************");
            WriteDogsSpeakToConsole(animals);

            Console.WriteLine("\n*************************USER ERROR*************************");
            var userErrors = new List<UserError>();
            NumericInputError numericInputError = new NumericInputError();
            TextInputError textInputError = new TextInputError();
           
            userErrors.Add(numericInputError);
            userErrors.Add(textInputError);
            
            foreach (UserError userError in userErrors)
                Console.WriteLine(userError.UEMessage());
        }

        static void WritePersonsInfoToConsole(List<Person> pers)
        {
            foreach (Person person in pers)
                Console.WriteLine(person);
        }
        static void WriteAnimalsNameToConsole(List<Animal> anims)
        {
            foreach (Animal animal in anims)
                Console.Write(animal.Name + "  ");
        }
        static void WriteAnimalsInfoToConsole(List<Animal> anims)
        {
            foreach (Animal animal in anims)
                Console.WriteLine(animal.Stats());
        }
        static void WriteDogsSpeakToConsole(List<Animal> anims)
        {
            foreach (Animal animal in anims)
                if (animal is Dog ddd)
                {
                    //var d = (Dog)animal;
                    //var dd = animal as Dog;
                    Console.WriteLine(ddd.Speak());
                }

        }
    }
}
