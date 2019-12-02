``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100-preview3-014645
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-UEOGOB : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DriveHelper  

```
|         Method |     Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------- |---------:|---------:|---------:|-------:|------:|------:|----------:|
| GetFixedDrives | 13.63 us | 0.160 us | 0.149 us | 0.0610 |     - |     - |     608 B |
