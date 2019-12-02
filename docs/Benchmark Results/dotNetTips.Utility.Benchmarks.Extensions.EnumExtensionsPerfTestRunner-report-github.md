``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100-preview3-014645
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-UEOGOB : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=EnumExtensions  

```
|   Method |     Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |---------:|----------:|----------:|-------:|------:|------:|----------:|
| GetItems | 4.273 us | 0.0225 us | 0.0211 us | 0.0916 |     - |     - |     872 B |
