## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringBuilderExtensionsPerfTestRunner.AppendBytes()
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       vmovsd    xmm0,qword ptr [7FF88A9AD0D8]
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateByteArray(Double)
       mov       rdx,rax
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+8]
       mov       rcx,rdi
       call      qword ptr [7FF88A9B7010]
       mov       edx,[rsi]
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
```
```assembly
; dotNetTips.Utility.Standard.Tester.RandomData.GenerateByteArray(Double)
; 			var size = Convert.ToInt32(sizeInKb * 1024);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var bytes = new byte[size];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_random.NextBytes(bytes);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return bytes;
; 			^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       vmulsd    xmm0,xmm0,qword ptr [7FF88A9AD1A0]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       rcx,222853975B8
       mov       rcx,[rcx]
       mov       rdx,rsi
       call      qword ptr [7FF88A9AD5A0]
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; dotNetTips.Utility.Standard.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rdi,rdx
       test      rsi,rsi
       je        near ptr M02_L04
       test      rdi,rdi
       je        near ptr M02_L05
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        near ptr M02_L05
       mov       rdx,22255391818
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebp,ebp
       test      ebx,ebx
       jle       short M02_L03
M02_L00:
       movsxd    rcx,ebp
       lea       rcx,[rdi+rcx+10]
       mov       rdx,22275392448
       mov       r8,[rdx]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,22255391820
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M02_L01
       xor       eax,eax
       xor       r9d,r9d
       jmp       short M02_L02
M02_L01:
       mov       eax,[rdx]
       mov       rax,rdx
       cmp       [rax],eax
       add       rax,0C
       mov       r9d,[rdx+8]
M02_L02:
       lea       rdx,[rsp+28]
       mov       [rdx],rax
       mov       [rdx+8],r9d
       lea       rdx,[rsp+28]
       call      System.Number.FormatUInt32(UInt32, System.ReadOnlySpan`1<Char>, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebp
       cmp       ebx,ebp
       jg        short M02_L00
M02_L03:
       mov       rcx,rsi
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0F4D
       mov       rdx,7FF88AA30240
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0F53
       mov       rdx,7FF88AA30240
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0F6B
       mov       rdx,7FF88AA30240
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0F9B
       mov       rdx,7FF88AA30240
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 375
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       test      ecx,ecx
       jne       short M03_L00
       mov       rax,22275393060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M03_L01
       xor       ebx,ebx
       jmp       short M03_L02
M03_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M03_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M03_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M03_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M03_L04
       cmp       eax,0
       jbe       near ptr M03_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       shl       r8d,1
       mov       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UInt64)
       xor       eax,eax
       mov       [rsp+20],rax
M03_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M03_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,8B30
       mov       rdx,7FF88A5B4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,22275393060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,13C67
       mov       rdx,7FF88A5B4020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 341
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringBuilderExtensionsPerfTestRunner.AppendJoin()
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsp+20],2D
       vmovsd    xmm0,qword ptr [7FF88A9AD108]
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateByteArray(Double)
       mov       r9,rax
       lea       rdx,[rsp+20]
       mov       rcx,rdi
       mov       r8d,1
       call      System.Text.StringBuilder.AppendJoinCore[[System.Byte, System.Private.CoreLib]](Char*, Int32, System.Collections.Generic.IEnumerable`1<Byte>)
       mov       rsi,[rsi+8]
       mov       rcx,rdi
       call      qword ptr [7FF88A9B7010]
       mov       edx,[rsi]
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 147
```
```assembly
; dotNetTips.Utility.Standard.Tester.RandomData.GenerateByteArray(Double)
; 			var size = Convert.ToInt32(sizeInKb * 1024);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var bytes = new byte[size];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_random.NextBytes(bytes);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return bytes;
; 			^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       vmulsd    xmm0,xmm0,qword ptr [7FF88A9AD1D0]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       rcx,28C0DD595D0
       mov       rcx,[rcx]
       mov       rdx,rsi
       call      qword ptr [7FF88A9AD5A0]
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; System.Text.StringBuilder.AppendJoinCore[[System.Byte, System.Private.CoreLib]](Char*, Int32, System.Collections.Generic.IEnumerable`1<Byte>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFB0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       test      r9,r9
       je        near ptr M02_L05
       mov       rcx,r9
       mov       r11,7FF88A5C0428
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9B0428]
       mov       [rbp+0FFC8],rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5C0430
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9B0430]
       test      eax,eax
       jne       short M02_L00
       mov       [rbp+0FFC0],rsi
       jmp       near ptr M02_L03
M02_L00:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5C0438
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9B0438]
       mov       ecx,eax
       xor       edx,edx
       xor       r8d,r8d
       mov       r14,rsi
       lea       rax,[rbp+0FFD0]
       mov       [rax],rdx
       mov       [rax+8],r8d
       lea       rdx,[rbp+0FFD0]
       xor       r8d,r8d
       call      System.Number.FormatUInt32(UInt32, System.ReadOnlySpan`1<Char>, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5C0440
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9B0440]
       test      eax,eax
       je        short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(Char*, Int32)
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5C0448
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9B0448]
       mov       ecx,eax
       xor       edx,edx
       xor       r8d,r8d
       lea       rax,[rbp+0FFD0]
       mov       [rax],rdx
       mov       [rax+8],r8d
       lea       rdx,[rbp+0FFD0]
       xor       r8d,r8d
       call      System.Number.FormatUInt32(UInt32, System.ReadOnlySpan`1<Char>, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5C0440
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9B0440]
       test      eax,eax
       jne       short M02_L01
M02_L02:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5C0450
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9B0450]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsp
       call      M02_L06
       nop
       mov       rax,[rbp+0FFC0]
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L04:
       mov       rax,rsi
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L05:
       mov       ecx,6
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L06:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M02_L07
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5C0450
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9B0450]
M02_L07:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 439
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       test      ecx,ecx
       jne       short M03_L00
       mov       rax,28BFDD53060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M03_L01
       xor       ebx,ebx
       jmp       short M03_L02
M03_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M03_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M03_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M03_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M03_L04
       cmp       eax,0
       jbe       near ptr M03_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       shl       r8d,1
       mov       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UInt64)
       xor       eax,eax
       mov       [rsp+20],rax
M03_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M03_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,8B30
       mov       rdx,7FF88A5B4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,28BFDD53060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,13C67
       mov       rdx,7FF88A5B4020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 341
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringBuilderExtensionsPerfTestRunner.AppendJoinParams()
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsp+20],2D
       vmovsd    xmm0,qword ptr [7FF88A97D108]
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateByteArray(Double)
       mov       r9,rax
       lea       rdx,[rsp+20]
       mov       rcx,rdi
       mov       r8d,1
       call      System.Text.StringBuilder.AppendJoinCore[[System.Byte, System.Private.CoreLib]](Char*, Int32, System.Collections.Generic.IEnumerable`1<Byte>)
       mov       rsi,[rsi+8]
       mov       rcx,rdi
       call      qword ptr [7FF88A987010]
       mov       edx,[rsi]
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 147
```
```assembly
; dotNetTips.Utility.Standard.Tester.RandomData.GenerateByteArray(Double)
; 			var size = Convert.ToInt32(sizeInKb * 1024);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var bytes = new byte[size];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_random.NextBytes(bytes);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return bytes;
; 			^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       vmulsd    xmm0,xmm0,qword ptr [7FF88A97D1D0]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       rcx,2293D0495D0
       mov       rcx,[rcx]
       mov       rdx,rsi
       call      qword ptr [7FF88A97D5A0]
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; System.Text.StringBuilder.AppendJoinCore[[System.Byte, System.Private.CoreLib]](Char*, Int32, System.Collections.Generic.IEnumerable`1<Byte>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFB0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       test      r9,r9
       je        near ptr M02_L05
       mov       rcx,r9
       mov       r11,7FF88A590428
       cmp       [rcx],ecx
       call      qword ptr [7FF88A980428]
       mov       [rbp+0FFC8],rax
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A590430
       cmp       [rcx],ecx
       call      qword ptr [7FF88A980430]
       test      eax,eax
       jne       short M02_L00
       mov       [rbp+0FFC0],rsi
       jmp       near ptr M02_L03
M02_L00:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A590438
       cmp       [rcx],ecx
       call      qword ptr [7FF88A980438]
       mov       ecx,eax
       xor       edx,edx
       xor       r8d,r8d
       mov       r14,rsi
       lea       rax,[rbp+0FFD0]
       mov       [rax],rdx
       mov       [rax+8],r8d
       lea       rdx,[rbp+0FFD0]
       xor       r8d,r8d
       call      System.Number.FormatUInt32(UInt32, System.ReadOnlySpan`1<Char>, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A590440
       cmp       [rcx],ecx
       call      qword ptr [7FF88A980440]
       test      eax,eax
       je        short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(Char*, Int32)
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A590448
       cmp       [rcx],ecx
       call      qword ptr [7FF88A980448]
       mov       ecx,eax
       xor       edx,edx
       xor       r8d,r8d
       lea       rax,[rbp+0FFD0]
       mov       [rax],rdx
       mov       [rax+8],r8d
       lea       rdx,[rbp+0FFD0]
       xor       r8d,r8d
       call      System.Number.FormatUInt32(UInt32, System.ReadOnlySpan`1<Char>, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A590440
       cmp       [rcx],ecx
       call      qword ptr [7FF88A980440]
       test      eax,eax
       jne       short M02_L01
M02_L02:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A590450
       cmp       [rcx],ecx
       call      qword ptr [7FF88A980450]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsp
       call      M02_L06
       nop
       mov       rax,[rbp+0FFC0]
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L04:
       mov       rax,rsi
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L05:
       mov       ecx,6
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M02_L06:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M02_L07
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A590450
       cmp       [rcx],ecx
       call      qword ptr [7FF88A980450]
M02_L07:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 439
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       test      ecx,ecx
       jne       short M03_L00
       mov       rax,2295D043060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M03_L01
       xor       ebx,ebx
       jmp       short M03_L02
M03_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M03_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M03_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M03_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M03_L04
       cmp       eax,0
       jbe       near ptr M03_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       shl       r8d,1
       mov       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UInt64)
       xor       eax,eax
       mov       [rsp+20],rax
M03_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M03_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,8B30
       mov       rdx,7FF88A584020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,2295D043060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,13C67
       mov       rdx,7FF88A584020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 341
```

