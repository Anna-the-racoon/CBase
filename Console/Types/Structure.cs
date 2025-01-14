namespace Console.Types
{
    public struct PublicStructure : IDisposable //может быть дочерним от класса или интерфейса, но не имеет наследников сам
    //может быть public или internal
    {
        public int Count { get; set; }

        public PublicStructure()    //не рекомендуется. По умолчанию существует онструктор без параметров, который будет вызван и может привести к путанице
        {
            Count = 0;
        }

        public PublicStructure(int start)
        {
            Count = start;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    internal struct Structure
    {
        public int count;   //допустимы поля

        public Structure() { }
        //Если мы используем хоть 1 элемент с заполнением, должны создать свой конструктор
        
        public string Name { get; set; }    //допустимы свойства

        public string ExampProtocol { get; set; } = "http";  //вариант заполнения начальным значанием

        //рекомендованный вариант присвоения значения по умолчанию 
        public string protocol;
        public string Protocol { get=>protocol ?? "https";
                                set=>protocol = value; }
    }

    //Можем применить как в целом, так и к отдельным элементам
    readonly struct ReadonlyStruct
    {
        public readonly string Type { get; }
    }
}
