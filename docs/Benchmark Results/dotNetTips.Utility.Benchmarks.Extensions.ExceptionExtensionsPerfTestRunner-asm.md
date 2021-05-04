## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.ExceptionExtensionsPerfTestRunner.GetAllMessages()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Data.Services.Client.DataServiceClientException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,221C6371788
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+20],rcx
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80131509
       lea       rcx,[rdi+78]
       mov       dword ptr [rcx],1F4
       mov       rcx,offset MT_System.Security.SecurityException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+70],0E0434352
       mov       dword ptr [rbx+74],80131500
       mov       rdx,221C6371790
       mov       rdx,[rdx]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+74],80131501
       mov       dword ptr [rbx+74],8013150A
       mov       rcx,offset MT_System.ServiceModel.Security.SecurityAccessDeniedException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,221C6371798
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rsi+8]
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Extensions.ExceptionExtensions.GetAllMessages(System.Exception, System.String)
       mov       edx,[rsi]
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 283
```
```assembly
; System.Environment.get_NewLine()
       mov       rax,221A63730F8
       mov       rax,[rax]
       ret
; Total bytes of code 14
```
```assembly
; dotNetTips.Utility.Standard.Extensions.ExceptionExtensions.GetAllMessages(System.Exception, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rdx
       test      rcx,rcx
       je        near ptr M02_L05
       test      rsi,rsi
       je        near ptr M02_L02
       cmp       dword ptr [rsi+8],0
       jbe       near ptr M02_L02
       mov       rax,221A637CCB8
       mov       r8,[rax]
       mov       rdi,rcx
       test      r8,r8
       jne       short M02_L00
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,221A637CCB0
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M02_L03
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Utility.Standard.Extensions.ExceptionExtensions+<>c.<GetAllMessages>b__3_0(System.Exception)
       mov       [rbx+18],rdx
       mov       rcx,221A637CCB8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M02_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Utility.Standard.Extensions.ExceptionExtensions.FromHierarchy(!!0, System.Func`2<!!0,!!0>)
       call      dotNetTips.Utility.Standard.Extensions.ExceptionExtensions.FromHierarchy[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`2<System.__Canon,System.__Canon>)
       mov       rbx,rax
       mov       rcx,221A637CCC0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M02_L01
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,221A637CCB0
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M02_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Utility.Standard.Extensions.ExceptionExtensions+<>c.<GetAllMessages>b__3_1(System.Exception)
       mov       [rdi+18],rdx
       mov       rcx,221A637CCC0
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rdi
M02_L01:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Select(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>)
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       rdx,rax
       mov       rcx,rsi
       mov       rax,offset System.String.Join(System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,41D
       mov       rdx,7FF88AA79968
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,465
       mov       rdx,7FF88AA79968
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rcx,rbx
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
M02_L04:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
M02_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,5F9
       mov       rdx,7FF88AA79968
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 469
```

