namespace Task9_3_12
{
    internal class Program
    {
        delegate void ShowMessageDelegate(string _message);

        static void Main(string[] args)
        {
            ShowMessageDelegate showMessageDelegate = (_message) => Console.WriteLine(_message);
            showMessageDelegate.Invoke("Hello World!");
            Console.Read();
        }
    }
}