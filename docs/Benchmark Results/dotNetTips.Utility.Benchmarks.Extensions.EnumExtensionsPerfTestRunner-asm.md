## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.EnumExtensionsPerfTestRunner.GetDescription()
;             var testEnum = StringComparison.OrdinalIgnoreCase;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var result = testEnum.GetDescription();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.StringComparison
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+8],5
       mov       rcx,rax
       call      dotNetTips.Utility.Standard.Extensions.EnumExtensions.GetDescription(System.Enum)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; dotNetTips.Utility.Standard.Extensions.EnumExtensions.GetDescription(System.Enum)
;             if (val == null)
;             ^^^^^^^^^^^^^^^^
;                 throw new ArgumentNullException(nameof(val), $"{nameof(val)} is null.");
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var field = val.GetType().GetField(val.ToString());
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var attributes = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             return attributes.Length > 0 ? attributes[0].Description : val.ToString();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       je        near ptr M01_L01
       mov       rcx,rsi
       call      00007FFFC03F1F60
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1C
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C147E0]
       mov       rdi,rax
       mov       rcx,offset MT_System.ComponentModel.DescriptionAttribute
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdx,rax
       mov       rcx,7FFF60C8C342
       call      CORINFO_HELP_CHKCASTARRAY
       cmp       dword ptr [rax+8],0
       jne       short M01_L00
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       mov       rax,[rax+8]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L00:
       cmp       dword ptr [rax+8],0
       jbe       short M01_L02
       mov       rcx,[rax+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       mov       rax,[rax+38]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,55D
       mov       rdx,7FFF60BFF440
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,565
       mov       rdx,7FFF60BFF440
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 266
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.EnumExtensionsPerfTestRunner.GetItems()
;             var testEnum = StringComparison.OrdinalIgnoreCase;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var result = testEnum.GetItems<StringComparison>();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.StringComparison
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+8],5
       mov       rcx,rax
       call      dotNetTips.Utility.Standard.Extensions.EnumExtensions.GetItems[[System.StringComparison, System.Private.CoreLib]](System.Enum)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; dotNetTips.Utility.Standard.Extensions.EnumExtensions.GetItems[[System.StringComparison, System.Private.CoreLib]](System.Enum)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
;             if (enumeration == null)
;             ^^^^^^^^^^^^^^^^^^^^^^^^
       test      rcx,rcx
       je        near ptr M01_L04
;             var enumType = enumeration.GetType();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       call      00007FFFC03F1F60
       mov       rsi,rax
       mov       rcx,rsi
       call      System.Enum.GetValues(System.Type)
       mov       rdi,rax
;             var items = new List<EnumItem<T>>();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Utility.Standard.Extensions.EnumItem`1[[System.StringComparison, System.Private.CoreLib]], dotNetTips.Utility.Standard.Extensions]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,7FFF60910020
       mov       edx,25
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1A471908D40
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
;             for (var itemCount = 0; itemCount < list.Count; itemCount++)
;                  ^^^^^^^^^^^^^^^^^
       xor       ebp,ebp
       mov       rcx,rdi
       mov       r11,7FFF60820428
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C10428]
       test      eax,eax
       jle       near ptr M01_L03
;                 var v = list[itemCount];
;                 ^^^^^^^^^^^^^^^^^^^^^^^^
M01_L00:
       mov       rcx,rdi
       mov       edx,ebp
       mov       r11,7FFF60820430
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C10430]
;                 var enumValue = Enum.Parse(enumType, v.ToString());
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rdx,rax
       lea       rcx,[rsp+30]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       xor       r8d,r8d
       mov       r9d,1
       call      System.Enum.TryParse(System.Type, System.String, Boolean, Boolean, System.Object ByRef)
       mov       rcx,[rsp+30]
       xor       eax,eax
       mov       [rsp+30],rax
;                 items.Add(GetDescriptionInternal<T>(enumValue));
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       call      dotNetTips.Utility.Standard.Extensions.EnumExtensions.GetDescriptionInternal[[System.StringComparison, System.Private.CoreLib]](System.Object)
       mov       r8,rax
       inc       dword ptr [rbx+14]
       mov       rcx,[rbx+8]
       mov       edx,[rbx+10]
       cmp       [rcx+8],edx
       jbe       short M01_L01
       lea       eax,[rdx+1]
       mov       [rbx+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L02
M01_L01:
       mov       rcx,rbx
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L02:
       inc       ebp
       mov       rcx,rdi
       mov       r11,7FFF60820428
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C10428]
       cmp       eax,ebp
       jg        near ptr M01_L00
;             return items;
;             ^^^^^^^^^^^^^
M01_L03:
       mov       rax,rbx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
;                 throw new ArgumentNullException(nameof(enumeration), $"{nameof(enumeration)} is null.");
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,57F
       mov       rdx,7FFF60BFF440
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,597
       mov       rdx,7FFF60BFF440
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
```

