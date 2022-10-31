namespace Task9_4_3
{
    internal class Program
    {
        delegate void childdelegate(Child child);

        static void Main(string[] args)
        {
            childdelegate cd;
            cd = parent;
            cd(new Child());
        }
        static void parent(Parent parent)
        {
            Console.WriteLine(parent);
        }
    }

    class Parent { }
    class Child : Parent { }
}