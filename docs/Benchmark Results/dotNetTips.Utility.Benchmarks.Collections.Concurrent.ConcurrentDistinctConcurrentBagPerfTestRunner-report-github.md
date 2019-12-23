``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT
  Job-QYQXQL : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DistinctConcurrentBag,GenericCollections  

```
|                        Method | CollectionCount |        Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------ |---------------- |------------:|----------:|----------:|-------:|------:|------:|----------:|
| **&#39;Creating Using Constructor.&#39;** |              **25** |  **6,299.1 ns** |  **84.43 ns** |  **74.84 ns** | **0.0076** |     **-** |     **-** |    **2192 B** |
| &#39;Creating Using Constructor.&#39; |              50 | 11,839.1 ns |  88.89 ns |  83.14 ns | 0.0153 |     - |     - |    4408 B |
| &#39;Creating Using Constructor.&#39; |             100 | 23,458.5 ns | 324.62 ns | 303.65 ns | 0.0305 |     - |     - |    9064 B |
| &#39;Creating Using Constructor.&#39; |             250 | 55,982.5 ns | 603.96 ns | 564.95 ns | 0.0610 |     - |     - |   19272 B |
|   **&#39;Creating Using ForEach().&#39;** |              **25** |  **6,145.8 ns** |  **71.63 ns** |  **63.50 ns** |      **-** |     **-** |     **-** |    **1978 B** |
|   &#39;Creating Using ForEach().&#39; |              50 | 11,858.2 ns |  56.46 ns |  50.05 ns | 0.0153 |     - |     - |    3976 B |
|   &#39;Creating Using ForEach().&#39; |             100 | 22,980.8 ns | 113.44 ns | 100.57 ns | 0.0305 |     - |     - |    8232 B |
|   &#39;Creating Using ForEach().&#39; |             250 | 55,075.4 ns | 128.25 ns | 119.96 ns | 0.0610 |     - |     - |   17256 B |
|     **&#39;Looping with foreach().&#39;** |              **25** |    **302.4 ns** |   **0.78 ns** |   **0.69 ns** | **0.0277** |     **-** |     **-** |     **264 B** |
|     &#39;Looping with foreach().&#39; |              50 |    541.8 ns |   1.05 ns |   0.88 ns | 0.0486 |     - |     - |     464 B |
|     &#39;Looping with foreach().&#39; |             100 |    967.0 ns |   2.93 ns |   2.28 ns | 0.0916 |     - |     - |     864 B |
|     &#39;Looping with foreach().&#39; |             250 |  2,291.6 ns |   4.00 ns |   3.74 ns | 0.2174 |     - |     - |    2064 B |
