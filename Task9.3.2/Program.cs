namespace Task9_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func func = Sub;
            Console.WriteLine($"10 - 5 = {func(5,10)}");
            Console.ReadLine();
        }

        public delegate int Func(int a, int b);

        static int Sub(int a, int b)
        {
            return b - a;
        }
    }
}