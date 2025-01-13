namespace Console.Types;

public class Asset
{
    public string Name { get; set; }
    public virtual decimal Liability => 0;
}

public class Stock : Asset
{
    public long SharesOwned;

}

public class House : Asset
{
    public decimal Mortgage;
    public override decimal Liability => Mortgage;      //переопределение вертуального родительского свойства

    public void Something()
    {
        var stock = new Stock();

        var liab = stock.Liability; //вызов вертуального не переопределенного свойства, то есть вернет 0
        var name = stock.Name;
    }
}