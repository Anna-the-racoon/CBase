namespace Console.Types;

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