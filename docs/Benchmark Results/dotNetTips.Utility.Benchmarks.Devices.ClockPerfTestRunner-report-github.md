``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
Unknown processor
.NET Core SDK=5.0.100-preview.8.20417.9
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  Job-RATGHQ : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=Clock  

```
|                Method |       Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-----------:|----------:|----------:|------:|------:|------:|----------:|
|    **DaysInCurrentMonth** | **485.537 ns** | **0.8886 ns** | **0.7420 ns** |     **-** |     **-** |     **-** |         **-** |
| **DaysInCurrentUtcMonth** | **170.858 ns** | **0.2350 ns** | **0.2198 ns** |     **-** |     **-** |     **-** |         **-** |
|             **LocalTime** | **235.874 ns** | **0.3508 ns** | **0.3110 ns** |     **-** |     **-** |     **-** |         **-** |
|             **TickCount** |   **1.569 ns** | **0.0042 ns** | **0.0037 ns** |     **-** |     **-** |     **-** |         **-** |
|               **UtcTime** |  **69.292 ns** | **0.1362 ns** | **0.1274 ns** |     **-** |     **-** |     **-** |         **-** |
