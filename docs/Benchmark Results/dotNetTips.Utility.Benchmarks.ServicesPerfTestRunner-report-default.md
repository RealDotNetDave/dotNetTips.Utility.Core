
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.572 (2004/?/20H1)
Unknown processor
.NET Core SDK=5.0.100-rc.2.20479.15
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  Job-TZRVGS : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Categories=Services  

        Method |     Mean |   Error |  StdDev |  Gen 0 |  Gen 1 |  Gen 2 | Allocated |
-------------- |---------:|--------:|--------:|-------:|-------:|-------:|----------:|
   **AllServices** | **975.7 μs** | **7.12 μs** | **6.32 μs** | **9.7656** | **3.9063** |      **-** | **104.04 KB** |
 **ServiceExists** | **951.1 μs** | **8.04 μs** | **7.52 μs** | **9.7656** | **4.8828** |      **-** | **104.11 KB** |
 **ServiceStatus** | **946.4 μs** | **3.79 μs** | **3.16 μs** | **9.7656** | **4.8828** | **0.9766** | **104.11 KB** |
