``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT
  Job-QYQXQL : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=FastSortedList,GenericCollections  

```
|                       Method | CollectionCount |         Mean |      Error |     StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------------------- |---------------- |-------------:|-----------:|-----------:|-------:|-------:|------:|----------:|
| **&#39;Creating Using Constructor&#39;** |              **25** |     **47.48 ns** |   **0.511 ns** |   **0.478 ns** | **0.0278** |      **-** |     **-** |     **264 B** |
| &#39;Creating Using Constructor&#39; |              50 |     65.18 ns |   0.386 ns |   0.361 ns | 0.0492 |      - |     - |     464 B |
| &#39;Creating Using Constructor&#39; |             100 |    100.74 ns |   0.730 ns |   0.683 ns | 0.0918 | 0.0001 |     - |     864 B |
| &#39;Creating Using Constructor&#39; |             250 |    211.94 ns |   2.361 ns |   2.209 ns | 0.2189 | 0.0012 |     - |    2064 B |
|       **&#39;Creating Using for()&#39;** |              **25** |    **246.33 ns** |   **0.386 ns** |   **0.361 ns** | **0.0749** |      **-** |     **-** |     **704 B** |
|       &#39;Creating Using for()&#39; |              50 |    454.09 ns |   1.167 ns |   1.035 ns | 0.1311 |      - |     - |    1240 B |
|       &#39;Creating Using for()&#39; |             100 |    764.26 ns |   1.253 ns |   1.046 ns | 0.2422 |      - |     - |    2288 B |
|       &#39;Creating Using for()&#39; |             250 |  1,646.99 ns |   2.839 ns |   2.656 ns | 0.4692 |      - |     - |    4360 B |
|     **&#39;Looping with ForEach()&#39;** |              **25** |    **112.63 ns** |   **1.026 ns** |   **0.960 ns** | **0.0068** |      **-** |     **-** |      **64 B** |
|     &#39;Looping with ForEach()&#39; |              50 |    184.10 ns |   0.249 ns |   0.208 ns | 0.0067 |      - |     - |      64 B |
|     &#39;Looping with ForEach()&#39; |             100 |    390.84 ns |   7.821 ns |  18.740 ns | 0.0067 |      - |     - |      64 B |
|     &#39;Looping with ForEach()&#39; |             250 |    859.03 ns |   4.667 ns |   4.366 ns | 0.0067 |      - |     - |      64 B |
|                       **Sort()** |              **25** |  **2,874.93 ns** |   **3.218 ns** |   **2.853 ns** |      **-** |      **-** |     **-** |         **-** |
|                       Sort() |              50 |  8,649.05 ns |  10.401 ns |   9.730 ns |      - |      - |     - |         - |
|                       Sort() |             100 | 25,024.51 ns | 472.048 ns | 441.554 ns |      - |      - |     - |         - |
|                       Sort() |             250 | 74,209.52 ns | 107.938 ns |  95.684 ns |      - |      - |     - |         - |
|  **&#39;Sort(delegate) on Country&#39;** |              **25** |  **2,879.53 ns** |   **2.835 ns** |   **2.652 ns** |      **-** |      **-** |     **-** |         **-** |
|  &#39;Sort(delegate) on Country&#39; |              50 |  8,177.16 ns |  10.971 ns |  10.262 ns |      - |      - |     - |         - |
|  &#39;Sort(delegate) on Country&#39; |             100 | 22,751.91 ns |  13.282 ns |  11.774 ns |      - |      - |     - |         - |
|  &#39;Sort(delegate) on Country&#39; |             250 | 68,210.25 ns |  77.630 ns |  72.615 ns |      - |      - |     - |         - |
