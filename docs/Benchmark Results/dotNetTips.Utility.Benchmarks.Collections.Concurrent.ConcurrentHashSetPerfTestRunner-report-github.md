``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Unknown processor
.NET Core SDK=3.1.400
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-GUNMTB : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=ConcurrentHashSet,GenericCollections  

```
|                      Method | CollectionCount |         Mean |       Error |      StdDev |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|---------------------------- |---------------- |-------------:|------------:|------------:|--------:|-------:|------:|----------:|
| **&#39;Create Using Constructor.&#39;** |              **25** |   **5,321.4 ns** |     **7.40 ns** |     **6.18 ns** |  **0.3662** |      **-** |     **-** |    **3504 B** |
| &#39;Create Using Constructor.&#39; |              50 |   9,611.2 ns |   150.16 ns |   140.46 ns |  0.4883 |      - |     - |    4624 B |
| &#39;Create Using Constructor.&#39; |             100 |  21,760.0 ns |    45.66 ns |    40.47 ns |  1.7395 | 0.0305 |     - |   16552 B |
| &#39;Create Using Constructor.&#39; |             250 |  57,219.7 ns |    83.20 ns |    69.48 ns |  5.6763 | 0.4883 |     - |   52257 B |
| &#39;Create Using Constructor.&#39; |             500 | 111,097.7 ns |   943.18 ns |   836.10 ns |  7.2021 |      - |     - |   68458 B |
| &#39;Create Using Constructor.&#39; |            1000 | 248,548.8 ns |   428.00 ns |   400.35 ns | 20.9961 |      - |     - |  214069 B |
|   **&#39;Create Using ForEach().&#39;** |              **25** |   **5,260.7 ns** |     **8.36 ns** |     **6.98 ns** |  **0.3052** |      **-** |     **-** |    **2912 B** |
|   &#39;Create Using ForEach().&#39; |              50 |  11,009.7 ns |    25.02 ns |    20.89 ns |  0.7629 |      - |     - |    7144 B |
|   &#39;Create Using ForEach().&#39; |             100 |  21,988.5 ns |    51.81 ns |    43.26 ns |  1.5564 |      - |     - |   14840 B |
|   &#39;Create Using ForEach().&#39; |             250 |  61,279.5 ns | 1,204.28 ns | 1,565.91 ns |  5.7373 | 0.3662 |     - |   53825 B |
|   &#39;Create Using ForEach().&#39; |             500 | 107,981.2 ns |   135.82 ns |   113.42 ns |  6.7139 | 0.6104 |     - |   61986 B |
|   &#39;Create Using ForEach().&#39; |            1000 | 252,127.1 ns |   668.69 ns |   625.49 ns | 20.9961 |      - |     - |  205477 B |
|   **&#39;Looping with foreach().&#39;** |              **25** |     **449.3 ns** |     **1.60 ns** |     **1.50 ns** |  **0.0057** |      **-** |     **-** |      **56 B** |
|   &#39;Looping with foreach().&#39; |              50 |   1,020.5 ns |     3.22 ns |     2.86 ns |  0.0057 |      - |     - |      56 B |
|   &#39;Looping with foreach().&#39; |             100 |   2,188.5 ns |    10.88 ns |     9.08 ns |  0.0038 |      - |     - |      56 B |
|   &#39;Looping with foreach().&#39; |             250 |   5,271.9 ns |    64.85 ns |    60.66 ns |       - |      - |     - |      56 B |
|   &#39;Looping with foreach().&#39; |             500 |  11,794.4 ns |    21.20 ns |    16.55 ns |       - |      - |     - |      56 B |
|   &#39;Looping with foreach().&#39; |            1000 |  31,185.5 ns |   109.01 ns |    91.03 ns |       - |      - |     - |      56 B |
