using System;
using System.Security.Cryptography.X509Certificates;

namespace Xlab
{
    public class Program
    {
        public static void Main()
        {
            MyList<int> list = new MyList<int>();

            for (int i = 0; i < 20; i++)
            {
                list.Add(i);

                if(i > 10)
                    list.Remove(i); 

                Console.WriteLine($"{i}     {list.Capacity}");
            }
        }

        public static void Hello(Human human)
        {
            Console.WriteLine($"Привет {human.Name} {2025-human.Age} года рождения");
        }
    }

    public class MyList<T>
    {
        public int Capacity => _items.Length;
        public int Length { get; private set; }
        private T[] _items;
        private int _nextLength => _items.Length * 2;
        private int _targetLenght => _items.Length / 2;

        public MyList()
        {
            _items = new T[16];
        }

        public MyList(int capacity)
        {
            _items = new T[capacity];
        }

        public void Add(T item)
        {
            if(Length > _targetLenght)
            {
                var newArray = new T[_nextLength];

                for(int i = 0; i < _items.Length; i++)
                {
                    newArray[i] = _items[i];
                }

                _items = newArray;
            }

            Length++;
        }

        public void Remove(T item) //ПОКА НЕ РАБОТАЕТ!
        {
            T[] newArray = new T[Capacity];

            for(int i = 0; i < Length; i++)
            {
                if (!_items[i].Equals(item))
                {
                    newArray[i] = _items[i];
                }
            }

            _items = newArray;

            Length--;
        }

        public void Insert(T item)
        {

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

