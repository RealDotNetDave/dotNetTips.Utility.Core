``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100-preview3-014645
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-UEOGOB : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=ConcurrentHashSet,GenericCollections  

```
|                      Method | CollectionCount |        Mean |     Error |    StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|---------------------------- |---------------- |------------:|----------:|----------:|-------:|-------:|------:|----------:|
| **&#39;Create Using Constructor.&#39;** |              **25** |  **5,227.3 ns** |   **9.31 ns** |   **8.71 ns** | **0.3586** |      **-** |     **-** |    **3384 B** |
| &#39;Create Using Constructor.&#39; |              50 | 10,846.9 ns | 128.17 ns | 119.89 ns | 0.8392 |      - |     - |    7936 B |
| &#39;Create Using Constructor.&#39; |             100 | 21,259.2 ns | 235.76 ns | 208.99 ns | 1.7395 | 0.0305 |     - |   16512 B |
| &#39;Create Using Constructor.&#39; |             250 | 58,301.5 ns |  56.38 ns |  49.98 ns | 5.8594 | 0.4272 |     - |   55097 B |
|   **&#39;Create Using ForEach().&#39;** |              **25** |  **5,452.7 ns** |  **11.11 ns** |  **10.39 ns** | **0.3586** |      **-** |     **-** |    **3432 B** |
|   &#39;Create Using ForEach().&#39; |              50 | 10,967.7 ns |  21.37 ns |  19.99 ns | 0.8087 |      - |     - |    7584 B |
|   &#39;Create Using ForEach().&#39; |             100 | 22,491.0 ns |  26.31 ns |  23.32 ns | 1.7395 |      - |     - |   16480 B |
|   &#39;Create Using ForEach().&#39; |             250 | 60,863.6 ns | 294.30 ns | 275.29 ns | 5.7373 | 0.4272 |     - |   54465 B |
|   **&#39;Looping with foreach().&#39;** |              **25** |    **470.1 ns** |   **5.92 ns** |   **5.54 ns** | **0.0057** |      **-** |     **-** |      **56 B** |
|   &#39;Looping with foreach().&#39; |              50 |  1,666.9 ns |  22.61 ns |  21.15 ns | 0.0057 |      - |     - |      56 B |
|   &#39;Looping with foreach().&#39; |             100 |  2,145.3 ns |   3.88 ns |   3.44 ns | 0.0038 |      - |     - |      56 B |
|   &#39;Looping with foreach().&#39; |             250 |  7,902.2 ns |  11.35 ns |  10.61 ns |      - |      - |     - |      56 B |
