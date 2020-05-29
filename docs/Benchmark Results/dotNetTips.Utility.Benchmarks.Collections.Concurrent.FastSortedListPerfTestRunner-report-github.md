``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.836 (1909/November2018Update/19H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.300
  [Host]     : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT
  Job-LAEGID : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=FastSortedList,GenericCollections  

```
|                       Method | CollectionCount |        Mean |       Error |      StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------------------- |---------------- |------------:|------------:|------------:|-------:|-------:|------:|----------:|
| **&#39;Creating Using Constructor&#39;** |              **25** |    **119.2 ns** |     **4.08 ns** |    **12.02 ns** | **0.0279** |      **-** |     **-** |     **264 B** |
| &#39;Creating Using Constructor&#39; |              50 |    158.9 ns |     3.20 ns |     4.79 ns | 0.0486 |      - |     - |     464 B |
| &#39;Creating Using Constructor&#39; |             100 |    251.7 ns |     5.06 ns |     5.82 ns | 0.0911 |      - |     - |     864 B |
| &#39;Creating Using Constructor&#39; |             250 |    513.5 ns |     8.32 ns |     6.95 ns | 0.2165 | 0.0010 |     - |    2056 B |
|       **&#39;Creating Using for()&#39;** |              **25** |    **601.4 ns** |    **11.94 ns** |    **23.30 ns** | **0.0734** |      **-** |     **-** |     **704 B** |
|       &#39;Creating Using for()&#39; |              50 |  1,192.9 ns |    33.37 ns |    98.40 ns | 0.1297 |      - |     - |    1240 B |
|       &#39;Creating Using for()&#39; |             100 |  2,116.1 ns |    40.80 ns |    43.66 ns | 0.2403 |      - |     - |    2288 B |
|       &#39;Creating Using for()&#39; |             250 |  4,518.1 ns |   114.24 ns |   336.85 ns | 0.4578 |      - |     - |    4360 B |
|     **&#39;Looping with ForEach()&#39;** |              **25** |    **200.4 ns** |     **4.06 ns** |     **8.57 ns** | **0.0067** |      **-** |     **-** |      **64 B** |
|     &#39;Looping with ForEach()&#39; |              50 |    403.5 ns |    10.48 ns |    30.89 ns | 0.0067 |      - |     - |      64 B |
|     &#39;Looping with ForEach()&#39; |             100 |    698.2 ns |    14.71 ns |    43.13 ns | 0.0067 |      - |     - |      64 B |
|     &#39;Looping with ForEach()&#39; |             250 |  1,289.6 ns |    23.84 ns |    42.99 ns | 0.0057 |      - |     - |      64 B |
|                       **Sort()** |              **25** |  **7,559.5 ns** |   **150.48 ns** |   **300.53 ns** |      **-** |      **-** |     **-** |         **-** |
|                       Sort() |              50 | 21,675.8 ns |   567.51 ns | 1,673.33 ns |      - |      - |     - |         - |
|                       Sort() |             100 | 62,426.0 ns | 1,620.77 ns | 4,778.89 ns |      - |      - |     - |         - |
|                       Sort() |             250 | 96,612.2 ns | 1,926.46 ns | 2,883.44 ns |      - |      - |     - |         - |
|  **&#39;Sort(delegate) on Country&#39;** |              **25** |  **6,250.1 ns** |   **103.53 ns** |    **91.77 ns** |      **-** |      **-** |     **-** |         **-** |
|  &#39;Sort(delegate) on Country&#39; |              50 | 22,276.5 ns |   468.23 ns | 1,365.86 ns |      - |      - |     - |         - |
|  &#39;Sort(delegate) on Country&#39; |             100 | 56,175.9 ns | 1,096.51 ns | 3,001.67 ns |      - |      - |     - |         - |
|  &#39;Sort(delegate) on Country&#39; |             250 | 97,483.8 ns | 1,928.35 ns | 4,693.87 ns |      - |      - |     - |         - |
