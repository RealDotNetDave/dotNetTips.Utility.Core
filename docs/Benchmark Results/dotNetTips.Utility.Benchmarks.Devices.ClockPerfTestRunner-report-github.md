``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.200
  [Host]     : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
  Job-KHIYCC : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=Clock  

```
|                Method |       Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-----------:|----------:|----------:|------:|------:|------:|----------:|
|    **DaysInCurrentMonth** | **492.483 ns** | **0.9022 ns** | **0.8439 ns** |     **-** |     **-** |     **-** |         **-** |
| **DaysInCurrentUtcMonth** | **162.944 ns** | **0.2159 ns** | **0.1914 ns** |     **-** |     **-** |     **-** |         **-** |
|             **LocalTime** | **228.303 ns** | **0.2651 ns** | **0.2070 ns** |     **-** |     **-** |     **-** |         **-** |
|             **TickCount** |   **1.728 ns** | **0.0039 ns** | **0.0037 ns** |     **-** |     **-** |     **-** |         **-** |
|               **UtcTime** |  **65.927 ns** | **0.1420 ns** | **0.1328 ns** |     **-** |     **-** |     **-** |         **-** |
