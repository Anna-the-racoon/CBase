using System.Text;
using Console.Types;

class Program
{
    public static void Main()
    {
        var wine = new ClassCtor(15, 2024);
        var (price, year) = wine;   //вызов деконструктора
        System.Console.WriteLine($"{wine.Price} = {wine.Year}");

        System.Console.ReadLine();
    }

    // Особенности присвоенния стартового значения ссылочным и значимым типам
    //StringBuilder sb = null;
    //int length = sb.ToString().Length;  //ошибка на этапе компиляции
    //int length2 = sb.Length;  //ошибка на этапе компиляции
    //System.Console.WriteLine($"{length}");



    //При смешенно-именнованной передаче аргументов в метод подобное поведение допустимо 

    //Foo(a: 1, 2, d: 10);  //в метод Main 

    //private static void Foo(int a = 0, int b = 0, int c = 0, int d = 0)
    //{

    //    var result = a + b + c + d;

    //}
}