using System;
using System.Threading;
using System.Threading.Tasks;

namespace Novemeber9thAsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            var cancellationTokenSource = new CancellationTokenSource();
            MainAsync(cancellationTokenSource).Wait();
            //var justinText = JustinExample().GetAwaiter().GetResult();
            //var tayloreResult = TayloreExample().GetAwaiter().GetResult();
            //if(tayloreResult.Success)
            //{
            //    //do the things we would do if we are successful
            //}
            //else
            //{
            //    tayloreResult = ;
            //    var exception = (FailureResult)tayloreResult
            //}
        }

        public static async Task MainAsync(CancellationTokenSource cancellationTokenSource)
        {
            var task1 = Task1(cancellationTokenSource.Token);
            var task2 = Task2(cancellationTokenSource.Token);
            //var movies = await _context.Movies.ToListAsync();

            //await Task.WhenAll(task1, task2);
            Task.Run(() => task1);
            Task.Run(() => task2);
            if(task1.IsCompleted && !task2.IsCompleted)
            {
                cancellationTokenSource.Cancel();
            }

            await Task.Delay(6000);

            //var justinText = await JustinExample();
            //var justinTask = JustinExample();
            //Task.Run(() => justinTask);
            //var done = justinTask.IsCompletedSuccessfully;
            //var justinResult = justinTask.Result;

            Console.WriteLine("MainAsync complete");
        }

        public static async Task Task1(CancellationToken cancellationToken)
        {
            await Task.Delay(5000);
            Console.WriteLine("Finished Task1");
        }
        
        public static async Task Task2(CancellationToken cancellationToken)
        {
            await Task.Delay(10000);
            Console.WriteLine("Finished Task2");
        }

        public static async Task<string> JustinExample()
        {
            await Task.Delay(20000);
            Console.WriteLine("Finished JustinExample");

            return "Hi Justin";
        }

        public static async Task<IResult> TayloreExample()
        {
            try
            {
                //do some stuff
                return new SuccessResult() { Success = true, SomeObject = new { WeDidIt = "Yes we did" } };
            }
            catch (Exception ex)
            {

                return new FailureResult() { Success = false, Exception = ex };
            }
        }
    }

    public interface IResult
    {
        public bool Success { get; set; }
    }

    public class SuccessResult : IResult
    {
        public bool Success { get; set; }
        public object SomeObject { get; set; }
    }

    public class FailureResult : IResult
    {
        public bool Success { get; set; }
        public object SomeObject { get; set; }
        public Exception Exception { get; set; }
    }
}
