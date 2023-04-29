

using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace HomeTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfNumbers = Enumerable.Range(1,100).ToList();
            foreach (var number in listOfNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            var listOfOddNumbers = listOfNumbers
                .Where (x => x % 2 == 1)
                .ToList();
            foreach (var number in listOfOddNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            var listOfSquares = listOfNumbers
                .Select (x => x * x)
                .ToList();
            foreach (var number in listOfSquares)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            var sumOfNumbers = listOfNumbers
                .Sum(x => x);           
            Console.WriteLine($"Sum: {sumOfNumbers}");

            var listOfPersons = new List<Person>()
            { 
                new Person(1, "Mark", 12),
                new Person(2, "Bob", 21),
                new Person(3, "Maria", 19),
                new Person(4, "Tom", 23),
                new Person(5, "James", 34),
                new Person(6, "Vlad", 18),
                new Person(7, "Jane", 31),
                new Person(8, "Mark", 21),
                new Person(9, "Oliver", 18),
                new Person(10, "Jack", 42),
                new Person(11, "Harry", 9),
                new Person(12, "Charley", 13),
                new Person(13, "Thomas", 50),
                new Person(14, "Ethan", 15),
                new Person(15, "Sophia", 44),
                new Person(16, "Victoria", 41),
                new Person(17, "Eva", 7),
                new Person(18, "Diana", 5),
                new Person(19, "Rebecca", 18),
                new Person(20, "Emma", 31),
            };
            
            var listOfNames = listOfPersons
                .Where(x => x.Age >= 20)
                .Select(x => x.Name)
                .ToList();

            foreach (var name in listOfNames)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();

            var anonymPersons = listOfPersons
            .Where(x => x.Age > 20)
            .OrderBy(x => x.Name)
            .Select((x, i) => new { Id = x.Id, Name = x.Name })
            .ToList();
            anonymPersons.ForEach(x => Console.WriteLine($"{x.Id} {x.Name}"));     
            Console.WriteLine();

            var olderPersons = listOfPersons            
            .Where(x => x.Age > 20)
            .Select(x => new { Id = x.Id, Name = x.Name, Age = x.Age })
            .GroupBy(x => x.Age)
            .ToDictionary(x => x.Key, x => x.Select(x => new { x.Name, x.Id }).ToList());
            foreach (var person in olderPersons)
            {
                Console.WriteLine($"Age: {person.Key}");

                foreach (var value in person.Value)
                {
                    Console.WriteLine($"Id: {value.Id}, Name: {value.Name}");
                }
                Console.WriteLine();
            }
            var result = listOfNumbers.PenultimateItem();
            Console.WriteLine(result);
        }    
    }
}