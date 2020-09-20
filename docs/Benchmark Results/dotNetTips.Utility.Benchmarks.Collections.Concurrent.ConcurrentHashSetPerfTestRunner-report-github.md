``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
Unknown processor
.NET Core SDK=5.0.100-preview.8.20417.9
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  Job-RATGHQ : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=ConcurrentHashSet,GenericCollections  

```
|                      Method | CollectionCount |         Mean |       Error |      StdDev |       Median |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|---------------------------- |---------------- |-------------:|------------:|------------:|-------------:|--------:|-------:|------:|----------:|
| **&#39;Create Using Constructor.&#39;** |              **25** |   **5,129.7 ns** |    **82.14 ns** |    **76.83 ns** |   **5,124.5 ns** |  **0.3662** |      **-** |     **-** |    **3504 B** |
| &#39;Create Using Constructor.&#39; |              50 |  10,868.5 ns |    30.76 ns |    25.69 ns |  10,863.7 ns |  0.8545 |      - |     - |    8176 B |
| &#39;Create Using Constructor.&#39; |             100 |  22,335.1 ns |   310.88 ns |   290.79 ns |  22,137.4 ns |  1.6174 | 0.0305 |     - |   15552 B |
| &#39;Create Using Constructor.&#39; |             250 |  59,795.3 ns |   110.20 ns |   103.08 ns |  59,801.2 ns |  6.2256 | 0.4272 |     - |   57418 B |
| &#39;Create Using Constructor.&#39; |             500 | 121,581.5 ns |   158.30 ns |   148.08 ns | 121,548.2 ns | 11.4746 | 2.1973 |     - |  110171 B |
| &#39;Create Using Constructor.&#39; |            1000 | 249,060.7 ns | 2,658.59 ns | 2,486.85 ns | 250,419.3 ns | 21.4844 |      - |     - |  217309 B |
|   **&#39;Create Using ForEach().&#39;** |              **25** |   **4,749.9 ns** |    **74.71 ns** |    **66.23 ns** |   **4,748.9 ns** |  **0.1678** |      **-** |     **-** |    **1632 B** |
|   &#39;Create Using ForEach().&#39; |              50 |  11,118.2 ns |    81.10 ns |    75.86 ns |  11,135.4 ns |  0.7782 |      - |     - |    7424 B |
|   &#39;Create Using ForEach().&#39; |             100 |  23,345.1 ns |   130.76 ns |   122.32 ns |  23,270.0 ns |  1.7090 | 0.0305 |     - |   16281 B |
|   &#39;Create Using ForEach().&#39; |             250 |  53,074.4 ns |   107.54 ns |    95.33 ns |  53,059.8 ns |  3.3569 | 0.1221 |     - |   32105 B |
|   &#39;Create Using ForEach().&#39; |             500 | 122,459.3 ns |   268.50 ns |   251.16 ns | 122,443.0 ns | 10.3760 | 1.7090 |     - |   99138 B |
|   &#39;Create Using ForEach().&#39; |            1000 | 260,589.8 ns | 1,083.48 ns |   960.48 ns | 260,495.4 ns | 21.4844 | 3.4180 |     - |  207037 B |
|   **&#39;Looping with foreach().&#39;** |              **25** |     **478.5 ns** |     **9.33 ns** |    **10.37 ns** |     **480.0 ns** |  **0.0057** |      **-** |     **-** |      **56 B** |
|   &#39;Looping with foreach().&#39; |              50 |   1,066.9 ns |    21.00 ns |    38.40 ns |   1,086.4 ns |  0.0057 |      - |     - |      56 B |
|   &#39;Looping with foreach().&#39; |             100 |   3,548.3 ns |     4.12 ns |     3.66 ns |   3,547.9 ns |  0.0038 |      - |     - |      56 B |
|   &#39;Looping with foreach().&#39; |             250 |   7,765.4 ns |    23.80 ns |    22.26 ns |   7,768.3 ns |       - |      - |     - |      56 B |
|   &#39;Looping with foreach().&#39; |             500 |  15,779.1 ns |    54.02 ns |    50.53 ns |  15,769.2 ns |       - |      - |     - |      56 B |
|   &#39;Looping with foreach().&#39; |            1000 |  32,853.1 ns |   115.04 ns |   107.60 ns |  32,821.5 ns |       - |      - |     - |      56 B |
