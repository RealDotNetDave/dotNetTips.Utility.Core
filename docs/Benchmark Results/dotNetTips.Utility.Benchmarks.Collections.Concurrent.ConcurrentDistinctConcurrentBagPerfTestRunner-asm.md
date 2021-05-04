## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner.Creating01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+58]
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 65
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_System.Collections.Generic.HashSet`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,22315058D30
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      System.Collections.Generic.HashSet`1[[System.Int32, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEqualityComparer`1<Int32>)
       lea       rcx,[rsi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       test      rdi,rdi
       je        near ptr M01_L02
       mov       rbx,[rsi]
       mov       rcx,rbx
       mov       rdx,[rcx+30]
       mov       rbp,[rdx+8]
       mov       rax,[rbp+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AA34B00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       mov       rcx,rax
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,rbx
       mov       rax,[rbp+10]
       test      rax,rax
       jne       short M01_L01
       mov       rdx,7FF88AA34C40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].<.ctor>b__3_0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,rdi
       mov       rdx,rbx
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M01_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 268
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner.Creating01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+58]
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 65
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_System.Collections.Generic.HashSet`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1B5F9DB8D30
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      System.Collections.Generic.HashSet`1[[System.Int32, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEqualityComparer`1<Int32>)
       lea       rcx,[rsi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       test      rdi,rdi
       je        near ptr M01_L02
       mov       rbx,[rsi]
       mov       rcx,rbx
       mov       rdx,[rcx+30]
       mov       rbp,[rdx+8]
       mov       rax,[rbp+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AA14B78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       mov       rcx,rax
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,rbx
       mov       rax,[rbp+10]
       test      rax,rax
       jne       short M01_L01
       mov       rdx,7FF88AA14CB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].<.ctor>b__3_0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,rdi
       mov       rdx,rbx
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M01_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 268
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner.Creating01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+58]
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 65
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_System.Collections.Generic.HashSet`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,18BDECD8D30
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      System.Collections.Generic.HashSet`1[[System.Int32, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEqualityComparer`1<Int32>)
       lea       rcx,[rsi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       test      rdi,rdi
       je        near ptr M01_L02
       mov       rbx,[rsi]
       mov       rcx,rbx
       mov       rdx,[rcx+30]
       mov       rbp,[rdx+8]
       mov       rax,[rbp+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AA15400
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       mov       rcx,rax
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,rbx
       mov       rax,[rbp+10]
       test      rax,rax
       jne       short M01_L01
       mov       rdx,7FF88AA15540
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].<.ctor>b__3_0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,rdi
       mov       rdx,rbx
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M01_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 268
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner.Creating01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+58]
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 65
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_System.Collections.Generic.HashSet`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1E448F348C8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      System.Collections.Generic.HashSet`1[[System.Int32, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEqualityComparer`1<Int32>)
       lea       rcx,[rsi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       test      rdi,rdi
       je        near ptr M01_L02
       mov       rbx,[rsi]
       mov       rcx,rbx
       mov       rdx,[rcx+30]
       mov       rbp,[rdx+8]
       mov       rax,[rbp+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AA455F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       mov       rcx,rax
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,rbx
       mov       rax,[rbp+10]
       test      rax,rax
       jne       short M01_L01
       mov       rdx,7FF88AA45730
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].<.ctor>b__3_0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,rdi
       mov       rdx,rbx
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M01_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 268
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner.Creating01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+58]
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 65
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_System.Collections.Generic.HashSet`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1C0D7418D30
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      System.Collections.Generic.HashSet`1[[System.Int32, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEqualityComparer`1<Int32>)
       lea       rcx,[rsi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       test      rdi,rdi
       je        near ptr M01_L02
       mov       rbx,[rsi]
       mov       rcx,rbx
       mov       rdx,[rcx+30]
       mov       rbp,[rdx+8]
       mov       rax,[rbp+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AA254C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       mov       rcx,rax
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,rbx
       mov       rax,[rbp+10]
       test      rax,rax
       jne       short M01_L01
       mov       rdx,7FF88AA25600
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].<.ctor>b__3_0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,rdi
       mov       rdx,rbx
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M01_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 268
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner.Creating01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+58]
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 65
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_System.Collections.Generic.HashSet`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1FA487F8D30
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      System.Collections.Generic.HashSet`1[[System.Int32, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEqualityComparer`1<Int32>)
       lea       rcx,[rsi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       test      rdi,rdi
       je        near ptr M01_L02
       mov       rbx,[rsi]
       mov       rcx,rbx
       mov       rdx,[rcx+30]
       mov       rbp,[rdx+8]
       mov       rax,[rbp+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AA252D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       mov       rcx,rax
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,rbx
       mov       rax,[rbp+10]
       test      rax,rax
       jne       short M01_L01
       mov       rdx,7FF88AA25410
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].<.ctor>b__3_0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,rdi
       mov       rdx,rbx
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M01_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 268
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner.Creating01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+58]
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 65
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_System.Collections.Generic.HashSet`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1F951948D30
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      System.Collections.Generic.HashSet`1[[System.Int32, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEqualityComparer`1<Int32>)
       lea       rcx,[rsi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       test      rdi,rdi
       je        near ptr M01_L02
       mov       rbx,[rsi]
       mov       rcx,rbx
       mov       rdx,[rcx+30]
       mov       rbp,[rdx+8]
       mov       rax,[rbp+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AA352D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       mov       rcx,rax
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,rbx
       mov       rax,[rbp+10]
       test      rax,rax
       jne       short M01_L01
       mov       rdx,7FF88AA35410
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].<.ctor>b__3_0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,rdi
       mov       rdx,rbx
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M01_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 268
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner.Creating02()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbp,[rsi+58]
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rbx+18],rcx
       mov       rcx,rbp
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[rsi+8]
       mov       rdx,[rdi+8]
       mov       eax,[rcx]
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.HashSet`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2258F4F48C8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Collections.Generic.HashSet`1[[System.Int32, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEqualityComparer`1<Int32>)
       lea       rcx,[rsi+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rax,offset System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 109
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       rcx,[rcx+8]
       mov       rax,offset dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       cmp       [rcx],ecx
       jmp       rax
; Total bytes of code 19
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        short M03_L03
       mov       ebx,[rsi+14]
       xor       ebp,ebp
       cmp       dword ptr [rsi+10],0
       jle       short M03_L01
M03_L00:
       cmp       ebx,[rsi+14]
       jne       short M03_L01
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       jae       short M03_L04
       movsxd    rdx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       inc       ebp
       cmp       ebp,[rsi+10]
       jl        short M03_L00
M03_L01:
       cmp       ebx,[rsi+14]
       je        short M03_L02
       mov       rax,offset System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L03:
       mov       ecx,1C
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M03_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner.Creating02()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbp,[rsi+58]
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rbx+18],rcx
       mov       rcx,rbp
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[rsi+8]
       mov       rdx,[rdi+8]
       mov       eax,[rcx]
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.HashSet`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2121C4A68E0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Collections.Generic.HashSet`1[[System.Int32, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEqualityComparer`1<Int32>)
       lea       rcx,[rsi+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rax,offset System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 109
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       rcx,[rcx+8]
       mov       rax,offset dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       cmp       [rcx],ecx
       jmp       rax
; Total bytes of code 19
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        short M03_L03
       mov       ebx,[rsi+14]
       xor       ebp,ebp
       cmp       dword ptr [rsi+10],0
       jle       short M03_L01
M03_L00:
       cmp       ebx,[rsi+14]
       jne       short M03_L01
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       jae       short M03_L04
       movsxd    rdx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       inc       ebp
       cmp       ebp,[rsi+10]
       jl        short M03_L00
M03_L01:
       cmp       ebx,[rsi+14]
       je        short M03_L02
       mov       rax,offset System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L03:
       mov       ecx,1C
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M03_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner.Creating02()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbp,[rsi+58]
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rbx+18],rcx
       mov       rcx,rbp
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[rsi+8]
       mov       rdx,[rdi+8]
       mov       eax,[rcx]
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.HashSet`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,14159E68D30
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Collections.Generic.HashSet`1[[System.Int32, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEqualityComparer`1<Int32>)
       lea       rcx,[rsi+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rax,offset System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 109
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       rcx,[rcx+8]
       mov       rax,offset dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       cmp       [rcx],ecx
       jmp       rax
; Total bytes of code 19
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        short M03_L03
       mov       ebx,[rsi+14]
       xor       ebp,ebp
       cmp       dword ptr [rsi+10],0
       jle       short M03_L01
M03_L00:
       cmp       ebx,[rsi+14]
       jne       short M03_L01
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       jae       short M03_L04
       movsxd    rdx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       inc       ebp
       cmp       ebp,[rsi+10]
       jl        short M03_L00
M03_L01:
       cmp       ebx,[rsi+14]
       je        short M03_L02
       mov       rax,offset System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L03:
       mov       ecx,1C
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M03_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner.Creating02()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbp,[rsi+58]
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rbx+18],rcx
       mov       rcx,rbp
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[rsi+8]
       mov       rdx,[rdi+8]
       mov       eax,[rcx]
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.HashSet`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,294B7F18D30
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Collections.Generic.HashSet`1[[System.Int32, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEqualityComparer`1<Int32>)
       lea       rcx,[rsi+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rax,offset System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 109
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       rcx,[rcx+8]
       mov       rax,offset dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       cmp       [rcx],ecx
       jmp       rax
; Total bytes of code 19
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        short M03_L03
       mov       ebx,[rsi+14]
       xor       ebp,ebp
       cmp       dword ptr [rsi+10],0
       jle       short M03_L01
M03_L00:
       cmp       ebx,[rsi+14]
       jne       short M03_L01
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       jae       short M03_L04
       movsxd    rdx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       inc       ebp
       cmp       ebp,[rsi+10]
       jl        short M03_L00
M03_L01:
       cmp       ebx,[rsi+14]
       je        short M03_L02
       mov       rax,offset System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L03:
       mov       ecx,1C
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M03_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner.Creating02()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbp,[rsi+58]
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rbx+18],rcx
       mov       rcx,rbp
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[rsi+8]
       mov       rdx,[rdi+8]
       mov       eax,[rcx]
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.HashSet`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1AC3E148D30
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Collections.Generic.HashSet`1[[System.Int32, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEqualityComparer`1<Int32>)
       lea       rcx,[rsi+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rax,offset System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 109
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       rcx,[rcx+8]
       mov       rax,offset dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       cmp       [rcx],ecx
       jmp       rax
; Total bytes of code 19
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        short M03_L03
       mov       ebx,[rsi+14]
       xor       ebp,ebp
       cmp       dword ptr [rsi+10],0
       jle       short M03_L01
M03_L00:
       cmp       ebx,[rsi+14]
       jne       short M03_L01
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       jae       short M03_L04
       movsxd    rdx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       inc       ebp
       cmp       ebp,[rsi+10]
       jl        short M03_L00
M03_L01:
       cmp       ebx,[rsi+14]
       je        short M03_L02
       mov       rax,offset System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L03:
       mov       ecx,1C
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M03_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner.Creating02()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbp,[rsi+58]
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rbx+18],rcx
       mov       rcx,rbp
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[rsi+8]
       mov       rdx,[rdi+8]
       mov       eax,[rcx]
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.HashSet`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,20CF4968D30
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Collections.Generic.HashSet`1[[System.Int32, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEqualityComparer`1<Int32>)
       lea       rcx,[rsi+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rax,offset System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 109
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       rcx,[rcx+8]
       mov       rax,offset dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       cmp       [rcx],ecx
       jmp       rax
; Total bytes of code 19
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        short M03_L03
       mov       ebx,[rsi+14]
       xor       ebp,ebp
       cmp       dword ptr [rsi+10],0
       jle       short M03_L01
M03_L00:
       cmp       ebx,[rsi+14]
       jne       short M03_L01
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       jae       short M03_L04
       movsxd    rdx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       inc       ebp
       cmp       ebp,[rsi+10]
       jl        short M03_L00
M03_L01:
       cmp       ebx,[rsi+14]
       je        short M03_L02
       mov       rax,offset System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L03:
       mov       ecx,1C
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M03_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner.Creating02()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbp,[rsi+58]
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rbx+18],rcx
       mov       rcx,rbp
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[rsi+8]
       mov       rdx,[rdi+8]
       mov       eax,[rcx]
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 157
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.HashSet`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,218DBF58D30
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Collections.Generic.HashSet`1[[System.Int32, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEqualityComparer`1<Int32>)
       lea       rcx,[rsi+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rax,offset System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 109
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       rcx,[rcx+8]
       mov       rax,offset dotNetTips.Utility.Standard.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       cmp       [rcx],ecx
       jmp       rax
; Total bytes of code 19
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        short M03_L03
       mov       ebx,[rsi+14]
       xor       ebp,ebp
       cmp       dword ptr [rsi+10],0
       jle       short M03_L01
M03_L00:
       cmp       ebx,[rsi+14]
       jne       short M03_L01
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       jae       short M03_L04
       movsxd    rdx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       inc       ebp
       cmp       ebp,[rsi+10]
       jl        short M03_L00
M03_L01:
       cmp       ebx,[rsi+14]
       je        short M03_L02
       mov       rax,offset System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L03:
       mov       ecx,1C
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M03_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner.LoopingForEach01()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,[rsi+88]
       mov       ecx,[rdi]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1+Enumerator[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      qword ptr [7FF88A9C3A30]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFE0],rbx
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FF88A9C1F30]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A5A05B0
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9C05B0]
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FF88A9C1F30]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FF88A9C1F50]
       nop
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M00_L02
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FF88A9C1F50]
M00_L02:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 208
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp+0FFB0],rax
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFC0],rcx
       mov       [rbp+10],rcx
       mov       rdx,[rbp+10]
       cmp       qword ptr [rdx+10],0
       je        near ptr M01_L08
       xor       edx,edx
       mov       [rbp+0FFB8],edx
       lea       rdx,[rbp+0FFB8]
       mov       rcx,[rbp+10]
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].FreezeBag(Boolean ByRef)
       mov       rcx,[rbp+10]
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].get_DangerousCount()
       mov       esi,eax
       test      esi,esi
       jle       near ptr M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+10]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AA68398
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       movsxd    rdx,esi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       xor       edi,edi
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       test      rbx,rbx
       je        short M01_L04
M01_L01:
       mov       r14d,[rbx+18]
       mov       ecx,[rbx+28]
       mov       r15d,[rbx+24]
       sub       r15d,ecx
       add       r15d,edi
       lea       r12d,[r15+0FFFF]
       cmp       r12d,edi
       jl        short M01_L03
M01_L02:
       lea       ecx,[r14+1]
       mov       r13d,ecx
       mov       edx,r12d
       mov       rcx,[rbx+8]
       and       r14d,[rbx+20]
       cmp       r14d,[rcx+8]
       jae       short M01_L05
       movsxd    r8,r14d
       mov       r8,[rcx+r8*8+10]
       mov       rcx,rsi
       call      CORINFO_HELP_ARRADDR_ST
       dec       r12d
       cmp       r12d,edi
       mov       r14d,r13d
       jge       short M01_L02
M01_L03:
       mov       edi,r15d
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M01_L01
M01_L04:
       mov       [rbp+0FFB0],rsi
       jmp       short M01_L07
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L06:
       mov       edx,[rbp+0FFB8]
       movzx     edx,dl
       mov       rcx,[rbp+10]
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].UnfreezeBag(Boolean)
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsp
       call      M01_L11
       jmp       short M01_L10
M01_L08:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M01_L09
       mov       rdx,7FF88AA68378
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L09:
       mov       rcx,rax
       call      System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L10:
       mov       rax,[rbp+0FFB0]
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       edx,[rbp+0FFB8]
       movzx     edx,dl
       mov       rcx,[rbp+10]
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].UnfreezeBag(Boolean)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 439
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rsi
       sub       rsp,20
       mov       edx,[rcx+18]
       mov       rsi,[rcx+8]
       cmp       edx,[rsi+8]
       jge       short M02_L00
       mov       edx,[rcx+18]
       lea       eax,[rdx+1]
       mov       [rcx+18],eax
       cmp       edx,[rsi+8]
       jae       short M02_L01
       movsxd    rdx,edx
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,1
       add       rsp,20
       pop       rsi
       ret
M02_L00:
       mov       eax,[rsi+8]
       inc       eax
       mov       [rcx+18],eax
       xor       eax,eax
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Dispose()
       ret
; Total bytes of code 1
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner.LoopingForEach01()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,[rsi+88]
       mov       ecx,[rdi]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1+Enumerator[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      qword ptr [7FF88A9D3A30]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFE0],rbx
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FF88A9D2430]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A5B05B0
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9D05B0]
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FF88A9D2430]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FF88A9D2450]
       nop
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M00_L02
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FF88A9D2450]
M00_L02:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 208
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp+0FFB0],rax
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFC0],rcx
       mov       [rbp+10],rcx
       mov       rdx,[rbp+10]
       cmp       qword ptr [rdx+10],0
       je        near ptr M01_L08
       xor       edx,edx
       mov       [rbp+0FFB8],edx
       lea       rdx,[rbp+0FFB8]
       mov       rcx,[rbp+10]
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].FreezeBag(Boolean ByRef)
       mov       rcx,[rbp+10]
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].get_DangerousCount()
       mov       esi,eax
       test      esi,esi
       jle       near ptr M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+10]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AA785C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       movsxd    rdx,esi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       xor       edi,edi
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       test      rbx,rbx
       je        short M01_L04
M01_L01:
       mov       r14d,[rbx+18]
       mov       ecx,[rbx+28]
       mov       r15d,[rbx+24]
       sub       r15d,ecx
       add       r15d,edi
       lea       r12d,[r15+0FFFF]
       cmp       r12d,edi
       jl        short M01_L03
M01_L02:
       lea       ecx,[r14+1]
       mov       r13d,ecx
       mov       edx,r12d
       mov       rcx,[rbx+8]
       and       r14d,[rbx+20]
       cmp       r14d,[rcx+8]
       jae       short M01_L05
       movsxd    r8,r14d
       mov       r8,[rcx+r8*8+10]
       mov       rcx,rsi
       call      CORINFO_HELP_ARRADDR_ST
       dec       r12d
       cmp       r12d,edi
       mov       r14d,r13d
       jge       short M01_L02
M01_L03:
       mov       edi,r15d
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M01_L01
M01_L04:
       mov       [rbp+0FFB0],rsi
       jmp       short M01_L07
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L06:
       mov       edx,[rbp+0FFB8]
       movzx     edx,dl
       mov       rcx,[rbp+10]
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].UnfreezeBag(Boolean)
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsp
       call      M01_L11
       jmp       short M01_L10
M01_L08:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M01_L09
       mov       rdx,7FF88AA785A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L09:
       mov       rcx,rax
       call      System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L10:
       mov       rax,[rbp+0FFB0]
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       edx,[rbp+0FFB8]
       movzx     edx,dl
       mov       rcx,[rbp+10]
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].UnfreezeBag(Boolean)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 439
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rsi
       sub       rsp,20
       mov       edx,[rcx+18]
       mov       rsi,[rcx+8]
       cmp       edx,[rsi+8]
       jge       short M02_L00
       mov       edx,[rcx+18]
       lea       eax,[rdx+1]
       mov       [rcx+18],eax
       cmp       edx,[rsi+8]
       jae       short M02_L01
       movsxd    rdx,edx
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,1
       add       rsp,20
       pop       rsi
       ret
M02_L00:
       mov       eax,[rsi+8]
       inc       eax
       mov       [rcx+18],eax
       xor       eax,eax
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Dispose()
       ret
; Total bytes of code 1
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner.LoopingForEach01()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,[rsi+88]
       mov       ecx,[rdi]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1+Enumerator[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      qword ptr [7FF88A9C3A30]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFE0],rbx
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FF88A9C2770]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A5A05B0
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9C05B0]
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FF88A9C2770]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FF88A9C2790]
       nop
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M00_L02
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FF88A9C2790]
M00_L02:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 208
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp+0FFB0],rax
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFC0],rcx
       mov       [rbp+10],rcx
       mov       rdx,[rbp+10]
       cmp       qword ptr [rdx+10],0
       je        near ptr M01_L08
       xor       edx,edx
       mov       [rbp+0FFB8],edx
       lea       rdx,[rbp+0FFB8]
       mov       rcx,[rbp+10]
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].FreezeBag(Boolean ByRef)
       mov       rcx,[rbp+10]
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].get_DangerousCount()
       mov       esi,eax
       test      esi,esi
       jle       near ptr M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+10]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AA68BF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       movsxd    rdx,esi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       xor       edi,edi
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       test      rbx,rbx
       je        short M01_L04
M01_L01:
       mov       r14d,[rbx+18]
       mov       ecx,[rbx+28]
       mov       r15d,[rbx+24]
       sub       r15d,ecx
       add       r15d,edi
       lea       r12d,[r15+0FFFF]
       cmp       r12d,edi
       jl        short M01_L03
M01_L02:
       lea       ecx,[r14+1]
       mov       r13d,ecx
       mov       edx,r12d
       mov       rcx,[rbx+8]
       and       r14d,[rbx+20]
       cmp       r14d,[rcx+8]
       jae       short M01_L05
       movsxd    r8,r14d
       mov       r8,[rcx+r8*8+10]
       mov       rcx,rsi
       call      CORINFO_HELP_ARRADDR_ST
       dec       r12d
       cmp       r12d,edi
       mov       r14d,r13d
       jge       short M01_L02
M01_L03:
       mov       edi,r15d
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M01_L01
M01_L04:
       mov       [rbp+0FFB0],rsi
       jmp       short M01_L07
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L06:
       mov       edx,[rbp+0FFB8]
       movzx     edx,dl
       mov       rcx,[rbp+10]
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].UnfreezeBag(Boolean)
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsp
       call      M01_L11
       jmp       short M01_L10
M01_L08:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M01_L09
       mov       rdx,7FF88AA68BD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L09:
       mov       rcx,rax
       call      System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L10:
       mov       rax,[rbp+0FFB0]
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       edx,[rbp+0FFB8]
       movzx     edx,dl
       mov       rcx,[rbp+10]
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].UnfreezeBag(Boolean)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 439
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rsi
       sub       rsp,20
       mov       edx,[rcx+18]
       mov       rsi,[rcx+8]
       cmp       edx,[rsi+8]
       jge       short M02_L00
       mov       edx,[rcx+18]
       lea       eax,[rdx+1]
       mov       [rcx+18],eax
       cmp       edx,[rsi+8]
       jae       short M02_L01
       movsxd    rdx,edx
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,1
       add       rsp,20
       pop       rsi
       ret
M02_L00:
       mov       eax,[rsi+8]
       inc       eax
       mov       [rcx+18],eax
       xor       eax,eax
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Dispose()
       ret
; Total bytes of code 1
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner.LoopingForEach01()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,[rsi+88]
       mov       ecx,[rdi]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1+Enumerator[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      qword ptr [7FF88A9C3A30]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFE0],rbx
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FF88A9C1F30]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A5A05B0
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9C05B0]
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FF88A9C1F30]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FF88A9C1F50]
       nop
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M00_L02
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FF88A9C1F50]
M00_L02:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 208
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp+0FFB0],rax
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFC0],rcx
       mov       [rbp+10],rcx
       mov       rdx,[rbp+10]
       cmp       qword ptr [rdx+10],0
       je        near ptr M01_L08
       xor       edx,edx
       mov       [rbp+0FFB8],edx
       lea       rdx,[rbp+0FFB8]
       mov       rcx,[rbp+10]
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].FreezeBag(Boolean ByRef)
       mov       rcx,[rbp+10]
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].get_DangerousCount()
       mov       esi,eax
       test      esi,esi
       jle       near ptr M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+10]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AA68428
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       movsxd    rdx,esi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       xor       edi,edi
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       test      rbx,rbx
       je        short M01_L04
M01_L01:
       mov       r14d,[rbx+18]
       mov       ecx,[rbx+28]
       mov       r15d,[rbx+24]
       sub       r15d,ecx
       add       r15d,edi
       lea       r12d,[r15+0FFFF]
       cmp       r12d,edi
       jl        short M01_L03
M01_L02:
       lea       ecx,[r14+1]
       mov       r13d,ecx
       mov       edx,r12d
       mov       rcx,[rbx+8]
       and       r14d,[rbx+20]
       cmp       r14d,[rcx+8]
       jae       short M01_L05
       movsxd    r8,r14d
       mov       r8,[rcx+r8*8+10]
       mov       rcx,rsi
       call      CORINFO_HELP_ARRADDR_ST
       dec       r12d
       cmp       r12d,edi
       mov       r14d,r13d
       jge       short M01_L02
M01_L03:
       mov       edi,r15d
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M01_L01
M01_L04:
       mov       [rbp+0FFB0],rsi
       jmp       short M01_L07
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L06:
       mov       edx,[rbp+0FFB8]
       movzx     edx,dl
       mov       rcx,[rbp+10]
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].UnfreezeBag(Boolean)
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsp
       call      M01_L11
       jmp       short M01_L10
M01_L08:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M01_L09
       mov       rdx,7FF88AA68408
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L09:
       mov       rcx,rax
       call      System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L10:
       mov       rax,[rbp+0FFB0]
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       edx,[rbp+0FFB8]
       movzx     edx,dl
       mov       rcx,[rbp+10]
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].UnfreezeBag(Boolean)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 439
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rsi
       sub       rsp,20
       mov       edx,[rcx+18]
       mov       rsi,[rcx+8]
       cmp       edx,[rsi+8]
       jge       short M02_L00
       mov       edx,[rcx+18]
       lea       eax,[rdx+1]
       mov       [rcx+18],eax
       cmp       edx,[rsi+8]
       jae       short M02_L01
       movsxd    rdx,edx
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,1
       add       rsp,20
       pop       rsi
       ret
M02_L00:
       mov       eax,[rsi+8]
       inc       eax
       mov       [rcx+18],eax
       xor       eax,eax
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Dispose()
       ret
; Total bytes of code 1
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner.LoopingForEach01()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,[rsi+88]
       mov       ecx,[rdi]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1+Enumerator[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      qword ptr [7FF88A9B3A30]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFE0],rbx
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FF88A9B2430]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A5905B0
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9B05B0]
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FF88A9B2430]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FF88A9B2450]
       nop
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M00_L02
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FF88A9B2450]
M00_L02:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 208
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp+0FFB0],rax
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFC0],rcx
       mov       [rbp+10],rcx
       mov       rdx,[rbp+10]
       cmp       qword ptr [rdx+10],0
       je        near ptr M01_L08
       xor       edx,edx
       mov       [rbp+0FFB8],edx
       lea       rdx,[rbp+0FFB8]
       mov       rcx,[rbp+10]
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].FreezeBag(Boolean ByRef)
       mov       rcx,[rbp+10]
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].get_DangerousCount()
       mov       esi,eax
       test      esi,esi
       jle       near ptr M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+10]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AA58B80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       movsxd    rdx,esi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       xor       edi,edi
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       test      rbx,rbx
       je        short M01_L04
M01_L01:
       mov       r14d,[rbx+18]
       mov       ecx,[rbx+28]
       mov       r15d,[rbx+24]
       sub       r15d,ecx
       add       r15d,edi
       lea       r12d,[r15+0FFFF]
       cmp       r12d,edi
       jl        short M01_L03
M01_L02:
       lea       ecx,[r14+1]
       mov       r13d,ecx
       mov       edx,r12d
       mov       rcx,[rbx+8]
       and       r14d,[rbx+20]
       cmp       r14d,[rcx+8]
       jae       short M01_L05
       movsxd    r8,r14d
       mov       r8,[rcx+r8*8+10]
       mov       rcx,rsi
       call      CORINFO_HELP_ARRADDR_ST
       dec       r12d
       cmp       r12d,edi
       mov       r14d,r13d
       jge       short M01_L02
M01_L03:
       mov       edi,r15d
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M01_L01
M01_L04:
       mov       [rbp+0FFB0],rsi
       jmp       short M01_L07
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L06:
       mov       edx,[rbp+0FFB8]
       movzx     edx,dl
       mov       rcx,[rbp+10]
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].UnfreezeBag(Boolean)
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsp
       call      M01_L11
       jmp       short M01_L10
M01_L08:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M01_L09
       mov       rdx,7FF88AA58B60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L09:
       mov       rcx,rax
       call      System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L10:
       mov       rax,[rbp+0FFB0]
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       edx,[rbp+0FFB8]
       movzx     edx,dl
       mov       rcx,[rbp+10]
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].UnfreezeBag(Boolean)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 439
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rsi
       sub       rsp,20
       mov       edx,[rcx+18]
       mov       rsi,[rcx+8]
       cmp       edx,[rsi+8]
       jge       short M02_L00
       mov       edx,[rcx+18]
       lea       eax,[rdx+1]
       mov       [rcx+18],eax
       cmp       edx,[rsi+8]
       jae       short M02_L01
       movsxd    rdx,edx
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,1
       add       rsp,20
       pop       rsi
       ret
M02_L00:
       mov       eax,[rsi+8]
       inc       eax
       mov       [rcx+18],eax
       xor       eax,eax
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Dispose()
       ret
; Total bytes of code 1
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner.LoopingForEach01()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,[rsi+88]
       mov       ecx,[rdi]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1+Enumerator[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      qword ptr [7FF88A9B3A30]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFE0],rbx
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FF88A9B1F30]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A5905B0
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9B05B0]
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FF88A9B1F30]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FF88A9B1F50]
       nop
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M00_L02
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FF88A9B1F50]
M00_L02:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 208
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp+0FFB0],rax
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFC0],rcx
       mov       [rbp+10],rcx
       mov       rdx,[rbp+10]
       cmp       qword ptr [rdx+10],0
       je        near ptr M01_L08
       xor       edx,edx
       mov       [rbp+0FFB8],edx
       lea       rdx,[rbp+0FFB8]
       mov       rcx,[rbp+10]
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].FreezeBag(Boolean ByRef)
       mov       rcx,[rbp+10]
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].get_DangerousCount()
       mov       esi,eax
       test      esi,esi
       jle       near ptr M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+10]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AA584A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       movsxd    rdx,esi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       xor       edi,edi
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       test      rbx,rbx
       je        short M01_L04
M01_L01:
       mov       r14d,[rbx+18]
       mov       ecx,[rbx+28]
       mov       r15d,[rbx+24]
       sub       r15d,ecx
       add       r15d,edi
       lea       r12d,[r15+0FFFF]
       cmp       r12d,edi
       jl        short M01_L03
M01_L02:
       lea       ecx,[r14+1]
       mov       r13d,ecx
       mov       edx,r12d
       mov       rcx,[rbx+8]
       and       r14d,[rbx+20]
       cmp       r14d,[rcx+8]
       jae       short M01_L05
       movsxd    r8,r14d
       mov       r8,[rcx+r8*8+10]
       mov       rcx,rsi
       call      CORINFO_HELP_ARRADDR_ST
       dec       r12d
       cmp       r12d,edi
       mov       r14d,r13d
       jge       short M01_L02
M01_L03:
       mov       edi,r15d
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M01_L01
M01_L04:
       mov       [rbp+0FFB0],rsi
       jmp       short M01_L07
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L06:
       mov       edx,[rbp+0FFB8]
       movzx     edx,dl
       mov       rcx,[rbp+10]
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].UnfreezeBag(Boolean)
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsp
       call      M01_L11
       jmp       short M01_L10
M01_L08:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M01_L09
       mov       rdx,7FF88AA58480
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L09:
       mov       rcx,rax
       call      System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L10:
       mov       rax,[rbp+0FFB0]
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       edx,[rbp+0FFB8]
       movzx     edx,dl
       mov       rcx,[rbp+10]
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].UnfreezeBag(Boolean)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 439
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rsi
       sub       rsp,20
       mov       edx,[rcx+18]
       mov       rsi,[rcx+8]
       cmp       edx,[rsi+8]
       jge       short M02_L00
       mov       edx,[rcx+18]
       lea       eax,[rdx+1]
       mov       [rcx+18],eax
       cmp       edx,[rsi+8]
       jae       short M02_L01
       movsxd    rdx,edx
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,1
       add       rsp,20
       pop       rsi
       ret
M02_L00:
       mov       eax,[rsi+8]
       inc       eax
       mov       [rcx+18],eax
       xor       eax,eax
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Dispose()
       ret
; Total bytes of code 1
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner.LoopingForEach01()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,[rsi+88]
       mov       ecx,[rdi]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1+Enumerator[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      qword ptr [7FF88A9D3A30]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFE0],rbx
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FF88A9D2430]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A5B05B0
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9D05B0]
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FF88A9D2430]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FF88A9D2450]
       nop
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M00_L02
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FF88A9D2450]
M00_L02:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 208
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp+0FFB0],rax
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFC0],rcx
       mov       [rbp+10],rcx
       mov       rdx,[rbp+10]
       cmp       qword ptr [rdx+10],0
       je        near ptr M01_L08
       xor       edx,edx
       mov       [rbp+0FFB8],edx
       lea       rdx,[rbp+0FFB8]
       mov       rcx,[rbp+10]
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].FreezeBag(Boolean ByRef)
       mov       rcx,[rbp+10]
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].get_DangerousCount()
       mov       esi,eax
       test      esi,esi
       jle       near ptr M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+10]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AA78688
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       movsxd    rdx,esi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       xor       edi,edi
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       test      rbx,rbx
       je        short M01_L04
M01_L01:
       mov       r14d,[rbx+18]
       mov       ecx,[rbx+28]
       mov       r15d,[rbx+24]
       sub       r15d,ecx
       add       r15d,edi
       lea       r12d,[r15+0FFFF]
       cmp       r12d,edi
       jl        short M01_L03
M01_L02:
       lea       ecx,[r14+1]
       mov       r13d,ecx
       mov       edx,r12d
       mov       rcx,[rbx+8]
       and       r14d,[rbx+20]
       cmp       r14d,[rcx+8]
       jae       short M01_L05
       movsxd    r8,r14d
       mov       r8,[rcx+r8*8+10]
       mov       rcx,rsi
       call      CORINFO_HELP_ARRADDR_ST
       dec       r12d
       cmp       r12d,edi
       mov       r14d,r13d
       jge       short M01_L02
M01_L03:
       mov       edi,r15d
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M01_L01
M01_L04:
       mov       [rbp+0FFB0],rsi
       jmp       short M01_L07
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L06:
       mov       edx,[rbp+0FFB8]
       movzx     edx,dl
       mov       rcx,[rbp+10]
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].UnfreezeBag(Boolean)
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsp
       call      M01_L11
       jmp       short M01_L10
M01_L08:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M01_L09
       mov       rdx,7FF88AA78668
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L09:
       mov       rcx,rax
       call      System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L10:
       mov       rax,[rbp+0FFB0]
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       edx,[rbp+0FFB8]
       movzx     edx,dl
       mov       rcx,[rbp+10]
       call      System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].UnfreezeBag(Boolean)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 439
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rsi
       sub       rsp,20
       mov       edx,[rcx+18]
       mov       rsi,[rcx+8]
       cmp       edx,[rsi+8]
       jge       short M02_L00
       mov       edx,[rcx+18]
       lea       eax,[rdx+1]
       mov       [rcx+18],eax
       cmp       edx,[rsi+8]
       jae       short M02_L01
       movsxd    rdx,edx
       mov       rdx,[rsi+rdx*8+10]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,1
       add       rsp,20
       pop       rsi
       ret
M02_L00:
       mov       eax,[rsi+8]
       inc       eax
       mov       [rcx+18],eax
       xor       eax,eax
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 81
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Dispose()
       ret
; Total bytes of code 1
```

