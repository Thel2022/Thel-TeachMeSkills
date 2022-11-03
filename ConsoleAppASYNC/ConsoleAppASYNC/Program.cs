using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppASYNC
{
    class Program
    {
        private static async Task Main(string[] args)
        {

            var ts = new CancellationTokenSource();
            var token = ts.Token;
            

            var s = new StreamWriter("text.text");
            var sb = new StringBuilder();
            sb.Append("Some text");

            
            var t = s.WriteLineAsync(sb, token);

            ts.Cancel();

            await t;


            /*
            WakeUp();
            TurnOnTV();
            var makingteaTask = MakeTea();
            var fireeggsTask = FireEggs();
            Wash();
            var toastTask = Toasts();

            await makingteaTask;
            FriedEggs egg = await fireeggsTask;
            Toast toast = await toastTask;

            MakeSandwich(egg, toast); // (await await fireeggsTask, await toastTask)
            */
        }
        /*
        private static void WakeUp()
        {
            Console.WriteLine($"Hello world! {Thread.CurrentThread.ManagedThreadId}");
        }
         private static void TurnOnTV()
        {
            Console.WriteLine($"TV on {Thread.CurrentThread.ManagedThreadId}");
        }

        private static async Task MakeTea()
        {
            Console.WriteLine($"Water into kettle {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"Kettle on {Thread.CurrentThread.ManagedThreadId}");

            var waterboilingTask = Task.Delay(5000);
            
            Console.WriteLine($"Tea into cap {Thread.CurrentThread.ManagedThreadId}");

            await waterboilingTask;

            Console.WriteLine($"Boiled water into cap {Thread.CurrentThread.ManagedThreadId}");

            await Task.Delay(3000);
                        
            Console.WriteLine($"Tea ready! {Thread.CurrentThread.ManagedThreadId}");
        }

        private static async Task<FriedEggs> FireEggs()
        {
            Console.WriteLine($"Put pan on fire {Thread.CurrentThread.ManagedThreadId}");

            await Task.Delay(2000);

            Console.WriteLine($"Pour oil into the pan {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"Put eggs {Thread.CurrentThread.ManagedThreadId}");

            await Task.Delay(7000);

            Console.WriteLine($"Eggs ready! {Thread.CurrentThread.ManagedThreadId}");

            return new FriedEggs();
        }

        private static void Wash()
        {
            Console.WriteLine($"Dishes is cleaned {Thread.CurrentThread.ManagedThreadId}");
        }
        private static async Task<Toast> Toasts()
        {
            Console.WriteLine($"Bread into toaster {Thread.CurrentThread.ManagedThreadId}");

            await Task.Delay(3000);

            Console.WriteLine($"Toast ready! {Thread.CurrentThread.ManagedThreadId}");

            return new Toast();
        }

        private static async Task MakeSandwich(FriedEggs eggs, Toast toast)
        {
            Console.WriteLine("Combaine toast and eggs into sandwich");


        }

        private class FriedEggs { }
        private class Toast { }
        */
    }
}
