
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT
  Job-QYQXQL : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=ConcurrentHashSet,GenericCollections  

                      Method | CollectionCount |        Mean |     Error |    StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
---------------------------- |---------------- |------------:|----------:|----------:|-------:|-------:|------:|----------:|
 **'Create Using Constructor.'** |              **25** |  **5,221.4 ns** |   **7.31 ns** |   **6.83 ns** | **0.3510** |      **-** |     **-** |    **3344 B** |
 'Create Using Constructor.' |              50 | 10,968.3 ns |  26.07 ns |  23.11 ns | 0.8392 |      - |     - |    7976 B |
 'Create Using Constructor.' |             100 | 21,083.3 ns |  51.12 ns |  47.81 ns | 1.7395 |      - |     - |   16392 B |
 'Create Using Constructor.' |             250 | 58,305.8 ns | 166.98 ns | 156.19 ns | 5.9204 | 0.4272 |     - |   54417 B |
   **'Create Using ForEach().'** |              **25** |  **6,048.3 ns** | **124.10 ns** | **147.73 ns** | **0.5951** |      **-** |     **-** |    **5624 B** |
   'Create Using ForEach().' |              50 | 11,051.3 ns |  17.23 ns |  15.28 ns | 0.7629 |      - |     - |    7264 B |
   'Create Using ForEach().' |             100 | 22,584.5 ns |  36.49 ns |  34.14 ns | 1.6785 | 0.0305 |     - |   16080 B |
   'Create Using ForEach().' |             250 | 62,119.9 ns | 108.47 ns | 101.46 ns | 5.8594 |      - |     - |   55065 B |
   **'Looping with foreach().'** |              **25** |    **549.4 ns** |   **1.42 ns** |   **1.33 ns** | **0.0057** |      **-** |     **-** |      **56 B** |
   'Looping with foreach().' |              50 |  1,089.6 ns |   1.44 ns |   1.28 ns | 0.0057 |      - |     - |      56 B |
   'Looping with foreach().' |             100 |  2,191.0 ns |   6.75 ns |   5.98 ns | 0.0038 |      - |     - |      56 B |
   'Looping with foreach().' |             250 |  5,756.1 ns |   9.20 ns |   8.16 ns |      - |      - |     - |      56 B |
