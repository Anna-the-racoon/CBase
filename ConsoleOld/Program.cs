using System;

namespace ConsoleOld
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
        }

    }
}


//При смешенно именнованной передаче аргументов в метод подобное поведение допустимо 
//Foo(a: 1, 2, d: 10);  //в метод Main 

//private static void Foo(int a = 0, int b = 0, int c = 0, int d = 0)
//{

//    var result = a + b + c + d;

//}
