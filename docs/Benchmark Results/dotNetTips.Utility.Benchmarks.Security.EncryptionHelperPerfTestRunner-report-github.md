``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Unknown processor
.NET Core SDK=3.1.400
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-GUNMTB : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=EncryptionHelper  

```
|             Method |     Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------- |---------:|----------:|----------:|-------:|------:|------:|----------:|
|      **AesEncryption** | **8.466 μs** | **0.1286 μs** | **0.1321 μs** | **2.0294** |     **-** |     **-** |  **18.84 KB** |
| **RijndaelEncryption** | **7.954 μs** | **0.1573 μs** | **0.2256 μs** | **2.0447** |     **-** |     **-** |  **19.03 KB** |
