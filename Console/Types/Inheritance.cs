using System.Reflection;
using System.Runtime.CompilerServices;

namespace Console.Types;


public class Asset
{
    public string Name { get; set; }
    public virtual decimal Liability => 0;
    public int Counter { get; set; }
    public virtual decimal NetValue => 1;

    private string PrivateString { get; set; }  //недоступно наследникам
    protected string ProtectedString { get; set; }  //доступно наследникам и только им

}

public class Stock : Asset
{
    public long SharesOwned;

    public int Counter { get; set; }    //ругается, но дает создать аналог родительского свойства

    public sealed override decimal Liability { get; }   //переопределили и запретили для изменения наследниками данного класса

    public override decimal NetValue => base.NetValue + Counter;    //base позволяет получить доступ к свойству родительского класса невиртуальным способом
}

[assembly: InternalsVisibleTo("ConsoleOld")]    //объявляем имя дружествнной сборки для доступа к нному классу
internal class House : Asset
{
    public decimal Mortgage;
    public override decimal Liability => Mortgage;      //переопределение вертуального родительского свойства

    public void Something()
    {
        var stock = new Stock();

        var liab = stock.Liability; //вызов вертуального не переопределенного свойства, то есть вернет 0
        var name = stock.Name;

        //var privStr = PrivateString;  //Ошибка
        var privStr = ProtectedString;  //Доступно

    }

    public new int Counter { get; set; }    //корректная форма переопределения родительского свойства. Тут new язвляется молификатором членов

}

file class Warehouse : Stock   //виден только в рамках данного класса, в остальном без изменений
{
    //чаще всего примеяется при автогенерации классов
}
