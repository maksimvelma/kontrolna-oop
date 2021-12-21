using System;

namespace ConsoleApp1
{
    interface ITree
    {
        int CrownHeight { get; }
        void GetInfo();
        void PlantName();
        void GetHeight();
    }
    class Bush
    {
        public int CrownHeight { get; }

        public void GetInfo(ITree tree)
        {
            tree.GetInfo();
        }

        public void PlantName(ITree tree)
        {
            tree.PlantName();
        }
        public void GetHeight(ITree tree)
        {
            tree.GetHeight();
        }
    }
    class Bushh : ITree
    {
        public int CrownHeight => 4;

        public void GetHeight()
        {
            Console.WriteLine($"Висота: {CrownHeight}");
        }

        public void GetInfo()
        {
            Console.WriteLine($"{GetType().Name}: Кущ");
        }

        public void PlantName()
        {
            Console.WriteLine("Назва: Календула");
        }
    }

    class Tree : ITree
    {
        public int CrownHeight => 9;

        public void GetHeight()
        {
            Console.WriteLine($"Висота: {CrownHeight}");
        }

        public void GetInfo()
        {
            Console.WriteLine($"{GetType().Name}: Дерево");
        }

        public void PlantName()
        {
            Console.WriteLine("Назва: Дуб");
        }
    }

    class Grass : ITree
    {
        public int CrownHeight => 1;

        public void GetHeight()
        {
            Console.WriteLine($"Висота: {CrownHeight}");
        }

        public void GetInfo()
        {
            Console.WriteLine($"{GetType().Name}: Трава");
        }

        public void PlantName()
        {
            Console.WriteLine("Назва: Травичка ^_^");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var bush = new Bush();
            ITree[] arr = { new Bushh(), new Tree(), new Grass() };
            foreach (var str in arr)
            {
                bush.GetInfo(str);
                Console.WriteLine();
                bush.PlantName(str);
                Console.WriteLine();
                bush.GetHeight(str);
                Console.WriteLine();
            }
        }
    }
}