## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Creating01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.FastSortedList`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+58]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L14
       mov       rcx,[rbp+10]
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rbx,[rdx]
       mov       rax,[rbx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AA5E940
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L06
       mov       rcx,rdi
       mov       r11,[rbx+28]
       test      r11,r11
       jne       short M01_L01
       mov       rdx,7FF88AA5E990
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L01:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L03
       mov       rcx,rdi
       mov       rax,[rbx+10]
       test      rax,rax
       jne       short M01_L02
       mov       rdx,7FF88AA5E950
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L02:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       mov       rcx,rdi
       mov       rax,[rbx+30]
       test      rax,rax
       jne       short M01_L04
       mov       rdx,7FF88AA5E9A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L04:
       movsxd    rdx,esi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rcx,rdi
       mov       r11,[rbx+38]
       test      r11,r11
       jne       short M01_L05
       mov       rdx,7FF88AA5E9B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L05:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       mov       rcx,[rbp+10]
       xor       edx,edx
       mov       [rcx+10],edx
       mov       rcx,rdi
       mov       rax,[rbx+10]
       test      rax,rax
       jne       short M01_L07
       mov       rdx,7FF88AA5E950
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L07:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+18]
       test      r11,r11
       jne       short M01_L08
       mov       rdx,7FF88AA5E960
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L08:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5B0590
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9C0590]
       test      eax,eax
       je        near ptr M01_L13
M01_L09:
       mov       rcx,rdi
       mov       r11,[rbx+20]
       test      r11,r11
       jne       short M01_L10
       mov       rdx,7FF88AA5E978
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,[rbp+0FFC8]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M01_L11
       lea       eax,[rdx+1]
       mov       r9,[rbp+10]
       mov       [r9+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L12
M01_L11:
       mov       rcx,[rbp+10]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L12:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5B0590
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9C0590]
       test      eax,eax
       jne       short M01_L09
M01_L13:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5B0598
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9C0598]
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L15
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5B0598
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9C0598]
M01_L15:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 712
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Creating01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.FastSortedList`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+58]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L14
       mov       rcx,[rbp+10]
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rbx,[rdx]
       mov       rax,[rbx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AA3E940
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L06
       mov       rcx,rdi
       mov       r11,[rbx+28]
       test      r11,r11
       jne       short M01_L01
       mov       rdx,7FF88AA3E990
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L01:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L03
       mov       rcx,rdi
       mov       rax,[rbx+10]
       test      rax,rax
       jne       short M01_L02
       mov       rdx,7FF88AA3E950
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L02:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       mov       rcx,rdi
       mov       rax,[rbx+30]
       test      rax,rax
       jne       short M01_L04
       mov       rdx,7FF88AA3E9A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L04:
       movsxd    rdx,esi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rcx,rdi
       mov       r11,[rbx+38]
       test      r11,r11
       jne       short M01_L05
       mov       rdx,7FF88AA3E9B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L05:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       mov       rcx,[rbp+10]
       xor       edx,edx
       mov       [rcx+10],edx
       mov       rcx,rdi
       mov       rax,[rbx+10]
       test      rax,rax
       jne       short M01_L07
       mov       rdx,7FF88AA3E950
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L07:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+18]
       test      r11,r11
       jne       short M01_L08
       mov       rdx,7FF88AA3E960
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L08:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A590590
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9A0590]
       test      eax,eax
       je        near ptr M01_L13
M01_L09:
       mov       rcx,rdi
       mov       r11,[rbx+20]
       test      r11,r11
       jne       short M01_L10
       mov       rdx,7FF88AA3E978
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,[rbp+0FFC8]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M01_L11
       lea       eax,[rdx+1]
       mov       r9,[rbp+10]
       mov       [r9+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L12
M01_L11:
       mov       rcx,[rbp+10]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L12:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A590590
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9A0590]
       test      eax,eax
       jne       short M01_L09
M01_L13:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A590598
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9A0598]
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L15
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A590598
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9A0598]
M01_L15:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 712
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Creating01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.FastSortedList`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+58]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L14
       mov       rcx,[rbp+10]
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rbx,[rdx]
       mov       rax,[rbx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AA5E758
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L06
       mov       rcx,rdi
       mov       r11,[rbx+28]
       test      r11,r11
       jne       short M01_L01
       mov       rdx,7FF88AA5E7A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L01:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L03
       mov       rcx,rdi
       mov       rax,[rbx+10]
       test      rax,rax
       jne       short M01_L02
       mov       rdx,7FF88AA5E768
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L02:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       mov       rcx,rdi
       mov       rax,[rbx+30]
       test      rax,rax
       jne       short M01_L04
       mov       rdx,7FF88AA5E7C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L04:
       movsxd    rdx,esi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rcx,rdi
       mov       r11,[rbx+38]
       test      r11,r11
       jne       short M01_L05
       mov       rdx,7FF88AA5E7D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L05:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       mov       rcx,[rbp+10]
       xor       edx,edx
       mov       [rcx+10],edx
       mov       rcx,rdi
       mov       rax,[rbx+10]
       test      rax,rax
       jne       short M01_L07
       mov       rdx,7FF88AA5E768
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L07:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+18]
       test      r11,r11
       jne       short M01_L08
       mov       rdx,7FF88AA5E778
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L08:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5B0590
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9C0590]
       test      eax,eax
       je        near ptr M01_L13
M01_L09:
       mov       rcx,rdi
       mov       r11,[rbx+20]
       test      r11,r11
       jne       short M01_L10
       mov       rdx,7FF88AA5E790
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,[rbp+0FFC8]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M01_L11
       lea       eax,[rdx+1]
       mov       r9,[rbp+10]
       mov       [r9+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L12
M01_L11:
       mov       rcx,[rbp+10]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L12:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5B0590
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9C0590]
       test      eax,eax
       jne       short M01_L09
M01_L13:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5B0598
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9C0598]
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L15
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5B0598
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9C0598]
M01_L15:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 712
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Creating01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.FastSortedList`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+58]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L14
       mov       rcx,[rbp+10]
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rbx,[rdx]
       mov       rax,[rbx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AA4EAE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L06
       mov       rcx,rdi
       mov       r11,[rbx+28]
       test      r11,r11
       jne       short M01_L01
       mov       rdx,7FF88AA4EB38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L01:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L03
       mov       rcx,rdi
       mov       rax,[rbx+10]
       test      rax,rax
       jne       short M01_L02
       mov       rdx,7FF88AA4EAF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L02:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       mov       rcx,rdi
       mov       rax,[rbx+30]
       test      rax,rax
       jne       short M01_L04
       mov       rdx,7FF88AA4EB50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L04:
       movsxd    rdx,esi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rcx,rdi
       mov       r11,[rbx+38]
       test      r11,r11
       jne       short M01_L05
       mov       rdx,7FF88AA4EB60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L05:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       mov       rcx,[rbp+10]
       xor       edx,edx
       mov       [rcx+10],edx
       mov       rcx,rdi
       mov       rax,[rbx+10]
       test      rax,rax
       jne       short M01_L07
       mov       rdx,7FF88AA4EAF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L07:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+18]
       test      r11,r11
       jne       short M01_L08
       mov       rdx,7FF88AA4EB08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L08:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5A0590
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9B0590]
       test      eax,eax
       je        near ptr M01_L13
M01_L09:
       mov       rcx,rdi
       mov       r11,[rbx+20]
       test      r11,r11
       jne       short M01_L10
       mov       rdx,7FF88AA4EB20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,[rbp+0FFC8]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M01_L11
       lea       eax,[rdx+1]
       mov       r9,[rbp+10]
       mov       [r9+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L12
M01_L11:
       mov       rcx,[rbp+10]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L12:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5A0590
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9B0590]
       test      eax,eax
       jne       short M01_L09
M01_L13:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5A0598
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9B0598]
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L15
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5A0598
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9B0598]
M01_L15:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 712
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Creating01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.FastSortedList`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+58]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L14
       mov       rcx,[rbp+10]
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rbx,[rdx]
       mov       rax,[rbx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AA3EC58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L06
       mov       rcx,rdi
       mov       r11,[rbx+28]
       test      r11,r11
       jne       short M01_L01
       mov       rdx,7FF88AA3ECA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L01:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L03
       mov       rcx,rdi
       mov       rax,[rbx+10]
       test      rax,rax
       jne       short M01_L02
       mov       rdx,7FF88AA3EC68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L02:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       mov       rcx,rdi
       mov       rax,[rbx+30]
       test      rax,rax
       jne       short M01_L04
       mov       rdx,7FF88AA3ECC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L04:
       movsxd    rdx,esi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rcx,rdi
       mov       r11,[rbx+38]
       test      r11,r11
       jne       short M01_L05
       mov       rdx,7FF88AA3ECD0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L05:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       mov       rcx,[rbp+10]
       xor       edx,edx
       mov       [rcx+10],edx
       mov       rcx,rdi
       mov       rax,[rbx+10]
       test      rax,rax
       jne       short M01_L07
       mov       rdx,7FF88AA3EC68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L07:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+18]
       test      r11,r11
       jne       short M01_L08
       mov       rdx,7FF88AA3EC78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L08:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A590590
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9A0590]
       test      eax,eax
       je        near ptr M01_L13
M01_L09:
       mov       rcx,rdi
       mov       r11,[rbx+20]
       test      r11,r11
       jne       short M01_L10
       mov       rdx,7FF88AA3EC90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,[rbp+0FFC8]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M01_L11
       lea       eax,[rdx+1]
       mov       r9,[rbp+10]
       mov       [r9+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L12
M01_L11:
       mov       rcx,[rbp+10]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L12:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A590590
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9A0590]
       test      eax,eax
       jne       short M01_L09
M01_L13:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A590598
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9A0598]
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L15
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A590598
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9A0598]
M01_L15:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 712
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Creating01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.FastSortedList`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+58]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L14
       mov       rcx,[rbp+10]
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rbx,[rdx]
       mov       rax,[rbx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AA4EC58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L06
       mov       rcx,rdi
       mov       r11,[rbx+28]
       test      r11,r11
       jne       short M01_L01
       mov       rdx,7FF88AA4ECA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L01:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L03
       mov       rcx,rdi
       mov       rax,[rbx+10]
       test      rax,rax
       jne       short M01_L02
       mov       rdx,7FF88AA4EC68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L02:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       mov       rcx,rdi
       mov       rax,[rbx+30]
       test      rax,rax
       jne       short M01_L04
       mov       rdx,7FF88AA4ECC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L04:
       movsxd    rdx,esi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rcx,rdi
       mov       r11,[rbx+38]
       test      r11,r11
       jne       short M01_L05
       mov       rdx,7FF88AA4ECD0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L05:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       mov       rcx,[rbp+10]
       xor       edx,edx
       mov       [rcx+10],edx
       mov       rcx,rdi
       mov       rax,[rbx+10]
       test      rax,rax
       jne       short M01_L07
       mov       rdx,7FF88AA4EC68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L07:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+18]
       test      r11,r11
       jne       short M01_L08
       mov       rdx,7FF88AA4EC78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L08:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5A0590
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9B0590]
       test      eax,eax
       je        near ptr M01_L13
M01_L09:
       mov       rcx,rdi
       mov       r11,[rbx+20]
       test      r11,r11
       jne       short M01_L10
       mov       rdx,7FF88AA4EC90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,[rbp+0FFC8]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M01_L11
       lea       eax,[rdx+1]
       mov       r9,[rbp+10]
       mov       [r9+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L12
M01_L11:
       mov       rcx,[rbp+10]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L12:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5A0590
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9B0590]
       test      eax,eax
       jne       short M01_L09
M01_L13:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5A0598
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9B0598]
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L15
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5A0598
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9B0598]
M01_L15:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 712
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Creating01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.FastSortedList`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+58]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L14
       mov       rcx,[rbp+10]
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rbx,[rdx]
       mov       rax,[rbx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AA6E800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L06
       mov       rcx,rdi
       mov       r11,[rbx+28]
       test      r11,r11
       jne       short M01_L01
       mov       rdx,7FF88AA6E850
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L01:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L03
       mov       rcx,rdi
       mov       rax,[rbx+10]
       test      rax,rax
       jne       short M01_L02
       mov       rdx,7FF88AA6E810
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L02:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       mov       rcx,rdi
       mov       rax,[rbx+30]
       test      rax,rax
       jne       short M01_L04
       mov       rdx,7FF88AA6E868
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L04:
       movsxd    rdx,esi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rcx,rdi
       mov       r11,[rbx+38]
       test      r11,r11
       jne       short M01_L05
       mov       rdx,7FF88AA6E878
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L05:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       mov       rcx,[rbp+10]
       xor       edx,edx
       mov       [rcx+10],edx
       mov       rcx,rdi
       mov       rax,[rbx+10]
       test      rax,rax
       jne       short M01_L07
       mov       rdx,7FF88AA6E810
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L07:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+18]
       test      r11,r11
       jne       short M01_L08
       mov       rdx,7FF88AA6E820
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L08:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5C0590
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9D0590]
       test      eax,eax
       je        near ptr M01_L13
M01_L09:
       mov       rcx,rdi
       mov       r11,[rbx+20]
       test      r11,r11
       jne       short M01_L10
       mov       rdx,7FF88AA6E838
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,[rbp+0FFC8]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M01_L11
       lea       eax,[rdx+1]
       mov       r9,[rbp+10]
       mov       [r9+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L12
M01_L11:
       mov       rcx,[rbp+10]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L12:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5C0590
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9D0590]
       test      eax,eax
       jne       short M01_L09
M01_L13:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5C0598
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9D0598]
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L15
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5C0598
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9D0598]
M01_L15:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 712
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Creating02()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.FastSortedList`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1C1380A48E8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
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
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
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
; Total bytes of code 171
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       push      rsi
       sub       rsp,20
       mov       [rsp+38],rdx
       mov       rsi,[rcx+8]
       mov       ecx,[rsi]
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+10]
       cmp       [rcx+8],r8d
       jbe       short M01_L00
       lea       eax,[r8+1]
       mov       [rsi+10],eax
       mov       edx,r8d
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,[rsp+38]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L01:
       mov       byte ptr [rsi+18],0
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 78
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
       je        short M02_L03
       mov       ebx,[rsi+14]
       xor       ebp,ebp
       cmp       dword ptr [rsi+10],0
       jle       short M02_L01
M02_L00:
       cmp       ebx,[rsi+14]
       jne       short M02_L01
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       jae       short M02_L04
       movsxd    rdx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       inc       ebp
       cmp       ebp,[rsi+10]
       jl        short M02_L00
M02_L01:
       cmp       ebx,[rsi+14]
       je        short M02_L02
       mov       rax,offset System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M02_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,1C
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Creating02()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.FastSortedList`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,24F1FE68D50
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
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
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
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
; Total bytes of code 171
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       push      rsi
       sub       rsp,20
       mov       [rsp+38],rdx
       mov       rsi,[rcx+8]
       mov       ecx,[rsi]
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+10]
       cmp       [rcx+8],r8d
       jbe       short M01_L00
       lea       eax,[r8+1]
       mov       [rsi+10],eax
       mov       edx,r8d
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,[rsp+38]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L01:
       mov       byte ptr [rsi+18],0
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 78
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
       je        short M02_L03
       mov       ebx,[rsi+14]
       xor       ebp,ebp
       cmp       dword ptr [rsi+10],0
       jle       short M02_L01
M02_L00:
       cmp       ebx,[rsi+14]
       jne       short M02_L01
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       jae       short M02_L04
       movsxd    rdx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       inc       ebp
       cmp       ebp,[rsi+10]
       jl        short M02_L00
M02_L01:
       cmp       ebx,[rsi+14]
       je        short M02_L02
       mov       rax,offset System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M02_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,1C
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Creating02()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.FastSortedList`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,24E9D7248E8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
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
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
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
; Total bytes of code 171
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       push      rsi
       sub       rsp,20
       mov       [rsp+38],rdx
       mov       rsi,[rcx+8]
       mov       ecx,[rsi]
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+10]
       cmp       [rcx+8],r8d
       jbe       short M01_L00
       lea       eax,[r8+1]
       mov       [rsi+10],eax
       mov       edx,r8d
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,[rsp+38]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L01:
       mov       byte ptr [rsi+18],0
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 78
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
       je        short M02_L03
       mov       ebx,[rsi+14]
       xor       ebp,ebp
       cmp       dword ptr [rsi+10],0
       jle       short M02_L01
M02_L00:
       cmp       ebx,[rsi+14]
       jne       short M02_L01
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       jae       short M02_L04
       movsxd    rdx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       inc       ebp
       cmp       ebp,[rsi+10]
       jl        short M02_L00
M02_L01:
       cmp       ebx,[rsi+14]
       je        short M02_L02
       mov       rax,offset System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M02_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,1C
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Creating02()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.FastSortedList`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,216B5C28D50
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
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
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
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
; Total bytes of code 171
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       push      rsi
       sub       rsp,20
       mov       [rsp+38],rdx
       mov       rsi,[rcx+8]
       mov       ecx,[rsi]
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+10]
       cmp       [rcx+8],r8d
       jbe       short M01_L00
       lea       eax,[r8+1]
       mov       [rsi+10],eax
       mov       edx,r8d
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,[rsp+38]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L01:
       mov       byte ptr [rsi+18],0
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 78
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
       je        short M02_L03
       mov       ebx,[rsi+14]
       xor       ebp,ebp
       cmp       dword ptr [rsi+10],0
       jle       short M02_L01
M02_L00:
       cmp       ebx,[rsi+14]
       jne       short M02_L01
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       jae       short M02_L04
       movsxd    rdx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       inc       ebp
       cmp       ebp,[rsi+10]
       jl        short M02_L00
M02_L01:
       cmp       ebx,[rsi+14]
       je        short M02_L02
       mov       rax,offset System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M02_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,1C
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Creating02()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.FastSortedList`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2A92B5F8D50
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
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
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
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
; Total bytes of code 171
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       push      rsi
       sub       rsp,20
       mov       [rsp+38],rdx
       mov       rsi,[rcx+8]
       mov       ecx,[rsi]
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+10]
       cmp       [rcx+8],r8d
       jbe       short M01_L00
       lea       eax,[r8+1]
       mov       [rsi+10],eax
       mov       edx,r8d
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,[rsp+38]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L01:
       mov       byte ptr [rsi+18],0
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 78
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
       je        short M02_L03
       mov       ebx,[rsi+14]
       xor       ebp,ebp
       cmp       dword ptr [rsi+10],0
       jle       short M02_L01
M02_L00:
       cmp       ebx,[rsi+14]
       jne       short M02_L01
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       jae       short M02_L04
       movsxd    rdx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       inc       ebp
       cmp       ebp,[rsi+10]
       jl        short M02_L00
M02_L01:
       cmp       ebx,[rsi+14]
       je        short M02_L02
       mov       rax,offset System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M02_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,1C
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Creating02()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.FastSortedList`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1F7E3F38D50
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
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
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
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
; Total bytes of code 171
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       push      rsi
       sub       rsp,20
       mov       [rsp+38],rdx
       mov       rsi,[rcx+8]
       mov       ecx,[rsi]
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+10]
       cmp       [rcx+8],r8d
       jbe       short M01_L00
       lea       eax,[r8+1]
       mov       [rsi+10],eax
       mov       edx,r8d
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,[rsp+38]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L01:
       mov       byte ptr [rsi+18],0
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 78
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
       je        short M02_L03
       mov       ebx,[rsi+14]
       xor       ebp,ebp
       cmp       dword ptr [rsi+10],0
       jle       short M02_L01
M02_L00:
       cmp       ebx,[rsi+14]
       jne       short M02_L01
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       jae       short M02_L04
       movsxd    rdx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       inc       ebp
       cmp       ebp,[rsi+10]
       jl        short M02_L00
M02_L01:
       cmp       ebx,[rsi+14]
       je        short M02_L02
       mov       rax,offset System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M02_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,1C
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Creating02()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.FastSortedList`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1C2547448E8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
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
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
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
; Total bytes of code 171
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c__DisplayClass3_0.<Creating02>b__0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       push      rsi
       sub       rsp,20
       mov       [rsp+38],rdx
       mov       rsi,[rcx+8]
       mov       ecx,[rsi]
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+10]
       cmp       [rcx+8],r8d
       jbe       short M01_L00
       lea       eax,[r8+1]
       mov       [rsi+10],eax
       mov       edx,r8d
       mov       r8,[rsp+38]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,[rsp+38]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L01:
       mov       byte ptr [rsi+18],0
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 78
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
       je        short M02_L03
       mov       ebx,[rsi+14]
       xor       ebp,ebp
       cmp       dword ptr [rsi+10],0
       jle       short M02_L01
M02_L00:
       cmp       ebx,[rsi+14]
       jne       short M02_L01
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       jae       short M02_L04
       movsxd    rdx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       inc       ebp
       cmp       ebp,[rsi+10]
       jl        short M02_L00
M02_L01:
       cmp       ebx,[rsi+14]
       je        short M02_L02
       mov       rax,offset System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M02_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,1C
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.LoopingForEach01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Action`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+88]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.<LoopingForEach01>b__4_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rdi+18],rcx
       mov       rcx,rbx
       mov       rdx,rdi
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 89
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.<LoopingForEach01>b__4_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       rcx,[rcx+8]
       mov       eax,[rcx]
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       ret
; Total bytes of code 17
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
       je        short M02_L03
       mov       ebx,[rsi+14]
       xor       ebp,ebp
       cmp       dword ptr [rsi+10],0
       jle       short M02_L01
M02_L00:
       cmp       ebx,[rsi+14]
       jne       short M02_L01
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       jae       short M02_L04
       movsxd    rdx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       inc       ebp
       cmp       ebp,[rsi+10]
       jl        short M02_L00
M02_L01:
       cmp       ebx,[rsi+14]
       je        short M02_L02
       mov       rax,offset System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M02_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,1C
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.LoopingForEach01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Action`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+88]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.<LoopingForEach01>b__4_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rdi+18],rcx
       mov       rcx,rbx
       mov       rdx,rdi
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 89
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.<LoopingForEach01>b__4_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       rcx,[rcx+8]
       mov       eax,[rcx]
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       ret
; Total bytes of code 17
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
       je        short M02_L03
       mov       ebx,[rsi+14]
       xor       ebp,ebp
       cmp       dword ptr [rsi+10],0
       jle       short M02_L01
M02_L00:
       cmp       ebx,[rsi+14]
       jne       short M02_L01
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       jae       short M02_L04
       movsxd    rdx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       inc       ebp
       cmp       ebp,[rsi+10]
       jl        short M02_L00
M02_L01:
       cmp       ebx,[rsi+14]
       je        short M02_L02
       mov       rax,offset System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M02_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,1C
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.LoopingForEach01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Action`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+88]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.<LoopingForEach01>b__4_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rdi+18],rcx
       mov       rcx,rbx
       mov       rdx,rdi
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 89
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.<LoopingForEach01>b__4_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       rcx,[rcx+8]
       mov       eax,[rcx]
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       ret
; Total bytes of code 17
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
       je        short M02_L03
       mov       ebx,[rsi+14]
       xor       ebp,ebp
       cmp       dword ptr [rsi+10],0
       jle       short M02_L01
M02_L00:
       cmp       ebx,[rsi+14]
       jne       short M02_L01
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       jae       short M02_L04
       movsxd    rdx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       inc       ebp
       cmp       ebp,[rsi+10]
       jl        short M02_L00
M02_L01:
       cmp       ebx,[rsi+14]
       je        short M02_L02
       mov       rax,offset System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M02_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,1C
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.LoopingForEach01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Action`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+88]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.<LoopingForEach01>b__4_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rdi+18],rcx
       mov       rcx,rbx
       mov       rdx,rdi
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 89
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.<LoopingForEach01>b__4_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       rcx,[rcx+8]
       mov       eax,[rcx]
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       ret
; Total bytes of code 17
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
       je        short M02_L03
       mov       ebx,[rsi+14]
       xor       ebp,ebp
       cmp       dword ptr [rsi+10],0
       jle       short M02_L01
M02_L00:
       cmp       ebx,[rsi+14]
       jne       short M02_L01
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       jae       short M02_L04
       movsxd    rdx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       inc       ebp
       cmp       ebp,[rsi+10]
       jl        short M02_L00
M02_L01:
       cmp       ebx,[rsi+14]
       je        short M02_L02
       mov       rax,offset System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M02_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,1C
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.LoopingForEach01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Action`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+88]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.<LoopingForEach01>b__4_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rdi+18],rcx
       mov       rcx,rbx
       mov       rdx,rdi
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 89
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.<LoopingForEach01>b__4_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       rcx,[rcx+8]
       mov       eax,[rcx]
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       ret
; Total bytes of code 17
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
       je        short M02_L03
       mov       ebx,[rsi+14]
       xor       ebp,ebp
       cmp       dword ptr [rsi+10],0
       jle       short M02_L01
M02_L00:
       cmp       ebx,[rsi+14]
       jne       short M02_L01
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       jae       short M02_L04
       movsxd    rdx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       inc       ebp
       cmp       ebp,[rsi+10]
       jl        short M02_L00
M02_L01:
       cmp       ebx,[rsi+14]
       je        short M02_L02
       mov       rax,offset System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M02_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,1C
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.LoopingForEach01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Action`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+88]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.<LoopingForEach01>b__4_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rdi+18],rcx
       mov       rcx,rbx
       mov       rdx,rdi
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 89
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.<LoopingForEach01>b__4_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       rcx,[rcx+8]
       mov       eax,[rcx]
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       ret
; Total bytes of code 17
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
       je        short M02_L03
       mov       ebx,[rsi+14]
       xor       ebp,ebp
       cmp       dword ptr [rsi+10],0
       jle       short M02_L01
M02_L00:
       cmp       ebx,[rsi+14]
       jne       short M02_L01
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       jae       short M02_L04
       movsxd    rdx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       inc       ebp
       cmp       ebp,[rsi+10]
       jl        short M02_L00
M02_L01:
       cmp       ebx,[rsi+14]
       je        short M02_L02
       mov       rax,offset System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M02_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,1C
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.LoopingForEach01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Action`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+88]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.<LoopingForEach01>b__4_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rdi+18],rcx
       mov       rcx,rbx
       mov       rdx,rdi
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 89
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.<LoopingForEach01>b__4_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       rcx,[rcx+8]
       mov       eax,[rcx]
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       ret
; Total bytes of code 17
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
       je        short M02_L03
       mov       ebx,[rsi+14]
       xor       ebp,ebp
       cmp       dword ptr [rsi+10],0
       jle       short M02_L01
M02_L00:
       cmp       ebx,[rsi+14]
       jne       short M02_L01
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       jae       short M02_L04
       movsxd    rdx,ebp
       mov       rdx,[rcx+rdx*8+10]
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       inc       ebp
       cmp       ebp,[rsi+10]
       jl        short M02_L00
M02_L01:
       cmp       ebx,[rsi+14]
       je        short M02_L02
       mov       rax,offset System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M02_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,1C
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 121
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Sort01()
       mov       rcx,[rcx+88]
       mov       r8d,[rcx]
       mov       r8d,[rcx+10]
       xor       edx,edx
       xor       r9d,r9d
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       jmp       rax
; Total bytes of code 32
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       ebx,edx
       mov       edi,r8d
       mov       rbp,r9
       test      ebx,ebx
       jl        short M01_L02
       test      edi,edi
       jl        short M01_L03
       mov       ecx,[rsi+10]
       sub       ecx,ebx
       cmp       ecx,edi
       jl        short M01_L04
       cmp       edi,1
       jle       short M01_L01
       mov       r14,[rsi+8]
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AA5EF28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       mov       [rsp+20],rbp
       mov       rcx,rax
       mov       rdx,r14
       mov       r8d,ebx
       mov       r9d,edi
       call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M01_L01:
       inc       dword ptr [rsi+14]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       call      System.ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException()
       int       3
M01_L03:
       mov       ecx,1B
       mov       edx,9
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument, System.ExceptionResource)
       int       3
M01_L04:
       mov       ecx,0B
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 155
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Sort01()
       mov       rcx,[rcx+88]
       mov       r8d,[rcx]
       mov       r8d,[rcx+10]
       xor       edx,edx
       xor       r9d,r9d
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       jmp       rax
; Total bytes of code 32
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       ebx,edx
       mov       edi,r8d
       mov       rbp,r9
       test      ebx,ebx
       jl        short M01_L02
       test      edi,edi
       jl        short M01_L03
       mov       ecx,[rsi+10]
       sub       ecx,ebx
       cmp       ecx,edi
       jl        short M01_L04
       cmp       edi,1
       jle       short M01_L01
       mov       r14,[rsi+8]
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AA4F578
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       mov       [rsp+20],rbp
       mov       rcx,rax
       mov       rdx,r14
       mov       r8d,ebx
       mov       r9d,edi
       call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M01_L01:
       inc       dword ptr [rsi+14]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       call      System.ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException()
       int       3
M01_L03:
       mov       ecx,1B
       mov       edx,9
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument, System.ExceptionResource)
       int       3
M01_L04:
       mov       ecx,0B
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 155
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Sort01()
       mov       rcx,[rcx+88]
       mov       r8d,[rcx]
       mov       r8d,[rcx+10]
       xor       edx,edx
       xor       r9d,r9d
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       jmp       rax
; Total bytes of code 32
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       ebx,edx
       mov       edi,r8d
       mov       rbp,r9
       test      ebx,ebx
       jl        short M01_L02
       test      edi,edi
       jl        short M01_L03
       mov       ecx,[rsi+10]
       sub       ecx,ebx
       cmp       ecx,edi
       jl        short M01_L04
       cmp       edi,1
       jle       short M01_L01
       mov       r14,[rsi+8]
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AA2F358
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       mov       [rsp+20],rbp
       mov       rcx,rax
       mov       rdx,r14
       mov       r8d,ebx
       mov       r9d,edi
       call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M01_L01:
       inc       dword ptr [rsi+14]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       call      System.ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException()
       int       3
M01_L03:
       mov       ecx,1B
       mov       edx,9
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument, System.ExceptionResource)
       int       3
M01_L04:
       mov       ecx,0B
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 155
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Sort01()
       mov       rcx,[rcx+88]
       mov       r8d,[rcx]
       mov       r8d,[rcx+10]
       xor       edx,edx
       xor       r9d,r9d
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       jmp       rax
; Total bytes of code 32
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       ebx,edx
       mov       edi,r8d
       mov       rbp,r9
       test      ebx,ebx
       jl        short M01_L02
       test      edi,edi
       jl        short M01_L03
       mov       ecx,[rsi+10]
       sub       ecx,ebx
       cmp       ecx,edi
       jl        short M01_L04
       cmp       edi,1
       jle       short M01_L01
       mov       r14,[rsi+8]
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AA6F888
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       mov       [rsp+20],rbp
       mov       rcx,rax
       mov       rdx,r14
       mov       r8d,ebx
       mov       r9d,edi
       call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M01_L01:
       inc       dword ptr [rsi+14]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       call      System.ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException()
       int       3
M01_L03:
       mov       ecx,1B
       mov       edx,9
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument, System.ExceptionResource)
       int       3
M01_L04:
       mov       ecx,0B
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 155
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Sort01()
       mov       rcx,[rcx+88]
       mov       r8d,[rcx]
       mov       r8d,[rcx+10]
       xor       edx,edx
       xor       r9d,r9d
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       jmp       rax
; Total bytes of code 32
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       ebx,edx
       mov       edi,r8d
       mov       rbp,r9
       test      ebx,ebx
       jl        short M01_L02
       test      edi,edi
       jl        short M01_L03
       mov       ecx,[rsi+10]
       sub       ecx,ebx
       cmp       ecx,edi
       jl        short M01_L04
       cmp       edi,1
       jle       short M01_L01
       mov       r14,[rsi+8]
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AA5F430
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       mov       [rsp+20],rbp
       mov       rcx,rax
       mov       rdx,r14
       mov       r8d,ebx
       mov       r9d,edi
       call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M01_L01:
       inc       dword ptr [rsi+14]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       call      System.ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException()
       int       3
M01_L03:
       mov       ecx,1B
       mov       edx,9
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument, System.ExceptionResource)
       int       3
M01_L04:
       mov       ecx,0B
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 155
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Sort01()
       mov       rcx,[rcx+88]
       mov       r8d,[rcx]
       mov       r8d,[rcx+10]
       xor       edx,edx
       xor       r9d,r9d
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       jmp       rax
; Total bytes of code 32
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       ebx,edx
       mov       edi,r8d
       mov       rbp,r9
       test      ebx,ebx
       jl        short M01_L02
       test      edi,edi
       jl        short M01_L03
       mov       ecx,[rsi+10]
       sub       ecx,ebx
       cmp       ecx,edi
       jl        short M01_L04
       cmp       edi,1
       jle       short M01_L01
       mov       r14,[rsi+8]
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AA6F830
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       mov       [rsp+20],rbp
       mov       rcx,rax
       mov       rdx,r14
       mov       r8d,ebx
       mov       r9d,edi
       call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M01_L01:
       inc       dword ptr [rsi+14]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       call      System.ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException()
       int       3
M01_L03:
       mov       ecx,1B
       mov       edx,9
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument, System.ExceptionResource)
       int       3
M01_L04:
       mov       ecx,0B
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 155
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Sort01()
       mov       rcx,[rcx+88]
       mov       r8d,[rcx]
       mov       r8d,[rcx+10]
       xor       edx,edx
       xor       r9d,r9d
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       jmp       rax
; Total bytes of code 32
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       ebx,edx
       mov       edi,r8d
       mov       rbp,r9
       test      ebx,ebx
       jl        short M01_L02
       test      edi,edi
       jl        short M01_L03
       mov       ecx,[rsi+10]
       sub       ecx,ebx
       cmp       ecx,edi
       jl        short M01_L04
       cmp       edi,1
       jle       short M01_L01
       mov       r14,[rsi+8]
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AA4F3D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L00:
       mov       [rsp+20],rbp
       mov       rcx,rax
       mov       rdx,r14
       mov       r8d,ebx
       mov       r9d,edi
       call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
M01_L01:
       inc       dword ptr [rsi+14]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       call      System.ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException()
       int       3
M01_L03:
       mov       ecx,1B
       mov       edx,9
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument, System.ExceptionResource)
       int       3
M01_L04:
       mov       ecx,0B
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 155
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Sort02()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+88]
       mov       rcx,1E72242B428
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Comparison`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1E72242B420
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c.<Sort02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rdi+18],rdx
       mov       rcx,1E72242B428
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,rdi
M00_L00:
       mov       rcx,rsi
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(System.Comparison`1<System.__Canon>)
       cmp       [rcx],ecx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M00_L01:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 144
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c.<Sort02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       rcx,[rdx+28]
       mov       rdx,[r8+28]
       mov       r8d,[rcx]
       xor       r8d,r8d
       mov       rax,offset System.String.Compare(System.String, System.String, System.StringComparison)
       jmp       rax
; Total bytes of code 27
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(System.Comparison`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        short M02_L02
       cmp       dword ptr [rsi+10],1
       jle       short M02_L01
       mov       rbx,[rsi+8]
       mov       ebp,[rsi+10]
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M02_L00
       mov       rdx,7FF88AA6F968
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L00:
       mov       [rsp+20],rdi
       mov       rcx,rax
       mov       rdx,rbx
       mov       r9d,ebp
       xor       r8d,r8d
       call      System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].Sort(System.__Canon[], Int32, Int32, System.Comparison`1<System.__Canon>)
M02_L01:
       inc       dword ptr [rsi+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,1D
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 116
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Sort02()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+88]
       mov       rcx,13E09352FC8
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Comparison`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,13E09352FC0
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c.<Sort02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rdi+18],rdx
       mov       rcx,13E09352FC8
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,rdi
M00_L00:
       mov       rcx,rsi
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(System.Comparison`1<System.__Canon>)
       cmp       [rcx],ecx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M00_L01:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 144
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c.<Sort02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       rcx,[rdx+28]
       mov       rdx,[r8+28]
       mov       r8d,[rcx]
       xor       r8d,r8d
       mov       rax,offset System.String.Compare(System.String, System.String, System.StringComparison)
       jmp       rax
; Total bytes of code 27
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(System.Comparison`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        short M02_L02
       cmp       dword ptr [rsi+10],1
       jle       short M02_L01
       mov       rbx,[rsi+8]
       mov       ebp,[rsi+10]
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M02_L00
       mov       rdx,7FF88AA50038
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L00:
       mov       [rsp+20],rdi
       mov       rcx,rax
       mov       rdx,rbx
       mov       r9d,ebp
       xor       r8d,r8d
       call      System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].Sort(System.__Canon[], Int32, Int32, System.Comparison`1<System.__Canon>)
M02_L01:
       inc       dword ptr [rsi+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,1D
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 116
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Sort02()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+88]
       mov       rcx,1CAF6C8B428
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Comparison`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1CAF6C8B420
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c.<Sort02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rdi+18],rdx
       mov       rcx,1CAF6C8B428
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,rdi
M00_L00:
       mov       rcx,rsi
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(System.Comparison`1<System.__Canon>)
       cmp       [rcx],ecx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M00_L01:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 144
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c.<Sort02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       rcx,[rdx+28]
       mov       rdx,[r8+28]
       mov       r8d,[rcx]
       xor       r8d,r8d
       mov       rax,offset System.String.Compare(System.String, System.String, System.StringComparison)
       jmp       rax
; Total bytes of code 27
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(System.Comparison`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        short M02_L02
       cmp       dword ptr [rsi+10],1
       jle       short M02_L01
       mov       rbx,[rsi+8]
       mov       ebp,[rsi+10]
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M02_L00
       mov       rdx,7FF88AA6FE48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L00:
       mov       [rsp+20],rdi
       mov       rcx,rax
       mov       rdx,rbx
       mov       r9d,ebp
       xor       r8d,r8d
       call      System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].Sort(System.__Canon[], Int32, Int32, System.Comparison`1<System.__Canon>)
M02_L01:
       inc       dword ptr [rsi+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,1D
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 116
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Sort02()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+88]
       mov       rcx,1A99F38B428
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Comparison`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1A99F38B420
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c.<Sort02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rdi+18],rdx
       mov       rcx,1A99F38B428
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,rdi
M00_L00:
       mov       rcx,rsi
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(System.Comparison`1<System.__Canon>)
       cmp       [rcx],ecx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M00_L01:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 144
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c.<Sort02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       rcx,[rdx+28]
       mov       rdx,[r8+28]
       mov       r8d,[rcx]
       xor       r8d,r8d
       mov       rax,offset System.String.Compare(System.String, System.String, System.StringComparison)
       jmp       rax
; Total bytes of code 27
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(System.Comparison`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        short M02_L02
       cmp       dword ptr [rsi+10],1
       jle       short M02_L01
       mov       rbx,[rsi+8]
       mov       ebp,[rsi+10]
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M02_L00
       mov       rdx,7FF88AA70290
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L00:
       mov       [rsp+20],rdi
       mov       rcx,rax
       mov       rdx,rbx
       mov       r9d,ebp
       xor       r8d,r8d
       call      System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].Sort(System.__Canon[], Int32, Int32, System.Comparison`1<System.__Canon>)
M02_L01:
       inc       dword ptr [rsi+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,1D
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 116
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Sort02()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+88]
       mov       rcx,17EC7AC8FD8
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Comparison`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,17EC7AC8FD0
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c.<Sort02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rdi+18],rdx
       mov       rcx,17EC7AC8FD8
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,rdi
M00_L00:
       mov       rcx,rsi
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(System.Comparison`1<System.__Canon>)
       cmp       [rcx],ecx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M00_L01:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 144
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c.<Sort02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       rcx,[rdx+28]
       mov       rdx,[r8+28]
       mov       r8d,[rcx]
       xor       r8d,r8d
       mov       rax,offset System.String.Compare(System.String, System.String, System.StringComparison)
       jmp       rax
; Total bytes of code 27
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(System.Comparison`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        short M02_L02
       cmp       dword ptr [rsi+10],1
       jle       short M02_L01
       mov       rbx,[rsi+8]
       mov       ebp,[rsi+10]
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M02_L00
       mov       rdx,7FF88AA602E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L00:
       mov       [rsp+20],rdi
       mov       rcx,rax
       mov       rdx,rbx
       mov       r9d,ebp
       xor       r8d,r8d
       call      System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].Sort(System.__Canon[], Int32, Int32, System.Comparison`1<System.__Canon>)
M02_L01:
       inc       dword ptr [rsi+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,1D
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 116
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Sort02()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+88]
       mov       rcx,23D26E76FC0
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Comparison`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,23D26E76FB8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c.<Sort02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rdi+18],rdx
       mov       rcx,23D26E76FC0
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,rdi
M00_L00:
       mov       rcx,rsi
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(System.Comparison`1<System.__Canon>)
       cmp       [rcx],ecx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M00_L01:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 144
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c.<Sort02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       rcx,[rdx+28]
       mov       rdx,[r8+28]
       mov       r8d,[rcx]
       xor       r8d,r8d
       mov       rax,offset System.String.Compare(System.String, System.String, System.StringComparison)
       jmp       rax
; Total bytes of code 27
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(System.Comparison`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        short M02_L02
       cmp       dword ptr [rsi+10],1
       jle       short M02_L01
       mov       rbx,[rsi+8]
       mov       ebp,[rsi+10]
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M02_L00
       mov       rdx,7FF88AA500B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L00:
       mov       [rsp+20],rdi
       mov       rcx,rax
       mov       rdx,rbx
       mov       r9d,ebp
       xor       r8d,r8d
       call      System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].Sort(System.__Canon[], Int32, Int32, System.Comparison`1<System.__Canon>)
M02_L01:
       inc       dword ptr [rsi+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,1D
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 116
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Sort02()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+88]
       mov       rcx,1A5D4C86FC0
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Comparison`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1A5D4C86FB8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c.<Sort02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rdi+18],rdx
       mov       rcx,1A5D4C86FC0
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,rdi
M00_L00:
       mov       rcx,rsi
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(System.Comparison`1<System.__Canon>)
       cmp       [rcx],ecx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M00_L01:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 144
```
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c.<Sort02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       rcx,[rdx+28]
       mov       rdx,[r8+28]
       mov       r8d,[rcx]
       xor       r8d,r8d
       mov       rax,offset System.String.Compare(System.String, System.String, System.StringComparison)
       jmp       rax
; Total bytes of code 27
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Sort(System.Comparison`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        short M02_L02
       cmp       dword ptr [rsi+10],1
       jle       short M02_L01
       mov       rbx,[rsi+8]
       mov       ebp,[rsi+10]
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M02_L00
       mov       rdx,7FF88AA6FF30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L00:
       mov       [rsp+20],rdi
       mov       rcx,rax
       mov       rdx,rbx
       mov       r9d,ebp
       xor       r8d,r8d
       call      System.Collections.Generic.ArraySortHelper`1[[System.__Canon, System.Private.CoreLib]].Sort(System.__Canon[], Int32, Int32, System.Comparison`1<System.__Canon>)
M02_L01:
       inc       dword ptr [rsi+14]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,1D
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 116
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

