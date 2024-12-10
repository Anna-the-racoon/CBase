namespace Console;

/// <summary>
/// Стр 79. Про ссылочные типи на примере класса
/// </summary>
internal class ReferenceTypeClass
{
    /*var p1 = new Point();
    p1.X = 7;

        var p2 = p1;    //при присваивании произошло копирование ссылки на уже созданный экземпляр объекта
        System.Console.WriteLine(p1.X);
        System.Console.WriteLine(p2.X);

        p1.X = 9;   //поэтому при изменении значения у нас первый элемент тоже поменялся
        System.Console.WriteLine(p1.X);
        System.Console.WriteLine(p2.X);


        var p3 = new Point();   //но в случае создания отдельного экземпляра класса, создается новая ссылка на объект в пямяти
        p3.X = p1.X;            //поэтому при копировании полей, происходит копирование значения, а не ссылки
        
        System.Console.WriteLine(p1.X);
        System.Console.WriteLine(p3.X);

        p1.X = 15;   //поэтому при изменении значения у нас элемент не поменялся
        System.Console.WriteLine(p1.X);
        System.Console.WriteLine(p3.X);

        Point pN = null; //NullReferenceException в процессе выполнения

        System.Console.ReadLine();*/

    public class Point { public int X, Y; };

}
