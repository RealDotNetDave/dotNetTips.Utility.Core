``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.572 (2004/?/20H1)
Unknown processor
.NET Core SDK=5.0.100-rc.2.20479.15
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  Job-TZRVGS : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Categories=StringBuilderExtensions  

```
|            Method |     Mean |    Error |   StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|------------------ |---------:|---------:|---------:|-------:|-------:|------:|----------:|
|       **AppendBytes** | **40.90 μs** | **0.082 μs** | **0.077 μs** | **4.8828** | **0.0610** |     **-** |  **45.69 KB** |
|        **AppendJoin** | **48.18 μs** | **0.076 μs** | **0.072 μs** | **5.1270** | **0.1221** |     **-** |   **47.6 KB** |
| **AppendJoin:Params** | **48.19 μs** | **0.058 μs** | **0.054 μs** | **5.1270** | **0.1221** |     **-** |   **47.6 KB** |
