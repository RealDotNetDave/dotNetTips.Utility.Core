``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Unknown processor
.NET Core SDK=3.1.400
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-GUNMTB : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=Clock  

```
|                Method |       Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-----------:|----------:|----------:|------:|------:|------:|----------:|
|    **DaysInCurrentMonth** | **485.669 ns** | **0.5505 ns** | **0.4298 ns** |     **-** |     **-** |     **-** |         **-** |
| **DaysInCurrentUtcMonth** | **170.345 ns** | **0.1105 ns** | **0.0923 ns** |     **-** |     **-** |     **-** |         **-** |
|             **LocalTime** | **231.378 ns** | **0.6164 ns** | **0.5464 ns** |     **-** |     **-** |     **-** |         **-** |
|             **TickCount** |   **1.545 ns** | **0.0379 ns** | **0.0354 ns** |     **-** |     **-** |     **-** |         **-** |
|               **UtcTime** |  **67.312 ns** | **0.1200 ns** | **0.1002 ns** |     **-** |     **-** |     **-** |         **-** |
