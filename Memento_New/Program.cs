using System;

namespace Memento_New
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var m = new Memento();
            Console.WriteLine("sample text");
            m.SetMemento(Console.ReadLine());
            Console.WriteLine(m.GetMemento());
            Console.WriteLine(Console.ReadLine());
            Console.WriteLine("Type new text");
            Console.ReadLine();
            Console.WriteLine(Console.ReadLine());
            Console.WriteLine("return previus value from memento");
            Console.WriteLine(m.GetMemento());

            

        }
    }
}
