## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner.Creating01()
;             var result = new ConcurrentHashSet<PersonProper>(base.personProperCollection);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       rsi,rcx
       lea       rcx,[rbp+0FF78]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp+0FF98],rcx
       mov       rcx,rbp
       mov       [rbp+0FFA8],rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFC0],rax
       mov       [rbp+10],rsi
       mov       r14,[rsi+58]
       mov       [rbp+0FFB8],r14
       xor       r11d,r11d
       mov       rax,offset MD_System.Environment.GetProcessorCount()
       mov       [rbp+0FF88],rax
       lea       rax,[M00_L00]
       mov       [rbp+0FFA0],rax
       lea       rax,[rbp+0FF78]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       call      qword ptr [7FFF60C46880]
M00_L00:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF60C47BD8],0
       je        short M00_L01
       call      qword ptr [7FFF60C4B278]
M00_L01:
       mov       rdx,[rbp+0FF80]
       mov       [rdi+10],rdx
       mov       edx,eax
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rbp+0FFC0]
       mov       r8d,1F
       mov       r9d,1
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32, Int32, Boolean, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,[rbp+0FFB8]
       test      r14,r14
       je        short M00_L02
       mov       rcx,[rbp+0FFC0]
       mov       rdx,r14
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].InitializeFromCollection(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L02:
       mov       rsi,[rbp+10]
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,[rbp+0FFC0]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       byte ptr [rdi+0C],1
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
; Total bytes of code 264
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32, Int32, Boolean, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
;             if (concurrencyLevel < 1)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^
       test      edx,edx
       jg        short M01_L00
;                 concurrencyLevel = 1;
;                 ^^^^^^^^^^^^^^^^^^^^^
       mov       edx,1
;             if (capacity < 0)
;             ^^^^^^^^^^^^^^^^^
M01_L00:
       test      edi,edi
       jge       short M01_L01
;                 capacity = 0;
;                 ^^^^^^^^^^^^^
       xor       edi,edi
;             if (capacity < concurrencyLevel)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L01:
       cmp       edi,edx
       jge       short M01_L02
;                 capacity = concurrencyLevel;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       edi,edx
;             var locks = new object[concurrencyLevel];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L02:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
;             for (var i = 0; i < locks.Length; i++)
;                  ^^^^^^^^^
       xor       r14d,r14d
       mov       r15d,[rbp+8]
       test      r15d,r15d
       jle       short M01_L04
;                 locks[i] = new object();
;                 ^^^^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       rcx,rbp
       mov       edx,r14d
       call      CORINFO_HELP_ARRADDR_ST
       inc       r14d
       cmp       r15d,r14d
       jg        short M01_L03
;             var countPerLock = new int[locks.Length];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L04:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
;             var buckets = new Node[capacity];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       r12,[rsi]
       mov       rcx,r12
       mov       rdx,[rcx+30]
       mov       r13,[rdx]
       mov       rax,[r13+8]
       test      rax,rax
       jne       short M01_L05
       mov       rdx,7FFF60CD2378
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L05:
       movsxd    rdx,edi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
;             this._tables = new Tables(buckets, locks, countPerLock);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,r12
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M01_L06
       mov       rdx,7FFF60CD2648
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+28]
       lea       rcx,[rax+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
;             this._growLockArray = growLockArray;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rcx,[rsi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+1C],bl
;             this._budget = buckets.Length / locks.Length;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       eax,[rdi+8]
       cdq
       idiv      r15d
       mov       [rsi+18],eax
       mov       rdi,[rsp+0A0]
       mov       rdx,rdi
;             this._comparer = comparer ?? EqualityComparer<T>.Default;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      rdx,rdx
       jne       short M01_L08
       mov       rcx,r12
       mov       rax,[r13+18]
       test      rax,rax
       jne       short M01_L07
       mov       rdx,7FFF60CD27B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L07:
       mov       rcx,rax
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
M01_L08:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
; Total bytes of code 385
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].InitializeFromCollection(System.Collections.Generic.IEnumerable`1<System.__Canon>)
;             collection.ToList().ForEach(item =>
;             ^^^
;             {
;             ^^^
;                 this.AddInternal(item, this._comparer.GetHashCode(item), false);
;             ^^^
;             });
;             ^^^
;             if (this._budget == 0)
;             ^^^^^^^^^^^^^^^^^^^^^^
;                 this._budget = this._tables._buckets.Length / this._tables._locks.Length;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi]
       mov       rcx,rbx
       mov       rdx,[rcx+30]
       mov       rbp,[rdx]
       mov       rax,[rbp+20]
       test      rax,rax
       jne       short M02_L00
       mov       rdx,7FFF60CD29D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L00:
       mov       rcx,rax
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,rbx
       mov       rax,[rbp+28]
       test      rax,rax
       jne       short M02_L01
       mov       rdx,7FFF60CD2B10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__38_0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rsi+18],0
       jne       short M02_L02
       mov       rax,[rsi+10]
       mov       rax,[rax+8]
       mov       eax,[rax+8]
       mov       rdx,[rsi+10]
       mov       rcx,[rdx+10]
       cdq
       idiv      dword ptr [rcx+8]
       mov       [rsi+18],eax
M02_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 188
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner.Creating01()
;             var result = new ConcurrentHashSet<PersonProper>(base.personProperCollection);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       rsi,rcx
       lea       rcx,[rbp+0FF78]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp+0FF98],rcx
       mov       rcx,rbp
       mov       [rbp+0FFA8],rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFC0],rax
       mov       [rbp+10],rsi
       mov       r14,[rsi+58]
       mov       [rbp+0FFB8],r14
       xor       r11d,r11d
       mov       rax,offset MD_System.Environment.GetProcessorCount()
       mov       [rbp+0FF88],rax
       lea       rax,[M00_L00]
       mov       [rbp+0FFA0],rax
       lea       rax,[rbp+0FF78]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       call      qword ptr [7FFF60C26880]
M00_L00:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF60C27BD8],0
       je        short M00_L01
       call      qword ptr [7FFF60C2B278]
M00_L01:
       mov       rdx,[rbp+0FF80]
       mov       [rdi+10],rdx
       mov       edx,eax
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rbp+0FFC0]
       mov       r8d,1F
       mov       r9d,1
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32, Int32, Boolean, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,[rbp+0FFB8]
       test      r14,r14
       je        short M00_L02
       mov       rcx,[rbp+0FFC0]
       mov       rdx,r14
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].InitializeFromCollection(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L02:
       mov       rsi,[rbp+10]
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,[rbp+0FFC0]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       byte ptr [rdi+0C],1
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
; Total bytes of code 264
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32, Int32, Boolean, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
;             if (concurrencyLevel < 1)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^
       test      edx,edx
       jg        short M01_L00
;                 concurrencyLevel = 1;
;                 ^^^^^^^^^^^^^^^^^^^^^
       mov       edx,1
;             if (capacity < 0)
;             ^^^^^^^^^^^^^^^^^
M01_L00:
       test      edi,edi
       jge       short M01_L01
;                 capacity = 0;
;                 ^^^^^^^^^^^^^
       xor       edi,edi
;             if (capacity < concurrencyLevel)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L01:
       cmp       edi,edx
       jge       short M01_L02
;                 capacity = concurrencyLevel;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       edi,edx
;             var locks = new object[concurrencyLevel];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L02:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
;             for (var i = 0; i < locks.Length; i++)
;                  ^^^^^^^^^
       xor       r14d,r14d
       mov       r15d,[rbp+8]
       test      r15d,r15d
       jle       short M01_L04
;                 locks[i] = new object();
;                 ^^^^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       rcx,rbp
       mov       edx,r14d
       call      CORINFO_HELP_ARRADDR_ST
       inc       r14d
       cmp       r15d,r14d
       jg        short M01_L03
;             var countPerLock = new int[locks.Length];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L04:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
;             var buckets = new Node[capacity];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       r12,[rsi]
       mov       rcx,r12
       mov       rdx,[rcx+30]
       mov       r13,[rdx]
       mov       rax,[r13+8]
       test      rax,rax
       jne       short M01_L05
       mov       rdx,7FFF60CB26B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L05:
       movsxd    rdx,edi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
;             this._tables = new Tables(buckets, locks, countPerLock);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,r12
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M01_L06
       mov       rdx,7FFF60CB2980
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+28]
       lea       rcx,[rax+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
;             this._growLockArray = growLockArray;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rcx,[rsi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+1C],bl
;             this._budget = buckets.Length / locks.Length;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       eax,[rdi+8]
       cdq
       idiv      r15d
       mov       [rsi+18],eax
       mov       rdi,[rsp+0A0]
       mov       rdx,rdi
;             this._comparer = comparer ?? EqualityComparer<T>.Default;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      rdx,rdx
       jne       short M01_L08
       mov       rcx,r12
       mov       rax,[r13+18]
       test      rax,rax
       jne       short M01_L07
       mov       rdx,7FFF60CB2AF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L07:
       mov       rcx,rax
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
M01_L08:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
; Total bytes of code 385
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].InitializeFromCollection(System.Collections.Generic.IEnumerable`1<System.__Canon>)
;             collection.ToList().ForEach(item =>
;             ^^^
;             {
;             ^^^
;                 this.AddInternal(item, this._comparer.GetHashCode(item), false);
;             ^^^
;             });
;             ^^^
;             if (this._budget == 0)
;             ^^^^^^^^^^^^^^^^^^^^^^
;                 this._budget = this._tables._buckets.Length / this._tables._locks.Length;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi]
       mov       rcx,rbx
       mov       rdx,[rcx+30]
       mov       rbp,[rdx]
       mov       rax,[rbp+20]
       test      rax,rax
       jne       short M02_L00
       mov       rdx,7FFF60CB2D08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L00:
       mov       rcx,rax
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,rbx
       mov       rax,[rbp+28]
       test      rax,rax
       jne       short M02_L01
       mov       rdx,7FFF60CB2E48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__38_0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rsi+18],0
       jne       short M02_L02
       mov       rax,[rsi+10]
       mov       rax,[rax+8]
       mov       eax,[rax+8]
       mov       rdx,[rsi+10]
       mov       rcx,[rdx+10]
       cdq
       idiv      dword ptr [rcx+8]
       mov       [rsi+18],eax
M02_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 188
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner.Creating01()
;             var result = new ConcurrentHashSet<PersonProper>(base.personProperCollection);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       rsi,rcx
       lea       rcx,[rbp+0FF78]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp+0FF98],rcx
       mov       rcx,rbp
       mov       [rbp+0FFA8],rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFC0],rax
       mov       [rbp+10],rsi
       mov       r14,[rsi+58]
       mov       [rbp+0FFB8],r14
       xor       r11d,r11d
       mov       rax,offset MD_System.Environment.GetProcessorCount()
       mov       [rbp+0FF88],rax
       lea       rax,[M00_L00]
       mov       [rbp+0FFA0],rax
       lea       rax,[rbp+0FF78]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       call      qword ptr [7FFF60C46880]
M00_L00:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF60C47BD8],0
       je        short M00_L01
       call      qword ptr [7FFF60C4B278]
M00_L01:
       mov       rdx,[rbp+0FF80]
       mov       [rdi+10],rdx
       mov       edx,eax
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rbp+0FFC0]
       mov       r8d,1F
       mov       r9d,1
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32, Int32, Boolean, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,[rbp+0FFB8]
       test      r14,r14
       je        short M00_L02
       mov       rcx,[rbp+0FFC0]
       mov       rdx,r14
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].InitializeFromCollection(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L02:
       mov       rsi,[rbp+10]
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,[rbp+0FFC0]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       byte ptr [rdi+0C],1
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
; Total bytes of code 264
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32, Int32, Boolean, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
;             if (concurrencyLevel < 1)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^
       test      edx,edx
       jg        short M01_L00
;                 concurrencyLevel = 1;
;                 ^^^^^^^^^^^^^^^^^^^^^
       mov       edx,1
;             if (capacity < 0)
;             ^^^^^^^^^^^^^^^^^
M01_L00:
       test      edi,edi
       jge       short M01_L01
;                 capacity = 0;
;                 ^^^^^^^^^^^^^
       xor       edi,edi
;             if (capacity < concurrencyLevel)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L01:
       cmp       edi,edx
       jge       short M01_L02
;                 capacity = concurrencyLevel;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       edi,edx
;             var locks = new object[concurrencyLevel];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L02:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
;             for (var i = 0; i < locks.Length; i++)
;                  ^^^^^^^^^
       xor       r14d,r14d
       mov       r15d,[rbp+8]
       test      r15d,r15d
       jle       short M01_L04
;                 locks[i] = new object();
;                 ^^^^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       rcx,rbp
       mov       edx,r14d
       call      CORINFO_HELP_ARRADDR_ST
       inc       r14d
       cmp       r15d,r14d
       jg        short M01_L03
;             var countPerLock = new int[locks.Length];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L04:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
;             var buckets = new Node[capacity];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       r12,[rsi]
       mov       rcx,r12
       mov       rdx,[rcx+30]
       mov       r13,[rdx]
       mov       rax,[r13+8]
       test      rax,rax
       jne       short M01_L05
       mov       rdx,7FFF60CD2420
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L05:
       movsxd    rdx,edi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
;             this._tables = new Tables(buckets, locks, countPerLock);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,r12
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M01_L06
       mov       rdx,7FFF60CD26F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+28]
       lea       rcx,[rax+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
;             this._growLockArray = growLockArray;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rcx,[rsi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+1C],bl
;             this._budget = buckets.Length / locks.Length;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       eax,[rdi+8]
       cdq
       idiv      r15d
       mov       [rsi+18],eax
       mov       rdi,[rsp+0A0]
       mov       rdx,rdi
;             this._comparer = comparer ?? EqualityComparer<T>.Default;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      rdx,rdx
       jne       short M01_L08
       mov       rcx,r12
       mov       rax,[r13+18]
       test      rax,rax
       jne       short M01_L07
       mov       rdx,7FFF60CD2860
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L07:
       mov       rcx,rax
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
M01_L08:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
; Total bytes of code 385
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].InitializeFromCollection(System.Collections.Generic.IEnumerable`1<System.__Canon>)
;             collection.ToList().ForEach(item =>
;             ^^^
;             {
;             ^^^
;                 this.AddInternal(item, this._comparer.GetHashCode(item), false);
;             ^^^
;             });
;             ^^^
;             if (this._budget == 0)
;             ^^^^^^^^^^^^^^^^^^^^^^
;                 this._budget = this._tables._buckets.Length / this._tables._locks.Length;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi]
       mov       rcx,rbx
       mov       rdx,[rcx+30]
       mov       rbp,[rdx]
       mov       rax,[rbp+20]
       test      rax,rax
       jne       short M02_L00
       mov       rdx,7FFF60CD2A78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L00:
       mov       rcx,rax
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,rbx
       mov       rax,[rbp+28]
       test      rax,rax
       jne       short M02_L01
       mov       rdx,7FFF60CD2BB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__38_0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rsi+18],0
       jne       short M02_L02
       mov       rax,[rsi+10]
       mov       rax,[rax+8]
       mov       eax,[rax+8]
       mov       rdx,[rsi+10]
       mov       rcx,[rdx+10]
       cdq
       idiv      dword ptr [rcx+8]
       mov       [rsi+18],eax
M02_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 188
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner.Creating01()
;             var result = new ConcurrentHashSet<PersonProper>(base.personProperCollection);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       rsi,rcx
       lea       rcx,[rbp+0FF78]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp+0FF98],rcx
       mov       rcx,rbp
       mov       [rbp+0FFA8],rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFC0],rax
       mov       [rbp+10],rsi
       mov       r14,[rsi+58]
       mov       [rbp+0FFB8],r14
       xor       r11d,r11d
       mov       rax,offset MD_System.Environment.GetProcessorCount()
       mov       [rbp+0FF88],rax
       lea       rax,[M00_L00]
       mov       [rbp+0FFA0],rax
       lea       rax,[rbp+0FF78]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       call      qword ptr [7FFF60C36880]
M00_L00:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF60C37BD8],0
       je        short M00_L01
       call      qword ptr [7FFF60C3B278]
M00_L01:
       mov       rdx,[rbp+0FF80]
       mov       [rdi+10],rdx
       mov       edx,eax
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rbp+0FFC0]
       mov       r8d,1F
       mov       r9d,1
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32, Int32, Boolean, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,[rbp+0FFB8]
       test      r14,r14
       je        short M00_L02
       mov       rcx,[rbp+0FFC0]
       mov       rdx,r14
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].InitializeFromCollection(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L02:
       mov       rsi,[rbp+10]
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,[rbp+0FFC0]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       byte ptr [rdi+0C],1
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
; Total bytes of code 264
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32, Int32, Boolean, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
;             if (concurrencyLevel < 1)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^
       test      edx,edx
       jg        short M01_L00
;                 concurrencyLevel = 1;
;                 ^^^^^^^^^^^^^^^^^^^^^
       mov       edx,1
;             if (capacity < 0)
;             ^^^^^^^^^^^^^^^^^
M01_L00:
       test      edi,edi
       jge       short M01_L01
;                 capacity = 0;
;                 ^^^^^^^^^^^^^
       xor       edi,edi
;             if (capacity < concurrencyLevel)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L01:
       cmp       edi,edx
       jge       short M01_L02
;                 capacity = concurrencyLevel;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       edi,edx
;             var locks = new object[concurrencyLevel];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L02:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
;             for (var i = 0; i < locks.Length; i++)
;                  ^^^^^^^^^
       xor       r14d,r14d
       mov       r15d,[rbp+8]
       test      r15d,r15d
       jle       short M01_L04
;                 locks[i] = new object();
;                 ^^^^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       rcx,rbp
       mov       edx,r14d
       call      CORINFO_HELP_ARRADDR_ST
       inc       r14d
       cmp       r15d,r14d
       jg        short M01_L03
;             var countPerLock = new int[locks.Length];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L04:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
;             var buckets = new Node[capacity];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       r12,[rsi]
       mov       rcx,r12
       mov       rdx,[rcx+30]
       mov       r13,[rdx]
       mov       rax,[r13+8]
       test      rax,rax
       jne       short M01_L05
       mov       rdx,7FFF60CC2420
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L05:
       movsxd    rdx,edi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
;             this._tables = new Tables(buckets, locks, countPerLock);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,r12
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M01_L06
       mov       rdx,7FFF60CC26F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+28]
       lea       rcx,[rax+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
;             this._growLockArray = growLockArray;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rcx,[rsi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+1C],bl
;             this._budget = buckets.Length / locks.Length;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       eax,[rdi+8]
       cdq
       idiv      r15d
       mov       [rsi+18],eax
       mov       rdi,[rsp+0A0]
       mov       rdx,rdi
;             this._comparer = comparer ?? EqualityComparer<T>.Default;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      rdx,rdx
       jne       short M01_L08
       mov       rcx,r12
       mov       rax,[r13+18]
       test      rax,rax
       jne       short M01_L07
       mov       rdx,7FFF60CC2860
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L07:
       mov       rcx,rax
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
M01_L08:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
; Total bytes of code 385
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].InitializeFromCollection(System.Collections.Generic.IEnumerable`1<System.__Canon>)
;             collection.ToList().ForEach(item =>
;             ^^^
;             {
;             ^^^
;                 this.AddInternal(item, this._comparer.GetHashCode(item), false);
;             ^^^
;             });
;             ^^^
;             if (this._budget == 0)
;             ^^^^^^^^^^^^^^^^^^^^^^
;                 this._budget = this._tables._buckets.Length / this._tables._locks.Length;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi]
       mov       rcx,rbx
       mov       rdx,[rcx+30]
       mov       rbp,[rdx]
       mov       rax,[rbp+20]
       test      rax,rax
       jne       short M02_L00
       mov       rdx,7FFF60CC2A78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L00:
       mov       rcx,rax
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,rbx
       mov       rax,[rbp+28]
       test      rax,rax
       jne       short M02_L01
       mov       rdx,7FFF60CC2BB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__38_0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rsi+18],0
       jne       short M02_L02
       mov       rax,[rsi+10]
       mov       rax,[rax+8]
       mov       eax,[rax+8]
       mov       rdx,[rsi+10]
       mov       rcx,[rdx+10]
       cdq
       idiv      dword ptr [rcx+8]
       mov       [rsi+18],eax
M02_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 188
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner.Creating01()
;             var result = new ConcurrentHashSet<PersonProper>(base.personProperCollection);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       rsi,rcx
       lea       rcx,[rbp+0FF78]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp+0FF98],rcx
       mov       rcx,rbp
       mov       [rbp+0FFA8],rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFC0],rax
       mov       [rbp+10],rsi
       mov       r14,[rsi+58]
       mov       [rbp+0FFB8],r14
       xor       r11d,r11d
       mov       rax,offset MD_System.Environment.GetProcessorCount()
       mov       [rbp+0FF88],rax
       lea       rax,[M00_L00]
       mov       [rbp+0FFA0],rax
       lea       rax,[rbp+0FF78]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       call      qword ptr [7FFF60C46880]
M00_L00:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF60C47BD8],0
       je        short M00_L01
       call      qword ptr [7FFF60C4B278]
M00_L01:
       mov       rdx,[rbp+0FF80]
       mov       [rdi+10],rdx
       mov       edx,eax
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rbp+0FFC0]
       mov       r8d,1F
       mov       r9d,1
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32, Int32, Boolean, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,[rbp+0FFB8]
       test      r14,r14
       je        short M00_L02
       mov       rcx,[rbp+0FFC0]
       mov       rdx,r14
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].InitializeFromCollection(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L02:
       mov       rsi,[rbp+10]
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,[rbp+0FFC0]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       byte ptr [rdi+0C],1
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
; Total bytes of code 264
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32, Int32, Boolean, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
;             if (concurrencyLevel < 1)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^
       test      edx,edx
       jg        short M01_L00
;                 concurrencyLevel = 1;
;                 ^^^^^^^^^^^^^^^^^^^^^
       mov       edx,1
;             if (capacity < 0)
;             ^^^^^^^^^^^^^^^^^
M01_L00:
       test      edi,edi
       jge       short M01_L01
;                 capacity = 0;
;                 ^^^^^^^^^^^^^
       xor       edi,edi
;             if (capacity < concurrencyLevel)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L01:
       cmp       edi,edx
       jge       short M01_L02
;                 capacity = concurrencyLevel;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       edi,edx
;             var locks = new object[concurrencyLevel];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L02:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
;             for (var i = 0; i < locks.Length; i++)
;                  ^^^^^^^^^
       xor       r14d,r14d
       mov       r15d,[rbp+8]
       test      r15d,r15d
       jle       short M01_L04
;                 locks[i] = new object();
;                 ^^^^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       rcx,rbp
       mov       edx,r14d
       call      CORINFO_HELP_ARRADDR_ST
       inc       r14d
       cmp       r15d,r14d
       jg        short M01_L03
;             var countPerLock = new int[locks.Length];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L04:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
;             var buckets = new Node[capacity];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       r12,[rsi]
       mov       rcx,r12
       mov       rdx,[rcx+30]
       mov       r13,[rdx]
       mov       rax,[r13+8]
       test      rax,rax
       jne       short M01_L05
       mov       rdx,7FFF60CD2878
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L05:
       movsxd    rdx,edi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
;             this._tables = new Tables(buckets, locks, countPerLock);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,r12
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M01_L06
       mov       rdx,7FFF60CD2B48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+28]
       lea       rcx,[rax+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
;             this._growLockArray = growLockArray;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rcx,[rsi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+1C],bl
;             this._budget = buckets.Length / locks.Length;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       eax,[rdi+8]
       cdq
       idiv      r15d
       mov       [rsi+18],eax
       mov       rdi,[rsp+0A0]
       mov       rdx,rdi
;             this._comparer = comparer ?? EqualityComparer<T>.Default;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      rdx,rdx
       jne       short M01_L08
       mov       rcx,r12
       mov       rax,[r13+18]
       test      rax,rax
       jne       short M01_L07
       mov       rdx,7FFF60CD2CB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L07:
       mov       rcx,rax
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
M01_L08:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
; Total bytes of code 385
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].InitializeFromCollection(System.Collections.Generic.IEnumerable`1<System.__Canon>)
;             collection.ToList().ForEach(item =>
;             ^^^
;             {
;             ^^^
;                 this.AddInternal(item, this._comparer.GetHashCode(item), false);
;             ^^^
;             });
;             ^^^
;             if (this._budget == 0)
;             ^^^^^^^^^^^^^^^^^^^^^^
;                 this._budget = this._tables._buckets.Length / this._tables._locks.Length;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi]
       mov       rcx,rbx
       mov       rdx,[rcx+30]
       mov       rbp,[rdx]
       mov       rax,[rbp+20]
       test      rax,rax
       jne       short M02_L00
       mov       rdx,7FFF60CD2ED0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L00:
       mov       rcx,rax
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,rbx
       mov       rax,[rbp+28]
       test      rax,rax
       jne       short M02_L01
       mov       rdx,7FFF60CD3010
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__38_0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rsi+18],0
       jne       short M02_L02
       mov       rax,[rsi+10]
       mov       rax,[rax+8]
       mov       eax,[rax+8]
       mov       rdx,[rsi+10]
       mov       rcx,[rdx+10]
       cdq
       idiv      dword ptr [rcx+8]
       mov       [rsi+18],eax
M02_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 188
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner.Creating01()
;             var result = new ConcurrentHashSet<PersonProper>(base.personProperCollection);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       rsi,rcx
       lea       rcx,[rbp+0FF78]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp+0FF98],rcx
       mov       rcx,rbp
       mov       [rbp+0FFA8],rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFC0],rax
       mov       [rbp+10],rsi
       mov       r14,[rsi+58]
       mov       [rbp+0FFB8],r14
       xor       r11d,r11d
       mov       rax,offset MD_System.Environment.GetProcessorCount()
       mov       [rbp+0FF88],rax
       lea       rax,[M00_L00]
       mov       [rbp+0FFA0],rax
       lea       rax,[rbp+0FF78]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       call      qword ptr [7FFF60C16880]
M00_L00:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF60C17BD8],0
       je        short M00_L01
       call      qword ptr [7FFF60C1B278]
M00_L01:
       mov       rdx,[rbp+0FF80]
       mov       [rdi+10],rdx
       mov       edx,eax
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rbp+0FFC0]
       mov       r8d,1F
       mov       r9d,1
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32, Int32, Boolean, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,[rbp+0FFB8]
       test      r14,r14
       je        short M00_L02
       mov       rcx,[rbp+0FFC0]
       mov       rdx,r14
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].InitializeFromCollection(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L02:
       mov       rsi,[rbp+10]
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,[rbp+0FFC0]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       byte ptr [rdi+0C],1
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
; Total bytes of code 264
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32, Int32, Boolean, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
;             if (concurrencyLevel < 1)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^
       test      edx,edx
       jg        short M01_L00
;                 concurrencyLevel = 1;
;                 ^^^^^^^^^^^^^^^^^^^^^
       mov       edx,1
;             if (capacity < 0)
;             ^^^^^^^^^^^^^^^^^
M01_L00:
       test      edi,edi
       jge       short M01_L01
;                 capacity = 0;
;                 ^^^^^^^^^^^^^
       xor       edi,edi
;             if (capacity < concurrencyLevel)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L01:
       cmp       edi,edx
       jge       short M01_L02
;                 capacity = concurrencyLevel;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       edi,edx
;             var locks = new object[concurrencyLevel];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L02:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
;             for (var i = 0; i < locks.Length; i++)
;                  ^^^^^^^^^
       xor       r14d,r14d
       mov       r15d,[rbp+8]
       test      r15d,r15d
       jle       short M01_L04
;                 locks[i] = new object();
;                 ^^^^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       rcx,rbp
       mov       edx,r14d
       call      CORINFO_HELP_ARRADDR_ST
       inc       r14d
       cmp       r15d,r14d
       jg        short M01_L03
;             var countPerLock = new int[locks.Length];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L04:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
;             var buckets = new Node[capacity];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       r12,[rsi]
       mov       rcx,r12
       mov       rdx,[rcx+30]
       mov       r13,[rdx]
       mov       rax,[r13+8]
       test      rax,rax
       jne       short M01_L05
       mov       rdx,7FFF60CA2420
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L05:
       movsxd    rdx,edi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
;             this._tables = new Tables(buckets, locks, countPerLock);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,r12
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M01_L06
       mov       rdx,7FFF60CA26F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+28]
       lea       rcx,[rax+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
;             this._growLockArray = growLockArray;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rcx,[rsi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+1C],bl
;             this._budget = buckets.Length / locks.Length;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       eax,[rdi+8]
       cdq
       idiv      r15d
       mov       [rsi+18],eax
       mov       rdi,[rsp+0A0]
       mov       rdx,rdi
;             this._comparer = comparer ?? EqualityComparer<T>.Default;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      rdx,rdx
       jne       short M01_L08
       mov       rcx,r12
       mov       rax,[r13+18]
       test      rax,rax
       jne       short M01_L07
       mov       rdx,7FFF60CA2860
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L07:
       mov       rcx,rax
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
M01_L08:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
; Total bytes of code 385
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].InitializeFromCollection(System.Collections.Generic.IEnumerable`1<System.__Canon>)
;             collection.ToList().ForEach(item =>
;             ^^^
;             {
;             ^^^
;                 this.AddInternal(item, this._comparer.GetHashCode(item), false);
;             ^^^
;             });
;             ^^^
;             if (this._budget == 0)
;             ^^^^^^^^^^^^^^^^^^^^^^
;                 this._budget = this._tables._buckets.Length / this._tables._locks.Length;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi]
       mov       rcx,rbx
       mov       rdx,[rcx+30]
       mov       rbp,[rdx]
       mov       rax,[rbp+20]
       test      rax,rax
       jne       short M02_L00
       mov       rdx,7FFF60CA2A78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L00:
       mov       rcx,rax
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,rbx
       mov       rax,[rbp+28]
       test      rax,rax
       jne       short M02_L01
       mov       rdx,7FFF60CA2BB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__38_0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rsi+18],0
       jne       short M02_L02
       mov       rax,[rsi+10]
       mov       rax,[rax+8]
       mov       eax,[rax+8]
       mov       rdx,[rsi+10]
       mov       rcx,[rdx+10]
       cdq
       idiv      dword ptr [rcx+8]
       mov       [rsi+18],eax
M02_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 188
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner.Creating01()
;             var result = new ConcurrentHashSet<PersonProper>(base.personProperCollection);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       rsi,rcx
       lea       rcx,[rbp+0FF78]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp+0FF98],rcx
       mov       rcx,rbp
       mov       [rbp+0FFA8],rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFC0],rax
       mov       [rbp+10],rsi
       mov       r14,[rsi+58]
       mov       [rbp+0FFB8],r14
       xor       r11d,r11d
       mov       rax,offset MD_System.Environment.GetProcessorCount()
       mov       [rbp+0FF88],rax
       lea       rax,[M00_L00]
       mov       [rbp+0FFA0],rax
       lea       rax,[rbp+0FF78]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       call      qword ptr [7FFF60C16880]
M00_L00:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF60C17BD8],0
       je        short M00_L01
       call      qword ptr [7FFF60C1B278]
M00_L01:
       mov       rdx,[rbp+0FF80]
       mov       [rdi+10],rdx
       mov       edx,eax
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rbp+0FFC0]
       mov       r8d,1F
       mov       r9d,1
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32, Int32, Boolean, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,[rbp+0FFB8]
       test      r14,r14
       je        short M00_L02
       mov       rcx,[rbp+0FFC0]
       mov       rdx,r14
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].InitializeFromCollection(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M00_L02:
       mov       rsi,[rbp+10]
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,[rbp+0FFC0]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       byte ptr [rdi+0C],1
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
; Total bytes of code 264
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32, Int32, Boolean, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
;             if (concurrencyLevel < 1)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^
       test      edx,edx
       jg        short M01_L00
;                 concurrencyLevel = 1;
;                 ^^^^^^^^^^^^^^^^^^^^^
       mov       edx,1
;             if (capacity < 0)
;             ^^^^^^^^^^^^^^^^^
M01_L00:
       test      edi,edi
       jge       short M01_L01
;                 capacity = 0;
;                 ^^^^^^^^^^^^^
       xor       edi,edi
;             if (capacity < concurrencyLevel)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L01:
       cmp       edi,edx
       jge       short M01_L02
;                 capacity = concurrencyLevel;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       edi,edx
;             var locks = new object[concurrencyLevel];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L02:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
;             for (var i = 0; i < locks.Length; i++)
;                  ^^^^^^^^^
       xor       r14d,r14d
       mov       r15d,[rbp+8]
       test      r15d,r15d
       jle       short M01_L04
;                 locks[i] = new object();
;                 ^^^^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       rcx,rbp
       mov       edx,r14d
       call      CORINFO_HELP_ARRADDR_ST
       inc       r14d
       cmp       r15d,r14d
       jg        short M01_L03
;             var countPerLock = new int[locks.Length];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L04:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
;             var buckets = new Node[capacity];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       r12,[rsi]
       mov       rcx,r12
       mov       rdx,[rcx+30]
       mov       r13,[rdx]
       mov       rax,[r13+8]
       test      rax,rax
       jne       short M01_L05
       mov       rdx,7FFF60CA2878
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L05:
       movsxd    rdx,edi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
;             this._tables = new Tables(buckets, locks, countPerLock);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,r12
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M01_L06
       mov       rdx,7FFF60CA2B48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+28]
       lea       rcx,[rax+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
;             this._growLockArray = growLockArray;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rcx,[rsi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+1C],bl
;             this._budget = buckets.Length / locks.Length;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       eax,[rdi+8]
       cdq
       idiv      r15d
       mov       [rsi+18],eax
       mov       rdi,[rsp+0A0]
       mov       rdx,rdi
;             this._comparer = comparer ?? EqualityComparer<T>.Default;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      rdx,rdx
       jne       short M01_L08
       mov       rcx,r12
       mov       rax,[r13+18]
       test      rax,rax
       jne       short M01_L07
       mov       rdx,7FFF60CA2CB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L07:
       mov       rcx,rax
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
M01_L08:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
; Total bytes of code 385
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].InitializeFromCollection(System.Collections.Generic.IEnumerable`1<System.__Canon>)
;             collection.ToList().ForEach(item =>
;             ^^^
;             {
;             ^^^
;                 this.AddInternal(item, this._comparer.GetHashCode(item), false);
;             ^^^
;             });
;             ^^^
;             if (this._budget == 0)
;             ^^^^^^^^^^^^^^^^^^^^^^
;                 this._budget = this._tables._buckets.Length / this._tables._locks.Length;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi]
       mov       rcx,rbx
       mov       rdx,[rcx+30]
       mov       rbp,[rdx]
       mov       rax,[rbp+20]
       test      rax,rax
       jne       short M02_L00
       mov       rdx,7FFF60CA2ED0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L00:
       mov       rcx,rax
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,rbx
       mov       rax,[rbp+28]
       test      rax,rax
       jne       short M02_L01
       mov       rdx,7FFF60CA3010
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].<InitializeFromCollection>b__38_0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       dword ptr [rsi+18],0
       jne       short M02_L02
       mov       rax,[rsi+10]
       mov       rax,[rax+8]
       mov       eax,[rax+8]
       mov       rdx,[rsi+10]
       mov       rcx,[rdx+10]
       cdq
       idiv      dword ptr [rcx+8]
       mov       [rsi+18],eax
M02_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 188
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner.Creating02()
;             var fakePeople = new ConcurrentHashSet<PersonProper>();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.personProperCollection.ForEach(p => fakePeople.Add(p));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(fakePeople);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+0FF78]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp+0FF98],rcx
       mov       rcx,rbp
       mov       [rbp+0FFA8],rcx
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbp+0FFC0],rbx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFB8],rax
       xor       r11d,r11d
       mov       rax,offset MD_System.Environment.GetProcessorCount()
       mov       [rbp+0FF88],rax
       lea       rax,[M00_L00]
       mov       [rbp+0FFA0],rax
       lea       rax,[rbp+0FF78]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       call      qword ptr [7FFF60C36880]
M00_L00:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF60C37BD8],0
       je        short M00_L01
       call      qword ptr [7FFF60C3B278]
M00_L01:
       mov       rdx,[rbp+0FF80]
       mov       [rdi+10],rdx
       mov       edx,eax
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rbp+0FFB8]
       mov       r8d,1F
       mov       r9d,1
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32, Int32, Boolean, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rbx,[rbp+0FFC0]
       lea       rcx,[rbx+8]
       mov       rdx,[rbp+0FFB8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       r14,[rbp+10]
       mov       r15,[r14+58]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rsi+18],rcx
       mov       rcx,r15
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rdx,[rbx+8]
       mov       eax,[rcx]
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       byte ptr [rdi+0C],1
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
; Total bytes of code 332
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32, Int32, Boolean, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
;             if (concurrencyLevel < 1)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^
       test      edx,edx
       jg        short M01_L00
;                 concurrencyLevel = 1;
;                 ^^^^^^^^^^^^^^^^^^^^^
       mov       edx,1
;             if (capacity < 0)
;             ^^^^^^^^^^^^^^^^^
M01_L00:
       test      edi,edi
       jge       short M01_L01
;                 capacity = 0;
;                 ^^^^^^^^^^^^^
       xor       edi,edi
;             if (capacity < concurrencyLevel)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L01:
       cmp       edi,edx
       jge       short M01_L02
;                 capacity = concurrencyLevel;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       edi,edx
;             var locks = new object[concurrencyLevel];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L02:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
;             for (var i = 0; i < locks.Length; i++)
;                  ^^^^^^^^^
       xor       r14d,r14d
       mov       r15d,[rbp+8]
       test      r15d,r15d
       jle       short M01_L04
;                 locks[i] = new object();
;                 ^^^^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       rcx,rbp
       mov       edx,r14d
       call      CORINFO_HELP_ARRADDR_ST
       inc       r14d
       cmp       r15d,r14d
       jg        short M01_L03
;             var countPerLock = new int[locks.Length];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L04:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
;             var buckets = new Node[capacity];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       r12,[rsi]
       mov       rcx,r12
       mov       rdx,[rcx+30]
       mov       r13,[rdx]
       mov       rax,[r13+8]
       test      rax,rax
       jne       short M01_L05
       mov       rdx,7FFF60CC2378
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L05:
       movsxd    rdx,edi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
;             this._tables = new Tables(buckets, locks, countPerLock);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,r12
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M01_L06
       mov       rdx,7FFF60CC2648
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+28]
       lea       rcx,[rax+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
;             this._growLockArray = growLockArray;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rcx,[rsi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+1C],bl
;             this._budget = buckets.Length / locks.Length;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       eax,[rdi+8]
       cdq
       idiv      r15d
       mov       [rsi+18],eax
       mov       rdi,[rsp+0A0]
       mov       rdx,rdi
;             this._comparer = comparer ?? EqualityComparer<T>.Default;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      rdx,rdx
       jne       short M01_L08
       mov       rcx,r12
       mov       rax,[r13+18]
       test      rax,rax
       jne       short M01_L07
       mov       rdx,7FFF60CC27B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L07:
       mov       rcx,rax
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
M01_L08:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
; Total bytes of code 385
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
;             base.personProperCollection.ForEach(p => fakePeople.Add(p));
;                                                      ^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rdx
       mov       rdi,[rcx+8]
       mov       rcx,[rdi+8]
       mov       rdx,rsi
       mov       r11,7FFF60820600
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C30600]
       mov       r8d,eax
       mov       rdx,rsi
       mov       rcx,rdi
       mov       r9d,1
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 66
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner.Creating02()
;             var fakePeople = new ConcurrentHashSet<PersonProper>();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.personProperCollection.ForEach(p => fakePeople.Add(p));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(fakePeople);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+0FF78]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp+0FF98],rcx
       mov       rcx,rbp
       mov       [rbp+0FFA8],rcx
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbp+0FFC0],rbx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFB8],rax
       xor       r11d,r11d
       mov       rax,offset MD_System.Environment.GetProcessorCount()
       mov       [rbp+0FF88],rax
       lea       rax,[M00_L00]
       mov       [rbp+0FFA0],rax
       lea       rax,[rbp+0FF78]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       call      qword ptr [7FFF60C26880]
M00_L00:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF60C27BD8],0
       je        short M00_L01
       call      qword ptr [7FFF60C2B278]
M00_L01:
       mov       rdx,[rbp+0FF80]
       mov       [rdi+10],rdx
       mov       edx,eax
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rbp+0FFB8]
       mov       r8d,1F
       mov       r9d,1
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32, Int32, Boolean, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rbx,[rbp+0FFC0]
       lea       rcx,[rbx+8]
       mov       rdx,[rbp+0FFB8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       r14,[rbp+10]
       mov       r15,[r14+58]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rsi+18],rcx
       mov       rcx,r15
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rdx,[rbx+8]
       mov       eax,[rcx]
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       byte ptr [rdi+0C],1
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
; Total bytes of code 332
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32, Int32, Boolean, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
;             if (concurrencyLevel < 1)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^
       test      edx,edx
       jg        short M01_L00
;                 concurrencyLevel = 1;
;                 ^^^^^^^^^^^^^^^^^^^^^
       mov       edx,1
;             if (capacity < 0)
;             ^^^^^^^^^^^^^^^^^
M01_L00:
       test      edi,edi
       jge       short M01_L01
;                 capacity = 0;
;                 ^^^^^^^^^^^^^
       xor       edi,edi
;             if (capacity < concurrencyLevel)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L01:
       cmp       edi,edx
       jge       short M01_L02
;                 capacity = concurrencyLevel;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       edi,edx
;             var locks = new object[concurrencyLevel];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L02:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
;             for (var i = 0; i < locks.Length; i++)
;                  ^^^^^^^^^
       xor       r14d,r14d
       mov       r15d,[rbp+8]
       test      r15d,r15d
       jle       short M01_L04
;                 locks[i] = new object();
;                 ^^^^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       rcx,rbp
       mov       edx,r14d
       call      CORINFO_HELP_ARRADDR_ST
       inc       r14d
       cmp       r15d,r14d
       jg        short M01_L03
;             var countPerLock = new int[locks.Length];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L04:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
;             var buckets = new Node[capacity];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       r12,[rsi]
       mov       rcx,r12
       mov       rdx,[rcx+30]
       mov       r13,[rdx]
       mov       rax,[r13+8]
       test      rax,rax
       jne       short M01_L05
       mov       rdx,7FFF60CB2420
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L05:
       movsxd    rdx,edi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
;             this._tables = new Tables(buckets, locks, countPerLock);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,r12
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M01_L06
       mov       rdx,7FFF60CB26F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+28]
       lea       rcx,[rax+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
;             this._growLockArray = growLockArray;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rcx,[rsi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+1C],bl
;             this._budget = buckets.Length / locks.Length;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       eax,[rdi+8]
       cdq
       idiv      r15d
       mov       [rsi+18],eax
       mov       rdi,[rsp+0A0]
       mov       rdx,rdi
;             this._comparer = comparer ?? EqualityComparer<T>.Default;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      rdx,rdx
       jne       short M01_L08
       mov       rcx,r12
       mov       rax,[r13+18]
       test      rax,rax
       jne       short M01_L07
       mov       rdx,7FFF60CB2860
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L07:
       mov       rcx,rax
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
M01_L08:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
; Total bytes of code 385
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
;             base.personProperCollection.ForEach(p => fakePeople.Add(p));
;                                                      ^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rdx
       mov       rdi,[rcx+8]
       mov       rcx,[rdi+8]
       mov       rdx,rsi
       mov       r11,7FFF60810600
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C20600]
       mov       r8d,eax
       mov       rdx,rsi
       mov       rcx,rdi
       mov       r9d,1
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 66
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner.Creating02()
;             var fakePeople = new ConcurrentHashSet<PersonProper>();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.personProperCollection.ForEach(p => fakePeople.Add(p));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(fakePeople);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+0FF78]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp+0FF98],rcx
       mov       rcx,rbp
       mov       [rbp+0FFA8],rcx
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbp+0FFC0],rbx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFB8],rax
       xor       r11d,r11d
       mov       rax,offset MD_System.Environment.GetProcessorCount()
       mov       [rbp+0FF88],rax
       lea       rax,[M00_L00]
       mov       [rbp+0FFA0],rax
       lea       rax,[rbp+0FF78]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       call      qword ptr [7FFF60C46880]
M00_L00:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF60C47BD8],0
       je        short M00_L01
       call      qword ptr [7FFF60C4B278]
M00_L01:
       mov       rdx,[rbp+0FF80]
       mov       [rdi+10],rdx
       mov       edx,eax
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rbp+0FFB8]
       mov       r8d,1F
       mov       r9d,1
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32, Int32, Boolean, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rbx,[rbp+0FFC0]
       lea       rcx,[rbx+8]
       mov       rdx,[rbp+0FFB8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       r14,[rbp+10]
       mov       r15,[r14+58]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rsi+18],rcx
       mov       rcx,r15
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rdx,[rbx+8]
       mov       eax,[rcx]
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       byte ptr [rdi+0C],1
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
; Total bytes of code 332
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32, Int32, Boolean, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
;             if (concurrencyLevel < 1)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^
       test      edx,edx
       jg        short M01_L00
;                 concurrencyLevel = 1;
;                 ^^^^^^^^^^^^^^^^^^^^^
       mov       edx,1
;             if (capacity < 0)
;             ^^^^^^^^^^^^^^^^^
M01_L00:
       test      edi,edi
       jge       short M01_L01
;                 capacity = 0;
;                 ^^^^^^^^^^^^^
       xor       edi,edi
;             if (capacity < concurrencyLevel)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L01:
       cmp       edi,edx
       jge       short M01_L02
;                 capacity = concurrencyLevel;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       edi,edx
;             var locks = new object[concurrencyLevel];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L02:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
;             for (var i = 0; i < locks.Length; i++)
;                  ^^^^^^^^^
       xor       r14d,r14d
       mov       r15d,[rbp+8]
       test      r15d,r15d
       jle       short M01_L04
;                 locks[i] = new object();
;                 ^^^^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       rcx,rbp
       mov       edx,r14d
       call      CORINFO_HELP_ARRADDR_ST
       inc       r14d
       cmp       r15d,r14d
       jg        short M01_L03
;             var countPerLock = new int[locks.Length];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L04:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
;             var buckets = new Node[capacity];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       r12,[rsi]
       mov       rcx,r12
       mov       rdx,[rcx+30]
       mov       r13,[rdx]
       mov       rax,[r13+8]
       test      rax,rax
       jne       short M01_L05
       mov       rdx,7FFF60CD2560
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L05:
       movsxd    rdx,edi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
;             this._tables = new Tables(buckets, locks, countPerLock);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,r12
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M01_L06
       mov       rdx,7FFF60CD2830
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+28]
       lea       rcx,[rax+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
;             this._growLockArray = growLockArray;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rcx,[rsi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+1C],bl
;             this._budget = buckets.Length / locks.Length;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       eax,[rdi+8]
       cdq
       idiv      r15d
       mov       [rsi+18],eax
       mov       rdi,[rsp+0A0]
       mov       rdx,rdi
;             this._comparer = comparer ?? EqualityComparer<T>.Default;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      rdx,rdx
       jne       short M01_L08
       mov       rcx,r12
       mov       rax,[r13+18]
       test      rax,rax
       jne       short M01_L07
       mov       rdx,7FFF60CD29A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L07:
       mov       rcx,rax
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
M01_L08:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
; Total bytes of code 385
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
;             base.personProperCollection.ForEach(p => fakePeople.Add(p));
;                                                      ^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rdx
       mov       rdi,[rcx+8]
       mov       rcx,[rdi+8]
       mov       rdx,rsi
       mov       r11,7FFF60830600
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C40600]
       mov       r8d,eax
       mov       rdx,rsi
       mov       rcx,rdi
       mov       r9d,1
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 66
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner.Creating02()
;             var fakePeople = new ConcurrentHashSet<PersonProper>();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.personProperCollection.ForEach(p => fakePeople.Add(p));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(fakePeople);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+0FF78]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp+0FF98],rcx
       mov       rcx,rbp
       mov       [rbp+0FFA8],rcx
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbp+0FFC0],rbx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFB8],rax
       xor       r11d,r11d
       mov       rax,offset MD_System.Environment.GetProcessorCount()
       mov       [rbp+0FF88],rax
       lea       rax,[M00_L00]
       mov       [rbp+0FFA0],rax
       lea       rax,[rbp+0FF78]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       call      qword ptr [7FFF60C06880]
M00_L00:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF60C07BD8],0
       je        short M00_L01
       call      qword ptr [7FFF60C0B278]
M00_L01:
       mov       rdx,[rbp+0FF80]
       mov       [rdi+10],rdx
       mov       edx,eax
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rbp+0FFB8]
       mov       r8d,1F
       mov       r9d,1
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32, Int32, Boolean, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rbx,[rbp+0FFC0]
       lea       rcx,[rbx+8]
       mov       rdx,[rbp+0FFB8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       r14,[rbp+10]
       mov       r15,[r14+58]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rsi+18],rcx
       mov       rcx,r15
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rdx,[rbx+8]
       mov       eax,[rcx]
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       byte ptr [rdi+0C],1
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
; Total bytes of code 332
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32, Int32, Boolean, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
;             if (concurrencyLevel < 1)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^
       test      edx,edx
       jg        short M01_L00
;                 concurrencyLevel = 1;
;                 ^^^^^^^^^^^^^^^^^^^^^
       mov       edx,1
;             if (capacity < 0)
;             ^^^^^^^^^^^^^^^^^
M01_L00:
       test      edi,edi
       jge       short M01_L01
;                 capacity = 0;
;                 ^^^^^^^^^^^^^
       xor       edi,edi
;             if (capacity < concurrencyLevel)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L01:
       cmp       edi,edx
       jge       short M01_L02
;                 capacity = concurrencyLevel;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       edi,edx
;             var locks = new object[concurrencyLevel];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L02:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
;             for (var i = 0; i < locks.Length; i++)
;                  ^^^^^^^^^
       xor       r14d,r14d
       mov       r15d,[rbp+8]
       test      r15d,r15d
       jle       short M01_L04
;                 locks[i] = new object();
;                 ^^^^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       rcx,rbp
       mov       edx,r14d
       call      CORINFO_HELP_ARRADDR_ST
       inc       r14d
       cmp       r15d,r14d
       jg        short M01_L03
;             var countPerLock = new int[locks.Length];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L04:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
;             var buckets = new Node[capacity];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       r12,[rsi]
       mov       rcx,r12
       mov       rdx,[rcx+30]
       mov       r13,[rdx]
       mov       rax,[r13+8]
       test      rax,rax
       jne       short M01_L05
       mov       rdx,7FFF60C926B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L05:
       movsxd    rdx,edi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
;             this._tables = new Tables(buckets, locks, countPerLock);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,r12
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M01_L06
       mov       rdx,7FFF60C92980
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+28]
       lea       rcx,[rax+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
;             this._growLockArray = growLockArray;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rcx,[rsi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+1C],bl
;             this._budget = buckets.Length / locks.Length;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       eax,[rdi+8]
       cdq
       idiv      r15d
       mov       [rsi+18],eax
       mov       rdi,[rsp+0A0]
       mov       rdx,rdi
;             this._comparer = comparer ?? EqualityComparer<T>.Default;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      rdx,rdx
       jne       short M01_L08
       mov       rcx,r12
       mov       rax,[r13+18]
       test      rax,rax
       jne       short M01_L07
       mov       rdx,7FFF60C92AF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L07:
       mov       rcx,rax
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
M01_L08:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
; Total bytes of code 385
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
;             base.personProperCollection.ForEach(p => fakePeople.Add(p));
;                                                      ^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rdx
       mov       rdi,[rcx+8]
       mov       rcx,[rdi+8]
       mov       rdx,rsi
       mov       r11,7FFF607F0600
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C00600]
       mov       r8d,eax
       mov       rdx,rsi
       mov       rcx,rdi
       mov       r9d,1
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 66
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner.Creating02()
;             var fakePeople = new ConcurrentHashSet<PersonProper>();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.personProperCollection.ForEach(p => fakePeople.Add(p));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(fakePeople);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+0FF78]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp+0FF98],rcx
       mov       rcx,rbp
       mov       [rbp+0FFA8],rcx
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbp+0FFC0],rbx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFB8],rax
       xor       r11d,r11d
       mov       rax,offset MD_System.Environment.GetProcessorCount()
       mov       [rbp+0FF88],rax
       lea       rax,[M00_L00]
       mov       [rbp+0FFA0],rax
       lea       rax,[rbp+0FF78]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       call      qword ptr [7FFF60C26880]
M00_L00:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF60C27BD8],0
       je        short M00_L01
       call      qword ptr [7FFF60C2B278]
M00_L01:
       mov       rdx,[rbp+0FF80]
       mov       [rdi+10],rdx
       mov       edx,eax
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rbp+0FFB8]
       mov       r8d,1F
       mov       r9d,1
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32, Int32, Boolean, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rbx,[rbp+0FFC0]
       lea       rcx,[rbx+8]
       mov       rdx,[rbp+0FFB8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       r14,[rbp+10]
       mov       r15,[r14+58]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rsi+18],rcx
       mov       rcx,r15
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rdx,[rbx+8]
       mov       eax,[rcx]
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       byte ptr [rdi+0C],1
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
; Total bytes of code 332
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32, Int32, Boolean, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
;             if (concurrencyLevel < 1)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^
       test      edx,edx
       jg        short M01_L00
;                 concurrencyLevel = 1;
;                 ^^^^^^^^^^^^^^^^^^^^^
       mov       edx,1
;             if (capacity < 0)
;             ^^^^^^^^^^^^^^^^^
M01_L00:
       test      edi,edi
       jge       short M01_L01
;                 capacity = 0;
;                 ^^^^^^^^^^^^^
       xor       edi,edi
;             if (capacity < concurrencyLevel)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L01:
       cmp       edi,edx
       jge       short M01_L02
;                 capacity = concurrencyLevel;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       edi,edx
;             var locks = new object[concurrencyLevel];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L02:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
;             for (var i = 0; i < locks.Length; i++)
;                  ^^^^^^^^^
       xor       r14d,r14d
       mov       r15d,[rbp+8]
       test      r15d,r15d
       jle       short M01_L04
;                 locks[i] = new object();
;                 ^^^^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       rcx,rbp
       mov       edx,r14d
       call      CORINFO_HELP_ARRADDR_ST
       inc       r14d
       cmp       r15d,r14d
       jg        short M01_L03
;             var countPerLock = new int[locks.Length];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L04:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
;             var buckets = new Node[capacity];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       r12,[rsi]
       mov       rcx,r12
       mov       rdx,[rcx+30]
       mov       r13,[rdx]
       mov       rax,[r13+8]
       test      rax,rax
       jne       short M01_L05
       mov       rdx,7FFF60CB2878
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L05:
       movsxd    rdx,edi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
;             this._tables = new Tables(buckets, locks, countPerLock);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,r12
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M01_L06
       mov       rdx,7FFF60CB2B48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+28]
       lea       rcx,[rax+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
;             this._growLockArray = growLockArray;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rcx,[rsi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+1C],bl
;             this._budget = buckets.Length / locks.Length;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       eax,[rdi+8]
       cdq
       idiv      r15d
       mov       [rsi+18],eax
       mov       rdi,[rsp+0A0]
       mov       rdx,rdi
;             this._comparer = comparer ?? EqualityComparer<T>.Default;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      rdx,rdx
       jne       short M01_L08
       mov       rcx,r12
       mov       rax,[r13+18]
       test      rax,rax
       jne       short M01_L07
       mov       rdx,7FFF60CB2CB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L07:
       mov       rcx,rax
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
M01_L08:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
; Total bytes of code 385
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
;             base.personProperCollection.ForEach(p => fakePeople.Add(p));
;                                                      ^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rdx
       mov       rdi,[rcx+8]
       mov       rcx,[rdi+8]
       mov       rdx,rsi
       mov       r11,7FFF60810600
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C20600]
       mov       r8d,eax
       mov       rdx,rsi
       mov       rcx,rdi
       mov       r9d,1
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 66
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner.Creating02()
;             var fakePeople = new ConcurrentHashSet<PersonProper>();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.personProperCollection.ForEach(p => fakePeople.Add(p));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(fakePeople);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+0FF78]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp+0FF98],rcx
       mov       rcx,rbp
       mov       [rbp+0FFA8],rcx
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbp+0FFC0],rbx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFB8],rax
       xor       r11d,r11d
       mov       rax,offset MD_System.Environment.GetProcessorCount()
       mov       [rbp+0FF88],rax
       lea       rax,[M00_L00]
       mov       [rbp+0FFA0],rax
       lea       rax,[rbp+0FF78]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       call      qword ptr [7FFF60C46880]
M00_L00:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF60C47BD8],0
       je        short M00_L01
       call      qword ptr [7FFF60C4B278]
M00_L01:
       mov       rdx,[rbp+0FF80]
       mov       [rdi+10],rdx
       mov       edx,eax
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rbp+0FFB8]
       mov       r8d,1F
       mov       r9d,1
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32, Int32, Boolean, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rbx,[rbp+0FFC0]
       lea       rcx,[rbx+8]
       mov       rdx,[rbp+0FFB8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       r14,[rbp+10]
       mov       r15,[r14+58]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rsi+18],rcx
       mov       rcx,r15
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rdx,[rbx+8]
       mov       eax,[rcx]
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       byte ptr [rdi+0C],1
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
; Total bytes of code 332
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32, Int32, Boolean, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
;             if (concurrencyLevel < 1)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^
       test      edx,edx
       jg        short M01_L00
;                 concurrencyLevel = 1;
;                 ^^^^^^^^^^^^^^^^^^^^^
       mov       edx,1
;             if (capacity < 0)
;             ^^^^^^^^^^^^^^^^^
M01_L00:
       test      edi,edi
       jge       short M01_L01
;                 capacity = 0;
;                 ^^^^^^^^^^^^^
       xor       edi,edi
;             if (capacity < concurrencyLevel)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L01:
       cmp       edi,edx
       jge       short M01_L02
;                 capacity = concurrencyLevel;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       edi,edx
;             var locks = new object[concurrencyLevel];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L02:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
;             for (var i = 0; i < locks.Length; i++)
;                  ^^^^^^^^^
       xor       r14d,r14d
       mov       r15d,[rbp+8]
       test      r15d,r15d
       jle       short M01_L04
;                 locks[i] = new object();
;                 ^^^^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       rcx,rbp
       mov       edx,r14d
       call      CORINFO_HELP_ARRADDR_ST
       inc       r14d
       cmp       r15d,r14d
       jg        short M01_L03
;             var countPerLock = new int[locks.Length];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L04:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
;             var buckets = new Node[capacity];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       r12,[rsi]
       mov       rcx,r12
       mov       rdx,[rcx+30]
       mov       r13,[rdx]
       mov       rax,[r13+8]
       test      rax,rax
       jne       short M01_L05
       mov       rdx,7FFF60CD2348
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L05:
       movsxd    rdx,edi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
;             this._tables = new Tables(buckets, locks, countPerLock);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,r12
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M01_L06
       mov       rdx,7FFF60CD2618
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+28]
       lea       rcx,[rax+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
;             this._growLockArray = growLockArray;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rcx,[rsi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+1C],bl
;             this._budget = buckets.Length / locks.Length;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       eax,[rdi+8]
       cdq
       idiv      r15d
       mov       [rsi+18],eax
       mov       rdi,[rsp+0A0]
       mov       rdx,rdi
;             this._comparer = comparer ?? EqualityComparer<T>.Default;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      rdx,rdx
       jne       short M01_L08
       mov       rcx,r12
       mov       rax,[r13+18]
       test      rax,rax
       jne       short M01_L07
       mov       rdx,7FFF60CD2788
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L07:
       mov       rcx,rax
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
M01_L08:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
; Total bytes of code 385
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
;             base.personProperCollection.ForEach(p => fakePeople.Add(p));
;                                                      ^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rdx
       mov       rdi,[rcx+8]
       mov       rcx,[rdi+8]
       mov       rdx,rsi
       mov       r11,7FFF60830600
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C40600]
       mov       r8d,eax
       mov       rdx,rsi
       mov       rcx,rdi
       mov       r9d,1
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 66
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner.Creating02()
;             var fakePeople = new ConcurrentHashSet<PersonProper>();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.personProperCollection.ForEach(p => fakePeople.Add(p));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(fakePeople);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+0FF78]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp+0FF98],rcx
       mov       rcx,rbp
       mov       [rbp+0FFA8],rcx
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbp+0FFC0],rbx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFB8],rax
       xor       r11d,r11d
       mov       rax,offset MD_System.Environment.GetProcessorCount()
       mov       [rbp+0FF88],rax
       lea       rax,[M00_L00]
       mov       [rbp+0FFA0],rax
       lea       rax,[rbp+0FF78]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       call      qword ptr [7FFF60C36880]
M00_L00:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FFF60C37BD8],0
       je        short M00_L01
       call      qword ptr [7FFF60C3B278]
M00_L01:
       mov       rdx,[rbp+0FF80]
       mov       [rdi+10],rdx
       mov       edx,eax
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,[rbp+0FFB8]
       mov       r8d,1F
       mov       r9d,1
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32, Int32, Boolean, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rbx,[rbp+0FFC0]
       lea       rcx,[rbx+8]
       mov       rdx,[rbp+0FFB8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       r14,[rbp+10]
       mov       r15,[r14+58]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rsi+18],rcx
       mov       rcx,r15
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rdx,[rbx+8]
       mov       eax,[rcx]
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       byte ptr [rdi+0C],1
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
; Total bytes of code 332
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32, Int32, Boolean, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
;             if (concurrencyLevel < 1)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^
       test      edx,edx
       jg        short M01_L00
;                 concurrencyLevel = 1;
;                 ^^^^^^^^^^^^^^^^^^^^^
       mov       edx,1
;             if (capacity < 0)
;             ^^^^^^^^^^^^^^^^^
M01_L00:
       test      edi,edi
       jge       short M01_L01
;                 capacity = 0;
;                 ^^^^^^^^^^^^^
       xor       edi,edi
;             if (capacity < concurrencyLevel)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L01:
       cmp       edi,edx
       jge       short M01_L02
;                 capacity = concurrencyLevel;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       edi,edx
;             var locks = new object[concurrencyLevel];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L02:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
;             for (var i = 0; i < locks.Length; i++)
;                  ^^^^^^^^^
       xor       r14d,r14d
       mov       r15d,[rbp+8]
       test      r15d,r15d
       jle       short M01_L04
;                 locks[i] = new object();
;                 ^^^^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       rcx,rbp
       mov       edx,r14d
       call      CORINFO_HELP_ARRADDR_ST
       inc       r14d
       cmp       r15d,r14d
       jg        short M01_L03
;             var countPerLock = new int[locks.Length];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L04:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
;             var buckets = new Node[capacity];
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       r12,[rsi]
       mov       rcx,r12
       mov       rdx,[rcx+30]
       mov       r13,[rdx]
       mov       rax,[r13+8]
       test      rax,rax
       jne       short M01_L05
       mov       rdx,7FFF60CC2878
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L05:
       movsxd    rdx,edi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
;             this._tables = new Tables(buckets, locks, countPerLock);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,r12
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M01_L06
       mov       rdx,7FFF60CC2B48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+28]
       lea       rcx,[rax+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[rsp+28]
       lea       rcx,[rbp+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
;             this._growLockArray = growLockArray;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rcx,[rsi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+1C],bl
;             this._budget = buckets.Length / locks.Length;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       eax,[rdi+8]
       cdq
       idiv      r15d
       mov       [rsi+18],eax
       mov       rdi,[rsp+0A0]
       mov       rdx,rdi
;             this._comparer = comparer ?? EqualityComparer<T>.Default;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      rdx,rdx
       jne       short M01_L08
       mov       rcx,r12
       mov       rax,[r13+18]
       test      rax,rax
       jne       short M01_L07
       mov       rdx,7FFF60CC2CB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L07:
       mov       rcx,rax
       call      System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
M01_L08:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
; Total bytes of code 385
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
;             base.personProperCollection.ForEach(p => fakePeople.Add(p));
;                                                      ^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rdx
       mov       rdi,[rcx+8]
       mov       rcx,[rdi+8]
       mov       rdx,rsi
       mov       r11,7FFF60820600
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C30600]
       mov       r8d,eax
       mov       rdx,rsi
       mov       rcx,rdi
       mov       r9d,1
       call      dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 66
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner.LoopingForEach01()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
;             foreach (var person in this._peopleConcurrentHashSet)
;                                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdi,[rsi+88]
       mov       ecx,[rdi]
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1+<GetEnumerator>d__29[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       xor       edx,edx
       mov       [rbx+28],edx
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFE0],rbx
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFF60BFEA38]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFF607F05A0
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C005A0]
       mov       rcx,[rsi+8]
       mov       rdx,[rax+38]
       mov       eax,[rcx]
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFF60BFEA38]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFF60BFEA30]
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
       call      qword ptr [7FFF60BFEA30]
M00_L02:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 205
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1+<GetEnumerator>d__29[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       eax,[rsi+28]
       mov       rdx,[rsi+10]
       test      eax,eax
       je        short M01_L00
;             var buckets = this._tables._buckets;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       eax,1
       je        near ptr M01_L04
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       dword ptr [rsi+28],0FFFFFFFF
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+8]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
;             for (var i = 0; i < buckets.Length; i++)
;                  ^^^^^^^^^
       xor       ecx,ecx
       mov       [rsi+2C],ecx
       mov       ecx,[rsi+2C]
       mov       rdx,[rsi+18]
       cmp       ecx,[rdx+8]
       jge       near ptr M01_L06
;                 var current = Volatile.Read(ref buckets[i]);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L01:
       mov       rdi,[rsi+18]
       mov       ebx,[rsi+2C]
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r8,[rdx+8]
       test      r8,r8
       jne       short M01_L02
       mov       rdx,7FFF60CB3B78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r8,rax
M01_L02:
       mov       rcx,rdi
       mov       edx,ebx
       call      CORINFO_HELP_LDELEMA_REF
       mov       rdx,[rax]
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
;                 while (current != null)
;                 ^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rsi+20],0
       je        short M01_L05
;                     yield return current._item;
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       rdx,[rsi+20]
       mov       rdx,[rdx+8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+28],1
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       dword ptr [rsi+28],0FFFFFFFF
;                     current = current._next;
;                     ^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,[rsi+20]
       mov       rdx,[rdx+10]
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rsi+20],0
       jne       short M01_L03
;             }
;             ^
M01_L05:
       xor       eax,eax
       mov       [rsi+20],rax
       mov       eax,[rsi+2C]
       inc       eax
       mov       [rsi+2C],eax
       mov       eax,[rsi+2C]
       mov       rdx,[rsi+18]
       cmp       eax,[rdx+8]
       jl        near ptr M01_L01
;         }
;         ^
M01_L06:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 271
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1+<GetEnumerator>d__29[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
       ret
; Total bytes of code 1
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner.LoopingForEach01()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
;             foreach (var person in this._peopleConcurrentHashSet)
;                                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdi,[rsi+88]
       mov       ecx,[rdi]
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1+<GetEnumerator>d__29[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       xor       edx,edx
       mov       [rbx+28],edx
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFE0],rbx
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFF60C0EA38]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFF608005A0
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C105A0]
       mov       rcx,[rsi+8]
       mov       rdx,[rax+38]
       mov       eax,[rcx]
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFF60C0EA38]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFF60C0EA30]
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
       call      qword ptr [7FFF60C0EA30]
M00_L02:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 205
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1+<GetEnumerator>d__29[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       eax,[rsi+28]
       mov       rdx,[rsi+10]
       test      eax,eax
       je        short M01_L00
;             var buckets = this._tables._buckets;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       eax,1
       je        near ptr M01_L04
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       dword ptr [rsi+28],0FFFFFFFF
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+8]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
;             for (var i = 0; i < buckets.Length; i++)
;                  ^^^^^^^^^
       xor       ecx,ecx
       mov       [rsi+2C],ecx
       mov       ecx,[rsi+2C]
       mov       rdx,[rsi+18]
       cmp       ecx,[rdx+8]
       jge       near ptr M01_L06
;                 var current = Volatile.Read(ref buckets[i]);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L01:
       mov       rdi,[rsi+18]
       mov       ebx,[rsi+2C]
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r8,[rdx+8]
       test      r8,r8
       jne       short M01_L02
       mov       rdx,7FFF60CC3E98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r8,rax
M01_L02:
       mov       rcx,rdi
       mov       edx,ebx
       call      CORINFO_HELP_LDELEMA_REF
       mov       rdx,[rax]
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
;                 while (current != null)
;                 ^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rsi+20],0
       je        short M01_L05
;                     yield return current._item;
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       rdx,[rsi+20]
       mov       rdx,[rdx+8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+28],1
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       dword ptr [rsi+28],0FFFFFFFF
;                     current = current._next;
;                     ^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,[rsi+20]
       mov       rdx,[rdx+10]
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rsi+20],0
       jne       short M01_L03
;             }
;             ^
M01_L05:
       xor       eax,eax
       mov       [rsi+20],rax
       mov       eax,[rsi+2C]
       inc       eax
       mov       [rsi+2C],eax
       mov       eax,[rsi+2C]
       mov       rdx,[rsi+18]
       cmp       eax,[rdx+8]
       jl        near ptr M01_L01
;         }
;         ^
M01_L06:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 271
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1+<GetEnumerator>d__29[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
       ret
; Total bytes of code 1
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner.LoopingForEach01()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
;             foreach (var person in this._peopleConcurrentHashSet)
;                                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdi,[rsi+88]
       mov       ecx,[rdi]
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1+<GetEnumerator>d__29[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       xor       edx,edx
       mov       [rbx+28],edx
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFE0],rbx
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFF60C3E210]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFF608305A0
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C405A0]
       mov       rcx,[rsi+8]
       mov       rdx,[rax+38]
       mov       eax,[rcx]
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFF60C3E210]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFF60C3E208]
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
       call      qword ptr [7FFF60C3E208]
M00_L02:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 205
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1+<GetEnumerator>d__29[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       eax,[rsi+28]
       mov       rdx,[rsi+10]
       test      eax,eax
       je        short M01_L00
;             var buckets = this._tables._buckets;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       eax,1
       je        near ptr M01_L04
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       dword ptr [rsi+28],0FFFFFFFF
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+8]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
;             for (var i = 0; i < buckets.Length; i++)
;                  ^^^^^^^^^
       xor       ecx,ecx
       mov       [rsi+2C],ecx
       mov       ecx,[rsi+2C]
       mov       rdx,[rsi+18]
       cmp       ecx,[rdx+8]
       jge       near ptr M01_L06
;                 var current = Volatile.Read(ref buckets[i]);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L01:
       mov       rdi,[rsi+18]
       mov       ebx,[rsi+2C]
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r8,[rdx+8]
       test      r8,r8
       jne       short M01_L02
       mov       rdx,7FFF60CF3C80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r8,rax
M01_L02:
       mov       rcx,rdi
       mov       edx,ebx
       call      CORINFO_HELP_LDELEMA_REF
       mov       rdx,[rax]
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
;                 while (current != null)
;                 ^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rsi+20],0
       je        short M01_L05
;                     yield return current._item;
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       rdx,[rsi+20]
       mov       rdx,[rdx+8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+28],1
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       dword ptr [rsi+28],0FFFFFFFF
;                     current = current._next;
;                     ^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,[rsi+20]
       mov       rdx,[rdx+10]
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rsi+20],0
       jne       short M01_L03
;             }
;             ^
M01_L05:
       xor       eax,eax
       mov       [rsi+20],rax
       mov       eax,[rsi+2C]
       inc       eax
       mov       [rsi+2C],eax
       mov       eax,[rsi+2C]
       mov       rdx,[rsi+18]
       cmp       eax,[rdx+8]
       jl        near ptr M01_L01
;         }
;         ^
M01_L06:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 271
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1+<GetEnumerator>d__29[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
       ret
; Total bytes of code 1
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner.LoopingForEach01()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
;             foreach (var person in this._peopleConcurrentHashSet)
;                                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdi,[rsi+88]
       mov       ecx,[rdi]
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1+<GetEnumerator>d__29[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       xor       edx,edx
       mov       [rbx+28],edx
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFE0],rbx
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFF60C2EA38]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFF608205A0
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C305A0]
       mov       rcx,[rsi+8]
       mov       rdx,[rax+38]
       mov       eax,[rcx]
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFF60C2EA38]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFF60C2EA30]
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
       call      qword ptr [7FFF60C2EA30]
M00_L02:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 205
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1+<GetEnumerator>d__29[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       eax,[rsi+28]
       mov       rdx,[rsi+10]
       test      eax,eax
       je        short M01_L00
;             var buckets = this._tables._buckets;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       eax,1
       je        near ptr M01_L04
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       dword ptr [rsi+28],0FFFFFFFF
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+8]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
;             for (var i = 0; i < buckets.Length; i++)
;                  ^^^^^^^^^
       xor       ecx,ecx
       mov       [rsi+2C],ecx
       mov       ecx,[rsi+2C]
       mov       rdx,[rsi+18]
       cmp       ecx,[rdx+8]
       jge       near ptr M01_L06
;                 var current = Volatile.Read(ref buckets[i]);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L01:
       mov       rdi,[rsi+18]
       mov       ebx,[rsi+2C]
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r8,[rdx+8]
       test      r8,r8
       jne       short M01_L02
       mov       rdx,7FFF60CE3FF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r8,rax
M01_L02:
       mov       rcx,rdi
       mov       edx,ebx
       call      CORINFO_HELP_LDELEMA_REF
       mov       rdx,[rax]
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
;                 while (current != null)
;                 ^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rsi+20],0
       je        short M01_L05
;                     yield return current._item;
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       rdx,[rsi+20]
       mov       rdx,[rdx+8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+28],1
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       dword ptr [rsi+28],0FFFFFFFF
;                     current = current._next;
;                     ^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,[rsi+20]
       mov       rdx,[rdx+10]
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rsi+20],0
       jne       short M01_L03
;             }
;             ^
M01_L05:
       xor       eax,eax
       mov       [rsi+20],rax
       mov       eax,[rsi+2C]
       inc       eax
       mov       [rsi+2C],eax
       mov       eax,[rsi+2C]
       mov       rdx,[rsi+18]
       cmp       eax,[rdx+8]
       jl        near ptr M01_L01
;         }
;         ^
M01_L06:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 271
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1+<GetEnumerator>d__29[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
       ret
; Total bytes of code 1
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner.LoopingForEach01()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
;             foreach (var person in this._peopleConcurrentHashSet)
;                                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdi,[rsi+88]
       mov       ecx,[rdi]
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1+<GetEnumerator>d__29[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       xor       edx,edx
       mov       [rbx+28],edx
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFE0],rbx
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFF60BFEA38]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFF607F05A0
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C005A0]
       mov       rcx,[rsi+8]
       mov       rdx,[rax+38]
       mov       eax,[rcx]
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFF60BFEA38]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFF60BFEA30]
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
       call      qword ptr [7FFF60BFEA30]
M00_L02:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 205
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1+<GetEnumerator>d__29[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       eax,[rsi+28]
       mov       rdx,[rsi+10]
       test      eax,eax
       je        short M01_L00
;             var buckets = this._tables._buckets;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       eax,1
       je        near ptr M01_L04
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       dword ptr [rsi+28],0FFFFFFFF
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+8]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
;             for (var i = 0; i < buckets.Length; i++)
;                  ^^^^^^^^^
       xor       ecx,ecx
       mov       [rsi+2C],ecx
       mov       ecx,[rsi+2C]
       mov       rdx,[rsi+18]
       cmp       ecx,[rdx+8]
       jge       near ptr M01_L06
;                 var current = Volatile.Read(ref buckets[i]);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L01:
       mov       rdi,[rsi+18]
       mov       ebx,[rsi+2C]
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r8,[rdx+8]
       test      r8,r8
       jne       short M01_L02
       mov       rdx,7FFF60CB3FF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r8,rax
M01_L02:
       mov       rcx,rdi
       mov       edx,ebx
       call      CORINFO_HELP_LDELEMA_REF
       mov       rdx,[rax]
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
;                 while (current != null)
;                 ^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rsi+20],0
       je        short M01_L05
;                     yield return current._item;
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       rdx,[rsi+20]
       mov       rdx,[rdx+8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+28],1
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       dword ptr [rsi+28],0FFFFFFFF
;                     current = current._next;
;                     ^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,[rsi+20]
       mov       rdx,[rdx+10]
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rsi+20],0
       jne       short M01_L03
;             }
;             ^
M01_L05:
       xor       eax,eax
       mov       [rsi+20],rax
       mov       eax,[rsi+2C]
       inc       eax
       mov       [rsi+2C],eax
       mov       eax,[rsi+2C]
       mov       rdx,[rsi+18]
       cmp       eax,[rdx+8]
       jl        near ptr M01_L01
;         }
;         ^
M01_L06:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 271
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1+<GetEnumerator>d__29[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
       ret
; Total bytes of code 1
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner.LoopingForEach01()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
;             foreach (var person in this._peopleConcurrentHashSet)
;                                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdi,[rsi+88]
       mov       ecx,[rdi]
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1+<GetEnumerator>d__29[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       xor       edx,edx
       mov       [rbx+28],edx
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFE0],rbx
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFF60C1EE48]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFF608105A0
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C205A0]
       mov       rcx,[rsi+8]
       mov       rdx,[rax+38]
       mov       eax,[rcx]
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFF60C1EE48]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFF60C1EE40]
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
       call      qword ptr [7FFF60C1EE40]
M00_L02:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 205
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1+<GetEnumerator>d__29[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       eax,[rsi+28]
       mov       rdx,[rsi+10]
       test      eax,eax
       je        short M01_L00
;             var buckets = this._tables._buckets;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       eax,1
       je        near ptr M01_L04
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       dword ptr [rsi+28],0FFFFFFFF
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+8]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
;             for (var i = 0; i < buckets.Length; i++)
;                  ^^^^^^^^^
       xor       ecx,ecx
       mov       [rsi+2C],ecx
       mov       ecx,[rsi+2C]
       mov       rdx,[rsi+18]
       cmp       ecx,[rdx+8]
       jge       near ptr M01_L06
;                 var current = Volatile.Read(ref buckets[i]);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L01:
       mov       rdi,[rsi+18]
       mov       ebx,[rsi+2C]
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r8,[rdx+8]
       test      r8,r8
       jne       short M01_L02
       mov       rdx,7FFF60CD4208
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r8,rax
M01_L02:
       mov       rcx,rdi
       mov       edx,ebx
       call      CORINFO_HELP_LDELEMA_REF
       mov       rdx,[rax]
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
;                 while (current != null)
;                 ^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rsi+20],0
       je        short M01_L05
;                     yield return current._item;
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       rdx,[rsi+20]
       mov       rdx,[rdx+8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+28],1
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       dword ptr [rsi+28],0FFFFFFFF
;                     current = current._next;
;                     ^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,[rsi+20]
       mov       rdx,[rdx+10]
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rsi+20],0
       jne       short M01_L03
;             }
;             ^
M01_L05:
       xor       eax,eax
       mov       [rsi+20],rax
       mov       eax,[rsi+2C]
       inc       eax
       mov       [rsi+2C],eax
       mov       eax,[rsi+2C]
       mov       rdx,[rsi+18]
       cmp       eax,[rdx+8]
       jl        near ptr M01_L01
;         }
;         ^
M01_L06:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 271
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1+<GetEnumerator>d__29[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
       ret
; Total bytes of code 1
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner.LoopingForEach01()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
;             foreach (var person in this._peopleConcurrentHashSet)
;                                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdi,[rsi+88]
       mov       ecx,[rdi]
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1+<GetEnumerator>d__29[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       xor       edx,edx
       mov       [rbx+28],edx
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFE0],rbx
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFF60C0EA38]
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFF608005A0
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C105A0]
       mov       rcx,[rsi+8]
       mov       rdx,[rax+38]
       mov       eax,[rcx]
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFF60C0EA38]
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFF60C0EA30]
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
       call      qword ptr [7FFF60C0EA30]
M00_L02:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 205
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1+<GetEnumerator>d__29[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       eax,[rsi+28]
       mov       rdx,[rsi+10]
       test      eax,eax
       je        short M01_L00
;             var buckets = this._tables._buckets;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       eax,1
       je        near ptr M01_L04
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       dword ptr [rsi+28],0FFFFFFFF
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+8]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
;             for (var i = 0; i < buckets.Length; i++)
;                  ^^^^^^^^^
       xor       ecx,ecx
       mov       [rsi+2C],ecx
       mov       ecx,[rsi+2C]
       mov       rdx,[rsi+18]
       cmp       ecx,[rdx+8]
       jge       near ptr M01_L06
;                 var current = Volatile.Read(ref buckets[i]);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L01:
       mov       rdi,[rsi+18]
       mov       ebx,[rsi+2C]
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r8,[rdx+8]
       test      r8,r8
       jne       short M01_L02
       mov       rdx,7FFF60CC3E98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r8,rax
M01_L02:
       mov       rcx,rdi
       mov       edx,ebx
       call      CORINFO_HELP_LDELEMA_REF
       mov       rdx,[rax]
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
;                 while (current != null)
;                 ^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rsi+20],0
       je        short M01_L05
;                     yield return current._item;
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       rdx,[rsi+20]
       mov       rdx,[rdx+8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+28],1
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       dword ptr [rsi+28],0FFFFFFFF
;                     current = current._next;
;                     ^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,[rsi+20]
       mov       rdx,[rdx+10]
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rsi+20],0
       jne       short M01_L03
;             }
;             ^
M01_L05:
       xor       eax,eax
       mov       [rsi+20],rax
       mov       eax,[rsi+2C]
       inc       eax
       mov       [rsi+2C],eax
       mov       eax,[rsi+2C]
       mov       rdx,[rsi+18]
       cmp       eax,[rdx+8]
       jl        near ptr M01_L01
;         }
;         ^
M01_L06:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 271
```
```assembly
; dotNetTips.Utility.Standard.Collections.Generic.Concurrent.ConcurrentHashSet`1+<GetEnumerator>d__29[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
       ret
; Total bytes of code 1
```

