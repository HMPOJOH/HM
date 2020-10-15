using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Linq
{
    public class Demo2
    {
        class Person
        {
            public Person(string firstName, int age)
            {
                FirstName = firstName;
                Age = age;
            }

            public int Age { get; }
            public string FirstName { get; }
        }

        public static void Run()
        {
            var people = new List<Person>
            {
                new Person("Ludvig", 55),
                new Person("Alice", 28),
                new Person("Fred", 30),
                new Person("Zelda", 45)
            };

            List<Person> result = PeopleOlderThan32(people);

            foreach (Person p in result)
            {
                Console.WriteLine(p.FirstName);
            }

            Console.WriteLine();

            // Solution with LINQ (11:42)

            var result2 = people.Where(p => p.Age > 32);

            foreach (Person p in result2)
            {
                Console.WriteLine(p.FirstName);
            }
            
            Console.WriteLine();

            // Use LINQ statement to create a list with these two elements (hard)
            //  "Ludwig is 55 years old"
            //  "Zelda is 45 years old"

            var result3 = people
                .Where(p => p.Age > 32)
                .Select(p => $"{p.FirstName} is {p.Age} years old");

            foreach (string x in result3)
            {
                Console.WriteLine(x);
            }

        }

        // Solution without LINQ
        private static List<Person> PeopleOlderThan32(List<Person> people)
        {
            var result = new List<Person>();

            foreach (Person p in people)
            {
                if (p.Age > 32)
                {
                    result.Add(p);
                }
            }
            return result;
        }
    }
}
