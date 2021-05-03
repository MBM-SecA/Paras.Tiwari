using System;
using System.Threading.Tasks;

namespace CounterApp
{
    class Program
    {
         
        static async Task Main(string[] arguments)
        { int counter =1;
            int limit = int.MaxValue;
            if(arguments.Length>0)
            {
                limit = int.Parse(arguments[0]);

            }
            while(counter<= limit)
            {
                await Task.Delay(1000);
                Console.WriteLine(counter);
                counter++;
            }
        }
    }
}
