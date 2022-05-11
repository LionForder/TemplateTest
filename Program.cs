using System;

namespace TemplateTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            TemplateTest<string> stringTest = new TemplateTest<string>();
            TemplateTest<int> intTest = new TemplateTest<int>();

            Console.WriteLine(stringTest.Count());
            Console.WriteLine(intTest.Count());

            stringTest.Add("10/");
            stringTest.Add("30/");
            stringTest.Add("50/");
            stringTest.Add("70/");
            stringTest.Add("90/");
            stringTest.Add("100/");

            intTest.Add(10);
            intTest.Add(30);
            intTest.Add(50);
            intTest.Add(70);
            intTest.Add(90);
            intTest.Add(100);

            Console.WriteLine(stringTest.Count());
            Console.WriteLine(intTest.Count());

            for (int i = 0; i < stringTest.Count(); i++)
            {
                Console.WriteLine(stringTest.Get(i));
                Console.WriteLine(intTest.Get(i));
                Console.WriteLine();
            }
        }
    }
    public class TemplateTest<T>
    {
        readonly T[] array = new T[10];
        int index = 0;

        public void Add(T value)
        {
            if(index > 9)
            {
                Console.WriteLine("Array.Length == 10!");
                return;
            }
            array[index++] = value;
        }
        public T Get(int index)
        {
            if (index < this.index && index >= 0)
                return array[index];
            return default(T);
        }
        public int Count()
        {
            return index;
        }
    }
}
