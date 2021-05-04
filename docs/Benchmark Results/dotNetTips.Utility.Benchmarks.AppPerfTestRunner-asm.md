## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.AppPerfTestRunner.GetEnvironmentVariables()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      dotNetTips.Utility.Standard.App.GetEnvironmentVariables()
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 38
```
```assembly
; dotNetTips.Utility.Standard.App.GetEnvironmentVariables()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       vzeroupper
       lea       rbp,[rsp+90]
       lea       rdi,[rbp+0FFB8]
       mov       ecx,0C
       xor       eax,eax
       rep stosd
       mov       [rbp+0FFA0],rsp
       call      System.Environment.GetEnvironmentVariables()
       mov       rsi,rax
       mov       rcx,7FF88AA00448
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,234E23DBBD8
       mov       rdi,[rcx]
       mov       ecx,[rdi]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableDictionary`2+Builder[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Immutable.ImmutableDictionary`2+Builder[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.ImmutableDictionary`2<System.__Canon,System.__Canon>)
       mov       rcx,rsi
       mov       r11,7FF88A590428
       cmp       [rcx],ecx
       call      qword ptr [7FF88A980428]
       mov       [rbp+0FFB0],rax
       mov       rcx,[rbp+0FFB0]
       mov       r11,7FF88A590430
       cmp       [rcx],ecx
       call      qword ptr [7FF88A980430]
       test      eax,eax
       je        near ptr M01_L02
M01_L00:
       mov       rcx,[rbp+0FFB0]
       mov       r11,7FF88A590438
       cmp       [rcx],ecx
       call      qword ptr [7FF88A980438]
       mov       rsi,rax
       mov       rdx,offset MT_System.Collections.DictionaryEntry
       cmp       [rsi],rdx
       je        short M01_L01
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.DictionaryEntry
       call      CORINFO_HELP_UNBOX
M01_L01:
       add       rsi,8
       mov       rcx,[rsi]
       mov       rsi,[rsi+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r9,rax
       lea       rcx,[rbp+0FFD8]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rbx+8]
       mov       r8,[rbx+10]
       lea       rdx,[rbp+0FFD8]
       mov       dword ptr [rsp+20],2
       lea       rax,[rbp+0FFC8]
       mov       [rax],rcx
       mov       [rax+8],r8
       mov       rcx,rdx
       lea       r8,[rbp+0FFC8]
       mov       [rsp+28],r8
       mov       r8,rdi
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableDictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      System.Collections.Immutable.ImmutableDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon, KeyCollisionBehavior<System.__Canon,System.__Canon>, MutationInput<System.__Canon,System.__Canon>)
       lea       rcx,[rbp+0FFB8]
       mov       rdx,[rbp+0FFD8]
       mov       [rcx],rdx
       mov       edx,[rbp+0FFE0]
       mov       [rcx+8],edx
       mov       rcx,rbx
       lea       rdx,[rbp+0FFB8]
       call      System.Collections.Immutable.ImmutableDictionary`2+Builder[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Apply(MutationResult<System.__Canon,System.__Canon>)
       mov       rcx,[rbp+0FFB0]
       mov       r11,7FF88A590430
       cmp       [rcx],ecx
       call      qword ptr [7FF88A980430]
       test      eax,eax
       jne       near ptr M01_L00
M01_L02:
       mov       rdx,[rbp+0FFB0]
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L03
       mov       rcx,rax
       mov       r11,7FF88A590440
       cmp       [rcx],ecx
       call      qword ptr [7FF88A980440]
M01_L03:
       cmp       qword ptr [rbx+18],0
       jne       short M01_L04
       mov       r9d,[rbx+28]
       mov       rdx,[rbx+8]
       mov       r8,[rbx+10]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableDictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      System.Collections.Immutable.ImmutableDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Wrap(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Comparers<System.__Canon,System.__Canon>, Int32)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L04:
       mov       rax,[rbx+18]
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
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+90]
       mov       rdx,[rbp+0FFB0]
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L05
       mov       rcx,rax
       mov       r11,7FF88A590440
       cmp       [rcx],ecx
       call      qword ptr [7FF88A980440]
M01_L05:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 576
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.AppPerfTestRunner.IsProcessRunning()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,288829F1788
       mov       rcx,[rcx]
       call      dotNetTips.Utility.Standard.App.IsProcessRunning(System.String)
       mov       rdx,[rsi+8]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; dotNetTips.Utility.Standard.App.IsProcessRunning(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      rsi,rsi
       je        short M01_L00
       cmp       dword ptr [rsi+8],0
       jbe       short M01_L00
       xor       edx,edx
       jmp       short M01_L01
M01_L00:
       mov       edx,1
M01_L01:
       test      edx,edx
       sete      dl
       movzx     edx,dl
       mov       r9,288629F3060
       mov       r9,[r9]
       mov       r8,288829F1790
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,rsi
       call      System.Diagnostics.Process.GetProcessesByName(System.String)
       test      rax,rax
       jne       short M01_L02
       xor       eax,eax
       jmp       short M01_L03
M01_L02:
       mov       rcx,rax
       call      00007FF8EA1CDBD0
       test      eax,eax
       setg      al
       movzx     eax,al
M01_L03:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 116
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.AppPerfTestRunner.IsRunning()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      dotNetTips.Utility.Standard.App.IsRunning()
       mov       rdx,[rsi+8]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 26
```
```assembly
; dotNetTips.Utility.Standard.App.IsRunning()
       push      rsi
       sub       rsp,20
       call      System.Diagnostics.Process.GetCurrentProcess()
       mov       rsi,rax
       mov       ecx,[rsi]
       mov       rcx,rsi
       mov       edx,8
       call      System.Diagnostics.Process.EnsureState(State)
       mov       rcx,[rsi+28]
       mov       rcx,[rcx+10]
       call      System.Diagnostics.Process.GetProcessesByName(System.String)
       test      rax,rax
       jne       short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       mov       rcx,rax
       call      00007FF8EA1CDBD0
       test      eax,eax
       setg      al
       movzx     eax,al
M01_L01:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 72
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.AppPerfTestRunner.IsRunningFromAspNet()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      dotNetTips.Utility.Standard.App.IsRunningFromAspNet()
       mov       rdx,[rsi+8]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 26
```
```assembly
; dotNetTips.Utility.Standard.App.IsRunningFromAspNet()
       mov       rax,1641E9611F8
       mov       rax,[rax]
       mov       eax,[rax]
       xor       eax,eax
       ret
; Total bytes of code 18
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.AppPerfTestRunner.ReferencedAssemblies()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      dotNetTips.Utility.Standard.App.ReferencedAssemblies()
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 38
```
```assembly
; dotNetTips.Utility.Standard.App.ReferencedAssemblies()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1587F0F4870
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       call      System.Reflection.Assembly.GetEntryAssembly()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       cmp       dword ptr [rax+8],0
       jle       near ptr M01_L05
M01_L00:
       call      System.Reflection.Assembly.GetEntryAssembly()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       cmp       edi,[rax+8]
       jae       near ptr M01_L06
       movsxd    rcx,edi
       mov       rbx,[rax+rcx*8+10]
       mov       ecx,[rbx]
       mov       rcx,rbx
       call      System.Reflection.AssemblyName.get_FullName()
       mov       rdx,rax
       test      rdx,rdx
       jne       short M01_L01
       mov       rcx,rbx
       call      00007FF8EA182020
       mov       rcx,rax
       mov       edx,1
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       r8,rax
       jmp       short M01_L02
M01_L01:
       mov       r8,rdx
M01_L02:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       cmp       [rcx+8],edx
       jbe       short M01_L03
       lea       eax,[rdx+1]
       mov       [rsi+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L04:
       inc       edi
       call      System.Reflection.Assembly.GetEntryAssembly()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       cmp       [rax+8],edi
       jg        near ptr M01_L00
M01_L05:
       mov       rcx,7FF88AA30448
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1587F0F48D8
       mov       rcx,[rcx]
       mov       rdx,rsi
       mov       rax,offset System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 285
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.AppPerfTestRunner.StackTrace()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      System.Environment.get_StackTrace()
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 38
```
```assembly
; System.Environment.get_StackTrace()
       push      rsi
       sub       rsp,20
       mov       rcx,offset MT_System.Diagnostics.StackTrace
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       mov       r8d,1
       xor       r9d,r9d
       call      System.Diagnostics.StackTrace.CaptureStackTrace(Int32, Boolean, System.Exception)
       mov       rcx,rsi
       xor       edx,edx
       call      System.Diagnostics.StackTrace.ToString(TraceFormat)
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 59
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.AppPerfTestRunner.WorkingSet()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      System.Environment.get_WorkingSet()
       mov       rdx,[rsi+8]
       mov       ecx,[rdx]
       add       rdx,20
       mov       [rdx],rax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 32
```
```assembly
; System.Environment.get_WorkingSet()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       vzeroupper
       lea       rbp,[rsp+0F0]
       lea       rcx,[rbp+0FF40]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       r11,rsp
       mov       [rbp+0FF60],r11
       mov       r11,rbp
       mov       [rbp+0FF70],r11
       xor       r11d,r11d
       lea       rax,[rbp+0FF80]
       vxorps    xmm1,xmm1,xmm1
       vmovdqu   xmmword ptr [rax],xmm1
       vmovdqu   xmmword ptr [rax+10],xmm1
       vmovdqu   xmmword ptr [rax+20],xmm1
       vmovdqu   xmmword ptr [rax+30],xmm1
       mov       [rax+40],r11
       mov       dword ptr [rbp+0FF80],48
       mov       rax,offset MD_Interop+Kernel32.GetCurrentProcess()
       mov       [rbp+0FF50],rax
       lea       rax,[M01_L00]
       mov       [rbp+0FF68],rax
       lea       rax,[rbp+0FF40]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       call      qword ptr [7FF88A982810]
M01_L00:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FF88A987BA8],0
       je        short M01_L01
       call      qword ptr [7FF88A97B278]
M01_L01:
       mov       rcx,[rbp+0FF48]
       mov       [rsi+10],rcx
       mov       rcx,rax
       lea       rdx,[rbp+0FF80]
       mov       r8d,[rbp+0FF80]
       call      Interop+Kernel32.GetProcessMemoryInfo(IntPtr, PROCESS_MEMORY_COUNTERS ByRef, UInt32)
       test      eax,eax
       jne       short M01_L02
       xor       eax,eax
       jmp       short M01_L03
M01_L02:
       mov       rax,[rbp+0FF90]
M01_L03:
       mov       byte ptr [rsi+0C],1
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
; Total bytes of code 240
```

