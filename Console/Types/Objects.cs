namespace Console.Types;
internal class Objects
{
    //Для проверки процесса распоковки перенести код в класс Program
    public void Unboxing()
    {
        object obj = 9;
        
        long x = (long) obj;    //ошибка выполнения Invalid Cast Exception из-за несоотвествия указанного (long) типа значения действительному (int)

        int y = (int)obj;      //в данноф формулировке отработает корректно
        System.Console.WriteLine(y);

        long z = (long)(int)obj;   //через двойное преобразование так же корректно. Сначала распаковка к действительному типу, потом преобразование к желаемому
        System.Console.WriteLine(z);

        object a = "5"; //будет считаться строкой из-за статической проверки компилятора
        int b = (int) a;    //Invalid Cast Exception
        string c = (string)a;   //корректно 
    }

    public void Boxing()
    {
        int x = 3;
        object obj = x;     //упаковали. Явных преобразований не требуется
        int y = (int) obj;   //распаковали 
    }

}
