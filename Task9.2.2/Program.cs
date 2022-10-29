namespace Task9_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new ArgumentOutOfRangeException();
            }
            catch(Exception ex) when (ex is ArgumentOutOfRangeException)
            {
                Console.WriteLine("Возникло исключение ArgumentOutOfRangeException");
            }
            finally
            {
                Console.WriteLine("Сработал finally");
            }
            Console.ReadLine();
        }
    }
}