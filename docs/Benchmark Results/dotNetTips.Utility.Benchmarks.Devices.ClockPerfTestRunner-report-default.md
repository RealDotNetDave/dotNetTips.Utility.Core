
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.572 (2004/?/20H1)
Unknown processor
.NET Core SDK=5.0.100-rc.2.20479.15
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  Job-TZRVGS : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Categories=Clock  

                Method |       Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
---------------------- |-----------:|----------:|----------:|------:|------:|------:|----------:|
    **DaysInCurrentMonth** | **455.079 ns** | **0.6964 ns** | **0.6514 ns** |     **-** |     **-** |     **-** |         **-** |
 **DaysInCurrentUtcMonth** | **171.172 ns** | **0.1692 ns** | **0.1582 ns** |     **-** |     **-** |     **-** |         **-** |
             **LocalTime** | **219.738 ns** | **0.5149 ns** | **0.4564 ns** |     **-** |     **-** |     **-** |         **-** |
             **TickCount** |   **1.570 ns** | **0.0054 ns** | **0.0050 ns** |     **-** |     **-** |     **-** |         **-** |
               **UtcTime** |  **69.574 ns** | **0.7692 ns** | **0.7195 ns** |     **-** |     **-** |     **-** |         **-** |
