``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100-preview3-014645
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-UEOGOB : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=Clock  

```
|                Method |       Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-----------:|----------:|----------:|------:|------:|------:|----------:|
|    **DaysInCurrentMonth** | **458.011 ns** | **0.5243 ns** | **0.4648 ns** |     **-** |     **-** |     **-** |         **-** |
| **DaysInCurrentUtcMonth** | **165.229 ns** | **0.1647 ns** | **0.1460 ns** |     **-** |     **-** |     **-** |         **-** |
|             **LocalTime** | **216.149 ns** | **0.2759 ns** | **0.2580 ns** |     **-** |     **-** |     **-** |         **-** |
|             **TickCount** |   **1.787 ns** | **0.0036 ns** | **0.0034 ns** |     **-** |     **-** |     **-** |         **-** |
|               **UtcTime** |  **65.497 ns** | **0.9254 ns** | **0.8656 ns** |     **-** |     **-** |     **-** |         **-** |
