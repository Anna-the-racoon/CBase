using Microsoft.VisualBasic;

namespace Console.Types;

/// <summary>
/// Разбор полей
/// </summary>
internal static class ClassField
{
    //Именование обычного поля
    public static string Name { get; set; }

    //Вариант именования нескольких однотипных методов
    static readonly int legs = 8,
                        eyes = 2;


    /// <summary>
    /// Особенности объявления константного значения
    /// </summary>
    private const int age = 18;
    //private const int age2 = new int();   //Недпустимо. ошибка на этапе компиляции

    /// <summary>
    /// Особенности объявления readonly static
    /// </summary>
    public readonly static DateTime day = DateTime.Now;


    public readonly static DateTime today;  //объявление в конструкторе класса
    static ClassField()
    {
        today = DateTime.Today;
    }
}

/// <summary>
/// Рзбор методов
/// </summary>
internal class ClassMethods
{
    /// <summary>
    /// варианты объявлений строчный методов
    /// </summary>
    int Foo1(int x) { return x * 2; }  //это полное содержание метода с возвращаемым типом int
    int Foo2(int x) => x * 2;   //альтернатива слову return => 
    void Foo3(int x) => System.Console.WriteLine(x); // полное содержание метода у которого нет возвращаемого типа

    //Строчные методы могут быть объявлены внутри другого метода
    void WriteSomething()
    {
        System.Console.WriteLine(Cube(3));
        System.Console.WriteLine(Cube(2));
        System.Console.WriteLine(Cube(5));
        System.Console.WriteLine(Cube(10));

        int Cube(int value)=> value*value*value;    //область видимости ограничивается конкретным методом
    }

    //Перегрузки методов
    void Overload(int x) { }
    void Overload(ref int x) { }    //приемлемо
    //void Overload(out int x) { }    //неприемлемо из-за наличия перегрузки с ref. Ошибка на этапе компиляции

}

/// <summary>
/// Немного о констукторах
/// </summary>
internal class ClassCtor
{
    //поля
    public decimal Price;
    public int Year;

    //свойства
    public string Name { get; set; }

    //конструкторы
    public ClassCtor(decimal price)=> Price=price;  //в конструкторе могут быть объявлены необходимые переменные
    public ClassCtor(decimal price, int year) : this(price) => Year = year; //перегрузка конструктора. Перегруженный конструктор ссылается на другой

    public ClassCtor(int year) => Year = year;

    //public ClassCtor(decimal price, int year) : this(year) => Price = price;    //ссылка сразу на 2 более просытвх конструктора невозможна

    //деструкторы присваивают поля набору переменных 
    public void Deconstruct(out decimal price, out int year)
    {
        price = Price;
        year = Year;
    }
    //пример вызова. Вставить в Main
    //var wine = new ClassCtor(15, 2024);
    //var(price, year) = wine;   //вызов деконструктора
    //System.Console.WriteLine($"{wine.Price} = {wine.Year}");

}

/// <summary>
///  Первичные конструкторы. Позволяют добавлять параметры к определению метода и использовать внутри класса
/// </summary>
internal class ClassPrimaryCtor(decimal price, int year)
{
    public ClassPrimaryCtor(decimal price) : this(price, DateTime.Now.Year) {}
}

