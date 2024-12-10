namespace Console;

/// <summary>
/// Стр 79. Про типи значений на примере структуры=
/// </summary>
internal class ValueTypeStructure
{
    /*var p1 = new Point();
    p1.X = 7;

    var p2 = p1;    //при присваивании произошло полное копирование нового экземпляра
    Console.WriteLine(p1.X);
    Console.WriteLine(p2.X);

    p1.X = 9;   //поэтому при изменении значения у нас первый элемент остался неизменным
    Console.WriteLine(p1.X);
    Console.WriteLine(p2.X);

    Point pN = null;    //ошибка на этапе компиляции

    Console.ReadLine();*/

    public struct Point { public int X, Y; }
}
