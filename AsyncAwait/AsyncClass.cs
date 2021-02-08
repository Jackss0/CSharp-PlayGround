using System;
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

            var task = await Task.Run(() => { return new Random().Next().ToString(); });

            Task1();

            Task2();

            Console.WriteLine(sw.ElapsedMilliseconds);

            var responseTask = Task3(task);

            var response = await responseTask;

            Console.WriteLine(response);

            Console.WriteLine(sw.ElapsedMilliseconds);

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