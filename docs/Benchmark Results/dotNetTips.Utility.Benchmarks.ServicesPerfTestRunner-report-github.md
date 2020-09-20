``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
Unknown processor
.NET Core SDK=5.0.100-preview.8.20417.9
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  Job-RATGHQ : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=Services  

```
|        Method |     Mean |   Error |  StdDev |  Gen 0 |  Gen 1 |  Gen 2 | Allocated |
|-------------- |---------:|--------:|--------:|-------:|-------:|-------:|----------:|
|   **AllServices** | **946.1 μs** | **4.02 μs** | **3.56 μs** | **9.7656** | **4.8828** | **0.9766** | **102.51 KB** |
| **ServiceExists** | **945.9 μs** | **7.11 μs** | **6.65 μs** | **9.7656** | **4.8828** |      **-** | **102.58 KB** |
| **ServiceStatus** | **942.2 μs** | **6.80 μs** | **6.03 μs** | **9.7656** | **4.8828** |      **-** | **102.58 KB** |
