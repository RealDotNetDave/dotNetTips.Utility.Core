``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.302
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-GMGNJH : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DistinctConcurrentBag,GenericCollections  

```
|                        Method | CollectionCount |         Mean |       Error |      StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------ |---------------- |-------------:|------------:|------------:|-------:|------:|------:|----------:|
| **&#39;Creating Using Constructor.&#39;** |              **25** |   **7,221.7 ns** |   **131.69 ns** |   **208.87 ns** | **0.0076** |     **-** |     **-** |    **2192 B** |
| &#39;Creating Using Constructor.&#39; |              50 |  14,215.5 ns |   279.54 ns |   504.07 ns | 0.0153 |     - |     - |    4408 B |
| &#39;Creating Using Constructor.&#39; |             100 |  26,870.0 ns |   503.70 ns |   813.38 ns | 0.0305 |     - |     - |    9064 B |
| &#39;Creating Using Constructor.&#39; |             250 |  65,534.7 ns | 1,273.24 ns | 1,784.90 ns | 0.1221 |     - |     - |   19288 B |
| &#39;Creating Using Constructor.&#39; |             500 | 134,715.1 ns | 2,670.50 ns | 5,632.98 ns | 0.2441 |     - |     - |   40168 B |
|   **&#39;Creating Using ForEach().&#39;** |              **25** |   **7,249.2 ns** |   **134.20 ns** |   **212.85 ns** | **0.0076** |     **-** |     **-** |    **1960 B** |
|   &#39;Creating Using ForEach().&#39; |              50 |  14,269.3 ns |   279.15 ns |   488.91 ns | 0.0153 |     - |     - |    3976 B |
|   &#39;Creating Using ForEach().&#39; |             100 |  26,678.0 ns |   529.49 ns |   824.35 ns | 0.0305 |     - |     - |    8232 B |
|   &#39;Creating Using ForEach().&#39; |             250 |  66,442.5 ns | 1,312.01 ns | 3,066.78 ns | 0.1221 |     - |     - |   17256 B |
|   &#39;Creating Using ForEach().&#39; |             500 | 134,155.7 ns | 2,663.91 ns | 6,876.40 ns | 0.2441 |     - |     - |   36136 B |
|     **&#39;Looping with foreach().&#39;** |              **25** |     **338.5 ns** |     **6.72 ns** |    **11.41 ns** | **0.0277** |     **-** |     **-** |     **264 B** |
|     &#39;Looping with foreach().&#39; |              50 |     599.5 ns |    11.95 ns |    15.12 ns | 0.0486 |     - |     - |     464 B |
|     &#39;Looping with foreach().&#39; |             100 |   1,134.7 ns |    22.64 ns |    52.92 ns | 0.0916 |     - |     - |     864 B |
|     &#39;Looping with foreach().&#39; |             250 |   2,686.6 ns |    53.34 ns |    87.64 ns | 0.2174 |     - |     - |    2064 B |
|     &#39;Looping with foreach().&#39; |             500 |   5,379.1 ns |   106.37 ns |   197.16 ns | 0.4349 |     - |     - |    4064 B |
