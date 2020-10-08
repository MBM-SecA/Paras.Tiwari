using System;
using System.Net.Http;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;

namespace Async
{
    class Program
    {
        //main 1
        /*    static   void Main()
                {
                
                // TPL - Parallel Programming
                int[] numbers ={4,12,12,6,8,5};
                //sequential execution
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
            
                foreach (var num in numbers)
                {
                    var f = Factorial(num);
                    Console.WriteLine($"{num}! = {f}");
                }
                Console.WriteLine($"Time taken for sequential = {stopwatch.ElapsedMilliseconds}");
                //parallel inmplementation
                stopwatch.Restart();
                Parallel.ForEach(numbers,num =>{
                    var f = Factorial(num);
                    Console.WriteLine($"{num}! = {f}");
                });
                Console.WriteLine($"Time taken for parallel = {stopwatch.ElapsedMilliseconds}");

                }

                static long Factorial (long number)
                {
                    if(number == 1 || number ==0)
                        return 1;
                    else 
                        return (number*Factorial(number-1));

                } */

        static async Task Main()
        {
            //Making breakfast

            //Make tea
            //- turn on burner(2sec)
            //- place kettle on burner(2sec)
            // -pour water(5sec)
            //- let it boil(5min)
            // -Grind masals(1min)
            //put suger and masalas(5s)

            //turn on burner(2sec)
            //- put pan on and oil it(30sec)
            // -crack eggs and  whisk it(3min)
            //- fry(2min)

            //Async Programming
            Stopwatch stopwatch= Stopwatch.StartNew();
            await TurnOnBurner();
            await PlaceOnBurner("Kettle");
            await Add("water");
            await Boil("Water");
            await GrindMasala();
            await Add("Sugar&Masala");
            await Add("Milk");
            await Boil("Milk");
            await TurnOnBurner();
            await Add("oil");
            await Crack_Wisk();
            await Fry();
            await Serve();
            Console.WriteLine($"Time taken : {stopwatch.ElapsedMilliseconds}");
        }

        private static Task TurnOnBurner()
        {
            Console.WriteLine($"Turning on burner");
            Task.Delay(2000);
            return Task.CompletedTask;
        }
        private static Task PlaceOnBurner(string pot)
        {
            Console.WriteLine($"Place {pot} on burner");
            Task.Delay(2000);
            return Task.CompletedTask;
        }
        private static Task Add(string item)
        {
            Console.WriteLine($"Adding {item}");
            Task.Delay(2000);
            return Task.CompletedTask;
        }
        private static Task Boil(string item)
        {
            Console.WriteLine($"Boiling {item}");
            Task.Delay(2000);
            return Task.CompletedTask;
        }

        private static Task GrindMasala()
        {
            Console.WriteLine($"Grinding Masala");
            Task.Delay(2000);
            return Task.CompletedTask;
        }
        private static Task Crack_Wisk()
        {
            Console.WriteLine($"Cracking and Whisking Eggs.");
            Task.Delay(2000);
            return Task.CompletedTask;

        }
        private static Task Fry()
        {
            Console.WriteLine($"frying Eggs");
            Task.Delay(2000);
            return Task.CompletedTask;

        }

         private static Task Serve()
        {
            Console.WriteLine($"Serving BreakFast");
            Task.Delay(2000);
            return Task.CompletedTask;

        }


    }
}
