## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Creating01()
;             var people = new FastSortedList<PersonProper>(base.personProperCollection);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(people);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFF60CAE758
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
       mov       rdx,7FFF60CAE7A8
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
       mov       rdx,7FFF60CAE768
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
       mov       rdx,7FFF60CAE7C0
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
       mov       rdx,7FFF60CAE7D0
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
       mov       rdx,7FFF60CAE768
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
       mov       rdx,7FFF60CAE778
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L08:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFF60800590
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C10590]
       test      eax,eax
       je        near ptr M01_L13
M01_L09:
       mov       rcx,rdi
       mov       r11,[rbx+20]
       test      r11,r11
       jne       short M01_L10
       mov       rdx,7FFF60CAE790
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
       mov       r11,7FFF60800590
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C10590]
       test      eax,eax
       jne       short M01_L09
M01_L13:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFF60800598
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C10598]
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
       mov       r11,7FFF60800598
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C10598]
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Creating01()
;             var people = new FastSortedList<PersonProper>(base.personProperCollection);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(people);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFF60CCE800
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
       mov       rdx,7FFF60CCE850
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
       mov       rdx,7FFF60CCE810
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
       mov       rdx,7FFF60CCE868
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
       mov       rdx,7FFF60CCE878
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
       mov       rdx,7FFF60CCE810
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
       mov       rdx,7FFF60CCE820
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L08:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFF60820590
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C30590]
       test      eax,eax
       je        near ptr M01_L13
M01_L09:
       mov       rcx,rdi
       mov       r11,[rbx+20]
       test      r11,r11
       jne       short M01_L10
       mov       rdx,7FFF60CCE838
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
       mov       r11,7FFF60820590
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C30590]
       test      eax,eax
       jne       short M01_L09
M01_L13:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFF60820598
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C30598]
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
       mov       r11,7FFF60820598
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C30598]
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Creating01()
;             var people = new FastSortedList<PersonProper>(base.personProperCollection);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(people);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFF60CAEA90
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
       mov       rdx,7FFF60CAEAE0
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
       mov       rdx,7FFF60CAEAA0
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
       mov       rdx,7FFF60CAEAF8
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
       mov       rdx,7FFF60CAEB08
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
       mov       rdx,7FFF60CAEAA0
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
       mov       rdx,7FFF60CAEAB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L08:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFF60800590
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C10590]
       test      eax,eax
       je        near ptr M01_L13
M01_L09:
       mov       rcx,rdi
       mov       r11,[rbx+20]
       test      r11,r11
       jne       short M01_L10
       mov       rdx,7FFF60CAEAC8
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
       mov       r11,7FFF60800590
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C10590]
       test      eax,eax
       jne       short M01_L09
M01_L13:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFF60800598
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C10598]
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
       mov       r11,7FFF60800598
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C10598]
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Creating01()
;             var people = new FastSortedList<PersonProper>(base.personProperCollection);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(people);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFF60CBEA90
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
       mov       rdx,7FFF60CBEAE0
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
       mov       rdx,7FFF60CBEAA0
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
       mov       rdx,7FFF60CBEAF8
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
       mov       rdx,7FFF60CBEB08
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
       mov       rdx,7FFF60CBEAA0
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
       mov       rdx,7FFF60CBEAB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L08:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFF60810590
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C20590]
       test      eax,eax
       je        near ptr M01_L13
M01_L09:
       mov       rcx,rdi
       mov       r11,[rbx+20]
       test      r11,r11
       jne       short M01_L10
       mov       rdx,7FFF60CBEAC8
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
       mov       r11,7FFF60810590
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C20590]
       test      eax,eax
       jne       short M01_L09
M01_L13:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFF60810598
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C20598]
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
       mov       r11,7FFF60810598
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C20598]
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Creating01()
;             var people = new FastSortedList<PersonProper>(base.personProperCollection);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(people);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFF60CAEC58
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
       mov       rdx,7FFF60CAECA8
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
       mov       rdx,7FFF60CAEC68
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
       mov       rdx,7FFF60CAECC0
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
       mov       rdx,7FFF60CAECD0
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
       mov       rdx,7FFF60CAEC68
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
       mov       rdx,7FFF60CAEC78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L08:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFF60800590
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C10590]
       test      eax,eax
       je        near ptr M01_L13
M01_L09:
       mov       rcx,rdi
       mov       r11,[rbx+20]
       test      r11,r11
       jne       short M01_L10
       mov       rdx,7FFF60CAEC90
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
       mov       r11,7FFF60800590
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C10590]
       test      eax,eax
       jne       short M01_L09
M01_L13:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFF60800598
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C10598]
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
       mov       r11,7FFF60800598
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C10598]
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Creating01()
;             var people = new FastSortedList<PersonProper>(base.personProperCollection);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(people);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFF60CAE728
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
       mov       rdx,7FFF60CAE778
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
       mov       rdx,7FFF60CAE738
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
       mov       rdx,7FFF60CAE790
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
       mov       rdx,7FFF60CAE7A0
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
       mov       rdx,7FFF60CAE738
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
       mov       rdx,7FFF60CAE748
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L08:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFF60800590
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C10590]
       test      eax,eax
       je        near ptr M01_L13
M01_L09:
       mov       rcx,rdi
       mov       r11,[rbx+20]
       test      r11,r11
       jne       short M01_L10
       mov       rdx,7FFF60CAE760
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
       mov       r11,7FFF60800590
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C10590]
       test      eax,eax
       jne       short M01_L09
M01_L13:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFF60800598
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C10598]
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
       mov       r11,7FFF60800598
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C10598]
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Creating01()
;             var people = new FastSortedList<PersonProper>(base.personProperCollection);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(people);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFF60C9EA90
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
       mov       rdx,7FFF60C9EAE0
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
       mov       rdx,7FFF60C9EAA0
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
       mov       rdx,7FFF60C9EAF8
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
       mov       rdx,7FFF60C9EB08
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
       mov       rdx,7FFF60C9EAA0
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
       mov       rdx,7FFF60C9EAB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L08:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       [rbp+0FFC8],rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFF607F0590
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C00590]
       test      eax,eax
       je        near ptr M01_L13
M01_L09:
       mov       rcx,rdi
       mov       r11,[rbx+20]
       test      r11,r11
       jne       short M01_L10
       mov       rdx,7FFF60C9EAC8
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
       mov       r11,7FFF607F0590
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C00590]
       test      eax,eax
       jne       short M01_L09
M01_L13:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FFF607F0598
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C00598]
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
       mov       r11,7FFF607F0598
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C00598]
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Creating02()
;             var fakePeople = new FastSortedList<PersonProper>();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.FastSortedList`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,239D21B8D50
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
;                 fakePeople.Add(p);
;                 ^^^^^^^^^^^^^^^^^^
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Creating02()
;             var fakePeople = new FastSortedList<PersonProper>();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.FastSortedList`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1BEBB208D50
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
;                 fakePeople.Add(p);
;                 ^^^^^^^^^^^^^^^^^^
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Creating02()
;             var fakePeople = new FastSortedList<PersonProper>();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.FastSortedList`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1EDDA2B48E8
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
;                 fakePeople.Add(p);
;                 ^^^^^^^^^^^^^^^^^^
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Creating02()
;             var fakePeople = new FastSortedList<PersonProper>();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.FastSortedList`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,20FF4478D50
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
;                 fakePeople.Add(p);
;                 ^^^^^^^^^^^^^^^^^^
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Creating02()
;             var fakePeople = new FastSortedList<PersonProper>();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.FastSortedList`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,14CC4CC48E8
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
;                 fakePeople.Add(p);
;                 ^^^^^^^^^^^^^^^^^^
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Creating02()
;             var fakePeople = new FastSortedList<PersonProper>();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.FastSortedList`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1F01AEB8D50
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
;                 fakePeople.Add(p);
;                 ^^^^^^^^^^^^^^^^^^
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Creating02()
;             var fakePeople = new FastSortedList<PersonProper>();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,offset MT_dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Collections.Generic.FastSortedList`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,25E40AF8D50
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
;                 fakePeople.Add(p);
;                 ^^^^^^^^^^^^^^^^^^
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.LoopingForEach01()
;             this._peopleFastSortedList.ForEach(p =>
;             ^^^
;             {
;             ^^^
;                 base.Consumer.Consume(p);
;             ^^^
;             });
;             ^^^
;         }
;         ^
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
;                 base.Consumer.Consume(p);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.LoopingForEach01()
;             this._peopleFastSortedList.ForEach(p =>
;             ^^^
;             {
;             ^^^
;                 base.Consumer.Consume(p);
;             ^^^
;             });
;             ^^^
;         }
;         ^
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
;                 base.Consumer.Consume(p);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.LoopingForEach01()
;             this._peopleFastSortedList.ForEach(p =>
;             ^^^
;             {
;             ^^^
;                 base.Consumer.Consume(p);
;             ^^^
;             });
;             ^^^
;         }
;         ^
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
;                 base.Consumer.Consume(p);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.LoopingForEach01()
;             this._peopleFastSortedList.ForEach(p =>
;             ^^^
;             {
;             ^^^
;                 base.Consumer.Consume(p);
;             ^^^
;             });
;             ^^^
;         }
;         ^
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
;                 base.Consumer.Consume(p);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.LoopingForEach01()
;             this._peopleFastSortedList.ForEach(p =>
;             ^^^
;             {
;             ^^^
;                 base.Consumer.Consume(p);
;             ^^^
;             });
;             ^^^
;         }
;         ^
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
;                 base.Consumer.Consume(p);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.LoopingForEach01()
;             this._peopleFastSortedList.ForEach(p =>
;             ^^^
;             {
;             ^^^
;                 base.Consumer.Consume(p);
;             ^^^
;             });
;             ^^^
;         }
;         ^
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
;                 base.Consumer.Consume(p);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.LoopingForEach01()
;             this._peopleFastSortedList.ForEach(p =>
;             ^^^
;             {
;             ^^^
;                 base.Consumer.Consume(p);
;             ^^^
;             });
;             ^^^
;         }
;         ^
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
;                 base.Consumer.Consume(p);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Sort01()
;             this._peopleFastSortedList.Sort();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFF60CCEEF8
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Sort01()
;             this._peopleFastSortedList.Sort();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFF60CBF428
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Sort01()
;             this._peopleFastSortedList.Sort();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFF60CDF6C0
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Sort01()
;             this._peopleFastSortedList.Sort();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFF60CAF388
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Sort01()
;             this._peopleFastSortedList.Sort();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFF60CDF888
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Sort01()
;             this._peopleFastSortedList.Sort();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFF60CDF830
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Sort01()
;             this._peopleFastSortedList.Sort();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFF60CDF830
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Sort02()
;             this._peopleFastSortedList.Sort(delegate (PersonProper p1, PersonProper p2)
;             ^^^
;             {
;             ^^^
;                 return p1.Country.CompareTo(p2.Country);
;             ^^^
;             });
;             ^^^
;         }
;         ^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+88]
       mov       rcx,1D0C5CE6FC0
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Comparison`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1D0C5CE6FB8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c.<Sort02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rdi+18],rdx
       mov       rcx,1D0C5CE6FC0
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
;                 return p1.Country.CompareTo(p2.Country);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFF60CCFC58
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Sort02()
;             this._peopleFastSortedList.Sort(delegate (PersonProper p1, PersonProper p2)
;             ^^^
;             {
;             ^^^
;                 return p1.Country.CompareTo(p2.Country);
;             ^^^
;             });
;             ^^^
;         }
;         ^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+88]
       mov       rcx,18ED33DB428
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Comparison`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,18ED33DB420
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c.<Sort02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rdi+18],rdx
       mov       rcx,18ED33DB428
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
;                 return p1.Country.CompareTo(p2.Country);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFF60CDFD80
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Sort02()
;             this._peopleFastSortedList.Sort(delegate (PersonProper p1, PersonProper p2)
;             ^^^
;             {
;             ^^^
;                 return p1.Country.CompareTo(p2.Country);
;             ^^^
;             });
;             ^^^
;         }
;         ^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+88]
       mov       rcx,20418196FC0
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Comparison`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,20418196FB8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c.<Sort02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rdi+18],rdx
       mov       rcx,20418196FC0
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
;                 return p1.Country.CompareTo(p2.Country);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFF60CD02E8
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Sort02()
;             this._peopleFastSortedList.Sort(delegate (PersonProper p1, PersonProper p2)
;             ^^^
;             {
;             ^^^
;                 return p1.Country.CompareTo(p2.Country);
;             ^^^
;             });
;             ^^^
;         }
;         ^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+88]
       mov       rcx,14BFA79B428
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Comparison`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,14BFA79B420
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c.<Sort02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rdi+18],rdx
       mov       rcx,14BFA79B428
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
;                 return p1.Country.CompareTo(p2.Country);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFF60CCFF30
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Sort02()
;             this._peopleFastSortedList.Sort(delegate (PersonProper p1, PersonProper p2)
;             ^^^
;             {
;             ^^^
;                 return p1.Country.CompareTo(p2.Country);
;             ^^^
;             });
;             ^^^
;         }
;         ^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+88]
       mov       rcx,1A2FA122FC8
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Comparison`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1A2FA122FC0
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c.<Sort02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rdi+18],rdx
       mov       rcx,1A2FA122FC8
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
;                 return p1.Country.CompareTo(p2.Country);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFF60CBFF88
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Sort02()
;             this._peopleFastSortedList.Sort(delegate (PersonProper p1, PersonProper p2)
;             ^^^
;             {
;             ^^^
;                 return p1.Country.CompareTo(p2.Country);
;             ^^^
;             });
;             ^^^
;         }
;         ^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+88]
       mov       rcx,2C5D4CA6FC0
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Comparison`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2C5D4CA6FB8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c.<Sort02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rdi+18],rdx
       mov       rcx,2C5D4CA6FC0
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
;                 return p1.Country.CompareTo(p2.Country);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFF60CF00B0
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner.Sort02()
;             this._peopleFastSortedList.Sort(delegate (PersonProper p1, PersonProper p2)
;             ^^^
;             {
;             ^^^
;                 return p1.Country.CompareTo(p2.Country);
;             ^^^
;             });
;             ^^^
;         }
;         ^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+88]
       mov       rcx,16E6B156FC0
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Comparison`1[[dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,16E6B156FB8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner+<>c.<Sort02>b__6_0(dotNetTips.Utility.Standard.Tester.Models.PersonProper, dotNetTips.Utility.Standard.Tester.Models.PersonProper)
       mov       [rdi+18],rdx
       mov       rcx,16E6B156FC0
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
;                 return p1.Country.CompareTo(p2.Country);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFF60CF0278
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

