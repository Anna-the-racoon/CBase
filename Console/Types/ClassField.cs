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
