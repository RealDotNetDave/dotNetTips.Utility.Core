``` ini

BenchmarkDotNet=v0.11.5.1191-nightly, OS=Windows 10.0.17763.775 (1809/October2018Update/Redstone5)
Unknown processor
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-RGRUUZ : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=ConcurrentHashSet,GenericCollections  

```
|                      Method | CollectionCount |        Mean |     Error |    StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|---------------------------- |---------------- |------------:|----------:|----------:|-------:|-------:|------:|----------:|
| **&#39;Create Using Constructor.&#39;** |              **25** |  **5,339.4 ns** |   **9.52 ns** |   **7.95 ns** | **0.3433** |      **-** |     **-** |    **3224 B** |
| &#39;Create Using Constructor.&#39; |              50 |  9,985.0 ns |  15.13 ns |  13.41 ns | 0.4578 |      - |     - |    4344 B |
| &#39;Create Using Constructor.&#39; |             100 | 21,496.2 ns | 172.32 ns | 161.19 ns | 1.4648 |      - |     - |   13792 B |
| &#39;Create Using Constructor.&#39; |             250 | 54,273.9 ns | 523.28 ns | 489.48 ns | 3.6011 |      - |     - |   33897 B |
|   **&#39;Create Using ForEach().&#39;** |              **25** |  **5,315.9 ns** |  **11.89 ns** |  **10.54 ns** | **0.3510** |      **-** |     **-** |    **3312 B** |
|   &#39;Create Using ForEach().&#39; |              50 | 10,292.4 ns | 111.47 ns |  98.82 ns | 0.4730 |      - |     - |    4432 B |
|   &#39;Create Using ForEach().&#39; |             100 | 21,785.6 ns |  29.33 ns |  26.00 ns | 1.6785 | 0.0305 |     - |   15760 B |
|   &#39;Create Using ForEach().&#39; |             250 | 53,798.5 ns | 181.08 ns | 151.21 ns | 3.5400 | 0.1831 |     - |   33385 B |
|   **&#39;Looping with foreach().&#39;** |              **25** |    **481.5 ns** |   **3.99 ns** |   **3.73 ns** | **0.0057** |      **-** |     **-** |      **56 B** |
|   &#39;Looping with foreach().&#39; |              50 |    687.4 ns |   8.74 ns |   8.17 ns | 0.0057 |      - |     - |      56 B |
|   &#39;Looping with foreach().&#39; |             100 |  2,242.8 ns |   5.60 ns |   5.24 ns | 0.0038 |      - |     - |      56 B |
|   &#39;Looping with foreach().&#39; |             250 |  7,834.3 ns |  15.92 ns |  14.12 ns |      - |      - |     - |      56 B |
