## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Security.EncryptionHelperPerfTestRunner.AesEncrypt()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rcx,offset MT_System.Security.Cryptography.AesManaged
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.Aes..ctor()
       mov       rcx,offset MT_Internal.Cryptography.AesImplementation
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      System.Security.Cryptography.Aes..ctor()
       lea       rcx,[rdi+40]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFE0],rdi
       call      dotNetTips.Utility.Standard.Tester.Properties.Resources.get_LongTestString()
       mov       rdi,rax
       mov       rcx,[rbp+0FFE0]
       mov       rcx,[rcx+40]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rbx,rax
       mov       rcx,[rbp+0FFE0]
       mov       rcx,[rcx+40]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       mov       rdi,rax
       mov       rcx,[rbp+0FFE0]
       mov       rcx,[rcx+40]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rbx,rax
       mov       rcx,[rbp+0FFE0]
       mov       rcx,[rcx+40]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Security.EncryptionHelper.AesDecrypt(Byte[], Byte[], Byte[])
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       mov       rcx,[rbp+0FFE0]
       mov       rcx,[rcx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FF88A991628]
       mov       rcx,[rbp+0FFE0]
       mov       edx,1
       call      qword ptr [7FF88A991630]
       mov       rcx,[rbp+0FFE0]
       call      System.GC.SuppressFinalize(System.Object)
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
       je        short M00_L00
       mov       rcx,[rbp+0FFE0]
       mov       rcx,[rcx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FF88A991628]
       mov       rcx,[rbp+0FFE0]
       mov       edx,1
       call      qword ptr [7FF88A991630]
       mov       rcx,[rbp+0FFE0]
       call      System.GC.SuppressFinalize(System.Object)
M00_L00:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 350
```
```assembly
; System.Security.Cryptography.Aes..ctor()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       dword ptr [rsi+28],1
       mov       dword ptr [rsi+2C],2
       mov       rcx,2025D1F75F0
       mov       rcx,[rcx]
       mov       eax,[rcx]
       call      00007FF8EA12E0A0
       mov       rdx,rax
       mov       rcx,7FF88AA1BCE2
       call      CORINFO_HELP_CHKCASTARRAY
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2025D1F75F8
       mov       rcx,[rcx]
       mov       eax,[rcx]
       call      00007FF8EA12E0A0
       mov       rdx,rax
       mov       rcx,7FF88AA1BCE2
       call      CORINFO_HELP_CHKCASTARRAY
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+30],80
       mov       dword ptr [rsi+34],8
       mov       dword ptr [rsi+38],100
       mov       dword ptr [rsi+28],1
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 156
```
```assembly
; dotNetTips.Utility.Standard.Tester.Properties.Resources.get_LongTestString()
;                 return ResourceManager.GetString("LongTestString", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      dotNetTips.Utility.Standard.Tester.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,2025D1FD738
       mov       rdx,[rdx]
       mov       r8,2025D1F7880
       mov       r8,[r8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       mov       rax,[rax+28]
       add       rsp,28
       jmp       rax
; Total bytes of code 56
```
```assembly
; dotNetTips.Utility.Standard.Security.EncryptionHelper.AesEncrypt(System.String, Byte[], Byte[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFC8],rax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FFB8],rax
       mov       [rbp+0FFA8],rsp
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       r8,2023D1F3060
       mov       r8,[r8]
       mov       rdx,2025D1FD788
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       r8,2023D1F3060
       mov       r8,[r8]
       mov       rdx,2025D1FD790
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,2023D1F3060
       mov       r8,[r8]
       mov       rdx,2023D1F3158
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,offset MT_System.Security.Cryptography.AesManaged
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Security.Cryptography.Aes..ctor()
       mov       rcx,offset MT_Internal.Cryptography.AesImplementation
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Security.Cryptography.Aes..ctor()
       lea       rcx,[r14+40]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFD0],r14
       mov       rcx,[rbp+0FFD0]
       mov       rcx,[rcx+40]
       mov       rdx,rsi
       mov       r8,rbx
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       [rbp+0FFC8],rax
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       call      System.IO.MemoryStream..ctor(Int32)
       mov       [rbp+0FFC0],rsi
       mov       rcx,offset MT_System.Security.Cryptography.CryptoStream
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       rdx,[rbp+0FFC0]
       mov       r8,[rbp+0FFC8]
       mov       r9d,1
       call      System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode, Boolean)
       mov       [rbp+0FFB8],rsi
       mov       rcx,offset MT_System.IO.StreamWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r8,2023D1F22A0
       mov       r8,[r8]
       mov       rcx,rsi
       mov       rdx,[rbp+0FFB8]
       mov       r9d,400
       call      System.IO.StreamWriter..ctor(System.IO.Stream, System.Text.Encoding, Int32, Boolean)
       mov       [rbp+0FFB0],rsi
       mov       rcx,[rbp+0FFB0]
       mov       rdx,rdi
       call      qword ptr [7FF88A99ACA8]
       nop
       mov       rcx,[rbp+0FFB0]
       mov       edx,1
       call      qword ptr [7FF88A99AC10]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [7FF88A999478]
       mov       rsi,rax
       mov       rcx,[rbp+0FFB8]
       mov       edx,1
       call      qword ptr [7FF88A99BB80]
       mov       rcx,[rbp+0FFB8]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       rcx,[rbp+0FFC0]
       mov       edx,1
       call      qword ptr [7FF88A9993A8]
       mov       rcx,[rbp+0FFC0]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       cmp       qword ptr [rbp+0FFC8],0
       je        short M03_L00
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5905D8
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9905D8]
       nop
M03_L00:
       mov       rcx,[rbp+0FFD0]
       mov       rcx,[rcx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FF88A991628]
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF88A991630]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB0],0
       je        short M03_L01
       mov       rcx,[rbp+0FFB0]
       mov       edx,1
       call      qword ptr [7FF88A99AC10]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
M03_L01:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M03_L02
       mov       rcx,[rbp+0FFB8]
       mov       edx,1
       call      qword ptr [7FF88A99BB80]
       mov       rcx,[rbp+0FFB8]
       call      System.GC.SuppressFinalize(System.Object)
M03_L02:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M03_L03
       mov       rcx,[rbp+0FFC0]
       mov       edx,1
       call      qword ptr [7FF88A9993A8]
       mov       rcx,[rbp+0FFC0]
       call      System.GC.SuppressFinalize(System.Object)
M03_L03:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M03_L04
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A5905D8
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9905D8]
M03_L04:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M03_L05
       mov       rcx,[rbp+0FFD0]
       mov       rcx,[rcx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FF88A991628]
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF88A991630]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
M03_L05:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 958
```
```assembly
; dotNetTips.Utility.Standard.Security.EncryptionHelper.AesDecrypt(Byte[], Byte[], Byte[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFC8],rax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FFB8],rax
       mov       [rbp+0FFA0],rsp
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       r8,2023D1F3060
       mov       r8,[r8]
       mov       rdx,2025D1FD7D8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,2023D1F3060
       mov       r8,[r8]
       mov       rdx,2025D1FD790
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,2023D1F3060
       mov       r8,[r8]
       mov       rdx,2023D1F3158
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,offset MT_System.Security.Cryptography.AesManaged
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Security.Cryptography.Aes..ctor()
       mov       rcx,offset MT_Internal.Cryptography.AesImplementation
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      System.Security.Cryptography.Aes..ctor()
       lea       rcx,[r14+40]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFD0],r14
       mov       rcx,[rbp+0FFD0]
       mov       rcx,[rcx+40]
       mov       rdx,rsi
       mov       r8,rbx
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
       mov       [rbp+0FFC8],rax
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,1
       call      System.IO.MemoryStream..ctor(Byte[], Boolean)
       mov       [rbp+0FFC0],rsi
       mov       rcx,offset MT_System.Security.Cryptography.CryptoStream
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       rdx,[rbp+0FFC0]
       mov       r8,[rbp+0FFC8]
       xor       r9d,r9d
       call      System.Security.Cryptography.CryptoStream..ctor(System.IO.Stream, System.Security.Cryptography.ICryptoTransform, System.Security.Cryptography.CryptoStreamMode, Boolean)
       mov       [rbp+0FFB8],rsi
       mov       rcx,offset MT_System.IO.StreamReader
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsp+20],400
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,2023D1F1820
       mov       r8,[r8]
       mov       rcx,rsi
       mov       rdx,[rbp+0FFB8]
       mov       r9d,1
       call      System.IO.StreamReader..ctor(System.IO.Stream, System.Text.Encoding, Boolean, Int32, Boolean)
       mov       [rbp+0FFB0],rsi
       mov       rcx,[rbp+0FFB0]
       call      qword ptr [7FF88A996CE0]
       mov       rsi,rax
       mov       rcx,[rbp+0FFB0]
       mov       edx,1
       call      qword ptr [7FF88A996CB8]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       rcx,[rbp+0FFB8]
       mov       edx,1
       call      qword ptr [7FF88A99BB80]
       mov       rcx,[rbp+0FFB8]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       mov       rcx,[rbp+0FFC0]
       mov       edx,1
       call      qword ptr [7FF88A9993A8]
       mov       rcx,[rbp+0FFC0]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       cmp       qword ptr [rbp+0FFC8],0
       je        short M04_L00
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A590668
       cmp       [rcx],ecx
       call      qword ptr [7FF88A990668]
       nop
M04_L00:
       mov       rcx,[rbp+0FFD0]
       mov       rcx,[rcx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FF88A991628]
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF88A991630]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFB0],0
       je        short M04_L01
       mov       rcx,[rbp+0FFB0]
       mov       edx,1
       call      qword ptr [7FF88A996CB8]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
M04_L01:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M04_L02
       mov       rcx,[rbp+0FFB8]
       mov       edx,1
       call      qword ptr [7FF88A99BB80]
       mov       rcx,[rbp+0FFB8]
       call      System.GC.SuppressFinalize(System.Object)
M04_L02:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M04_L03
       mov       rcx,[rbp+0FFC0]
       mov       edx,1
       call      qword ptr [7FF88A9993A8]
       mov       rcx,[rbp+0FFC0]
       call      System.GC.SuppressFinalize(System.Object)
M04_L03:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M04_L04
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF88A590668
       cmp       [rcx],ecx
       call      qword ptr [7FF88A990668]
M04_L04:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M04_L05
       mov       rcx,[rbp+0FFD0]
       mov       rcx,[rcx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FF88A991628]
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF88A991630]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
M04_L05:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 957
```
```assembly
; System.Security.Cryptography.SymmetricAlgorithm.Dispose()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+58]
       call      qword ptr [rax+8]
       mov       rcx,rsi
       mov       rax,offset System.GC.SuppressFinalize(System.Object)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 47
```
```assembly
; System.Security.Cryptography.SymmetricAlgorithm.Dispose(Boolean)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dl,dl
       je        short M06_L01
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        short M06_L00
       mov       r8d,[rcx+8]
       xor       edx,edx
       call      System.Array.Clear(System.Array, Int32, Int32)
       xor       r8d,r8d
       mov       [rsi+8],r8
M06_L00:
       mov       rcx,[rsi+10]
       test      rcx,rcx
       je        short M06_L01
       mov       r8d,[rcx+8]
       xor       edx,edx
       call      System.Array.Clear(System.Array, Int32, Int32)
       xor       eax,eax
       mov       [rsi+10],rax
M06_L01:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 71
```
```assembly
; System.GC.SuppressFinalize(System.Object)
       push      rsi
       sub       rsp,20
       test      rcx,rcx
       je        short M07_L00
       mov       rax,7FF8EA1AAC90
       add       rsp,20
       pop       rsi
       jmp       rax
M07_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,150A
       mov       rdx,7FF88A584020
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 86
```

