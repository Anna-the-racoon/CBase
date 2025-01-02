//код является рабочим, не мешает сборке проекта

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
}
