``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.302
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-GMGNJH : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DistinctBlockingCollection,GenericCollections  

```
|                             Method | CollectionCount |         Mean |        Error |       StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------------- |---------------- |-------------:|-------------:|-------------:|-------:|------:|------:|----------:|
|      **&#39;Creating Using Constructor.&#39;** |              **25** |  **3,387.97 ns** |    **64.980 ns** |    **84.492 ns** | **0.1488** |     **-** |     **-** |    **1440 B** |
|      &#39;Creating Using Constructor.&#39; |              50 |  6,292.71 ns |   110.103 ns |   131.070 ns | 0.1755 |     - |     - |    1640 B |
|      &#39;Creating Using Constructor.&#39; |             100 | 12,944.76 ns |   255.812 ns |   467.766 ns | 0.2136 |     - |     - |    2040 B |
|      &#39;Creating Using Constructor.&#39; |             250 | 30,015.45 ns |   590.225 ns | 1,049.123 ns | 0.3357 |     - |     - |    3240 B |
|      &#39;Creating Using Constructor.&#39; |             500 | 60,648.90 ns | 1,192.329 ns | 2,592.025 ns | 0.4883 |     - |     - |    5240 B |
|            **&#39;Creating Using for().&#39;** |              **25** |  **3,413.63 ns** |    **65.818 ns** |    **94.394 ns** | **0.1259** |     **-** |     **-** |    **1208 B** |
|            &#39;Creating Using for().&#39; |              50 |  6,264.26 ns |   122.767 ns |   194.721 ns | 0.1221 |     - |     - |    1208 B |
|            &#39;Creating Using for().&#39; |             100 | 12,506.58 ns |   244.707 ns |   477.283 ns | 0.1221 |     - |     - |    1208 B |
|            &#39;Creating Using for().&#39; |             250 | 30,484.02 ns |   601.013 ns | 1,254.537 ns | 0.1221 |     - |     - |    1208 B |
|            &#39;Creating Using for().&#39; |             500 | 59,700.32 ns | 1,181.290 ns | 2,542.852 ns |      - |     - |     - |    1208 B |
|          **&#39;Looping with foreach().&#39;** |              **25** |     **50.94 ns** |     **1.042 ns** |     **1.622 ns** | **0.0085** |     **-** |     **-** |      **80 B** |
|          &#39;Looping with foreach().&#39; |              50 |     52.35 ns |     1.068 ns |     2.518 ns | 0.0085 |     - |     - |      80 B |
|          &#39;Looping with foreach().&#39; |             100 |     52.11 ns |     1.059 ns |     1.088 ns | 0.0085 |     - |     - |      80 B |
|          &#39;Looping with foreach().&#39; |             250 |     51.57 ns |     1.045 ns |     1.884 ns | 0.0085 |     - |     - |      80 B |
|          &#39;Looping with foreach().&#39; |             500 |     51.18 ns |     1.050 ns |     2.597 ns | 0.0085 |     - |     - |      80 B |
| **&#39;Looping with Parallel.ForEach().&#39;** |              **25** |  **2,415.50 ns** |    **35.763 ns** |    **33.453 ns** | **0.6485** |     **-** |     **-** |    **5170 B** |
| &#39;Looping with Parallel.ForEach().&#39; |              50 |  2,381.96 ns |    34.264 ns |    30.374 ns | 0.6599 |     - |     - |    5166 B |
| &#39;Looping with Parallel.ForEach().&#39; |             100 |  2,424.28 ns |    47.601 ns |    44.526 ns | 0.6409 |     - |     - |    5169 B |
| &#39;Looping with Parallel.ForEach().&#39; |             250 |  2,422.41 ns |    38.683 ns |    36.184 ns | 0.6447 |     - |     - |    5169 B |
| &#39;Looping with Parallel.ForEach().&#39; |             500 |  2,367.11 ns |    38.612 ns |    34.228 ns | 0.6523 |     - |     - |    5167 B |
