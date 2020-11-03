``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.572 (2004/?/20H1)
Unknown processor
.NET Core SDK=5.0.100-rc.2.20479.15
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  Job-TZRVGS : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Categories=EncryptionHelper  

```
|             Method |     Mean |     Error |    StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|------------------- |---------:|----------:|----------:|-------:|-------:|------:|----------:|
|      **AesEncryption** | **8.210 μs** | **0.0952 μs** | **0.0890 μs** | **2.0142** |      **-** |     **-** |  **18.84 KB** |
| **RijndaelEncryption** | **8.199 μs** | **0.0328 μs** | **0.0274 μs** | **2.0447** | **0.0153** |     **-** |  **19.03 KB** |
