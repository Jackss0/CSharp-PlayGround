using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class AsyncClass
    {
        public async Task Handle(string word)
        {
            var sw = new Stopwatch();
            sw.Start();
            Task2();

            Task2();

            System.Console.WriteLine(sw.ElapsedMilliseconds);

            var responseTask = Task3(word);

            var response = await responseTask;

            System.Console.WriteLine(response);

            System.Console.WriteLine(sw.ElapsedMilliseconds);

            sw.Stop();

            await Task.CompletedTask;
        }

        public void Task1() => Thread.Sleep(1000);

        public void Task2() => Thread.Sleep(2000);

        public async Task<string> Task3(string word)
        {
            Thread.Sleep(3000);
            return await Task.FromResult(word.ToUpper());
        }
    }
}