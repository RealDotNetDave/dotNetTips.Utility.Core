
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100-preview3-014645
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-UEOGOB : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DistinctBlockingCollection,GenericCollections  

                             Method | CollectionCount |         Mean |      Error |     StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
----------------------------------- |---------------- |-------------:|-----------:|-----------:|-------:|------:|------:|----------:|
      **'Creating Using Constructor.'** |              **25** |  **2,788.38 ns** |  **13.771 ns** |  **12.208 ns** | **0.1488** |     **-** |     **-** |    **1440 B** |
      'Creating Using Constructor.' |              50 |  5,290.47 ns |  12.207 ns |  11.418 ns | 0.1755 |     - |     - |    1640 B |
      'Creating Using Constructor.' |             100 | 10,361.55 ns | 200.764 ns | 214.815 ns | 0.2136 |     - |     - |    2040 B |
      'Creating Using Constructor.' |             250 | 25,243.51 ns | 283.724 ns | 265.396 ns | 0.3357 |     - |     - |    3240 B |
            **'Creating Using for().'** |              **25** |  **2,757.80 ns** |   **5.245 ns** |   **4.650 ns** | **0.1297** |     **-** |     **-** |    **1208 B** |
            'Creating Using for().' |              50 |  5,235.70 ns |   6.187 ns |   5.167 ns | 0.1221 |     - |     - |    1208 B |
            'Creating Using for().' |             100 | 10,304.99 ns | 114.942 ns | 101.893 ns | 0.1221 |     - |     - |    1208 B |
            'Creating Using for().' |             250 | 25,207.36 ns |  51.886 ns |  45.995 ns | 0.1221 |     - |     - |    1208 B |
          **'Looping with foreach().'** |              **25** |     **40.23 ns** |   **0.521 ns** |   **0.407 ns** | **0.0085** |     **-** |     **-** |      **80 B** |
          'Looping with foreach().' |              50 |     41.58 ns |   0.281 ns |   0.263 ns | 0.0085 |     - |     - |      80 B |
          'Looping with foreach().' |             100 |     42.27 ns |   0.301 ns |   0.282 ns | 0.0085 |     - |     - |      80 B |
          'Looping with foreach().' |             250 |     41.95 ns |   0.126 ns |   0.118 ns | 0.0085 |     - |     - |      80 B |
 **'Looping with Parallel.ForEach().'** |              **25** |  **2,250.10 ns** |   **3.393 ns** |   **3.173 ns** | **0.6943** |     **-** |     **-** |    **5165 B** |
 'Looping with Parallel.ForEach().' |              50 |  2,310.94 ns |  26.051 ns |  24.368 ns | 0.6828 |     - |     - |    5162 B |
 'Looping with Parallel.ForEach().' |             100 |  2,270.76 ns |   3.505 ns |   3.107 ns | 0.7133 |     - |     - |    5164 B |
 'Looping with Parallel.ForEach().' |             250 |  2,250.07 ns |   4.677 ns |   4.375 ns | 0.6981 |     - |     - |    5167 B |
