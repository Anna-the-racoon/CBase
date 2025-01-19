using System.Collections;

namespace Console.Types;

/// <summary>
/// После реализации интерфейса, нам необходимо переопределить его члены в нашем классе
/// </summary>
internal class Example : IEnumerator
{
    public object Current => throw new NotImplementedException();

    public bool MoveNext()
    {
        throw new NotImplementedException();
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }
}

//Объект может быть неявно приведен к любому интерфейсу, который он реализовывает
//Код для вставкли в класс Program:
//        IEnumerator example = new Example();


interface IBaseInterface
{
    public int MyProperty { get; set; }

}

interface ISEcondInterface : IBaseInterface //Интерфейсы могут быть производными от других интерфейсов. 
{
    private int PrivateProp {  get => 10;}  //Можем создавать приватные элементы, которые будут использовать все классы ревализации
}


internal class Interfaces : ISEcondInterface
{
    public int MyProperty { get; set; } //является свойством одного из интерфейсов, хоть и не явный его наследник

}
