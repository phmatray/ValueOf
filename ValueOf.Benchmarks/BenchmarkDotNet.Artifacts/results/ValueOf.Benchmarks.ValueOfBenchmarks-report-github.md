``` ini

BenchmarkDotNet=v0.13.5, OS=macOS Ventura 13.2.1 (22D68) [Darwin 22.3.0]
Apple M2, 1 CPU, 8 logical and 8 physical cores
.NET SDK=7.0.202
  [Host]     : .NET 6.0.15 (6.0.1523.11507), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 6.0.15 (6.0.1523.11507), Arm64 RyuJIT AdvSIMD


```
|  Method |     Mean |    Error |   StdDev |
|-------- |---------:|---------:|---------:|
|    From | 13.14 ns | 0.065 ns | 0.058 ns |
| TryFrom | 14.49 ns | 0.046 ns | 0.041 ns |
