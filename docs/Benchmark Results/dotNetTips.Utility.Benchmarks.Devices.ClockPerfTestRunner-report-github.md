``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.836 (1909/November2018Update/19H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.300
  [Host]     : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT
  Job-LAEGID : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=Clock  

```
|                Method |       Mean |      Error |     StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-----------:|-----------:|-----------:|------:|------:|------:|----------:|
|    **DaysInCurrentMonth** | **668.059 ns** | **13.3572 ns** | **22.6815 ns** |     **-** |     **-** |     **-** |         **-** |
| **DaysInCurrentUtcMonth** | **221.203 ns** |  **3.8602 ns** |  **3.6108 ns** |     **-** |     **-** |     **-** |         **-** |
|             **LocalTime** | **320.743 ns** |  **6.4459 ns** | **11.4576 ns** |     **-** |     **-** |     **-** |         **-** |
|             **TickCount** |   **2.208 ns** |  **0.0855 ns** |  **0.2031 ns** |     **-** |     **-** |     **-** |         **-** |
|               **UtcTime** |  **89.280 ns** |  **1.8090 ns** |  **3.3078 ns** |     **-** |     **-** |     **-** |         **-** |
