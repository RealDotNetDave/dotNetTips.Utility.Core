``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.572 (2004/?/20H1)
Unknown processor
.NET Core SDK=5.0.100-rc.2.20479.15
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  Job-TZRVGS : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Categories=DistinctConcurrentBag,GenericCollections  

```
|                        Method | CollectionCount |         Mean |       Error |      StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------ |---------------- |-------------:|------------:|------------:|-------:|------:|------:|----------:|
| **&#39;Creating Using Constructor.&#39;** |              **25** |   **6,156.4 ns** |    **55.79 ns** |    **52.18 ns** | **0.0076** |     **-** |     **-** |    **2192 B** |
| &#39;Creating Using Constructor.&#39; |              50 |  12,588.6 ns |   246.38 ns |   456.68 ns | 0.0153 |     - |     - |    4408 B |
| &#39;Creating Using Constructor.&#39; |             100 |  22,570.2 ns |    70.86 ns |    62.81 ns | 0.0305 |     - |     - |    9064 B |
| &#39;Creating Using Constructor.&#39; |             250 |  56,508.0 ns |   621.98 ns |   581.80 ns | 0.0610 |     - |     - |   19288 B |
| &#39;Creating Using Constructor.&#39; |             500 | 114,811.0 ns |   888.68 ns |   831.27 ns | 0.1221 |     - |     - |   40168 B |
| &#39;Creating Using Constructor.&#39; |            1000 | 230,199.1 ns | 2,635.83 ns | 2,465.56 ns | 0.2441 |     - |     - |   83337 B |
|   **&#39;Creating Using ForEach().&#39;** |              **25** |   **6,016.8 ns** |    **45.24 ns** |    **42.32 ns** |      **-** |     **-** |     **-** |    **1978 B** |
|   &#39;Creating Using ForEach().&#39; |              50 |  12,159.9 ns |    71.17 ns |    66.57 ns |      - |     - |     - |    3994 B |
|   &#39;Creating Using ForEach().&#39; |             100 |  22,574.5 ns |   368.84 ns |   345.01 ns | 0.0305 |     - |     - |    8232 B |
|   &#39;Creating Using ForEach().&#39; |             250 |  53,812.0 ns |   199.41 ns |   186.53 ns | 0.0610 |     - |     - |   17256 B |
|   &#39;Creating Using ForEach().&#39; |             500 | 108,972.1 ns |   452.57 ns |   401.19 ns | 0.1221 |     - |     - |   36137 B |
|   &#39;Creating Using ForEach().&#39; |            1000 | 223,943.7 ns | 1,206.15 ns | 1,128.23 ns | 0.2441 |     - |     - |   75304 B |
|     **&#39;Looping with foreach().&#39;** |              **25** |     **283.6 ns** |     **0.49 ns** |     **0.38 ns** | **0.0277** |     **-** |     **-** |     **264 B** |
|     &#39;Looping with foreach().&#39; |              50 |     512.4 ns |     1.23 ns |     1.15 ns | 0.0486 |     - |     - |     464 B |
|     &#39;Looping with foreach().&#39; |             100 |     888.3 ns |     0.74 ns |     0.58 ns | 0.0906 |     - |     - |     864 B |
|     &#39;Looping with foreach().&#39; |             250 |   2,127.3 ns |     3.72 ns |     3.30 ns | 0.2174 |     - |     - |    2064 B |
|     &#39;Looping with foreach().&#39; |             500 |   4,240.9 ns |     6.90 ns |     6.12 ns | 0.4272 |     - |     - |    4064 B |
|     &#39;Looping with foreach().&#39; |            1000 |   8,924.1 ns |    11.30 ns |    10.02 ns | 0.8545 |     - |     - |    8064 B |
