``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Unknown processor
.NET Core SDK=3.1.400
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-GUNMTB : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=StringBuilderExtensions  

```
|            Method |     Mean |    Error |   StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|------------------ |---------:|---------:|---------:|-------:|-------:|------:|----------:|
|       **AppendBytes** | **39.42 μs** | **0.076 μs** | **0.063 μs** | **4.9438** | **0.0610** |     **-** |  **45.69 KB** |
|        **AppendJoin** | **47.76 μs** | **0.112 μs** | **0.093 μs** | **5.1880** | **0.1221** |     **-** |   **47.6 KB** |
| **AppendJoin:Params** | **47.22 μs** | **0.207 μs** | **0.193 μs** | **5.1270** | **0.1221** |     **-** |   **47.6 KB** |
