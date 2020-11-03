``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.572 (2004/?/20H1)
Unknown processor
.NET Core SDK=5.0.100-rc.2.20479.15
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  Job-TZRVGS : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Categories=PathHelper  

```
|                Method |     Mean |   Error |  StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |---------:|--------:|--------:|-------:|------:|------:|----------:|
|   **EnsureTrailingSlash** | **167.1 ns** | **0.91 ns** | **0.85 ns** | **0.0801** |     **-** |     **-** |     **760 B** |
| **HasInvalidFilterChars** | **490.4 ns** | **4.26 ns** | **3.98 ns** | **0.0162** |     **-** |     **-** |     **160 B** |
|  **PathContainsWildcard** | **142.6 ns** | **2.70 ns** | **2.52 ns** | **0.0386** |     **-** |     **-** |     **368 B** |
|   **PathHasInvalidChars** | **307.4 ns** | **1.36 ns** | **1.14 ns** | **0.0391** |     **-** |     **-** |     **368 B** |
