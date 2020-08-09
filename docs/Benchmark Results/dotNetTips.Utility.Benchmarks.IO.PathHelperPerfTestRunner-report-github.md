``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Unknown processor
.NET Core SDK=3.1.400
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-GUNMTB : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=PathHelper  

```
|                Method |     Mean |   Error |  StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |---------:|--------:|--------:|-------:|------:|------:|----------:|
|   **EnsureTrailingSlash** | **166.7 ns** | **2.14 ns** | **2.00 ns** | **0.0811** |     **-** |     **-** |     **760 B** |
| **HasInvalidFilterChars** | **485.3 ns** | **3.60 ns** | **3.01 ns** | **0.0162** |     **-** |     **-** |     **160 B** |
|  **PathContainsWildcard** | **142.3 ns** | **2.70 ns** | **2.77 ns** | **0.0389** |     **-** |     **-** |     **368 B** |
|   **PathHasInvalidChars** | **312.2 ns** | **3.90 ns** | **3.05 ns** | **0.0391** |     **-** |     **-** |     **368 B** |
