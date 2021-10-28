using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
             
            
               var watch = new System.Diagnostics.Stopwatch();
                watch.Start();

                Add obj = new Add();
            obj.add();

                Console.ReadKey();
                watch.Stop();
                var time = watch.ElapsedMilliseconds;
                Console.WriteLine("Time taken to execute all the codes is {0} milli-seconds", time);
            
            
        }
    }
}
