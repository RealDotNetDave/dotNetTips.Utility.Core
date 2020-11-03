
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.572 (2004/?/20H1)
Unknown processor
.NET Core SDK=5.0.100-rc.2.20479.15
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  Job-TZRVGS : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Categories=ConcurrentHashSet,GenericCollections  

                      Method | CollectionCount |         Mean |     Error |    StdDev |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
---------------------------- |---------------- |-------------:|----------:|----------:|--------:|-------:|------:|----------:|
 **'Create Using Constructor.'** |              **25** |   **5,061.3 ns** |  **14.05 ns** |  **13.14 ns** |  **0.3510** |      **-** |     **-** |    **3344 B** |
 'Create Using Constructor.' |              50 |  10,277.0 ns |  19.56 ns |  16.33 ns |  0.7629 |      - |     - |    7336 B |
 'Create Using Constructor.' |             100 |  23,229.4 ns | 334.98 ns | 313.34 ns |  1.8311 | 0.0305 |     - |   17232 B |
 'Create Using Constructor.' |             250 |  58,780.3 ns | 121.97 ns | 114.10 ns |  5.7983 | 0.3662 |     - |   54577 B |
 'Create Using Constructor.' |             500 | 119,854.9 ns | 296.27 ns | 277.13 ns | 10.9863 |      - |     - |  106091 B |
 'Create Using Constructor.' |            1000 | 241,252.1 ns | 439.08 ns | 410.71 ns | 21.7285 | 4.8828 |     - |  209221 B |
   **'Create Using ForEach().'** |              **25** |   **5,326.6 ns** |  **11.79 ns** |  **11.03 ns** |  **0.3586** |      **-** |     **-** |    **3392 B** |
   'Create Using ForEach().' |              50 |  10,933.6 ns |  89.80 ns |  79.60 ns |  0.7629 |      - |     - |    7264 B |
   'Create Using ForEach().' |             100 |  22,843.9 ns |  83.84 ns |  74.32 ns |  1.5564 | 0.0305 |     - |   15001 B |
   'Create Using ForEach().' |             250 |  60,668.3 ns | 142.55 ns | 133.34 ns |  5.4932 |      - |     - |   51945 B |
   'Create Using ForEach().' |             500 | 126,422.0 ns | 316.98 ns | 264.69 ns | 11.4746 | 1.4648 |     - |  108339 B |
   'Create Using ForEach().' |            1000 | 246,625.3 ns | 665.00 ns | 622.04 ns | 21.9727 | 4.8828 |     - |  200997 B |
   **'Looping with foreach().'** |              **25** |     **324.0 ns** |   **1.59 ns** |   **1.24 ns** |  **0.0057** |      **-** |     **-** |      **56 B** |
   'Looping with foreach().' |              50 |   1,217.5 ns |  24.29 ns |  47.95 ns |  0.0057 |      - |     - |      56 B |
   'Looping with foreach().' |             100 |   2,344.3 ns |   3.51 ns |   2.93 ns |  0.0038 |      - |     - |      56 B |
   'Looping with foreach().' |             250 |   7,923.1 ns |  11.00 ns |  10.29 ns |       - |      - |     - |      56 B |
   'Looping with foreach().' |             500 |  16,005.6 ns |  67.28 ns |  62.93 ns |       - |      - |     - |      56 B |
   'Looping with foreach().' |            1000 |  32,591.6 ns | 432.33 ns | 404.40 ns |       - |      - |     - |      56 B |
