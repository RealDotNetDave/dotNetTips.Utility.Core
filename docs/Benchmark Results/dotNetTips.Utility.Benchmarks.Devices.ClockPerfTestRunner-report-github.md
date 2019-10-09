``` ini

BenchmarkDotNet=v0.11.5.1191-nightly, OS=Windows 10.0.17763.775 (1809/October2018Update/Redstone5)
Unknown processor
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-RGRUUZ : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=Clock  

```
|                Method |       Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-----------:|----------:|----------:|------:|------:|------:|----------:|
|    **DaysInCurrentMonth** | **506.637 ns** | **0.7172 ns** | **0.6708 ns** |     **-** |     **-** |     **-** |         **-** |
| **DaysInCurrentUtcMonth** | **170.533 ns** | **0.2128 ns** | **0.1886 ns** |     **-** |     **-** |     **-** |         **-** |
|             **LocalTime** | **241.918 ns** | **0.5220 ns** | **0.4628 ns** |     **-** |     **-** |     **-** |         **-** |
|             **TickCount** |   **1.738 ns** | **0.0442 ns** | **0.0414 ns** |     **-** |     **-** |     **-** |         **-** |
|               **UtcTime** |  **67.108 ns** | **0.2167 ns** | **0.2027 ns** |     **-** |     **-** |     **-** |         **-** |
