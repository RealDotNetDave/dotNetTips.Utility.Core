``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.836 (1909/November2018Update/19H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.300
  [Host]     : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT
  Job-LAEGID : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DistinctConcurrentBag,GenericCollections  

```
|                        Method | CollectionCount |         Mean |       Error |      StdDev |       Median |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------ |---------------- |-------------:|------------:|------------:|-------------:|-------:|------:|------:|----------:|
| **&#39;Creating Using Constructor.&#39;** |              **25** |   **9,885.9 ns** |   **339.32 ns** |   **984.43 ns** |   **9,623.0 ns** |      **-** |     **-** |     **-** |    **2192 B** |
| &#39;Creating Using Constructor.&#39; |              50 |  20,437.4 ns |   764.88 ns | 2,206.84 ns |  20,555.1 ns | 0.0305 |     - |     - |    4408 B |
| &#39;Creating Using Constructor.&#39; |             100 |  42,482.5 ns | 1,045.08 ns | 3,048.55 ns |  42,061.9 ns | 0.0610 |     - |     - |    9064 B |
| &#39;Creating Using Constructor.&#39; |             250 | 143,007.2 ns | 3,315.30 ns | 9,775.25 ns | 143,595.5 ns | 0.2441 |     - |     - |   19288 B |
|   **&#39;Creating Using ForEach().&#39;** |              **25** |   **9,003.1 ns** |   **227.74 ns** |   **660.72 ns** |   **8,925.1 ns** |      **-** |     **-** |     **-** |    **1960 B** |
|   &#39;Creating Using ForEach().&#39; |              50 |  26,065.3 ns |   837.13 ns | 2,468.31 ns |  26,460.5 ns |      - |     - |     - |    3976 B |
|   &#39;Creating Using ForEach().&#39; |             100 |  43,010.9 ns | 1,499.10 ns | 4,252.69 ns |  42,548.4 ns | 0.0610 |     - |     - |    8232 B |
|   &#39;Creating Using ForEach().&#39; |             250 | 131,486.3 ns | 2,619.93 ns | 5,171.49 ns | 131,360.2 ns | 0.2441 |     - |     - |   17256 B |
|     **&#39;Looping with foreach().&#39;** |              **25** |     **466.7 ns** |    **17.88 ns** |    **51.30 ns** |     **451.1 ns** | **0.0277** |     **-** |     **-** |     **264 B** |
|     &#39;Looping with foreach().&#39; |              50 |     937.5 ns |    43.20 ns |   127.38 ns |     921.3 ns | 0.0496 |     - |     - |     464 B |
|     &#39;Looping with foreach().&#39; |             100 |   1,868.4 ns |    68.85 ns |   203.00 ns |   1,855.7 ns | 0.0916 |     - |     - |     864 B |
|     &#39;Looping with foreach().&#39; |             250 |   5,369.7 ns |   100.57 ns |   168.04 ns |   5,386.3 ns | 0.2136 |     - |     - |    2064 B |
