using BenchmarkDotNet.Running;

namespace ValueOf.Benchmarks
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<ValueOfBenchmarks>();
        }
    }
}