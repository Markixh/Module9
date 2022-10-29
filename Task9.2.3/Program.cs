namespace Task9_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new ArgumentOutOfRangeException();
            }
            catch (Exception ex) when (ex is RankException)
            {
                Console.WriteLine("Возникло исключение RankException");
                Console.WriteLine(ex.GetType());
            }
            finally
            {
                Console.WriteLine("Сработал finally");
            }
            Console.ReadLine();
        }
    }
}