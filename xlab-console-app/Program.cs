using System;

namespace Xlab
{
    public class Program
    {
        public static void Main()
        {
            int a = 1000;
            for (int i = 1000; i > 0; i -= 7)
            {
                Console.WriteLine($"{i}-7 = {i}");
            }

            Human aleksey = new("Алексей", 27);

            Hello(aleksey);
        }

        public static void Hello(Human human)
        {
            Console.WriteLine($"Привет {human.Name} {2025-human.Age} года рождения");
        }
    }

    public class Human
    {
        public string Name { get; private set; }
        public int Age { get; private set; }


        public Human(string name, int age)
        {
            Name = name;

            if (age <= 0)
                throw new Exception("Автору 0 лет");

            Age = age;
        }
    }
}

