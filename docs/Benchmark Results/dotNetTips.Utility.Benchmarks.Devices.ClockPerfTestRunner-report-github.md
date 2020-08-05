``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.302
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-GMGNJH : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=Clock  

```
|                Method |       Mean |      Error |     StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-----------:|-----------:|-----------:|------:|------:|------:|----------:|
|    **DaysInCurrentMonth** | **525.171 ns** | **10.3425 ns** | **14.1570 ns** |     **-** |     **-** |     **-** |         **-** |
| **DaysInCurrentUtcMonth** | **179.894 ns** |  **3.5646 ns** |  **3.3343 ns** |     **-** |     **-** |     **-** |         **-** |
|             **LocalTime** | **254.022 ns** |  **3.2375 ns** |  **2.8700 ns** |     **-** |     **-** |     **-** |         **-** |
|             **TickCount** |   **1.599 ns** |  **0.0614 ns** |  **0.0754 ns** |     **-** |     **-** |     **-** |         **-** |
|               **UtcTime** |  **73.565 ns** |  **1.4117 ns** |  **1.3205 ns** |     **-** |     **-** |     **-** |         **-** |
