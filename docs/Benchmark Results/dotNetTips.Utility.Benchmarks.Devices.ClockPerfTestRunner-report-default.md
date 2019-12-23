
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT
  Job-QYQXQL : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=Clock  

                Method |       Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
---------------------- |-----------:|----------:|----------:|------:|------:|------:|----------:|
    **DaysInCurrentMonth** | **497.030 ns** | **0.3375 ns** | **0.2819 ns** |     **-** |     **-** |     **-** |         **-** |
 **DaysInCurrentUtcMonth** | **164.782 ns** | **0.2541 ns** | **0.2253 ns** |     **-** |     **-** |     **-** |         **-** |
             **LocalTime** | **221.138 ns** | **0.1205 ns** | **0.1069 ns** |     **-** |     **-** |     **-** |         **-** |
             **TickCount** |   **1.730 ns** | **0.0455 ns** | **0.0425 ns** |     **-** |     **-** |     **-** |         **-** |
               **UtcTime** |  **64.722 ns** | **0.1645 ns** | **0.1539 ns** |     **-** |     **-** |     **-** |         **-** |
