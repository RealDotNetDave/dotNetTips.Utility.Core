``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.836 (1909/November2018Update/19H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.300
  [Host]     : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT
  Job-LAEGID : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=TypeHelper  

```
|                  Method |              Mean |           Error |          StdDev |            Median |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------ |------------------:|----------------:|----------------:|------------------:|-------:|------:|------:|----------:|
|                  **Create** |        **71.1352 ns** |       **3.3152 ns** |       **9.1310 ns** |        **69.1875 ns** | **0.0125** |     **-** |     **-** |     **120 B** |
| **DoesObjectEqualInstance** |    **21,515.4109 ns** |     **817.0139 ns** |   **2,408.9839 ns** |    **20,946.1075 ns** | **0.5493** |     **-** |     **-** |    **5447 B** |
|        **FindDerivedTypes** | **3,221,474.0000 ns** | **176,534.5960 ns** | **520,516.2394 ns** | **3,135,500.0000 ns** |      **-** |     **-** |     **-** |  **165376 B** |
|              **GetDefault** |         **0.1984 ns** |       **0.0691 ns** |       **0.2028 ns** |         **0.1396 ns** |      **-** |     **-** |     **-** |         **-** |
|     **GetInstanceHashCode** |     **3,786.5824 ns** |     **145.1648 ns** |     **428.0217 ns** |     **3,688.0430 ns** | **0.0458** |     **-** |     **-** |     **432 B** |
