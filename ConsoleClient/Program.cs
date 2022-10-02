using System;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyLibrary.MyClass myClass = new MyLibrary.MyClass("Greetings");
            System.Console.WriteLine(myClass.MyProperty); 
        }
    }
}
