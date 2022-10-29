namespace Module9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception exception = new Exception("Мое исключение");

            exception.Data.Add("Дата создания исключения", DateTime.Now);

            exception.HelpLink = "www.ya.ru";

            Console.ReadKey();
        }
    }
}