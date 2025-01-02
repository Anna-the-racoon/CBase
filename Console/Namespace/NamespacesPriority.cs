//код является рабочим, не мешает сборке проекта, поскольку IL содердит в себе только поные имена

namespace Console.Namespace
{
    internal class NamespacesPriority
    {
    }

    namespace Inner
    {
        internal class Foo { }
        internal class NamespacesPriority { }   //допустимо, поскольку этот класс вложенный то имя у него другое, не такое как у первого

        internal class Examples
        {
            Foo f1 = new();

            NamespacesPriority n1 = new();  //тот, что находится в одном с данным классом пространстве имен
            Namespace.NamespacesPriority n2 = new();    //тот, что находится сверху. для этого четко прописан адрес

        }
    }

    //будут корректно работать, при отсутствии дубликатов в содержимом
    namespace Inner 
    {
        //internal class Foo { } //вот так нельзя. Конфлик имен с аналогичным namespace
        internal class Example { }  //а вот так уже можно
    }
}
