
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.572 (2004/?/20H1)
Unknown processor
.NET Core SDK=5.0.100-rc.2.20479.15
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  Job-TZRVGS : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Categories=DriveHelper  

             Method |     Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |---------:|---------:|---------:|-------:|------:|------:|----------:|
     **GetFixedDrives** | **20.74 μs** | **0.267 μs** | **0.250 μs** | **0.0610** |     **-** |     **-** |     **608 B** |
 **GetRemovableDrives** | **20.74 μs** | **0.065 μs** | **0.060 μs** | **0.0305** |     **-** |     **-** |     **528 B** |
