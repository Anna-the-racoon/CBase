namespace Console.Types;

public abstract class AssetA    //Экземпляр класса не может быть создан. только наследники
{
    public string Name { get; set; }
    public virtual decimal Liability => 0;

    public abstract decimal NetValue { get; }       //обязательна реализация у наследников
}

public class StockA : AssetA
{
    public long SharesOwned;

    public override decimal NetValue => throw new NotImplementedException();    //если переопределение в данном классе реализции не требуется 
}

public class HouseA : AssetA
{
    public decimal Mortgage;
    public override decimal Liability => Mortgage;      //переопределение вертуального родительского свойства

    public override decimal NetValue { get; }   //переопределение абстрактного члена родительского класса

    public void Something()
    {
        var stock = new Stock();

        var liab = stock.Liability; //вызов вертуального не переопределенного свойства, то есть вернет 0
        var name = stock.Name;
    }
}

public abstract class Warehouse : AssetA    // если наследник тоже абстрактный, то переопределения абстрактных членов не требуется
{
    
}
