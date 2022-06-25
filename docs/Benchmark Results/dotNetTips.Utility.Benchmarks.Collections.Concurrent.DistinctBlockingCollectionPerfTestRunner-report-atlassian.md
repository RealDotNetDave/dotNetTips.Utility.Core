{noformat}

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.300-preview.21180.15
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  Job-SOGKAI : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Namespace=dotNetTips.Utility.Benchmarks.Collections.Concurrent  Categories=DistinctBlockingCollection,GenericCollections  

{noformat}
||                            Method ||CollectionCount ||         Mean ||       Error ||      StdDev ||    StdErr ||       Median ||          Min ||           Q1 ||           Q3 ||          Max ||        Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline ||Code Size || Gen 0 ||Gen 1 ||Gen 2 ||Allocated ||
|      *'Creating Using Constructor.'* |              *10* |   *1,433.95 ns* |    *11.152 ns* |     *9.886 ns* |   *2.642 ns* |   *1,436.53 ns* |   *1,407.51 ns* |   *1,428.98 ns* |   *1,439.68 ns* |   *1,448.94 ns* |    *697,375.6* |     *11.1522 ns* |      *14.00* |    *4.150* |  *2.000* |  *-1.1156* |    *4* |            *** |       *No* |     *279 B* | *0.1392* |     *-* |     *-* |    *1320 B* |
|      'Creating Using Constructor.' |              25 |   3,011.27 ns |     8.144 ns |     7.618 ns |   1.967 ns |   3,014.00 ns |   2,997.20 ns |   3,008.80 ns |   3,014.93 ns |   3,020.95 ns |    332,086.3 |      8.1437 ns |      15.00 |    2.137 |  2.000 |  -0.7540 |    7 |            * |       No |     279 B | 0.1526 |     - |     - |    1440 B |
|      'Creating Using Constructor.' |              50 |   5,459.17 ns |    46.707 ns |    43.690 ns |  11.281 ns |   5,473.08 ns |   5,337.42 ns |   5,453.97 ns |   5,482.00 ns |   5,498.26 ns |    183,178.1 |     46.7069 ns |      15.00 |    4.603 |  2.000 |  -1.5834 |    9 |            * |       No |     279 B | 0.1755 |     - |     - |    1640 B |
|      'Creating Using Constructor.' |             100 |  10,769.58 ns |   214.830 ns |   179.393 ns |  49.755 ns |  10,768.73 ns |  10,539.25 ns |  10,658.08 ns |  10,795.68 ns |  11,134.48 ns |     92,854.1 |    214.8298 ns |      13.00 |    2.647 |  2.000 |   0.8985 |   10 |            * |       No |     279 B | 0.2136 |     - |     - |    2040 B |
|      'Creating Using Constructor.' |             250 |  26,287.04 ns |   184.124 ns |   172.230 ns |  44.470 ns |  26,267.65 ns |  25,878.88 ns |  26,221.47 ns |  26,418.79 ns |  26,525.20 ns |     38,041.6 |    184.1242 ns |      15.00 |    2.783 |  2.000 |  -0.6873 |   11 |            * |       No |     279 B | 0.3357 |     - |     - |    3240 B |
|      'Creating Using Constructor.' |             500 |  52,259.44 ns |   945.201 ns |   789.286 ns | 218.908 ns |  52,226.04 ns |  51,274.68 ns |  51,806.53 ns |  52,454.30 ns |  54,497.47 ns |     19,135.3 |    945.2011 ns |      13.00 |    5.261 |  2.000 |   1.4960 |   12 |            * |       No |     279 B | 0.5493 |     - |     - |    5240 B |
|      'Creating Using Constructor.' |            1000 | 104,103.00 ns |   691.851 ns |   613.308 ns | 163.914 ns | 104,146.80 ns | 102,972.97 ns | 103,575.88 ns | 104,584.16 ns | 105,095.58 ns |      9,605.9 |    691.8514 ns |      14.00 |    1.844 |  2.000 |  -0.1094 |   13 |            * |       No |     279 B | 0.9766 |     - |     - |    9240 B |
|            *'Creating Using for().'* |              *10* |   *1,306.06 ns* |    *21.440 ns* |    *17.903 ns* |   *4.965 ns* |   *1,311.42 ns* |   *1,260.72 ns* |   *1,309.02 ns* |   *1,315.77 ns* |   *1,322.78 ns* |    *765,662.2* |     *21.4396 ns* |      *13.00* |    *3.850* |  *2.000* |  *-1.4688* |    *3* |            *** |       *No* |     *587 B* | *0.1278* |     *-* |     *-* |    *1208 B* |
|            'Creating Using for().' |              25 |   2,814.21 ns |    18.520 ns |    17.324 ns |   4.473 ns |   2,809.58 ns |   2,794.41 ns |   2,798.45 ns |   2,826.85 ns |   2,848.31 ns |    355,339.6 |     18.5202 ns |      15.00 |    1.709 |  2.000 |   0.4401 |    6 |            * |       No |     587 B | 0.1259 |     - |     - |    1208 B |
|            'Creating Using for().' |              50 |   5,393.09 ns |    27.628 ns |    25.843 ns |   6.673 ns |   5,384.05 ns |   5,356.89 ns |   5,375.09 ns |   5,405.61 ns |   5,449.89 ns |    185,422.4 |     27.6276 ns |      15.00 |    2.340 |  2.000 |   0.6031 |    8 |            * |       No |     587 B | 0.1221 |     - |     - |    1208 B |
|            'Creating Using for().' |             100 |  10,901.31 ns |   212.213 ns |   311.059 ns |  57.762 ns |  10,710.53 ns |  10,453.97 ns |  10,677.67 ns |  11,174.40 ns |  11,568.33 ns |     91,732.1 |    212.2131 ns |      29.00 |    1.763 |  3.250 |   0.4112 |   10 |            * |       No |     587 B | 0.1221 |     - |     - |    1208 B |
|            'Creating Using for().' |             250 |  26,418.31 ns |   172.633 ns |   161.481 ns |  41.694 ns |  26,458.57 ns |  26,057.37 ns |  26,338.38 ns |  26,538.80 ns |  26,601.85 ns |     37,852.5 |    172.6332 ns |      15.00 |    2.418 |  2.000 |  -0.8516 |   11 |            * |       No |     587 B | 0.1221 |     - |     - |    1208 B |
|            'Creating Using for().' |             500 |  52,293.04 ns |   487.788 ns |   456.277 ns | 117.810 ns |  52,354.74 ns |  51,538.18 ns |  52,008.86 ns |  52,521.93 ns |  53,105.62 ns |     19,123.0 |    487.7880 ns |      15.00 |    2.187 |  2.000 |   0.1398 |   12 |            * |       No |     587 B | 0.1221 |     - |     - |    1208 B |
|            'Creating Using for().' |            1000 | 103,740.79 ns | 1,229.836 ns | 1,150.390 ns | 297.029 ns | 103,579.00 ns | 101,834.91 ns | 103,023.23 ns | 104,401.62 ns | 106,040.10 ns |      9,639.4 |  1,229.8363 ns |      15.00 |    2.121 |  2.000 |   0.1547 |   13 |            * |       No |     587 B |      - |     - |     - |    1209 B |
|          *'Looping with foreach().'* |              *10* |      *45.13 ns* |     *0.406 ns* |     *0.380 ns* |   *0.098 ns* |      *45.12 ns* |      *44.39 ns* |      *44.84 ns* |      *45.43 ns* |      *45.67 ns* | *22,159,898.3* |      *0.4064 ns* |      *15.00* |    *1.831* |  *2.000* |  *-0.2526* |    *2* |            *** |       *No* |     *225 B* | *0.0085* |     *-* |     *-* |      *80 B* |
|          'Looping with foreach().' |              25 |      44.02 ns |     0.315 ns |     0.295 ns |   0.076 ns |      43.99 ns |      43.49 ns |      43.89 ns |      44.19 ns |      44.54 ns | 22,718,085.7 |      0.3154 ns |      15.00 |    2.310 |  2.000 |   0.0690 |    1 |            * |       No |     225 B | 0.0085 |     - |     - |      80 B |
|          'Looping with foreach().' |              50 |      44.39 ns |     0.283 ns |     0.251 ns |   0.067 ns |      44.38 ns |      44.03 ns |      44.21 ns |      44.53 ns |      44.86 ns | 22,529,381.0 |      0.2834 ns |      14.00 |    1.849 |  2.000 |   0.2528 |    1 |            * |       No |     225 B | 0.0085 |     - |     - |      80 B |
|          'Looping with foreach().' |             100 |      44.11 ns |     0.172 ns |     0.134 ns |   0.039 ns |      44.14 ns |      43.76 ns |      44.11 ns |      44.15 ns |      44.30 ns | 22,670,749.1 |      0.1719 ns |      12.00 |    4.126 |  2.000 |  -1.2382 |    1 |            * |       No |     225 B | 0.0085 |     - |     - |      80 B |
|          'Looping with foreach().' |             250 |      43.56 ns |     0.365 ns |     0.323 ns |   0.086 ns |      43.46 ns |      43.05 ns |      43.32 ns |      43.77 ns |      44.22 ns | 22,959,041.1 |      0.3647 ns |      14.00 |    2.034 |  2.000 |   0.3495 |    1 |            * |       No |     225 B | 0.0085 |     - |     - |      80 B |
|          'Looping with foreach().' |             500 |      44.19 ns |     0.217 ns |     0.192 ns |   0.051 ns |      44.23 ns |      43.85 ns |      44.07 ns |      44.32 ns |      44.50 ns | 22,627,560.0 |      0.2169 ns |      14.00 |    1.874 |  2.000 |  -0.2238 |    1 |            * |       No |     225 B | 0.0085 |     - |     - |      80 B |
|          'Looping with foreach().' |            1000 |      45.57 ns |     0.236 ns |     0.210 ns |   0.056 ns |      45.59 ns |      45.12 ns |      45.55 ns |      45.73 ns |      45.82 ns | 21,944,993.6 |      0.2364 ns |      14.00 |    2.398 |  2.000 |  -0.8521 |    2 |            * |       No |     225 B | 0.0084 |     - |     - |      80 B |
| *'Looping with Parallel.ForEach().'* |              *10* |   *2,586.17 ns* |     *7.937 ns* |     *7.425 ns* |   *1.917 ns* |   *2,586.94 ns* |   *2,571.21 ns* |   *2,581.07 ns* |   *2,590.98 ns* |   *2,597.65 ns* |    *386,671.6* |      *7.9375 ns* |      *15.00* |    *2.061* |  *2.000* |  *-0.2486* |    *5* |            *** |       *No* |     *368 B* | *0.6828* |     *-* |     *-* |    *5175 B* |
| 'Looping with Parallel.ForEach().' |              25 |   2,583.84 ns |     8.013 ns |     7.496 ns |   1.935 ns |   2,587.29 ns |   2,571.43 ns |   2,576.91 ns |   2,589.66 ns |   2,594.62 ns |    387,020.9 |      8.0132 ns |      15.00 |    1.501 |  2.000 |  -0.2750 |    5 |            * |       No |     368 B | 0.6714 |     - |     - |    5175 B |
| 'Looping with Parallel.ForEach().' |              50 |   2,539.28 ns |     6.425 ns |     6.010 ns |   1.552 ns |   2,538.99 ns |   2,530.70 ns |   2,535.50 ns |   2,544.13 ns |   2,552.16 ns |    393,811.9 |      6.4254 ns |      15.00 |    2.202 |  2.000 |   0.3275 |    5 |            * |       No |     368 B | 0.7133 |     - |     - |    5175 B |
| 'Looping with Parallel.ForEach().' |             100 |   2,550.85 ns |     4.535 ns |     3.787 ns |   1.050 ns |   2,550.32 ns |   2,545.23 ns |   2,548.78 ns |   2,553.22 ns |   2,559.01 ns |    392,026.1 |      4.5353 ns |      13.00 |    2.435 |  2.000 |   0.4297 |    5 |            * |       No |     368 B | 0.6752 |     - |     - |    5173 B |
| 'Looping with Parallel.ForEach().' |             250 |   2,570.86 ns |     6.392 ns |     5.979 ns |   1.544 ns |   2,571.53 ns |   2,557.27 ns |   2,567.95 ns |   2,575.08 ns |   2,578.37 ns |    388,975.1 |      6.3917 ns |      15.00 |    2.550 |  2.000 |  -0.7330 |    5 |            * |       No |     368 B | 0.6714 |     - |     - |    5178 B |
| 'Looping with Parallel.ForEach().' |             500 |   2,578.84 ns |     7.146 ns |     6.685 ns |   1.726 ns |   2,578.87 ns |   2,566.46 ns |   2,575.71 ns |   2,583.07 ns |   2,589.77 ns |    387,770.7 |      7.1464 ns |      15.00 |    2.009 |  2.000 |  -0.2716 |    5 |            * |       No |     368 B | 0.6828 |     - |     - |    5175 B |
| 'Looping with Parallel.ForEach().' |            1000 |   2,548.65 ns |     5.655 ns |     5.290 ns |   1.366 ns |   2,547.40 ns |   2,541.03 ns |   2,545.83 ns |   2,551.37 ns |   2,559.68 ns |    392,364.3 |      5.6549 ns |      15.00 |    2.302 |  2.000 |   0.5545 |    5 |            * |       No |     368 B | 0.6905 |     - |     - |    5175 B |