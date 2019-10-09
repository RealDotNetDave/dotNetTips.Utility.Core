``` ini

BenchmarkDotNet=v0.11.5.1191-nightly, OS=Windows 10.0.17763.775 (1809/October2018Update/Redstone5)
Unknown processor
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-RGRUUZ : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=CollectionExtensions  

```
|            Method | CollectionCount |          Mean |        Error |       StdDev |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|------------------ |---------------- |--------------:|-------------:|-------------:|--------:|-------:|------:|----------:|
|          **AddRange** |              **25** |  **78,277.49 ns** |   **303.904 ns** |   **284.272 ns** |  **1.5869** |      **-** |     **-** |   **15632 B** |
|          AddRange |              50 | 152,785.55 ns |   599.922 ns |   561.168 ns |  3.1738 |      - |     - |   29512 B |
|          AddRange |             100 | 325,273.46 ns | 1,131.292 ns | 1,058.212 ns |  6.3477 |      - |     - |   59649 B |
|          AddRange |             250 | 809,529.77 ns | 1,814.074 ns | 1,608.129 ns | 15.6250 |      - |     - |  150105 B |
|           **FastAny** |              **25** |     **501.02 ns** |     **2.210 ns** |     **2.067 ns** |  **0.0038** |      **-** |     **-** |      **40 B** |
|           FastAny |              50 |   1,090.58 ns |     2.386 ns |     2.115 ns |  0.0038 |      - |     - |      40 B |
|           FastAny |             100 |   2,019.93 ns |    11.781 ns |    11.020 ns |  0.0038 |      - |     - |      40 B |
|           FastAny |             250 |   5,749.52 ns |    10.021 ns |     9.374 ns |       - |      - |     - |      40 B |
|         **FastCount** |              **25** |     **299.33 ns** |     **0.514 ns** |     **0.481 ns** |       **-** |      **-** |     **-** |         **-** |
|         FastCount |              50 |     584.72 ns |     0.925 ns |     0.866 ns |       - |      - |     - |         - |
|         FastCount |             100 |   1,319.60 ns |     2.274 ns |     2.016 ns |       - |      - |     - |         - |
|         FastCount |             250 |   3,642.93 ns |     7.494 ns |     6.644 ns |       - |      - |     - |         - |
|          **HasItems** |              **25** |      **12.46 ns** |     **0.012 ns** |     **0.011 ns** |       **-** |      **-** |     **-** |         **-** |
|          HasItems |              50 |      12.54 ns |     0.020 ns |     0.019 ns |       - |      - |     - |         - |
|          HasItems |             100 |      12.45 ns |     0.017 ns |     0.015 ns |       - |      - |     - |         - |
|          HasItems |             250 |      20.35 ns |     0.038 ns |     0.036 ns |       - |      - |     - |         - |
|        **PickRandom** |              **25** |      **34.49 ns** |     **0.076 ns** |     **0.071 ns** |  **0.0095** |      **-** |     **-** |      **88 B** |
|        PickRandom |              50 |      34.86 ns |     0.079 ns |     0.070 ns |  0.0095 |      - |     - |      88 B |
|        PickRandom |             100 |      34.81 ns |     0.090 ns |     0.075 ns |  0.0095 |      - |     - |      88 B |
|        PickRandom |             250 |      34.52 ns |     0.432 ns |     0.404 ns |  0.0094 |      - |     - |      88 B |
|         **Randomize** |              **25** |      **20.11 ns** |     **0.212 ns** |     **0.198 ns** |  **0.0060** |      **-** |     **-** |      **56 B** |
|         Randomize |              50 |      21.13 ns |     0.433 ns |     0.425 ns |  0.0060 |      - |     - |      56 B |
|         Randomize |             100 |      21.28 ns |     0.441 ns |     0.413 ns |  0.0060 |      - |     - |      56 B |
|         Randomize |             250 |      19.62 ns |     0.104 ns |     0.097 ns |  0.0060 |      - |     - |      56 B |
| **ToDelimitedString** |              **25** |   **1,154.05 ns** |     **4.274 ns** |     **3.998 ns** |  **0.5150** | **0.0019** |     **-** |    **4840 B** |
| ToDelimitedString |              50 |   2,187.42 ns |     9.879 ns |     9.241 ns |  0.9766 | 0.0076 |     - |    9120 B |
| ToDelimitedString |             100 |   4,235.80 ns |     8.326 ns |     7.381 ns |  1.9302 | 0.0305 |     - |   17880 B |
| ToDelimitedString |             250 |   9,668.96 ns |    21.275 ns |    19.900 ns |  4.0436 |      - |     - |   39464 B |
