﻿class Program
{
    public static void Main()
    {

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

    #region Сравнение GetType и typeof

    //ReferenceTypeClass.Point p = new();

    //System.Console.WriteLine(p.GetType().Name);
    //System.Console.WriteLine(typeof(ReferenceTypeClass.Point).Name);
    //System.Console.WriteLine(p.GetType() == typeof(ReferenceTypeClass.Point));
    //System.Console.WriteLine(p.X.GetType().Name);
    //System.Console.WriteLine(p.Y.GetType().FullName);

    #endregion

}