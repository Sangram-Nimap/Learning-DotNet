using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOut01_07_2025
{
    internal class AsyncAndAwait
    {
        private static async Task Main(string[] args)
        {
            Console.WriteLine("Fetching data...");
            string message = await GetMessageAsync();
            Console.WriteLine(message);
        }

        static async Task<string> GetMessageAsync()
        {
            await Task.Delay(2000);
            return "Hello from async method";
        }
    }
}
