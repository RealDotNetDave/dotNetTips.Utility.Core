``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Unknown processor
.NET Core SDK=3.1.400
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-GUNMTB : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DistinctConcurrentBag,GenericCollections  

```
|                        Method | CollectionCount |         Mean |       Error |      StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------ |---------------- |-------------:|------------:|------------:|-------:|------:|------:|----------:|
| **&#39;Creating Using Constructor.&#39;** |              **25** |   **5,975.5 ns** |    **74.64 ns** |    **69.82 ns** | **0.0076** |     **-** |     **-** |    **2192 B** |
| &#39;Creating Using Constructor.&#39; |              50 |  12,489.5 ns |    59.49 ns |    52.73 ns | 0.0153 |     - |     - |    4408 B |
| &#39;Creating Using Constructor.&#39; |             100 |  22,792.1 ns |   177.47 ns |   166.00 ns | 0.0305 |     - |     - |    9064 B |
| &#39;Creating Using Constructor.&#39; |             250 |  55,805.2 ns |   540.00 ns |   505.11 ns | 0.0610 |     - |     - |   19288 B |
| &#39;Creating Using Constructor.&#39; |             500 | 109,421.9 ns |   878.98 ns |   822.20 ns | 0.1221 |     - |     - |   40168 B |
| &#39;Creating Using Constructor.&#39; |            1000 | 226,092.7 ns | 1,716.77 ns | 1,605.86 ns | 0.2441 |     - |     - |   83336 B |
|   **&#39;Creating Using ForEach().&#39;** |              **25** |   **6,059.3 ns** |    **73.24 ns** |    **68.51 ns** | **0.0076** |     **-** |     **-** |    **1960 B** |
|   &#39;Creating Using ForEach().&#39; |              50 |  12,214.9 ns |   116.28 ns |   108.77 ns |      - |     - |     - |    3994 B |
|   &#39;Creating Using ForEach().&#39; |             100 |  22,646.9 ns |   129.91 ns |   121.52 ns | 0.0305 |     - |     - |    8232 B |
|   &#39;Creating Using ForEach().&#39; |             250 |  55,596.3 ns |   252.53 ns |   223.86 ns | 0.0610 |     - |     - |   17256 B |
|   &#39;Creating Using ForEach().&#39; |             500 | 113,818.5 ns |   694.13 ns |   615.33 ns | 0.1221 |     - |     - |   36137 B |
|   &#39;Creating Using ForEach().&#39; |            1000 | 222,490.1 ns | 1,519.24 ns | 1,421.10 ns | 0.2441 |     - |     - |   75304 B |
|     **&#39;Looping with foreach().&#39;** |              **25** |     **325.0 ns** |     **4.79 ns** |     **4.48 ns** | **0.0277** |     **-** |     **-** |     **264 B** |
|     &#39;Looping with foreach().&#39; |              50 |     501.0 ns |     0.81 ns |     0.68 ns | 0.0486 |     - |     - |     464 B |
|     &#39;Looping with foreach().&#39; |             100 |     917.5 ns |     7.97 ns |     7.07 ns | 0.0906 |     - |     - |     864 B |
|     &#39;Looping with foreach().&#39; |             250 |   2,164.0 ns |    34.32 ns |    30.42 ns | 0.2174 |     - |     - |    2064 B |
|     &#39;Looping with foreach().&#39; |             500 |   4,557.4 ns |    18.37 ns |    15.34 ns | 0.4272 |     - |     - |    4064 B |
|     &#39;Looping with foreach().&#39; |            1000 |   8,948.2 ns |    18.33 ns |    15.31 ns | 0.8545 |     - |     - |    8064 B |
