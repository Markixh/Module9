namespace Task9_3_4
{
    internal class Program
    {
        delegate void Func(int a, int b);

        static void Main(string[] args)
        {
            Func func = Sub;
            func += Sum;
            func(5, 10);            

            func -= Sum;
            func(5, 10);
        }

        static void Sub(int a, int b)
        {
            Console.WriteLine($"{b} - {a} = {b - a}");
        }

        static void Sum(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
    }
}