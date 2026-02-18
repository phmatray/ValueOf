using BenchmarkDotNet.Attributes;

namespace ValueOf.Benchmarks
{
    public class ValueOfBenchmarks
    {
        private const int SampleValue = 42;

        [Benchmark]
        public ValueOf<int, ValueOfInt> From() => ValueOf<int, ValueOfInt>.From(SampleValue);

        [Benchmark]
        public bool TryFrom()
        {
            return ValueOf<int, ValueOfInt>.TryFrom(SampleValue, out var value);
        }

        public class ValueOfInt : ValueOf<int, ValueOfInt>
        {
        }
    }
}