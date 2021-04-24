## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.Creating01()
;             var people = new DistinctBlockingCollection<PersonProper>(base.personProperCollection);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(people);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+58]
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
;         public DistinctBlockingCollection(IEnumerable<T> collection)
;         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             if (collection.HasItems())
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 collection.ToList()
;                 ^^^^^^^
;                     .ForEach(item =>
;                 ^^^^^^^
;                     {
;                 ^^^^^^^
;                         this.Add(item);
;                 ^^^^^^^
;                     });
;                 ^^^^^^^
;         }
;         ^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       test      rdi,rdi
       je        near ptr M01_L02
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Extensions.CollectionExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L02
       mov       rbx,[rsi]
       mov       rcx,rbx
       mov       rdx,[rcx+30]
       mov       rbp,[rdx+8]
       mov       rax,[rbp+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FFF60C94F08
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
       mov       rdx,7FFF60C95048
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].<.ctor>b__1_0(System.__Canon)
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
; Total bytes of code 214
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.Creating01()
;             var people = new DistinctBlockingCollection<PersonProper>(base.personProperCollection);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(people);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+58]
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
;         public DistinctBlockingCollection(IEnumerable<T> collection)
;         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             if (collection.HasItems())
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 collection.ToList()
;                 ^^^^^^^
;                     .ForEach(item =>
;                 ^^^^^^^
;                     {
;                 ^^^^^^^
;                         this.Add(item);
;                 ^^^^^^^
;                     });
;                 ^^^^^^^
;         }
;         ^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       test      rdi,rdi
       je        near ptr M01_L02
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Extensions.CollectionExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L02
       mov       rbx,[rsi]
       mov       rcx,rbx
       mov       rdx,[rcx+30]
       mov       rbp,[rdx+8]
       mov       rax,[rbp+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FFF60CC4F08
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
       mov       rdx,7FFF60CC5048
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].<.ctor>b__1_0(System.__Canon)
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
; Total bytes of code 214
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.Creating01()
;             var people = new DistinctBlockingCollection<PersonProper>(base.personProperCollection);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(people);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+58]
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
;         public DistinctBlockingCollection(IEnumerable<T> collection)
;         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             if (collection.HasItems())
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 collection.ToList()
;                 ^^^^^^^
;                     .ForEach(item =>
;                 ^^^^^^^
;                     {
;                 ^^^^^^^
;                         this.Add(item);
;                 ^^^^^^^
;                     });
;                 ^^^^^^^
;         }
;         ^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       test      rdi,rdi
       je        near ptr M01_L02
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Extensions.CollectionExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L02
       mov       rbx,[rsi]
       mov       rcx,rbx
       mov       rdx,[rcx+30]
       mov       rbp,[rdx+8]
       mov       rax,[rbp+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FFF60CC4F08
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
       mov       rdx,7FFF60CC5048
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].<.ctor>b__1_0(System.__Canon)
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
; Total bytes of code 214
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.Creating01()
;             var people = new DistinctBlockingCollection<PersonProper>(base.personProperCollection);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(people);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+58]
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
;         public DistinctBlockingCollection(IEnumerable<T> collection)
;         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             if (collection.HasItems())
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 collection.ToList()
;                 ^^^^^^^
;                     .ForEach(item =>
;                 ^^^^^^^
;                     {
;                 ^^^^^^^
;                         this.Add(item);
;                 ^^^^^^^
;                     });
;                 ^^^^^^^
;         }
;         ^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       test      rdi,rdi
       je        near ptr M01_L02
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Extensions.CollectionExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L02
       mov       rbx,[rsi]
       mov       rcx,rbx
       mov       rdx,[rcx+30]
       mov       rbp,[rdx+8]
       mov       rax,[rbp+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FFF60CA4F08
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
       mov       rdx,7FFF60CA5048
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].<.ctor>b__1_0(System.__Canon)
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
; Total bytes of code 214
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.Creating01()
;             var people = new DistinctBlockingCollection<PersonProper>(base.personProperCollection);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(people);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+58]
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
;         public DistinctBlockingCollection(IEnumerable<T> collection)
;         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             if (collection.HasItems())
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 collection.ToList()
;                 ^^^^^^^
;                     .ForEach(item =>
;                 ^^^^^^^
;                     {
;                 ^^^^^^^
;                         this.Add(item);
;                 ^^^^^^^
;                     });
;                 ^^^^^^^
;         }
;         ^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       test      rdi,rdi
       je        near ptr M01_L02
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Extensions.CollectionExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L02
       mov       rbx,[rsi]
       mov       rcx,rbx
       mov       rdx,[rcx+30]
       mov       rbp,[rdx+8]
       mov       rax,[rbp+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FFF60CC4F08
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
       mov       rdx,7FFF60CC5048
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].<.ctor>b__1_0(System.__Canon)
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
; Total bytes of code 214
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.Creating01()
;             var people = new DistinctBlockingCollection<PersonProper>(base.personProperCollection);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(people);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+58]
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
;         public DistinctBlockingCollection(IEnumerable<T> collection)
;         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             if (collection.HasItems())
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 collection.ToList()
;                 ^^^^^^^
;                     .ForEach(item =>
;                 ^^^^^^^
;                     {
;                 ^^^^^^^
;                         this.Add(item);
;                 ^^^^^^^
;                     });
;                 ^^^^^^^
;         }
;         ^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       test      rdi,rdi
       je        near ptr M01_L02
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Extensions.CollectionExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L02
       mov       rbx,[rsi]
       mov       rcx,rbx
       mov       rdx,[rcx+30]
       mov       rbp,[rdx+8]
       mov       rax,[rbp+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FFF60C84F08
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
       mov       rdx,7FFF60C85048
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].<.ctor>b__1_0(System.__Canon)
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
; Total bytes of code 214
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.Creating01()
;             var people = new DistinctBlockingCollection<PersonProper>(base.personProperCollection);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(people);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+58]
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
;         public DistinctBlockingCollection(IEnumerable<T> collection)
;         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             if (collection.HasItems())
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 collection.ToList()
;                 ^^^^^^^
;                     .ForEach(item =>
;                 ^^^^^^^
;                     {
;                 ^^^^^^^
;                         this.Add(item);
;                 ^^^^^^^
;                     });
;                 ^^^^^^^
;         }
;         ^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       test      rdi,rdi
       je        near ptr M01_L02
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Extensions.CollectionExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L02
       mov       rbx,[rsi]
       mov       rcx,rbx
       mov       rdx,[rcx+30]
       mov       rbp,[rdx+8]
       mov       rax,[rbp+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FFF60CA4F08
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
       mov       rdx,7FFF60CA5048
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].<.ctor>b__1_0(System.__Canon)
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
; Total bytes of code 214
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.Creating02()
;             var fakePeople = new DistinctBlockingCollection<PersonProper>();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.personProperCollection.ForEach(p =>
;             ^^^
;             {
;             ^^^
;                 fakePeople.Add(p);
;             ^^^
;             });
;             ^^^
;             base.Consumer.Consume(fakePeople);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,rbx
       mov       rdx,rbp
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Concurrent.IProducerConsumerCollection`1<System.__Canon>)
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
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner+<>c__DisplayClass4_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
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
; Total bytes of code 186
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FFF60CE8298
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,20
       call      System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 131
```
```assembly
; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Concurrent.IProducerConsumerCollection`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,rsi
       mov       r11,7FFF608205F8
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C405F8]
       mov       r9d,eax
       mov       rdx,rsi
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       mov       rax,offset System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Collections.Concurrent.IProducerConsumerCollection`1<System.__Canon>, Int32, Int32)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M02_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0E06
       mov       rdx,7FFF60B9DA50
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 130
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner+<>c__DisplayClass4_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
;                 fakePeople.Add(p);
;                 ^^^^^^^^^^^^^^^^^^
       mov       rcx,[rcx+8]
       mov       rax,offset dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       je        short M04_L03
       mov       ebx,[rsi+14]
       xor       ebp,ebp
       cmp       dword ptr [rsi+10],0
       jle       short M04_L01
M04_L00:
       cmp       ebx,[rsi+14]
       jne       short M04_L01
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       jae       short M04_L04
       movsxd    rdx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       inc       ebp
       cmp       ebp,[rsi+10]
       jl        short M04_L00
M04_L01:
       cmp       ebx,[rsi+14]
       je        short M04_L02
       mov       rax,offset System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       ecx,1C
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M04_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.Creating02()
;             var fakePeople = new DistinctBlockingCollection<PersonProper>();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.personProperCollection.ForEach(p =>
;             ^^^
;             {
;             ^^^
;                 fakePeople.Add(p);
;             ^^^
;             });
;             ^^^
;             base.Consumer.Consume(fakePeople);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,rbx
       mov       rdx,rbp
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Concurrent.IProducerConsumerCollection`1<System.__Canon>)
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
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner+<>c__DisplayClass4_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
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
; Total bytes of code 186
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FFF60CC8438
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,20
       call      System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 131
```
```assembly
; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Concurrent.IProducerConsumerCollection`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,rsi
       mov       r11,7FFF608005F8
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C205F8]
       mov       r9d,eax
       mov       rdx,rsi
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       mov       rax,offset System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Collections.Concurrent.IProducerConsumerCollection`1<System.__Canon>, Int32, Int32)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M02_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0E06
       mov       rdx,7FFF60B7DA50
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 130
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner+<>c__DisplayClass4_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
;                 fakePeople.Add(p);
;                 ^^^^^^^^^^^^^^^^^^
       mov       rcx,[rcx+8]
       mov       rax,offset dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       je        short M04_L03
       mov       ebx,[rsi+14]
       xor       ebp,ebp
       cmp       dword ptr [rsi+10],0
       jle       short M04_L01
M04_L00:
       cmp       ebx,[rsi+14]
       jne       short M04_L01
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       jae       short M04_L04
       movsxd    rdx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       inc       ebp
       cmp       ebp,[rsi+10]
       jl        short M04_L00
M04_L01:
       cmp       ebx,[rsi+14]
       je        short M04_L02
       mov       rax,offset System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       ecx,1C
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M04_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.Creating02()
;             var fakePeople = new DistinctBlockingCollection<PersonProper>();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.personProperCollection.ForEach(p =>
;             ^^^
;             {
;             ^^^
;                 fakePeople.Add(p);
;             ^^^
;             });
;             ^^^
;             base.Consumer.Consume(fakePeople);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,rbx
       mov       rdx,rbp
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Concurrent.IProducerConsumerCollection`1<System.__Canon>)
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
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner+<>c__DisplayClass4_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
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
; Total bytes of code 186
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FFF60CC8298
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,20
       call      System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 131
```
```assembly
; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Concurrent.IProducerConsumerCollection`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,rsi
       mov       r11,7FFF608005F8
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C205F8]
       mov       r9d,eax
       mov       rdx,rsi
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       mov       rax,offset System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Collections.Concurrent.IProducerConsumerCollection`1<System.__Canon>, Int32, Int32)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M02_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0E06
       mov       rdx,7FFF60B7DA50
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 130
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner+<>c__DisplayClass4_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
;                 fakePeople.Add(p);
;                 ^^^^^^^^^^^^^^^^^^
       mov       rcx,[rcx+8]
       mov       rax,offset dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       je        short M04_L03
       mov       ebx,[rsi+14]
       xor       ebp,ebp
       cmp       dword ptr [rsi+10],0
       jle       short M04_L01
M04_L00:
       cmp       ebx,[rsi+14]
       jne       short M04_L01
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       jae       short M04_L04
       movsxd    rdx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       inc       ebp
       cmp       ebp,[rsi+10]
       jl        short M04_L00
M04_L01:
       cmp       ebx,[rsi+14]
       je        short M04_L02
       mov       rax,offset System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       ecx,1C
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M04_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.Creating02()
;             var fakePeople = new DistinctBlockingCollection<PersonProper>();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.personProperCollection.ForEach(p =>
;             ^^^
;             {
;             ^^^
;                 fakePeople.Add(p);
;             ^^^
;             });
;             ^^^
;             base.Consumer.Consume(fakePeople);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,rbx
       mov       rdx,rbp
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Concurrent.IProducerConsumerCollection`1<System.__Canon>)
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
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner+<>c__DisplayClass4_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
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
; Total bytes of code 186
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FFF60CD8438
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,20
       call      System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 131
```
```assembly
; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Concurrent.IProducerConsumerCollection`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,rsi
       mov       r11,7FFF608105F8
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C305F8]
       mov       r9d,eax
       mov       rdx,rsi
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       mov       rax,offset System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Collections.Concurrent.IProducerConsumerCollection`1<System.__Canon>, Int32, Int32)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M02_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0E06
       mov       rdx,7FFF60B8DA50
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 130
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner+<>c__DisplayClass4_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
;                 fakePeople.Add(p);
;                 ^^^^^^^^^^^^^^^^^^
       mov       rcx,[rcx+8]
       mov       rax,offset dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       je        short M04_L03
       mov       ebx,[rsi+14]
       xor       ebp,ebp
       cmp       dword ptr [rsi+10],0
       jle       short M04_L01
M04_L00:
       cmp       ebx,[rsi+14]
       jne       short M04_L01
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       jae       short M04_L04
       movsxd    rdx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       inc       ebp
       cmp       ebp,[rsi+10]
       jl        short M04_L00
M04_L01:
       cmp       ebx,[rsi+14]
       je        short M04_L02
       mov       rax,offset System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       ecx,1C
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M04_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.Creating02()
;             var fakePeople = new DistinctBlockingCollection<PersonProper>();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.personProperCollection.ForEach(p =>
;             ^^^
;             {
;             ^^^
;                 fakePeople.Add(p);
;             ^^^
;             });
;             ^^^
;             base.Consumer.Consume(fakePeople);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,rbx
       mov       rdx,rbp
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Concurrent.IProducerConsumerCollection`1<System.__Canon>)
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
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner+<>c__DisplayClass4_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
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
; Total bytes of code 186
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FFF60CE8638
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,20
       call      System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 131
```
```assembly
; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Concurrent.IProducerConsumerCollection`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,rsi
       mov       r11,7FFF608205F8
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C405F8]
       mov       r9d,eax
       mov       rdx,rsi
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       mov       rax,offset System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Collections.Concurrent.IProducerConsumerCollection`1<System.__Canon>, Int32, Int32)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M02_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0E06
       mov       rdx,7FFF60B9DA50
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 130
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner+<>c__DisplayClass4_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
;                 fakePeople.Add(p);
;                 ^^^^^^^^^^^^^^^^^^
       mov       rcx,[rcx+8]
       mov       rax,offset dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       je        short M04_L03
       mov       ebx,[rsi+14]
       xor       ebp,ebp
       cmp       dword ptr [rsi+10],0
       jle       short M04_L01
M04_L00:
       cmp       ebx,[rsi+14]
       jne       short M04_L01
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       jae       short M04_L04
       movsxd    rdx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       inc       ebp
       cmp       ebp,[rsi+10]
       jl        short M04_L00
M04_L01:
       cmp       ebx,[rsi+14]
       je        short M04_L02
       mov       rax,offset System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       ecx,1C
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M04_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.Creating02()
;             var fakePeople = new DistinctBlockingCollection<PersonProper>();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.personProperCollection.ForEach(p =>
;             ^^^
;             {
;             ^^^
;                 fakePeople.Add(p);
;             ^^^
;             });
;             ^^^
;             base.Consumer.Consume(fakePeople);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,rbx
       mov       rdx,rbp
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Concurrent.IProducerConsumerCollection`1<System.__Canon>)
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
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner+<>c__DisplayClass4_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
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
; Total bytes of code 186
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FFF60CD8638
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,20
       call      System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 131
```
```assembly
; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Concurrent.IProducerConsumerCollection`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,rsi
       mov       r11,7FFF608105F8
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C305F8]
       mov       r9d,eax
       mov       rdx,rsi
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       mov       rax,offset System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Collections.Concurrent.IProducerConsumerCollection`1<System.__Canon>, Int32, Int32)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M02_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0E06
       mov       rdx,7FFF60B8DA50
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 130
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner+<>c__DisplayClass4_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
;                 fakePeople.Add(p);
;                 ^^^^^^^^^^^^^^^^^^
       mov       rcx,[rcx+8]
       mov       rax,offset dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       je        short M04_L03
       mov       ebx,[rsi+14]
       xor       ebp,ebp
       cmp       dword ptr [rsi+10],0
       jle       short M04_L01
M04_L00:
       cmp       ebx,[rsi+14]
       jne       short M04_L01
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       jae       short M04_L04
       movsxd    rdx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       inc       ebp
       cmp       ebp,[rsi+10]
       jl        short M04_L00
M04_L01:
       cmp       ebx,[rsi+14]
       je        short M04_L02
       mov       rax,offset System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       ecx,1C
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M04_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.Creating02()
;             var fakePeople = new DistinctBlockingCollection<PersonProper>();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.personProperCollection.ForEach(p =>
;             ^^^
;             {
;             ^^^
;                 fakePeople.Add(p);
;             ^^^
;             });
;             ^^^
;             base.Consumer.Consume(fakePeople);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,rbx
       mov       rdx,rbp
       call      System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Concurrent.IProducerConsumerCollection`1<System.__Canon>)
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
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner+<>c__DisplayClass4_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
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
; Total bytes of code 186
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FFF60CF85D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,20
       call      System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 131
```
```assembly
; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Concurrent.IProducerConsumerCollection`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,rsi
       mov       r11,7FFF608305F8
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C505F8]
       mov       r9d,eax
       mov       rdx,rsi
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       mov       rax,offset System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Initialize(System.Collections.Concurrent.IProducerConsumerCollection`1<System.__Canon>, Int32, Int32)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M02_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0E06
       mov       rdx,7FFF60BADA50
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 130
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner+<>c__DisplayClass4_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
;                 fakePeople.Add(p);
;                 ^^^^^^^^^^^^^^^^^^
       mov       rcx,[rcx+8]
       mov       rax,offset dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       je        short M04_L03
       mov       ebx,[rsi+14]
       xor       ebp,ebp
       cmp       dword ptr [rsi+10],0
       jle       short M04_L01
M04_L00:
       cmp       ebx,[rsi+14]
       jne       short M04_L01
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       jae       short M04_L04
       movsxd    rdx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       inc       ebp
       cmp       ebp,[rsi+10]
       jl        short M04_L00
M04_L01:
       cmp       ebx,[rsi+14]
       je        short M04_L02
       mov       rax,offset System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       ecx,1C
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M04_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.LoopingForEach01()
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp+0FFE0],rsp
       mov       rsi,rcx
;             foreach (var person in this._peopleDistinctBlockingCollection)
;                                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rsi+88]
       mov       r11,7FFF60830590
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C50590]
       mov       [rbp+0FFF0],rax
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF60830598
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C50598]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF608305A0
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C505A0]
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF60830598
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C50598]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF608305A8
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C505A8]
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFF0],0
       je        short M00_L02
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF608305A8
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C505A8]
M00_L02:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 225
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.LoopingForEach01()
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp+0FFE0],rsp
       mov       rsi,rcx
;             foreach (var person in this._peopleDistinctBlockingCollection)
;                                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rsi+88]
       mov       r11,7FFF60830590
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C50590]
       mov       [rbp+0FFF0],rax
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF60830598
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C50598]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF608305A0
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C505A0]
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF60830598
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C50598]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF608305A8
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C505A8]
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFF0],0
       je        short M00_L02
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF608305A8
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C505A8]
M00_L02:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 225
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.LoopingForEach01()
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp+0FFE0],rsp
       mov       rsi,rcx
;             foreach (var person in this._peopleDistinctBlockingCollection)
;                                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rsi+88]
       mov       r11,7FFF60810590
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C30590]
       mov       [rbp+0FFF0],rax
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF60810598
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C30598]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF608105A0
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C305A0]
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF60810598
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C30598]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF608105A8
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C305A8]
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFF0],0
       je        short M00_L02
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF608105A8
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C305A8]
M00_L02:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 225
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.LoopingForEach01()
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp+0FFE0],rsp
       mov       rsi,rcx
;             foreach (var person in this._peopleDistinctBlockingCollection)
;                                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rsi+88]
       mov       r11,7FFF60830590
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C50590]
       mov       [rbp+0FFF0],rax
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF60830598
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C50598]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF608305A0
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C505A0]
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF60830598
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C50598]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF608305A8
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C505A8]
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFF0],0
       je        short M00_L02
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF608305A8
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C505A8]
M00_L02:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 225
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.LoopingForEach01()
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp+0FFE0],rsp
       mov       rsi,rcx
;             foreach (var person in this._peopleDistinctBlockingCollection)
;                                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rsi+88]
       mov       r11,7FFF60830590
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C50590]
       mov       [rbp+0FFF0],rax
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF60830598
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C50598]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF608305A0
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C505A0]
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF60830598
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C50598]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF608305A8
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C505A8]
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFF0],0
       je        short M00_L02
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF608305A8
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C505A8]
M00_L02:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 225
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.LoopingForEach01()
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp+0FFE0],rsp
       mov       rsi,rcx
;             foreach (var person in this._peopleDistinctBlockingCollection)
;                                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rsi+88]
       mov       r11,7FFF60820590
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C40590]
       mov       [rbp+0FFF0],rax
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF60820598
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C40598]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF608205A0
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C405A0]
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF60820598
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C40598]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF608205A8
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C405A8]
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFF0],0
       je        short M00_L02
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF608205A8
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C405A8]
M00_L02:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 225
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.LoopingForEach01()
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp+0FFE0],rsp
       mov       rsi,rcx
;             foreach (var person in this._peopleDistinctBlockingCollection)
;                                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rsi+88]
       mov       r11,7FFF60800590
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C20590]
       mov       [rbp+0FFF0],rax
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF60800598
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C20598]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF608005A0
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C205A0]
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF60800598
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C20598]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF608005A8
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C205A8]
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp+0FFF0],0
       je        short M00_L02
       mov       rcx,[rbp+0FFF0]
       mov       r11,7FFF608005A8
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C205A8]
M00_L02:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 225
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.LoopingForEach02()
;             Parallel.ForEach(this._peopleDistinctBlockingCollection, p =>
;             ^^^^^^^^^^^^^^^
;                         {
;             ^^^^^^^^^^^^^^^
;                             base.Consumer.Consume(p);
;             ^^^^^^^^^^^^^^^
;                         });
;             ^^^^^^^^^^^^^^^
;         }
;         ^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       rsi,rcx
       mov       rcx,offset MT_System.Action`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+88]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.<LoopingForEach02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rdi+18],rcx
       lea       rcx,[rsp+28]
       mov       r9,rdi
       mov       r8,rbx
       mov       rdx,offset MD_System.Threading.Tasks.Parallel.ForEach(System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
       call      System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       mov       [rbp+0FFD8],rdx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        short M01_L01
       test      rbx,rbx
       je        near ptr M01_L02
       mov       rcx,2A90879BDC8
       mov       r14,[rcx]
       mov       rcx,[rdx+10]
       mov       rax,[rcx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rcx,rdx
       mov       rdx,7FFF60CDFC10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L00:
       mov       [rsp+20],rbx
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       mov       [rsp+50],rcx
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,rdi
       mov       r9,r14
       call      System.Threading.Tasks.Parallel.ForEachWorker[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Threading.Tasks.ParallelOptions, System.Action`1<System.__Canon>, System.Action`2<System.__Canon,System.Threading.Tasks.ParallelLoopState>, System.Action`3<System.__Canon,System.Threading.Tasks.ParallelLoopState,Int64>, System.Func`4<System.__Canon,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`5<System.__Canon,System.Threading.Tasks.ParallelLoopState,Int64,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       mov       rax,rsi
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,375
       mov       rdx,7FFF60BED770
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,33D
       mov       rdx,7FFF60BED770
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 272
```
**Method was not JITted yet.**
dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.<LoopingForEach02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.LoopingForEach02()
;             Parallel.ForEach(this._peopleDistinctBlockingCollection, p =>
;             ^^^^^^^^^^^^^^^
;                         {
;             ^^^^^^^^^^^^^^^
;                             base.Consumer.Consume(p);
;             ^^^^^^^^^^^^^^^
;                         });
;             ^^^^^^^^^^^^^^^
;         }
;         ^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       rsi,rcx
       mov       rcx,offset MT_System.Action`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+88]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.<LoopingForEach02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rdi+18],rcx
       lea       rcx,[rsp+28]
       mov       r9,rdi
       mov       r8,rbx
       mov       rdx,offset MD_System.Threading.Tasks.Parallel.ForEach(System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
       call      System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       mov       [rbp+0FFD8],rdx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        short M01_L01
       test      rbx,rbx
       je        near ptr M01_L02
       mov       rcx,2B3CA1E7960
       mov       r14,[rcx]
       mov       rcx,[rdx+10]
       mov       rax,[rcx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rcx,rdx
       mov       rdx,7FFF60CFEA40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L00:
       mov       [rsp+20],rbx
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       mov       [rsp+50],rcx
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,rdi
       mov       r9,r14
       call      System.Threading.Tasks.Parallel.ForEachWorker[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Threading.Tasks.ParallelOptions, System.Action`1<System.__Canon>, System.Action`2<System.__Canon,System.Threading.Tasks.ParallelLoopState>, System.Action`3<System.__Canon,System.Threading.Tasks.ParallelLoopState,Int64>, System.Func`4<System.__Canon,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`5<System.__Canon,System.Threading.Tasks.ParallelLoopState,Int64,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       mov       rax,rsi
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,375
       mov       rdx,7FFF60C0D770
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,33D
       mov       rdx,7FFF60C0D770
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 272
```
**Method was not JITted yet.**
dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.<LoopingForEach02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.LoopingForEach02()
;             Parallel.ForEach(this._peopleDistinctBlockingCollection, p =>
;             ^^^^^^^^^^^^^^^
;                         {
;             ^^^^^^^^^^^^^^^
;                             base.Consumer.Consume(p);
;             ^^^^^^^^^^^^^^^
;                         });
;             ^^^^^^^^^^^^^^^
;         }
;         ^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       rsi,rcx
       mov       rcx,offset MT_System.Action`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+88]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.<LoopingForEach02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rdi+18],rcx
       lea       rcx,[rsp+28]
       mov       r9,rdi
       mov       r8,rbx
       mov       rdx,offset MD_System.Threading.Tasks.Parallel.ForEach(System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
       call      System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       mov       [rbp+0FFD8],rdx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        short M01_L01
       test      rbx,rbx
       je        near ptr M01_L02
       mov       rcx,14872647960
       mov       r14,[rcx]
       mov       rcx,[rdx+10]
       mov       rax,[rcx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rcx,rdx
       mov       rdx,7FFF60CDEC08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L00:
       mov       [rsp+20],rbx
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       mov       [rsp+50],rcx
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,rdi
       mov       r9,r14
       call      System.Threading.Tasks.Parallel.ForEachWorker[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Threading.Tasks.ParallelOptions, System.Action`1<System.__Canon>, System.Action`2<System.__Canon,System.Threading.Tasks.ParallelLoopState>, System.Action`3<System.__Canon,System.Threading.Tasks.ParallelLoopState,Int64>, System.Func`4<System.__Canon,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`5<System.__Canon,System.Threading.Tasks.ParallelLoopState,Int64,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       mov       rax,rsi
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,375
       mov       rdx,7FFF60BED770
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,33D
       mov       rdx,7FFF60BED770
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 272
```
**Method was not JITted yet.**
dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.<LoopingForEach02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.LoopingForEach02()
;             Parallel.ForEach(this._peopleDistinctBlockingCollection, p =>
;             ^^^^^^^^^^^^^^^
;                         {
;             ^^^^^^^^^^^^^^^
;                             base.Consumer.Consume(p);
;             ^^^^^^^^^^^^^^^
;                         });
;             ^^^^^^^^^^^^^^^
;         }
;         ^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       rsi,rcx
       mov       rcx,offset MT_System.Action`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+88]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.<LoopingForEach02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rdi+18],rcx
       lea       rcx,[rsp+28]
       mov       r9,rdi
       mov       r8,rbx
       mov       rdx,offset MD_System.Threading.Tasks.Parallel.ForEach(System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
       call      System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       mov       [rbp+0FFD8],rdx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        short M01_L01
       test      rbx,rbx
       je        near ptr M01_L02
       mov       rcx,1CB1ED77960
       mov       r14,[rcx]
       mov       rcx,[rdx+10]
       mov       rax,[rcx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rcx,rdx
       mov       rdx,7FFF60CEE9B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L00:
       mov       [rsp+20],rbx
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       mov       [rsp+50],rcx
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,rdi
       mov       r9,r14
       call      System.Threading.Tasks.Parallel.ForEachWorker[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Threading.Tasks.ParallelOptions, System.Action`1<System.__Canon>, System.Action`2<System.__Canon,System.Threading.Tasks.ParallelLoopState>, System.Action`3<System.__Canon,System.Threading.Tasks.ParallelLoopState,Int64>, System.Func`4<System.__Canon,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`5<System.__Canon,System.Threading.Tasks.ParallelLoopState,Int64,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       mov       rax,rsi
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,375
       mov       rdx,7FFF60BFD770
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,33D
       mov       rdx,7FFF60BFD770
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 272
```
**Method was not JITted yet.**
dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.<LoopingForEach02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.LoopingForEach02()
;             Parallel.ForEach(this._peopleDistinctBlockingCollection, p =>
;             ^^^^^^^^^^^^^^^
;                         {
;             ^^^^^^^^^^^^^^^
;                             base.Consumer.Consume(p);
;             ^^^^^^^^^^^^^^^
;                         });
;             ^^^^^^^^^^^^^^^
;         }
;         ^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       rsi,rcx
       mov       rcx,offset MT_System.Action`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+88]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.<LoopingForEach02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rdi+18],rcx
       lea       rcx,[rsp+28]
       mov       r9,rdi
       mov       r8,rbx
       mov       rdx,offset MD_System.Threading.Tasks.Parallel.ForEach(System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
       call      System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       mov       [rbp+0FFD8],rdx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        short M01_L01
       test      rbx,rbx
       je        near ptr M01_L02
       mov       rcx,222F4497960
       mov       r14,[rcx]
       mov       rcx,[rdx+10]
       mov       rax,[rcx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rcx,rdx
       mov       rdx,7FFF60CFEE98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L00:
       mov       [rsp+20],rbx
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       mov       [rsp+50],rcx
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,rdi
       mov       r9,r14
       call      System.Threading.Tasks.Parallel.ForEachWorker[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Threading.Tasks.ParallelOptions, System.Action`1<System.__Canon>, System.Action`2<System.__Canon,System.Threading.Tasks.ParallelLoopState>, System.Action`3<System.__Canon,System.Threading.Tasks.ParallelLoopState,Int64>, System.Func`4<System.__Canon,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`5<System.__Canon,System.Threading.Tasks.ParallelLoopState,Int64,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       mov       rax,rsi
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,375
       mov       rdx,7FFF60C0D770
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,33D
       mov       rdx,7FFF60C0D770
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 272
```
**Method was not JITted yet.**
dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.<LoopingForEach02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.LoopingForEach02()
;             Parallel.ForEach(this._peopleDistinctBlockingCollection, p =>
;             ^^^^^^^^^^^^^^^
;                         {
;             ^^^^^^^^^^^^^^^
;                             base.Consumer.Consume(p);
;             ^^^^^^^^^^^^^^^
;                         });
;             ^^^^^^^^^^^^^^^
;         }
;         ^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       rsi,rcx
       mov       rcx,offset MT_System.Action`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+88]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.<LoopingForEach02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rdi+18],rcx
       lea       rcx,[rsp+28]
       mov       r9,rdi
       mov       r8,rbx
       mov       rdx,offset MD_System.Threading.Tasks.Parallel.ForEach(System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
       call      System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       mov       [rbp+0FFD8],rdx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        short M01_L01
       test      rbx,rbx
       je        near ptr M01_L02
       mov       rcx,1C3E6747960
       mov       r14,[rcx]
       mov       rcx,[rdx+10]
       mov       rax,[rcx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rcx,rdx
       mov       rdx,7FFF60CEF088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L00:
       mov       [rsp+20],rbx
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       mov       [rsp+50],rcx
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,rdi
       mov       r9,r14
       call      System.Threading.Tasks.Parallel.ForEachWorker[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Threading.Tasks.ParallelOptions, System.Action`1<System.__Canon>, System.Action`2<System.__Canon,System.Threading.Tasks.ParallelLoopState>, System.Action`3<System.__Canon,System.Threading.Tasks.ParallelLoopState,Int64>, System.Func`4<System.__Canon,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`5<System.__Canon,System.Threading.Tasks.ParallelLoopState,Int64,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       mov       rax,rsi
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,375
       mov       rdx,7FFF60BFD770
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,33D
       mov       rdx,7FFF60BFD770
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 272
```
**Method was not JITted yet.**
dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.<LoopingForEach02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.LoopingForEach02()
;             Parallel.ForEach(this._peopleDistinctBlockingCollection, p =>
;             ^^^^^^^^^^^^^^^
;                         {
;             ^^^^^^^^^^^^^^^
;                             base.Consumer.Consume(p);
;             ^^^^^^^^^^^^^^^
;                         });
;             ^^^^^^^^^^^^^^^
;         }
;         ^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       rsi,rcx
       mov       rcx,offset MT_System.Action`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+88]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.<LoopingForEach02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rdi+18],rcx
       lea       rcx,[rsp+28]
       mov       r9,rdi
       mov       r8,rbx
       mov       rdx,offset MD_System.Threading.Tasks.Parallel.ForEach(System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
       call      System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       mov       [rbp+0FFD8],rdx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        short M01_L01
       test      rbx,rbx
       je        near ptr M01_L02
       mov       rcx,2160D897960
       mov       r14,[rcx]
       mov       rcx,[rdx+10]
       mov       rax,[rcx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rcx,rdx
       mov       rdx,7FFF60CCF1B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L00:
       mov       [rsp+20],rbx
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       mov       [rsp+50],rcx
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,rdi
       mov       r9,r14
       call      System.Threading.Tasks.Parallel.ForEachWorker[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Threading.Tasks.ParallelOptions, System.Action`1<System.__Canon>, System.Action`2<System.__Canon,System.Threading.Tasks.ParallelLoopState>, System.Action`3<System.__Canon,System.Threading.Tasks.ParallelLoopState,Int64>, System.Func`4<System.__Canon,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`5<System.__Canon,System.Threading.Tasks.ParallelLoopState,Int64,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       mov       rax,rsi
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,375
       mov       rdx,7FFF60BDD770
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,33D
       mov       rdx,7FFF60BDD770
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 272
```
**Method was not JITted yet.**
dotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner.<LoopingForEach02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)

