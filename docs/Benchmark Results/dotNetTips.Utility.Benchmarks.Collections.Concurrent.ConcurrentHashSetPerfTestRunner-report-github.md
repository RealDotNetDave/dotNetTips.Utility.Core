``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.302
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-GMGNJH : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=ConcurrentHashSet,GenericCollections  

```
|                      Method | CollectionCount |         Mean |       Error |      StdDev |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |---------------- |-------------:|------------:|------------:|--------:|------:|------:|----------:|
| **&#39;Create Using Constructor.&#39;** |              **25** |   **6,253.0 ns** |   **123.54 ns** |   **199.50 ns** |  **0.3662** |     **-** |     **-** |    **3504 B** |
| &#39;Create Using Constructor.&#39; |              50 |  12,608.0 ns |   247.64 ns |   471.16 ns |  0.8240 |     - |     - |    7816 B |
| &#39;Create Using Constructor.&#39; |             100 |  30,037.2 ns |   584.09 ns |   991.83 ns |  2.8687 |     - |     - |   27017 B |
| &#39;Create Using Constructor.&#39; |             250 |  64,243.3 ns | 1,269.42 ns | 3,016.90 ns |  3.7842 |     - |     - |   36497 B |
| &#39;Create Using Constructor.&#39; |             500 | 150,767.1 ns | 2,995.31 ns | 6,318.13 ns | 11.2305 |     - |     - |  108170 B |
|   **&#39;Create Using ForEach().&#39;** |              **25** |   **6,494.2 ns** |   **119.59 ns** |   **106.01 ns** |  **0.3357** |     **-** |     **-** |    **3192 B** |
|   &#39;Create Using ForEach().&#39; |              50 |  13,915.0 ns |   231.94 ns |   181.08 ns |  0.8392 |     - |     - |    7904 B |
|   &#39;Create Using ForEach().&#39; |             100 |  27,247.2 ns |   526.94 ns |   721.28 ns |  1.7090 |     - |     - |   16160 B |
|   &#39;Create Using ForEach().&#39; |             250 |  75,459.1 ns | 1,507.22 ns | 3,044.65 ns |  5.7373 |     - |     - |   53345 B |
|   &#39;Create Using ForEach().&#39; |             500 | 160,026.2 ns | 3,198.47 ns | 5,848.58 ns | 11.2305 |     - |     - |  108098 B |
|   **&#39;Looping with foreach().&#39;** |              **25** |     **363.9 ns** |     **7.19 ns** |     **9.84 ns** |  **0.0057** |     **-** |     **-** |      **56 B** |
|   &#39;Looping with foreach().&#39; |              50 |   1,185.3 ns |    21.91 ns |    22.50 ns |  0.0057 |     - |     - |      56 B |
|   &#39;Looping with foreach().&#39; |             100 |   2,502.5 ns |    49.95 ns |    66.69 ns |  0.0038 |     - |     - |      56 B |
|   &#39;Looping with foreach().&#39; |             250 |   6,576.3 ns |   131.15 ns |   183.85 ns |       - |     - |     - |      56 B |
|   &#39;Looping with foreach().&#39; |             500 |  18,149.1 ns |   353.41 ns |   459.54 ns |       - |     - |     - |      56 B |
