``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.200
  [Host]     : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
  Job-KHIYCC : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=ConcurrentHashSet,GenericCollections  

```
|                      Method | CollectionCount |        Mean |     Error |    StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|---------------------------- |---------------- |------------:|----------:|----------:|-------:|-------:|------:|----------:|
| **&#39;Create Using Constructor.&#39;** |              **25** |  **4,551.5 ns** |  **31.27 ns** |  **27.72 ns** | **0.1984** |      **-** |     **-** |    **1864 B** |
| &#39;Create Using Constructor.&#39; |              50 | 10,845.9 ns |  21.03 ns |  18.64 ns | 0.8850 |      - |     - |    8416 B |
| &#39;Create Using Constructor.&#39; |             100 | 21,739.5 ns |  37.06 ns |  34.66 ns | 1.8311 | 0.0305 |     - |   17312 B |
| &#39;Create Using Constructor.&#39; |             250 | 58,060.1 ns | 672.69 ns | 629.24 ns | 5.9814 | 0.3052 |     - |   55417 B |
|   **&#39;Create Using ForEach().&#39;** |              **25** |  **5,441.1 ns** |   **8.29 ns** |   **7.35 ns** | **0.3510** |      **-** |     **-** |    **3352 B** |
|   &#39;Create Using ForEach().&#39; |              50 | 11,368.2 ns |  26.27 ns |  24.58 ns | 0.8240 |      - |     - |    7824 B |
|   &#39;Create Using ForEach().&#39; |             100 | 21,580.8 ns |  39.43 ns |  34.95 ns | 1.7090 |      - |     - |   16160 B |
|   &#39;Create Using ForEach().&#39; |             250 | 52,170.3 ns | 172.84 ns | 134.94 ns | 3.3569 |      - |     - |   31945 B |
|   **&#39;Looping with foreach().&#39;** |              **25** |    **426.9 ns** |   **0.84 ns** |   **0.75 ns** | **0.0057** |      **-** |     **-** |      **56 B** |
|   &#39;Looping with foreach().&#39; |              50 |    971.3 ns |   8.14 ns |   7.61 ns | 0.0057 |      - |     - |      56 B |
|   &#39;Looping with foreach().&#39; |             100 |  2,140.8 ns |  26.03 ns |  24.35 ns | 0.0038 |      - |     - |      56 B |
|   &#39;Looping with foreach().&#39; |             250 |  7,560.7 ns | 109.17 ns | 102.12 ns |      - |      - |     - |      56 B |
