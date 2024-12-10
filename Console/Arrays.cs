namespace Console;

internal class Arrays
{

    //работа с индексами
    /*//char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };   //старый вариант инициализации
    char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

    char lastElement = vowels[^1];      //значек ^ говорит о том, что ищем i-тый элемент от конца
    char beforeLastElement = vowels[^2];

    System.Console.WriteLine(lastElement);
        System.Console.WriteLine(beforeLastElement);

        //диапазоны
        char[] firstTwo = vowels[..2];
    System.Console.WriteLine(firstTwo);

        char[] lastTwo = vowels[2..];
    System.Console.WriteLine(lastTwo);

        Range diapazoneForMiddle = 2..3;    //вариант задания диапазона
    char[] middle = vowels[diapazoneForMiddle];
    System.Console.WriteLine(middle);*/


    //варианты заполнения массива
    /*Point[] array = new Point[1000];
    int x = array[500].X;

    System.Console.WriteLine(x);

    //foreach (var item in array)
    //    System.Console.WriteLine($"Point {item.X}, {item.Y};");

    System.Console.ReadLine();*/
    public struct Point { public int X, Y; }      //отрабатывает заполняя значения по умолчанию
                                                  //public class Point { public int X, Y; }     //падает с ошибкой на этапе выполнения. Нужно явное создание экземпляров класса
}
