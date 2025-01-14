using System.ComponentModel;

namespace Console.Types;

/// <summary>
/// Разбор полей и свойств
/// </summary>
internal class ClassFieldAndProperty
{
    //Именование обычного поля
    public string name;
    public decimal price;
    public int year;


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


    public static readonly DateTime today;  //объявление в конструкторе класса
    static ClassFieldAndProperty()
    {
        today = DateTime.Today;
    }



    //автоматическое свойство
    public string Name { get; set; }

    //свойство со строковым объявлением 
    public decimal WDecimal => price * year;

    //свойство
    public decimal CurrentPrice
    {
        get { return price; }
        set { price = value; }
    }

    //свойство с инициализатором 
    public string MyName { get; set; } = "Anna";

    //init - средство доступа для инициализации
    public int Height { get; init; } = 178; //далее значение не может быть изменено. Инициализация допустима так же через конструктор или средство доступа для инициализации

    //только для чтения
    public int Weight { get;}   //инициализация только через конструктор
    public ClassFieldAndProperty(int weight = 62)
    {
        Weight = weight;
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
/// Немного о констукторах, деконструкторах
/// </summary>
internal class ClassCtor
{
    //поля
    public decimal price;
    public int year;

    //конструкторы
    public ClassCtor(decimal price)=> this.price=price;  //в конструкторе могут быть объявлены необходимые переменные
    public ClassCtor(decimal price, int year) : this(price) => this.year = year; //перегрузка конструктора. Перегруженный конструктор ссылается на другой

    public ClassCtor(int year) => this.year = year;

    //public ClassCtor(decimal price, int year) : this(year) => Price = price;    //ссылка сразу на 2 более просытвх конструктора невозможна

    //деструкторы присваивают поля набору переменных 
    public void Deconstruct(out decimal price, out int year)
    {
        price = this.price;
        year = this.year;
    }
    //пример вызова. Вставить в Main
    //var wine = new ClassCtor(15, 2024);
    //var(price, year) = wine;   //вызов деконструктора
    //System.Console.WriteLine($"{wine.Price} = {wine.Year}");

}

/// <summary>
/// Первичные конструкторы. Позволяют добавлять параметры к определению метода и использовать внутри класса
/// </summary>
internal class ClassPrimaryCtor(decimal price, int year)    //При такой записи конструктор создасться автоматически
{
    private readonly decimal price;      //допустимо. называется маскированием, рекомендуется делать readonly для избежания редактирования параметров

    public ClassPrimaryCtor(decimal price) : this(price, DateTime.Now.Year) {}  //можно сказать, я создала перегрузку

    //примеры объявления класса:
    //var wine = new ClassPrimaryCtor(15);
    //var wine2 = new ClassPrimaryCtor(10, 2023);

    //внутри типа мы можем обращаться с параметрами первичного конструктора, в отличае от обычных кострукторов 
    public decimal ReturnPrice()
    {
        var result = price;
        return result;
    }
}

/// <summary>
/// О статических классах и их конструкторах
/// </summary>
internal static class ClassStatic
{
    //на вход не получает параметров
    static ClassStatic() { }

    //может содержать только статические поля, свойста и методы
    private static decimal price;
    public static int Year { get; set; }

    public static string Message(string message = "Тебе было лень придумать текст для метода?")
    {
        return message;
    }
}

/// <summary>
/// Про финализаторы
/// </summary>
internal class ClassFinalize
{
    //public Finalize() { }

    //финализатор класса. Происходит переопределение метода Finalize класса Object
    ~ClassFinalize()
    {
        //some code
        System.Console.WriteLine("Finalize");
    }

    //альтернативный вариант
    //~Finalize() => System.Console.WriteLine("Finalize");

    //В классе может быть только один
}

internal class Panda
{
    public string Name { get; set; }
    public override string ToString() => Name;  //для переопределения методов Object не нужно указывать наследование. Допустимо переиспользовать базовые реализации для дополнения своих
}