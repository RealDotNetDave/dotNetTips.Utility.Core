## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Serialization.JsonSerializerPerfTestRunner.DeserializeTest()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.Serialization.JsonSerializer.Deserialize(System.String)
       call      dotNetTips.Utility.Standard.Serialization.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Utility.Standard.Serialization.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+90]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1C594873060
       mov       r8,[r8]
       mov       rdx,1C594881AF8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       rdi,[rdi+10]
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,1C594871820
       mov       rcx,[rcx]
       mov       rdx,rsi
       call      qword ptr [7FF88A9E3A68]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8d,1
       call      System.IO.MemoryStream..ctor(Byte[], Boolean)
       mov       [rbp+0FFD0],rbx
       mov       rcx,offset MT_System.Runtime.Serialization.Json.DataContractJsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rdi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rbx,rax
       mov       rcx,offset MT_System.Runtime.Serialization.Json.DataContractJsonSerializerImpl
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [rsp+20],7FFFFFFF
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],ecx
       mov       [rsp+38],ecx
       xor       ecx,ecx
       mov       [rsp+40],rcx
       xor       ecx,ecx
       mov       [rsp+48],ecx
       mov       rcx,r14
       mov       rdx,rbx
       xor       r8d,r8d
       xor       r9d,r9d
       call      System.Runtime.Serialization.Json.DataContractJsonSerializerImpl.Initialize(System.Type, System.Xml.XmlDictionaryString, System.Collections.Generic.IEnumerable`1<System.Type>, Int32, Boolean, System.Runtime.Serialization.EmitTypeInformation, Boolean, System.Runtime.Serialization.DateTimeFormat, Boolean)
       lea       rcx,[rsi+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+28]
       mov       rdx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9E23D0]
       mov       rdx,rax
       mov       rsi,[rdi]
       mov       rcx,rsi
       call      CORINFO_HELP_ISINSTANCEOFANY
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHKCASTANY
       mov       rsi,rax
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF88A9D7CF0]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       mov       rbp,[rcx+50]
       mov       [rsp+50],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L00
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF88A9D7CF0]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
M01_L00:
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 393
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Serialization.JsonSerializerPerfTestRunner.DeserializeTest()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.Serialization.JsonSerializer.Deserialize(System.String)
       call      dotNetTips.Utility.Standard.Serialization.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Utility.Standard.Serialization.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+90]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1E241FA3060
       mov       r8,[r8]
       mov       rdx,1E231FA16E0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       rdi,[rdi+10]
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,1E241FA1820
       mov       rcx,[rcx]
       mov       rdx,rsi
       call      qword ptr [7FF88AA03A68]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8d,1
       call      System.IO.MemoryStream..ctor(Byte[], Boolean)
       mov       [rbp+0FFD0],rbx
       mov       rcx,offset MT_System.Runtime.Serialization.Json.DataContractJsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rdi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rbx,rax
       mov       rcx,offset MT_System.Runtime.Serialization.Json.DataContractJsonSerializerImpl
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [rsp+20],7FFFFFFF
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],ecx
       mov       [rsp+38],ecx
       xor       ecx,ecx
       mov       [rsp+40],rcx
       xor       ecx,ecx
       mov       [rsp+48],ecx
       mov       rcx,r14
       mov       rdx,rbx
       xor       r8d,r8d
       xor       r9d,r9d
       call      System.Runtime.Serialization.Json.DataContractJsonSerializerImpl.Initialize(System.Type, System.Xml.XmlDictionaryString, System.Collections.Generic.IEnumerable`1<System.Type>, Int32, Boolean, System.Runtime.Serialization.EmitTypeInformation, Boolean, System.Runtime.Serialization.DateTimeFormat, Boolean)
       lea       rcx,[rsi+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+28]
       mov       rdx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      qword ptr [7FF88AA023D0]
       mov       rdx,rax
       mov       rsi,[rdi]
       mov       rcx,rsi
       call      CORINFO_HELP_ISINSTANCEOFANY
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHKCASTANY
       mov       rsi,rax
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF88A9F7CF0]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       mov       rbp,[rcx+50]
       mov       [rsp+50],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L00
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF88A9F7CF0]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
M01_L00:
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 393
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Serialization.JsonSerializerPerfTestRunner.DeserializeTest()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.Serialization.JsonSerializer.Deserialize(System.String)
       call      dotNetTips.Utility.Standard.Serialization.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Utility.Standard.Serialization.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+90]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,21279873060
       mov       r8,[r8]
       mov       rdx,21279881AF8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       rdi,[rdi+10]
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,21279871820
       mov       rcx,[rcx]
       mov       rdx,rsi
       call      qword ptr [7FF88A9D3A68]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8d,1
       call      System.IO.MemoryStream..ctor(Byte[], Boolean)
       mov       [rbp+0FFD0],rbx
       mov       rcx,offset MT_System.Runtime.Serialization.Json.DataContractJsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rdi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rbx,rax
       mov       rcx,offset MT_System.Runtime.Serialization.Json.DataContractJsonSerializerImpl
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [rsp+20],7FFFFFFF
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],ecx
       mov       [rsp+38],ecx
       xor       ecx,ecx
       mov       [rsp+40],rcx
       xor       ecx,ecx
       mov       [rsp+48],ecx
       mov       rcx,r14
       mov       rdx,rbx
       xor       r8d,r8d
       xor       r9d,r9d
       call      System.Runtime.Serialization.Json.DataContractJsonSerializerImpl.Initialize(System.Type, System.Xml.XmlDictionaryString, System.Collections.Generic.IEnumerable`1<System.Type>, Int32, Boolean, System.Runtime.Serialization.EmitTypeInformation, Boolean, System.Runtime.Serialization.DateTimeFormat, Boolean)
       lea       rcx,[rsi+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+28]
       mov       rdx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9D23D0]
       mov       rdx,rax
       mov       rsi,[rdi]
       mov       rcx,rsi
       call      CORINFO_HELP_ISINSTANCEOFANY
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHKCASTANY
       mov       rsi,rax
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF88A9C7CF0]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       mov       rbp,[rcx+50]
       mov       [rsp+50],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L00
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF88A9C7CF0]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
M01_L00:
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 393
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Serialization.JsonSerializerPerfTestRunner.DeserializeTest()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.Serialization.JsonSerializer.Deserialize(System.String)
       call      dotNetTips.Utility.Standard.Serialization.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Utility.Standard.Serialization.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+90]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1DF31D43060
       mov       r8,[r8]
       mov       rdx,1DF21D4D690
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       rdi,[rdi+10]
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,1DF31D41820
       mov       rcx,[rcx]
       mov       rdx,rsi
       call      qword ptr [7FF88A9C3A68]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8d,1
       call      System.IO.MemoryStream..ctor(Byte[], Boolean)
       mov       [rbp+0FFD0],rbx
       mov       rcx,offset MT_System.Runtime.Serialization.Json.DataContractJsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rdi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rbx,rax
       mov       rcx,offset MT_System.Runtime.Serialization.Json.DataContractJsonSerializerImpl
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [rsp+20],7FFFFFFF
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],ecx
       mov       [rsp+38],ecx
       xor       ecx,ecx
       mov       [rsp+40],rcx
       xor       ecx,ecx
       mov       [rsp+48],ecx
       mov       rcx,r14
       mov       rdx,rbx
       xor       r8d,r8d
       xor       r9d,r9d
       call      System.Runtime.Serialization.Json.DataContractJsonSerializerImpl.Initialize(System.Type, System.Xml.XmlDictionaryString, System.Collections.Generic.IEnumerable`1<System.Type>, Int32, Boolean, System.Runtime.Serialization.EmitTypeInformation, Boolean, System.Runtime.Serialization.DateTimeFormat, Boolean)
       lea       rcx,[rsi+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+28]
       mov       rdx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9C2E28]
       mov       rdx,rax
       mov       rsi,[rdi]
       mov       rcx,rsi
       call      CORINFO_HELP_ISINSTANCEOFANY
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHKCASTANY
       mov       rsi,rax
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF88A9B8508]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       mov       rbp,[rcx+50]
       mov       [rsp+50],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L00
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF88A9B8508]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
M01_L00:
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 393
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Serialization.JsonSerializerPerfTestRunner.DeserializeTest()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.Serialization.JsonSerializer.Deserialize(System.String)
       call      dotNetTips.Utility.Standard.Serialization.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Utility.Standard.Serialization.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+90]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1BFE0533060
       mov       r8,[r8]
       mov       rdx,1BFF05316E0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       rdi,[rdi+10]
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,1BFE0531820
       mov       rcx,[rcx]
       mov       rdx,rsi
       call      qword ptr [7FF88AA03A68]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8d,1
       call      System.IO.MemoryStream..ctor(Byte[], Boolean)
       mov       [rbp+0FFD0],rbx
       mov       rcx,offset MT_System.Runtime.Serialization.Json.DataContractJsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rdi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rbx,rax
       mov       rcx,offset MT_System.Runtime.Serialization.Json.DataContractJsonSerializerImpl
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [rsp+20],7FFFFFFF
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],ecx
       mov       [rsp+38],ecx
       xor       ecx,ecx
       mov       [rsp+40],rcx
       xor       ecx,ecx
       mov       [rsp+48],ecx
       mov       rcx,r14
       mov       rdx,rbx
       xor       r8d,r8d
       xor       r9d,r9d
       call      System.Runtime.Serialization.Json.DataContractJsonSerializerImpl.Initialize(System.Type, System.Xml.XmlDictionaryString, System.Collections.Generic.IEnumerable`1<System.Type>, Int32, Boolean, System.Runtime.Serialization.EmitTypeInformation, Boolean, System.Runtime.Serialization.DateTimeFormat, Boolean)
       lea       rcx,[rsi+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+28]
       mov       rdx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      qword ptr [7FF88AA02E28]
       mov       rdx,rax
       mov       rsi,[rdi]
       mov       rcx,rsi
       call      CORINFO_HELP_ISINSTANCEOFANY
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHKCASTANY
       mov       rsi,rax
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF88A9F8508]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       mov       rbp,[rcx+50]
       mov       [rsp+50],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L00
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF88A9F8508]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
M01_L00:
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 393
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Serialization.JsonSerializerPerfTestRunner.DeserializeTest()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.Serialization.JsonSerializer.Deserialize(System.String)
       call      dotNetTips.Utility.Standard.Serialization.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Utility.Standard.Serialization.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+90]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1E12E7B3060
       mov       r8,[r8]
       mov       rdx,1E12E7C2330
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       rdi,[rdi+10]
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,1E12E7B1820
       mov       rcx,[rcx]
       mov       rdx,rsi
       call      qword ptr [7FF88A9E3A68]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8d,1
       call      System.IO.MemoryStream..ctor(Byte[], Boolean)
       mov       [rbp+0FFD0],rbx
       mov       rcx,offset MT_System.Runtime.Serialization.Json.DataContractJsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rdi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rbx,rax
       mov       rcx,offset MT_System.Runtime.Serialization.Json.DataContractJsonSerializerImpl
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [rsp+20],7FFFFFFF
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],ecx
       mov       [rsp+38],ecx
       xor       ecx,ecx
       mov       [rsp+40],rcx
       xor       ecx,ecx
       mov       [rsp+48],ecx
       mov       rcx,r14
       mov       rdx,rbx
       xor       r8d,r8d
       xor       r9d,r9d
       call      System.Runtime.Serialization.Json.DataContractJsonSerializerImpl.Initialize(System.Type, System.Xml.XmlDictionaryString, System.Collections.Generic.IEnumerable`1<System.Type>, Int32, Boolean, System.Runtime.Serialization.EmitTypeInformation, Boolean, System.Runtime.Serialization.DateTimeFormat, Boolean)
       lea       rcx,[rsi+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+28]
       mov       rdx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9E2E28]
       mov       rdx,rax
       mov       rsi,[rdi]
       mov       rcx,rsi
       call      CORINFO_HELP_ISINSTANCEOFANY
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHKCASTANY
       mov       rsi,rax
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF88A9D8508]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       mov       rbp,[rcx+50]
       mov       [rsp+50],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L00
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF88A9D8508]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
M01_L00:
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 393
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Serialization.JsonSerializerPerfTestRunner.DeserializeTest()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.Serialization.JsonSerializer.Deserialize(System.String)
       call      dotNetTips.Utility.Standard.Serialization.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Utility.Standard.Serialization.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+90]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1DE9C073060
       mov       r8,[r8]
       mov       rdx,1DEBC0FA6C8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       rdi,[rdi+10]
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,1DE9C071820
       mov       rcx,[rcx]
       mov       rdx,rsi
       call      qword ptr [7FF88A9F3A68]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8d,1
       call      System.IO.MemoryStream..ctor(Byte[], Boolean)
       mov       [rbp+0FFD0],rbx
       mov       rcx,offset MT_System.Runtime.Serialization.Json.DataContractJsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rdi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rbx,rax
       mov       rcx,offset MT_System.Runtime.Serialization.Json.DataContractJsonSerializerImpl
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [rsp+20],7FFFFFFF
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],ecx
       mov       [rsp+38],ecx
       xor       ecx,ecx
       mov       [rsp+40],rcx
       xor       ecx,ecx
       mov       [rsp+48],ecx
       mov       rcx,r14
       mov       rdx,rbx
       xor       r8d,r8d
       xor       r9d,r9d
       call      System.Runtime.Serialization.Json.DataContractJsonSerializerImpl.Initialize(System.Type, System.Xml.XmlDictionaryString, System.Collections.Generic.IEnumerable`1<System.Type>, Int32, Boolean, System.Runtime.Serialization.EmitTypeInformation, Boolean, System.Runtime.Serialization.DateTimeFormat, Boolean)
       lea       rcx,[rsi+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+28]
       mov       rdx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9F2E28]
       mov       rdx,rax
       mov       rsi,[rdi]
       mov       rcx,rsi
       call      CORINFO_HELP_ISINSTANCEOFANY
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHKCASTANY
       mov       rsi,rax
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF88A9E8508]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       mov       rbp,[rcx+50]
       mov       [rsp+50],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L00
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF88A9E8508]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
M01_L00:
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 393
```

