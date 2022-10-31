namespace Task9_4_2
{
    internal class Program
    {
        delegate Car CarDelegate(string model);

        static void Main(string[] args)
        {
            CarDelegate carDelegate;
            carDelegate = BuildLexus;
            Car c = carDelegate("Lexus");
            Console.WriteLine(c);
            Console.ReadLine();
        }

        static Car BuildLexus(string model)
        {
            return new Lexus();
        }
    }
    class Car { }
    class Lexus : Car { }
}