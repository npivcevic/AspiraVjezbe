﻿namespace EF_02
{
    internal class Person
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public int Age { get; set; }

        public string City { get; set; } = "";

        public string Address { get; set; } = "";

        public void Print()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Age: {Age}, City: {City}, Address: {Address}");
        }
    }
}
