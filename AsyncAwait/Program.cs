namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            var asyncClass = new AsyncClass();

            System.Console.WriteLine("Writing something at the start");

            asyncClass.Handle("xd").Wait();

            System.Console.WriteLine("Writing something before finish");
        }
    }
}
