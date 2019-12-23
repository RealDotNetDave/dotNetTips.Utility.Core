``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT
  Job-QYQXQL : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=StringExtensions  

```
|            Method |         Mean |      Error |     StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|------------------ |-------------:|-----------:|-----------:|-------:|-------:|------:|----------:|
| **ComputeSha256Hash** | **6,133.034 ns** | **12.5422 ns** | **11.7320 ns** | **0.2823** |      **-** |     **-** |    **2760 B** |
|            **Concat** |   **573.840 ns** |  **4.4345 ns** |  **4.1480 ns** | **0.6409** | **0.0038** |     **-** |    **6064 B** |
|       **ContainsAny** |    **65.912 ns** |  **0.1428 ns** |  **0.1266 ns** | **0.0170** |      **-** |     **-** |     **160 B** |
|          **HasValue** |     **6.339 ns** |  **0.0597 ns** |  **0.0558 ns** |      **-** |      **-** |     **-** |         **-** |
|            **Indent** |   **438.488 ns** |  **2.6027 ns** |  **2.4346 ns** | **0.4334** | **0.0019** |     **-** |    **4088 B** |
|   **ToTrimmedString** |   **215.051 ns** |  **3.2300 ns** |  **3.0214 ns** | **0.2089** | **0.0002** |     **-** |    **1960 B** |
