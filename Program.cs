using System;

namespace MoreClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog roy = new Dog();
            roy.Name = "Roy";

            Console.WriteLine($"Name: {roy.Name}");
            string royString = roy.ToString();
            Console.WriteLine($"ToString of object: {royString}");
            Console.WriteLine($"Automatically calls ToString Method: {roy}");

        }
    }

    public class Dog : Animal
    {
        public string Name { get; set; }
        public override string ToString()
        {
            // Can't access Species if private in child class
            // If Protected you can
            Species = "Dog";
            return $"My Name is {Name}. I'm a {Species}.";
        }
    }

    public class Animal
    {
        protected string Species { get; set; }
    }
}