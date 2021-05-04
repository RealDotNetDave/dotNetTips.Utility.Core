## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Logging.LoggingHelperPerfTestRunner.RetrieveAllExceptionMessages()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      dotNetTips.Utility.Standard.Common.Logging.LoggingHelper.RetrieveAllExceptionMessages(System.Exception)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M00_L01
M00_L00:
       movsxd    rdx,ebx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rsi+8]
       mov       eax,[rcx]
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebx
       cmp       ebp,ebx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 88
```
```assembly
; dotNetTips.Utility.Standard.Common.Logging.LoggingHelper.RetrieveAllExceptionMessages(System.Exception)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M01_L00
       call      dotNetTips.Utility.Standard.Common.Resources.get_ExMessageNullException()
       mov       rcx,rax
       mov       rdx,1FB1DBF1C08
       mov       rdx,[rdx]
       call      dotNetTips.Utility.Standard.Common.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L00:
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.Common.Logging.LoggingHelper.RetrieveAllExceptions(System.Exception)
       mov       rsi,rax
       mov       edi,[rsi+8]
       movsxd    rdx,edi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       xor       ebp,ebp
       test      edi,edi
       jle       short M01_L02
M01_L01:
       movsxd    rcx,ebp
       mov       rcx,[rsi+rcx*8+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r8,rax
       mov       edx,ebp
       mov       rcx,rbx
       call      CORINFO_HELP_ARRADDR_ST
       inc       ebp
       cmp       edi,ebp
       jg        short M01_L01
M01_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 132
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M02_L04
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M02_L00
       mov       rcx,rsi
       mov       rdx,7FF88AA3B820
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbp,rax
       test      rbp,rbp
       jne       short M02_L02
       mov       rcx,[rbx+18]
       test      rcx,rcx
       jne       short M02_L01
       mov       rcx,rsi
       mov       rdx,7FF88AA3B860
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       mov       rax,offset System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M02_L02:
       mov       r11,[rbx+10]
       test      r11,r11
       jne       short M02_L03
       mov       rcx,rsi
       mov       rdx,7FF88AA3B830
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       mov       rcx,rbp
       mov       rax,[r11]
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M02_L04:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 192
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Logging.LoggingHelperPerfTestRunner.RetrieveAllExceptions()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      dotNetTips.Utility.Standard.Common.Logging.LoggingHelper.RetrieveAllExceptions(System.Exception)
       mov       rdi,rax
       mov       rcx,29EC209B3B0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,29EC209B3A8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Utility.Benchmarks.Logging.LoggingHelperPerfTestRunner+<>c.<RetrieveAllExceptions>b__3_0(System.Exception)
       mov       [rbx+18],rdx
       mov       rcx,29EC209B3B0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Select(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>)
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.Count(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+8]
       mov       [rcx+30],eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,rbx
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 180
```
```assembly
; dotNetTips.Utility.Standard.Common.Logging.LoggingHelper.RetrieveAllExceptions(System.Exception)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M01_L00
       call      dotNetTips.Utility.Standard.Common.Resources.get_ExMessageNullException()
       mov       rcx,rax
       mov       rdx,29EA20917F0
       mov       rdx,[rdx]
       call      dotNetTips.Utility.Standard.Common.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L00:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,29EC2098D40
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M01_L03
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,29EC2098D40
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M01_L01
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L02
M01_L01:
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L02:
       mov       rcx,[rsi+20]
       test      rcx,rcx
       je        short M01_L03
       call      dotNetTips.Utility.Standard.Common.Logging.LoggingHelper.RetrieveAllExceptions(System.Exception)
       mov       r8,rax
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].InsertRange(Int32, System.Collections.Generic.IEnumerable`1<System.__Canon>)
M01_L03:
       mov       rcx,rdi
       mov       rax,offset System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       cmp       [rcx],ecx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 221
```
```assembly
; dotNetTips.Utility.Benchmarks.Logging.LoggingHelperPerfTestRunner+<>c.<RetrieveAllExceptions>b__3_0(System.Exception)
       mov       rax,rdx
       ret
; Total bytes of code 4
```
```assembly
; System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M03_L16
       test      rbx,rbx
       je        near ptr M03_L17
       mov       rbp,[rsi+10]
       mov       r14,[rbp+10]
       mov       rcx,r14
       test      rcx,rcx
       jne       short M03_L00
       mov       rcx,rsi
       mov       rdx,7FF88AA1AFB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       r15,rax
       test      r15,r15
       je        short M03_L02
       test      r14,r14
       jne       short M03_L01
       mov       rcx,rsi
       mov       rdx,7FF88AA1AFB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r14,rax
M03_L01:
       mov       rcx,rsi
       mov       rdx,7FF88AA1D168
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,r15
       mov       rdx,rbx
       call      rax
       jmp       near ptr M03_L15
M03_L02:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       jne       short M03_L03
       mov       rcx,rsi
       mov       rdx,7FF88AA1B1F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M03_L10
       mov       rcx,rsi
       mov       rdx,7FF88AA1BE08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFARRAY
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M03_L06
       cmp       dword ptr [rbp+8],0
       je        short M03_L05
       mov       rcx,rsi
       mov       rdx,7FF88AA1D120
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FF88A690020
       mov       edx,1E2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       short M03_L04
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M03_L04:
       cmp       [rcx],ecx
       call      00007FF8EA1B3670
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M03_L15
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FF88AA1D050
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       call      System.Linq.Enumerable.Empty[[System.__Canon, System.Private.CoreLib]]()
       jmp       near ptr M03_L15
M03_L06:
       mov       rcx,rsi
       mov       rdx,7FF88AA1BE58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       rdi,rax
       test      rdi,rdi
       je        short M03_L08
       mov       rcx,rsi
       mov       rdx,7FF88AA1C9E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FF88A690020
       mov       edx,1E2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       short M03_L07
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M03_L07:
       cmp       [rcx],ecx
       call      00007FF8EA1B3670
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M03_L15
M03_L08:
       mov       rcx,rsi
       mov       rdx,7FF88AA1C828
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FF88A690020
       mov       edx,1E2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       short M03_L09
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M03_L09:
       cmp       [rcx],ecx
       call      00007FF8EA1B3670
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M03_L15
M03_L10:
       mov       rcx,[rbp+20]
       test      rcx,rcx
       jne       short M03_L11
       mov       rcx,rsi
       mov       rdx,7FF88AA1B358
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L11:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        short M03_L12
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,rsi
       mov       rdx,7FF88AA1BDE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       lea       r9,[rsp+28]
       mov       rdx,rbx
       mov       r8,r14
       call      System.Linq.Enumerable.CreateSelectIPartitionIterator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Func`2<System.__Canon,System.__Canon>, System.Linq.IPartition`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef)
       cmp       qword ptr [rsp+28],0
       je        short M03_L12
       mov       rax,[rsp+28]
       jmp       short M03_L15
M03_L12:
       mov       rcx,[rbp+28]
       test      rcx,rcx
       jne       short M03_L13
       mov       rcx,rsi
       mov       rdx,7FF88AA1BD50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L13:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FF88A690020
       mov       edx,1E2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       short M03_L14
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M03_L14:
       cmp       [rcx],ecx
       call      00007FF8EA1B3670
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
M03_L15:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L16:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M03_L17:
       mov       ecx,0F
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 916
```
```assembly
; System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M04_L10
       mov       rbx,[rsi+10]
       mov       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M04_L00
       mov       rcx,rsi
       mov       rdx,7FF88AA1D6D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        short M04_L01
       mov       rcx,rsi
       mov       rdx,7FF88AA1D968
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,r14
       mov       r11,rax
       mov       rax,[rax]
       cmp       [rcx],ecx
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       jmp       rax
M04_L01:
       mov       rcx,[rbx+10]
       test      rcx,rcx
       jne       short M04_L02
       mov       rcx,rsi
       mov       rdx,7FF88AA1D830
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L02:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        short M04_L04
       mov       r11,[rbx+20]
       test      r11,r11
       jne       short M04_L03
       mov       rcx,rsi
       mov       rdx,7FF88AA1D900
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L03:
       mov       rcx,r14
       xor       edx,edx
       mov       rax,[r11]
       cmp       [rcx],ecx
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       jmp       rax
M04_L04:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.ICollection
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M04_L05
       mov       rcx,rax
       mov       r11,7FF88A5A04A8
       mov       rax,[7FF88A9A04A8]
       cmp       [rcx],ecx
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       jmp       rax
M04_L05:
       xor       r14d,r14d
       mov       r11,[rbx+18]
       test      r11,r11
       jne       short M04_L06
       mov       rcx,rsi
       mov       rdx,7FF88AA1D8D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L06:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       [rbp+0FFD0],rax
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FF88A5A0498
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9A0498]
       test      eax,eax
       je        short M04_L09
M04_L07:
       add       r14d,1
       jo        short M04_L08
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FF88A5A0498
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9A0498]
       test      eax,eax
       jne       short M04_L07
       jmp       short M04_L09
M04_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M04_L09:
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FF88A5A04A0
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9A04A0]
       mov       eax,r14d
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M04_L10:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M04_L11
       mov       rcx,[rbp+0FFD0]
       mov       r11,7FF88A5A04A0
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9A04A0]
M04_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 509
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

