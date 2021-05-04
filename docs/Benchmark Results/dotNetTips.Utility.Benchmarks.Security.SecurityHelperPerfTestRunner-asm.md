## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Security.SecurityHelperPerfTestRunner.CompareSecureStrings()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,14E0A111788
       mov       rcx,[rcx]
       call      dotNetTips.Utility.Standard.Security.SecurityHelper.LoadSecureString(System.String)
       mov       rdi,rax
       mov       rcx,14E0A111788
       mov       rcx,[rcx]
       call      dotNetTips.Utility.Standard.Security.SecurityHelper.LoadSecureString(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Security.SecurityHelper.CompareSecureStrings(System.Security.SecureString, System.Security.SecureString)
       mov       rdx,[rsi+8]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 73
```
```assembly
; dotNetTips.Utility.Standard.Security.SecurityHelper.LoadSecureString(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       r8,14DFA113060
       mov       r8,[r8]
       mov       rdx,14E0A111170
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,rsi
       xor       edx,edx
       mov       rax,offset dotNetTips.Utility.Standard.Security.SecurityHelper.LoadSecureString(System.String, Boolean)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 65
```
```assembly
; dotNetTips.Utility.Standard.Security.SecurityHelper.CompareSecureStrings(System.Security.SecureString, System.Security.SecureString)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,14DFA113060
       mov       r8,[r8]
       mov       rdx,14E0A111790
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.Security.SecureString, System.String, System.String)
       mov       r8,14DFA113060
       mov       r8,[r8]
       mov       rdx,14E0A111798
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.Security.SecureString, System.String, System.String)
       xor       ecx,ecx
       mov       [rbp+0FFE8],rcx
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      System.Runtime.InteropServices.Marshal.SecureStringToBSTR(System.Security.SecureString)
       mov       [rbp+0FFE8],rax
       mov       rcx,rdi
       call      System.Runtime.InteropServices.Marshal.SecureStringToBSTR(System.Security.SecureString)
       mov       [rbp+0FFE0],rax
       mov       rcx,[rbp+0FFE8]
       call      System.Runtime.InteropServices.Marshal.PtrToStringUni(IntPtr)
       mov       rsi,rax
       mov       rcx,[rbp+0FFE0]
       call      System.Runtime.InteropServices.Marshal.PtrToStringUni(IntPtr)
       mov       rdx,rax
       mov       rcx,rsi
       call      System.String.Equals(System.String, System.String)
       mov       esi,eax
       mov       rcx,[rbp+0FFE8]
       call      System.Runtime.InteropServices.Marshal.ZeroFreeBSTR(IntPtr)
       mov       rcx,[rbp+0FFE0]
       call      System.Runtime.InteropServices.Marshal.ZeroFreeBSTR(IntPtr)
       mov       eax,esi
       lea       rsp,[rbp+0FFF0]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rcx,[rbp+0FFE8]
       call      System.Runtime.InteropServices.Marshal.ZeroFreeBSTR(IntPtr)
       mov       rcx,[rbp+0FFE0]
       call      System.Runtime.InteropServices.Marshal.ZeroFreeBSTR(IntPtr)
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 233
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Security.SecurityHelperPerfTestRunner.LoadSecureString()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,14CA9651788
       mov       rcx,[rcx]
       call      dotNetTips.Utility.Standard.Security.SecurityHelper.LoadSecureString(System.String)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 51
```
```assembly
; dotNetTips.Utility.Standard.Security.SecurityHelper.LoadSecureString(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       r8,14CC9653060
       mov       r8,[r8]
       mov       rdx,14CA9651170
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,rsi
       xor       edx,edx
       mov       rax,offset dotNetTips.Utility.Standard.Security.SecurityHelper.LoadSecureString(System.String, Boolean)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 65
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Security.SecurityHelperPerfTestRunner.ReadStringCharacters()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,26D61283060
       mov       rdi,[rcx]
       mov       rcx,26D61291BA0
       mov       rcx,[rcx]
       call      System.String.ToCharArray()
       mov       rbx,rax
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       movsxd    rcx,ebp
       movzx     r15d,word ptr [rbx+rcx*2+10]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       rdx,rax
       mov       [rdx+0C],r15w
       mov       rcx,rdi
       call      System.String.Concat(System.String, System.String)
       mov       rdi,rax
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,8
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 137
```
```assembly
; System.String.ToCharArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       edi,[rsi+8]
       test      edi,edi
       jne       short M01_L00
       mov       rax,26D61288CD0
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       add       rsi,0C
       mov       [rsp+28],rsi
       mov       rdx,[rsp+28]
       cmp       dword ptr [rbx+8],0
       jbe       short M01_L01
       lea       r8,[rbx+10]
       mov       [rsp+20],r8
       mov       rcx,[rsp+20]
       shl       edi,1
       mov       r8d,edi
       call      System.Buffer.Memmove(Byte*, Byte*, UInt64)
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 144
```
```assembly
; System.String.Concat(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short M02_L00
       cmp       dword ptr [rdi+8],0
       ja        short M02_L03
M02_L00:
       test      rsi,rsi
       je        short M02_L01
       cmp       dword ptr [rsi+8],0
       ja        short M02_L02
M02_L01:
       mov       rax,26D61283060
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       test      rsi,rsi
       je        short M02_L04
       cmp       dword ptr [rsi+8],0
       ja        short M02_L05
M02_L04:
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L05:
       mov       ebx,[rdi+8]
       mov       ecx,ebx
       add       ecx,[rsi+8]
       call      System.String.FastAllocateString(Int32)
       mov       rbp,rax
       mov       rcx,rbp
       mov       r8,rdi
       xor       edx,edx
       call      System.String.FillStringChecked(System.String, Int32, System.String)
       mov       rcx,rbp
       mov       edx,ebx
       mov       r8,rsi
       call      System.String.FillStringChecked(System.String, Int32, System.String)
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 147
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Security.SecurityHelperPerfTestRunner.ReadSecureString()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,29EE3EA1BA0
       mov       rcx,[rcx]
       call      dotNetTips.Utility.Standard.Security.SecurityHelper.LoadSecureString(System.String)
       mov       rcx,rax
       call      dotNetTips.Utility.Standard.Security.SecurityHelper.ReadSecureString(System.Security.SecureString)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; dotNetTips.Utility.Standard.Security.SecurityHelper.LoadSecureString(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       r8,29EE3E93060
       mov       r8,[r8]
       mov       rdx,29EE3EA1588
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,rsi
       xor       edx,edx
       mov       rax,offset dotNetTips.Utility.Standard.Security.SecurityHelper.LoadSecureString(System.String, Boolean)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 65
```
```assembly
; dotNetTips.Utility.Standard.Security.SecurityHelper.ReadSecureString(System.Security.SecureString)
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp+0FFE0],rsp
       mov       rsi,rcx
       mov       r8,29EE3E93060
       mov       r8,[r8]
       mov       rdx,29EE3EA1588
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.Security.SecureString, System.String, System.String)
       xor       ecx,ecx
       mov       [rbp+0FFF0],rcx
       mov       rcx,rsi
       call      System.Runtime.InteropServices.Marshal.SecureStringToBSTR(System.Security.SecureString)
       mov       [rbp+0FFF0],rax
       mov       rcx,[rbp+0FFF0]
       call      System.Runtime.InteropServices.Marshal.PtrToStringUni(IntPtr)
       mov       rsi,rax
       mov       rcx,[rbp+0FFF0]
       call      System.Runtime.InteropServices.Marshal.ZeroFreeBSTR(IntPtr)
       mov       rax,rsi
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
       mov       rcx,[rbp+0FFF0]
       call      System.Runtime.InteropServices.Marshal.ZeroFreeBSTR(IntPtr)
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 137
```

