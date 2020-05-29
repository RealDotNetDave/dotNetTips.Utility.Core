``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.836 (1909/November2018Update/19H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.300
  [Host]     : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT
  Job-LAEGID : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=ConcurrentHashSet,GenericCollections  

```
|                      Method | CollectionCount |       Mean |     Error |     StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |---------------- |-----------:|----------:|-----------:|-------:|------:|------:|----------:|
| **&#39;Create Using Constructor.&#39;** |              **25** |  **14.182 μs** | **0.2689 μs** |  **0.2989 μs** | **0.3510** |     **-** |     **-** |    **3424 B** |
| &#39;Create Using Constructor.&#39; |              50 |  25.112 μs | 0.6516 μs |  1.8904 μs | 0.4883 |     - |     - |    4864 B |
| &#39;Create Using Constructor.&#39; |             100 |  54.296 μs | 1.0836 μs |  3.0564 μs | 1.7700 |     - |     - |   16752 B |
| &#39;Create Using Constructor.&#39; |             250 | 147.508 μs | 5.3960 μs | 15.9102 μs | 5.6152 |     - |     - |   54817 B |
|   **&#39;Create Using ForEach().&#39;** |              **25** |  **12.819 μs** | **0.3167 μs** |  **0.9338 μs** | **0.1678** |     **-** |     **-** |    **1632 B** |
|   &#39;Create Using ForEach().&#39; |              50 |  28.968 μs | 0.6045 μs |  1.7824 μs | 0.7629 |     - |     - |    7344 B |
|   &#39;Create Using ForEach().&#39; |             100 |  56.839 μs | 1.1333 μs |  2.8222 μs | 1.6479 |     - |     - |   15840 B |
|   &#39;Create Using ForEach().&#39; |             250 | 137.060 μs | 2.7275 μs |  6.7417 μs | 3.4180 |     - |     - |   33025 B |
|   **&#39;Looping with foreach().&#39;** |              **25** |   **1.242 μs** | **0.0336 μs** |  **0.0991 μs** | **0.0038** |     **-** |     **-** |      **56 B** |
|   &#39;Looping with foreach().&#39; |              50 |   2.431 μs | 0.0482 μs |  0.1117 μs | 0.0038 |     - |     - |      56 B |
|   &#39;Looping with foreach().&#39; |             100 |   5.069 μs | 0.1048 μs |  0.3074 μs |      - |     - |     - |      56 B |
|   &#39;Looping with foreach().&#39; |             250 |  12.295 μs | 0.2456 μs |  0.5017 μs |      - |     - |     - |      56 B |
