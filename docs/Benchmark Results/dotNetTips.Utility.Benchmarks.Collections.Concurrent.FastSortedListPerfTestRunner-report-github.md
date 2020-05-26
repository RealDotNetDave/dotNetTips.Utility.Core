``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.200
  [Host]     : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
  Job-KHIYCC : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=FastSortedList,GenericCollections  

```
|                       Method | CollectionCount |         Mean |      Error |     StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------------------- |---------------- |-------------:|-----------:|-----------:|-------:|-------:|------:|----------:|
| **&#39;Creating Using Constructor&#39;** |              **25** |     **45.31 ns** |   **0.352 ns** |   **0.312 ns** | **0.0279** |      **-** |     **-** |     **264 B** |
| &#39;Creating Using Constructor&#39; |              50 |     64.37 ns |   0.205 ns |   0.171 ns | 0.0490 |      - |     - |     464 B |
| &#39;Creating Using Constructor&#39; |             100 |    101.87 ns |   0.404 ns |   0.358 ns | 0.0917 | 0.0001 |     - |     864 B |
| &#39;Creating Using Constructor&#39; |             250 |    208.82 ns |   2.914 ns |   2.725 ns | 0.2189 | 0.0007 |     - |    2064 B |
|       **&#39;Creating Using for()&#39;** |              **25** |    **248.21 ns** |   **0.629 ns** |   **0.558 ns** | **0.0749** |      **-** |     **-** |     **704 B** |
|       &#39;Creating Using for()&#39; |              50 |    463.34 ns |   1.306 ns |   1.158 ns | 0.1321 |      - |     - |    1240 B |
|       &#39;Creating Using for()&#39; |             100 |    758.37 ns |   1.193 ns |   1.116 ns | 0.2422 |      - |     - |    2288 B |
|       &#39;Creating Using for()&#39; |             250 |  1,615.05 ns |   3.228 ns |   2.862 ns | 0.4578 |      - |     - |    4360 B |
|     **&#39;Looping with ForEach()&#39;** |              **25** |     **84.30 ns** |   **0.212 ns** |   **0.198 ns** | **0.0067** |      **-** |     **-** |      **64 B** |
|     &#39;Looping with ForEach()&#39; |              50 |    168.74 ns |   0.422 ns |   0.374 ns | 0.0067 |      - |     - |      64 B |
|     &#39;Looping with ForEach()&#39; |             100 |    326.97 ns |   1.409 ns |   1.177 ns | 0.0067 |      - |     - |      64 B |
|     &#39;Looping with ForEach()&#39; |             250 |    773.17 ns |   1.424 ns |   1.332 ns | 0.0067 |      - |     - |      64 B |
|                       **Sort()** |              **25** |  **2,850.67 ns** |   **6.424 ns** |   **6.009 ns** |      **-** |      **-** |     **-** |         **-** |
|                       Sort() |              50 |  8,994.60 ns |  17.525 ns |  16.393 ns |      - |      - |     - |         - |
|                       Sort() |             100 | 25,144.29 ns | 313.455 ns | 277.870 ns |      - |      - |     - |         - |
|                       Sort() |             250 | 71,297.31 ns | 140.984 ns | 131.876 ns |      - |      - |     - |         - |
|  **&#39;Sort(delegate) on Country&#39;** |              **25** |  **2,631.20 ns** |   **5.135 ns** |   **4.803 ns** |      **-** |      **-** |     **-** |         **-** |
|  &#39;Sort(delegate) on Country&#39; |              50 |  8,071.22 ns |  22.868 ns |  20.272 ns |      - |      - |     - |         - |
|  &#39;Sort(delegate) on Country&#39; |             100 | 23,550.69 ns | 299.147 ns | 279.822 ns |      - |      - |     - |         - |
|  &#39;Sort(delegate) on Country&#39; |             250 | 66,606.58 ns |  81.263 ns |  76.014 ns |      - |      - |     - |         - |
