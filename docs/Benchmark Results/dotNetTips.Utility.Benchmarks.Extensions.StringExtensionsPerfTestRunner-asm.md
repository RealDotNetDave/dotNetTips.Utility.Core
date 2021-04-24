## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner.ComputeMD5Hash()
;             var result = LongTestString.ComputeSha256Hash();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,220644A1930
       mov       rcx,[rcx]
       call      dotNetTips.Utility.Standard.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 51
```
```assembly
; dotNetTips.Utility.Standard.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFD8],rax
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
;             using (var sha256Hash = SHA256.Create())
;                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFC8],rdi
       mov       rcx,220744A1820
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C53A68]
       mov       rdx,rax
       mov       rcx,[rbp+0FFC8]
       call      System.Security.Cryptography.HashAlgorithm.ComputeHash(Byte[])
       mov       rsi,rax
;                 var builder = new StringBuilder();
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
;                 for (var i = 0; i < bytes.Length; i++)
;                      ^^^^^^^^^
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M01_L03
;                     builder.Append(bytes[i].ToString("x2", CultureInfo.InvariantCulture));
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rdx,220744A2448
       mov       r8,[rdx]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,220644A1938
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M01_L01
       xor       eax,eax
       xor       r9d,r9d
       jmp       short M01_L02
M01_L01:
       mov       eax,[rdx]
       mov       rax,rdx
       cmp       [rax],eax
       add       rax,0C
       mov       r9d,[rdx+8]
M01_L02:
       lea       rdx,[rbp+0FFD0]
       mov       [rdx],rax
       mov       [rdx+8],r9d
       lea       rdx,[rbp+0FFD0]
       call      System.Number.FormatUInt32(UInt32, System.ReadOnlySpan`1<Char>, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       r14d,ebx
       jg        short M01_L00
;                 return builder.ToString();
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       rcx,rdi
       call      qword ptr [7FFF60C47010]
       mov       rsi,rax
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [7FFF60C45EC8]
;         }
;         ^
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
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L04
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [7FFF60C45EC8]
M01_L04:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 370
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner.Concat()
;             var result = LongTestString.Concat(",", true, "TEST1", "TEST2");
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       r8,24481C410F8
       mov       r8,[r8]
       mov       rcx,rdi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       r8,24481C41100
       mov       r8,[r8]
       mov       rcx,rdi
       mov       edx,1
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,24481C41108
       mov       rcx,[rcx]
       mov       rdx,24471C43100
       mov       rdx,[rdx]
       mov       r9,rdi
       mov       r8d,1
       call      dotNetTips.Utility.Standard.Extensions.StringExtensions.Concat(System.String, System.String, Boolean, System.String[])
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,8
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
; dotNetTips.Utility.Standard.Extensions.StringExtensions.Concat(System.String, System.String, Boolean, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       ebp,r8d
       mov       rsi,r9
;             if (input.IsNullOrEmpty())
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      rbx,rbx
       je        short M01_L00
       cmp       dword ptr [rbx+8],0
       ja        short M01_L01
;                 ExceptionThrower.ThrowArgumentNullException(nameof(input));
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L00:
       mov       rcx,24491C4D120
       mov       rcx,[rcx]
       call      dotNetTips.Utility.Standard.Common.ExceptionThrower.ThrowArgumentNullException(System.String)
;             if (delimiter.IsNullOrEmpty())
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L01:
       test      rdi,rdi
       je        short M01_L02
       cmp       dword ptr [rdi+8],0
       ja        short M01_L03
;                 delimiter = string.Empty;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L02:
       mov       rcx,24471C43060
       mov       rdi,[rcx]
;             var sb = new StringBuilder(input);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,rbx
       test      rdx,rdx
       jne       short M01_L04
       xor       r9d,r9d
       jmp       short M01_L05
M01_L04:
       mov       rdx,rbx
       mov       r9d,[rdx+8]
M01_L05:
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       xor       r8d,r8d
       call      System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
;             if (args.HasItems())
;             ^^^^^^^^^^^^^^^^^^^^
       test      rsi,rsi
       je        short M01_L09
       mov       rcx,rsi
       call      00007FFFC043DA80
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L09
;                 for (var argCount = 0; argCount < args.Length; argCount++)
;                      ^^^^^^^^^^^^^^^^
       xor       ebx,ebx
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M01_L09
       movzx     ebp,bpl
;                     var value = args[argCount];
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L06:
       movsxd    rcx,ebx
       mov       rdx,[rsi+rcx*8+10]
;                     if (addLineFeed)
;                     ^^^^^^^^^^^^^^^^
       test      ebp,ebp
       je        short M01_L07
;                         sb.AppendLine(value);
;                         ^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdx
       mov       rdx,rdi
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M01_L08:
       inc       ebx
       cmp       r15d,ebx
       jg        short M01_L06
;             return sb.ToString();
;             ^^^^^^^^^^^^^^^^^^^^^
M01_L09:
       mov       rcx,r14
       mov       rax,[7FFF60C57010]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
; Total bytes of code 266
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner.ContainsAny()
;             var result = LongTestString.ContainsAny("A", "Z");
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       r8,124A34A1930
       mov       r8,[r8]
       mov       rcx,rdi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       r8,124A34A1938
       mov       r8,[r8]
       mov       rcx,rdi
       mov       edx,1
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,124A34A1940
       mov       rcx,[rcx]
       mov       rdx,rdi
       call      dotNetTips.Utility.Standard.Extensions.StringExtensions.ContainsAny(System.String, System.String[])
       mov       rdx,[rsi+8]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```
```assembly
; dotNetTips.Utility.Standard.Extensions.StringExtensions.ContainsAny(System.String, System.String[])
;             if (input.IsNullOrEmpty())
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 ExceptionThrower.ThrowArgumentNullException(nameof(input));
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             return characters.FastAny(character =>
;             ^^^
;             {
;             ^^^
;                 return input.Contains(character);
;             ^^^
;             });
;             ^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Extensions.StringExtensions+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0
       ja        short M01_L01
M01_L00:
       mov       rcx,124A34A1170
       mov       rcx,[rcx]
       call      dotNetTips.Utility.Standard.Common.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L01:
       mov       rcx,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,offset dotNetTips.Utility.Standard.Extensions.StringExtensions+<>c__DisplayClass3_0.<ContainsAny>b__0(System.String)
       mov       [rsi+18],r8
       mov       r8,rsi
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Utility.Standard.Extensions.CollectionExtensions.FastAny(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       mov       rax,offset dotNetTips.Utility.Standard.Extensions.CollectionExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 156
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner.DefaultIfNull()
;             var result = LongTestString.DefaultIfNull();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,207570C3110
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,207270C3060
       mov       rdx,[rdx]
M00_L00:
       mov       rcx,[rcx+8]
       mov       eax,[rcx]
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       ret
; Total bytes of code 48
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner.DefaultIfNullOrEmpty()
;             var result = LongTestString.DefaultIfNullOrEmpty("David");
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,1DA7E963D80
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L00
       cmp       dword ptr [rdx+8],0
       je        short M00_L00
       jmp       short M00_L01
M00_L00:
       mov       rdx,1DA7E963D88
       mov       rdx,[rdx]
M00_L01:
       mov       rcx,[rcx+8]
       mov       eax,[rcx]
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       ret
; Total bytes of code 56
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner.DelimitedStringToArray()
;             var result = this._commaDelimitedString.DelimitedStringToArray();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       edx,2C
       call      dotNetTips.Utility.Standard.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; dotNetTips.Utility.Standard.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
;             if (input.IsNullOrEmpty())
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 ExceptionThrower.ThrowArgumentNullException(nameof(input));
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             if (delimiter.IsNull())
;             ^^^^^^^^^^^^^^^^^^^^^^^
;                 delimiter = ControlChars.Comma;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             return input.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       edi,edx
       test      rsi,rsi
       je        short M01_L00
       cmp       dword ptr [rsi+8],0
       ja        short M01_L01
M01_L00:
       mov       rcx,2D0E30F1588
       mov       rcx,[rcx]
       call      dotNetTips.Utility.Standard.Common.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L01:
       movzx     edx,di
       mov       rcx,rsi
       mov       r8d,1
       mov       rax,offset dotNetTips.Utility.Standard.Extensions.StringExtensions.Split(System.String, Char, System.StringSplitOptions)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 71
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner.EqualsIgnoreCase()
;             var result = RandomData.GenerateWord(10).EqualsIgnoreCase(RandomData.GenerateWord(5));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,0A
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32)
       mov       rdi,rax
       mov       ecx,5
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,5
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rdx,[rsi+8]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 63
```
```assembly
; dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32)
;             Encapsulation.TryValidateParam(length, minimumValue: 1, paramName: nameof(length));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var returnValue = GenerateWord(length, DefaultMinCharacter, DefaultMaxCharacter);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             return returnValue;
;             ^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rdx,281BA8B3060
       mov       rsi,[rdx]
       test      ecx,ecx
       jle       short M01_L00
       cmp       ecx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       test      edx,edx
       je        short M01_L00
       mov       edx,41
       mov       r8d,7A
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32, Char, Char)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rsi,rsi
       jne       short M01_L01
       call      dotNetTips.Utility.Standard.Properties.Resources.get_NumberNotInRange()
       mov       rsi,rax
M01_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,6B
       mov       rdx,7FFF60BCEFB0
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 137
```
```assembly
; System.String.Equals(System.String, System.String, System.StringComparison)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       cmp       rsi,rdi
       jne       short M02_L00
       cmp       ebx,5
       ja        near ptr M02_L05
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       test      rsi,rsi
       je        short M02_L01
       test      rdi,rdi
       jne       short M02_L03
M02_L01:
       cmp       ebx,5
       ja        near ptr M02_L06
M02_L02:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       cmp       ebx,5
       ja        near ptr M02_L07
       mov       eax,ebx
       lea       rdx,[7FFF60C388C0]
       mov       edx,[rdx+rax*4]
       lea       rcx,[7FFF60C486F1]
       add       rdx,rcx
       jmp       rdx
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r9d,ebx
       and       r9d,1
       mov       rcx,rax
       mov       rdx,rsi
       mov       r8,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       test      eax,eax
       sete      bpl
       movzx     ebp,bpl
       jmp       near ptr M02_L04
       mov       rcx,7FFF60900020
       mov       edx,65C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       r9,281BA8B24A8
       mov       rcx,[r9]
       mov       r9d,ebx
       and       r9d,1
       mov       rdx,rsi
       mov       r8,rdi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       test      eax,eax
       sete      bpl
       movzx     ebp,bpl
       jmp       short M02_L04
       mov       r8d,[rsi+8]
       cmp       r8d,[rdi+8]
       jne       near ptr M02_L02
       lea       rcx,[rsi+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,[rsi+8]
       movsxd    r8,r8d
       shl       r8,1
       mov       rax,offset System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UInt64)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
       mov       ecx,[rsi+8]
       cmp       ecx,[rdi+8]
       jne       near ptr M02_L02
       mov       rcx,rsi
       mov       rdx,rdi
       mov       rax,offset System.String.EqualsOrdinalIgnoreCase(System.String, System.String)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M02_L04:
       movzx     eax,bpl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L05:
       mov       ecx,16
       mov       edx,29
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M02_L06:
       mov       ecx,16
       mov       edx,29
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M02_L07:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0E2A8
       mov       rdx,7FFF60804020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,281BA8B3060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1B8B
       mov       rdx,7FFF60804020
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 477
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner.EqualsOrBothNullOrEmpty()
;             var result = RandomData.GenerateWord(10).EqualsOrBothNullOrEmpty(RandomData.GenerateWord(5));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,0A
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32)
       mov       rdi,rax
       mov       ecx,5
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       mov       rdx,[rsi+8]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 57
```
```assembly
; dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32)
;             Encapsulation.TryValidateParam(length, minimumValue: 1, paramName: nameof(length));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var returnValue = GenerateWord(length, DefaultMinCharacter, DefaultMaxCharacter);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             return returnValue;
;             ^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rdx,2B67A313060
       mov       rsi,[rdx]
       test      ecx,ecx
       jle       short M01_L00
       cmp       ecx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       test      edx,edx
       je        short M01_L00
       mov       edx,41
       mov       r8d,7A
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32, Char, Char)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rsi,rsi
       jne       short M01_L01
       call      dotNetTips.Utility.Standard.Properties.Resources.get_NumberNotInRange()
       mov       rsi,rax
M01_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,6B
       mov       rdx,7FFF60BCEFB0
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 137
```
```assembly
; dotNetTips.Utility.Standard.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
;             return string.Equals(input ?? string.Empty, valueToCompare ?? string.Empty, StringComparison.Ordinal);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      rcx,rcx
       jne       short M02_L00
       mov       rcx,2B67A313060
       mov       rcx,[rcx]
M02_L00:
       test      rdx,rdx
       jne       short M02_L01
       mov       rdx,2B67A313060
       mov       rdx,[rdx]
M02_L01:
       mov       r8d,4
       mov       rax,offset System.String.Equals(System.String, System.String, System.StringComparison)
       jmp       rax
; Total bytes of code 55
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner.FromBase64()
;             var base64 = RandomData.GenerateWord(100).ToBase64();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var result = base64.FromBase64();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,64
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32)
       mov       rcx,rax
       call      dotNetTips.Utility.Standard.Extensions.StringExtensions.ToBase64(System.String)
       mov       rcx,rax
       call      dotNetTips.Utility.Standard.Extensions.StringExtensions.FromBase64(System.String)
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
; dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32)
;             Encapsulation.TryValidateParam(length, minimumValue: 1, paramName: nameof(length));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var returnValue = GenerateWord(length, DefaultMinCharacter, DefaultMaxCharacter);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             return returnValue;
;             ^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rdx,20D252D3060
       mov       rsi,[rdx]
       test      ecx,ecx
       jle       short M01_L00
       cmp       ecx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       test      edx,edx
       je        short M01_L00
       mov       edx,41
       mov       r8d,7A
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32, Char, Char)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rsi,rsi
       jne       short M01_L01
       call      dotNetTips.Utility.Standard.Properties.Resources.get_NumberNotInRange()
       mov       rsi,rax
M01_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,6B
       mov       rdx,7FFF60BDEFB0
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 137
```
```assembly
; dotNetTips.Utility.Standard.Extensions.StringExtensions.ToBase64(System.String)
;             if (value.IsNullOrEmpty())
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 return value;
;                 ^^^^^^^^^^^^^
;                 var encoding = new ASCIIEncoding();
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 return Convert.ToBase64String(encoding.GetBytes(value));
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       je        short M02_L00
       cmp       dword ptr [rsi+8],0
       ja        short M02_L01
M02_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       call      System.Text.EncoderFallback.get_ReplacementFallback()
       lea       rcx,[rdi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      System.Text.DecoderFallback.get_ReplacementFallback()
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFF60C53A68]
       mov       rcx,rax
       mov       rax,offset System.Convert.ToBase64String(Byte[])
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 127
```
```assembly
; dotNetTips.Utility.Standard.Extensions.StringExtensions.FromBase64(System.String)
;             if (input.IsNullOrEmpty())
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 return input;
;                 ^^^^^^^^^^^^^
;                 var encoding = new ASCIIEncoding();
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 return encoding.GetString(Convert.FromBase64String(input));
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       je        short M03_L00
       cmp       dword ptr [rsi+8],0
       ja        short M03_L01
M03_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L01:
       mov       rcx,offset MT_System.Text.ASCIIEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+24],1
       mov       dword ptr [rdi+20],4E9F
       call      System.Text.EncoderFallback.get_ReplacementFallback()
       lea       rcx,[rdi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       call      System.Text.DecoderFallback.get_ReplacementFallback()
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FFF60C53B00]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 123
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner.HasValue()
;             var result = LongTestString.HasValue();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,183E42810F8
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M00_L00
       mov       edx,[rcx]
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(TrimType)
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rdx,[rsi+8]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; System.String.TrimWhiteSpaceHelper(TrimType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx+0FFFF]
       mov       r14d,ebp
       xor       r15d,r15d
       cmp       edi,1
       je        short M01_L05
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M01_L05
M01_L00:
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,0FF
       ja        short M01_L03
       cmp       ecx,20
       je        short M01_L01
       lea       edx,[rcx+0FFF7]
       cmp       edx,4
       jbe       short M01_L01
       cmp       ecx,0A0
       je        short M01_L01
       cmp       ecx,85
       sete      al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       mov       eax,1
M01_L02:
       jmp       short M01_L04
M01_L03:
       xor       edx,edx
       call      System.Globalization.CharUnicodeInfo.InternalGetCategoryValue(Int32, Int32)
       add       eax,0FFFFFFF5
       cmp       eax,2
       setbe     al
       movzx     eax,al
M01_L04:
       test      eax,eax
       je        short M01_L05
       inc       r15d
       cmp       ebx,r15d
       jg        short M01_L00
M01_L05:
       test      edi,edi
       je        short M01_L11
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M01_L11
M01_L06:
       cmp       r14d,ebx
       jae       short M01_L12
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,0FF
       ja        short M01_L09
       cmp       ecx,20
       je        short M01_L07
       lea       edx,[rcx+0FFF7]
       cmp       edx,4
       jbe       short M01_L07
       cmp       ecx,0A0
       je        short M01_L07
       cmp       ecx,85
       sete      al
       movzx     eax,al
       jmp       short M01_L08
M01_L07:
       mov       eax,1
M01_L08:
       jmp       short M01_L10
M01_L09:
       xor       edx,edx
       call      System.Globalization.CharUnicodeInfo.InternalGetCategoryValue(Int32, Int32)
       add       eax,0FFFFFFF5
       cmp       eax,2
       setbe     al
       movzx     eax,al
M01_L10:
       test      eax,eax
       je        short M01_L11
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L06
M01_L11:
       mov       rcx,rsi
       mov       edx,r15d
       mov       r8d,r14d
       mov       rax,offset System.String.CreateTrimmedString(Int32, Int32)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 276
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner.Indent()
;             var result = LongTestString.Indent(10, '>');
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,28B1C3110F8
       mov       rcx,[rcx]
       mov       edx,0A
       mov       r8d,3E
       call      dotNetTips.Utility.Standard.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 62
```
```assembly
; dotNetTips.Utility.Standard.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
;             if (input.IsNullOrEmpty())
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      rdi,rdi
       je        short M01_L00
       cmp       dword ptr [rdi+8],0
       ja        short M01_L01
;                 ExceptionThrower.ThrowArgumentNullException(nameof(input));
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L00:
       mov       rcx,28B2C321588
       mov       rcx,[rcx]
       call      dotNetTips.Utility.Standard.Common.ExceptionThrower.ThrowArgumentNullException(System.String)
;             if (length == 0)
;             ^^^^^^^^^^^^^^^^
M01_L01:
       test      esi,esi
       jne       short M01_L02
;                 ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(length));
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,28B2C3219B8
       mov       rcx,[rcx]
       call      dotNetTips.Utility.Standard.Common.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
;             var sb = new StringBuilder();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       dword ptr [rbp+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
;             if (length < 0)
;             ^^^^^^^^^^^^^^^
       test      esi,esi
       jge       short M01_L03
;                 sb.Append(input);
;                 ^^^^^^^^^^^^^^^^^
       mov       rcx,rbp
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
;             for (var charCount = 1; charCount <= Math.Abs(length); charCount++)
;                  ^^^^^^^^^^^^^^^^^
M01_L03:
       mov       r14d,1
       jmp       short M01_L05
M01_L04:
       movzx     edx,bx
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(Char)
       inc       r14d
M01_L05:
       mov       edx,esi
       test      esi,esi
       jge       short M01_L06
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L08
M01_L06:
       cmp       r14d,edx
       jle       short M01_L04
;             if (length > 0)
;             ^^^^^^^^^^^^^^^
       test      esi,esi
       jle       short M01_L07
;                 sb.Append(input);
;                 ^^^^^^^^^^^^^^^^^
       mov       rcx,rbp
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
;             return sb.ToString();
;             ^^^^^^^^^^^^^^^^^^^^^
M01_L07:
       mov       rcx,rbp
       mov       rax,[7FFF60C27010]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M01_L08:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 226
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner.IsAsciiLetter()
;             var result = RandomData.GenerateCharacter().IsAsciiLetter();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,41
       mov       edx,7A
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateInteger(Int32, Int32)
       movzx     eax,ax
       add       eax,0FFFFFFBF
       and       rax,0FFFFFFFFFFFFFFDF
       cmp       rax,1A
       setl      al
       movzx     eax,al
       mov       rdx,[rsi+8]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 56
```
```assembly
; dotNetTips.Utility.Standard.Tester.RandomData.GenerateInteger(Int32, Int32)
;             lock (_lock)
;             ^^^^^^^^^^^^
;                 return _random.Next(min, max);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         }
;         ^
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       esi,ecx
       mov       edi,edx
       mov       rdx,2863FCE75B0
       mov       rdx,[rdx]
       mov       [rbp+0FFE0],rdx
       xor       edx,edx
       mov       [rbp+0FFE8],edx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M01_L00
       lea       rdx,[rbp+0FFE8]
       mov       rcx,[rbp+0FFE0]
       call      00007FFFC03B88D0
       jmp       short M01_L01
M01_L00:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L01:
       mov       rcx,2863FCE75B8
       mov       rcx,[rcx]
       mov       edx,esi
       mov       r8d,edi
       call      qword ptr [7FFF60C2DAD0]
       mov       esi,eax
       cmp       byte ptr [rbp+0FFE8],0
       je        short M01_L02
       mov       rcx,[rbp+0FFE0]
       call      00007FFFC03B8610
M01_L02:
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
       cmp       byte ptr [rbp+0FFE8],0
       je        short M01_L03
       mov       rcx,[rbp+0FFE0]
       call      00007FFFC03B8610
M01_L03:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 170
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner.IsAsciiLetterOrDigit()
;             var result = RandomData.GenerateCharacter().IsAsciiLetterOrDigit();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,41
       mov       edx,7A
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateInteger(Int32, Int32)
       movzx     ecx,ax
       call      dotNetTips.Utility.Standard.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       mov       rdx,[rsi+8]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
```
```assembly
; dotNetTips.Utility.Standard.Tester.RandomData.GenerateInteger(Int32, Int32)
;             lock (_lock)
;             ^^^^^^^^^^^^
;                 return _random.Next(min, max);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         }
;         ^
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       esi,ecx
       mov       edi,edx
       mov       rdx,28E369355D0
       mov       rdx,[rdx]
       mov       [rbp+0FFE0],rdx
       xor       edx,edx
       mov       [rbp+0FFE8],edx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M01_L00
       lea       rdx,[rbp+0FFE8]
       mov       rcx,[rbp+0FFE0]
       call      00007FFFC03B88D0
       jmp       short M01_L01
M01_L00:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L01:
       mov       rcx,28E369355D8
       mov       rcx,[rcx]
       mov       edx,esi
       mov       r8d,edi
       call      qword ptr [7FFF60C3DAD0]
       mov       esi,eax
       cmp       byte ptr [rbp+0FFE8],0
       je        short M01_L02
       mov       rcx,[rbp+0FFE0]
       call      00007FFFC03B8610
M01_L02:
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
       cmp       byte ptr [rbp+0FFE8],0
       je        short M01_L03
       mov       rcx,[rbp+0FFE0]
       call      00007FFFC03B8610
M01_L03:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 170
```
```assembly
; dotNetTips.Utility.Standard.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
;         { return ( ( ( ( (uint)character ) - 'A' ) & ( ~0x20 ) ) < 26 ) || ( ( (uint)character ) - '0' < 10 ); }
;           ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       movzx     eax,cx
       lea       edx,[rax+0FFBF]
       and       rdx,0FFFFFFFFFFFFFFDF
       cmp       rdx,1A
       jl        short M02_L00
       add       eax,0FFFFFFD0
       cmp       eax,0A
       setb      al
       movzx     eax,al
       ret
M02_L00:
       mov       eax,1
       ret
; Total bytes of code 35
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner.IsWhitespaceChar()
;             var result = RandomData.GenerateCharacter().IsWhitespace();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,41
       mov       edx,7A
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateInteger(Int32, Int32)
       movzx     ecx,ax
       call      dotNetTips.Utility.Standard.Extensions.StringExtensions.IsWhitespace(Char)
       mov       rdx,[rsi+8]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
```
```assembly
; dotNetTips.Utility.Standard.Tester.RandomData.GenerateInteger(Int32, Int32)
;             lock (_lock)
;             ^^^^^^^^^^^^
;                 return _random.Next(min, max);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         }
;         ^
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       esi,ecx
       mov       edi,edx
       mov       rdx,1C308D4BA18
       mov       rdx,[rdx]
       mov       [rbp+0FFE0],rdx
       xor       edx,edx
       mov       [rbp+0FFE8],edx
       cmp       byte ptr [rbp+0FFE8],0
       jne       short M01_L00
       lea       rdx,[rbp+0FFE8]
       mov       rcx,[rbp+0FFE0]
       call      00007FFFC03B88D0
       jmp       short M01_L01
M01_L00:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L01:
       mov       rcx,1C308D4BA20
       mov       rcx,[rcx]
       mov       edx,esi
       mov       r8d,edi
       call      qword ptr [7FFF60C5DAD0]
       mov       esi,eax
       cmp       byte ptr [rbp+0FFE8],0
       je        short M01_L02
       mov       rcx,[rbp+0FFE0]
       call      00007FFFC03B8610
M01_L02:
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
       cmp       byte ptr [rbp+0FFE8],0
       je        short M01_L03
       mov       rcx,[rbp+0FFE0]
       call      00007FFFC03B8610
M01_L03:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 170
```
```assembly
; dotNetTips.Utility.Standard.Extensions.StringExtensions.IsWhitespace(Char)
;             return ( character <= ' ' ) && ( ( character == ' ' ) || ( character == '\t' ) || ( character == '\r' ) || ( character == '\n' ) );
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       movzx     eax,cx
       cmp       eax,20
       jg        short M02_L01
       cmp       eax,20
       je        short M02_L00
       cmp       eax,9
       je        short M02_L00
       cmp       eax,0D
       je        short M02_L00
       cmp       eax,0A
       sete      al
       movzx     eax,al
       ret
M02_L00:
       mov       eax,1
       ret
M02_L01:
       xor       eax,eax
       ret
; Total bytes of code 42
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner.IsWhitespaceString()
;             var result = this._stringToTrim.IsWhitespace();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       call      dotNetTips.Utility.Standard.Extensions.StringExtensions.IsWhitespace(System.String)
       mov       rdx,[rsi+8]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 30
```
```assembly
; dotNetTips.Utility.Standard.Extensions.StringExtensions.IsWhitespace(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
;             if (input.IsNullOrEmpty())
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      rsi,rsi
       je        short M01_L00
       mov       edi,[rsi+8]
       test      edi,edi
       jne       short M01_L01
;                 return false;
;                 ^^^^^^^^^^^^^
M01_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
;             for (var i = 0; i < input.Length; i++)
;                  ^^^^^^^^^
M01_L01:
       xor       ebx,ebx
       mov       edi,[rsi+8]
       test      edi,edi
       jle       short M01_L03
M01_L02:
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       call      dotNetTips.Utility.Standard.Extensions.StringExtensions.IsWhitespace(Char)
       test      eax,eax
       je        short M01_L04
       inc       ebx
       cmp       edi,ebx
       jg        short M01_L02
;             return true;
;             ^^^^^^^^^^^^
M01_L03:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
;                     return false;
;                     ^^^^^^^^^^^^^
M01_L04:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 87
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner.SplitCharSeparator()
;             var result = this._commaDelimitedString.Split(ControlChars.Comma, StringSplitOptions.None);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       dword ptr [rsp+3C],2C
       mov       edx,[rcx]
       lea       rdx,[rsp+3C]
       mov       r8d,1
       lea       r9,[rsp+28]
       mov       [r9],rdx
       mov       [r9+8],r8d
       lea       rdx,[rsp+28]
       mov       r8d,7FFFFFFF
       xor       r9d,r9d
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 101
```
```assembly
; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+30]
       mov       rsi,rcx
       lea       rdi,[rbp+8]
       mov       ecx,10
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rax,1CCC7BCEEA51
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M01_L11
       test      ebx,ebx
       jl        near ptr M01_L12
       cmp       ebx,1
       jg        near ptr M01_L12
       cmp       ebx,1
       sete      bl
       movzx     ebx,bl
       test      edi,edi
       je        short M01_L00
       test      ebx,ebx
       je        short M01_L02
       cmp       dword ptr [rsi+8],0
       jne       short M01_L02
M01_L00:
       mov       rcx,7FFF60910020
       mov       edx,25
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,1BBE46C8D60
       mov       rax,[rax]
       mov       rcx,1CCC7BCEEA51
       cmp       [rbp],rcx
       je        short M01_L01
       call      CORINFO_HELP_FAIL_FAST
M01_L01:
       nop
       lea       rsp,[rbp+48]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       cmp       edi,1
       jne       short M01_L04
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,rsi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rbx
       mov       rcx,1CCC7BCEEA51
       cmp       [rbp],rcx
       je        short M01_L03
       call      CORINFO_HELP_FAIL_FAST
M01_L03:
       nop
       lea       rsp,[rbp+48]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r8,[rsp+30]
       lea       rcx,[rbp+38]
       mov       [rcx],r8
       mov       dword ptr [rcx+8],80
       xor       r8d,r8d
       mov       [rbp+28],r8
       xor       r8d,r8d
       mov       [rbp+30],r8d
       lea       r8,[rbp+28]
       mov       rcx,rsi
       call      System.String.MakeSeparatorList(System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+30]
       mov       ecx,eax
       mov       edx,[rbp+40]
       cmp       rcx,rdx
       ja        near ptr M01_L13
       mov       r8,[rbp+38]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,rsi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rbx
       mov       rcx,1CCC7BCEEA51
       cmp       [rbp],rcx
       je        short M01_L05
       call      CORINFO_HELP_FAIL_FAST
M01_L05:
       nop
       lea       rsp,[rbp+48]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       test      ebx,ebx
       jne       short M01_L07
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitKeepEmptyEntries(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
       jmp       short M01_L08
M01_L07:
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitOmitEmptyEntries(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
M01_L08:
       cmp       qword ptr [rbp+28],0
       je        short M01_L09
       mov       rcx,7FFF60910020
       mov       edx,26
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1BBE46C8D68
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C4D558]
       xor       eax,eax
       mov       [rbp+28],rax
M01_L09:
       mov       rax,r15
       mov       rcx,1CCC7BCEEA51
       cmp       [rbp],rcx
       je        short M01_L10
       call      CORINFO_HELP_FAIL_FAST
M01_L10:
       nop
       lea       rsp,[rbp+48]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1B1F
       mov       rdx,7FFF60814020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,91DA
       mov       rdx,7FFF60814020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,1BBE46C3060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,2C54
       mov       rdx,7FFF60814020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,1BBE46C3060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       rdi,rax
       mov       [rsi+8],ebx
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.SR.Format(System.String, System.Object)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.ArgumentException..ctor(System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 854
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner.SplitCharSeparatorCount()
;             var result = this._commaDelimitedString.Split(ControlChars.Comma, 2, StringSplitOptions.None);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       dword ptr [rsp+3C],2C
       mov       edx,[rcx]
       lea       rdx,[rsp+3C]
       mov       r8d,1
       lea       r9,[rsp+28]
       mov       [r9],rdx
       mov       [r9+8],r8d
       lea       rdx,[rsp+28]
       mov       r8d,2
       xor       r9d,r9d
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 101
```
```assembly
; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+30]
       mov       rsi,rcx
       lea       rdi,[rbp+8]
       mov       ecx,10
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rax,14ABE8FA551E
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M01_L11
       test      ebx,ebx
       jl        near ptr M01_L12
       cmp       ebx,1
       jg        near ptr M01_L12
       cmp       ebx,1
       sete      bl
       movzx     ebx,bl
       test      edi,edi
       je        short M01_L00
       test      ebx,ebx
       je        short M01_L02
       cmp       dword ptr [rsi+8],0
       jne       short M01_L02
M01_L00:
       mov       rcx,7FFF60900020
       mov       edx,25
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,19770B248F8
       mov       rax,[rax]
       mov       rcx,14ABE8FA551E
       cmp       [rbp],rcx
       je        short M01_L01
       call      CORINFO_HELP_FAIL_FAST
M01_L01:
       nop
       lea       rsp,[rbp+48]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       cmp       edi,1
       jne       short M01_L04
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,rsi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rbx
       mov       rcx,14ABE8FA551E
       cmp       [rbp],rcx
       je        short M01_L03
       call      CORINFO_HELP_FAIL_FAST
M01_L03:
       nop
       lea       rsp,[rbp+48]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r8,[rsp+30]
       lea       rcx,[rbp+38]
       mov       [rcx],r8
       mov       dword ptr [rcx+8],80
       xor       r8d,r8d
       mov       [rbp+28],r8
       xor       r8d,r8d
       mov       [rbp+30],r8d
       lea       r8,[rbp+28]
       mov       rcx,rsi
       call      System.String.MakeSeparatorList(System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+30]
       mov       ecx,eax
       mov       edx,[rbp+40]
       cmp       rcx,rdx
       ja        near ptr M01_L13
       mov       r8,[rbp+38]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,rsi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rbx
       mov       rcx,14ABE8FA551E
       cmp       [rbp],rcx
       je        short M01_L05
       call      CORINFO_HELP_FAIL_FAST
M01_L05:
       nop
       lea       rsp,[rbp+48]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       test      ebx,ebx
       jne       short M01_L07
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitKeepEmptyEntries(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
       jmp       short M01_L08
M01_L07:
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitOmitEmptyEntries(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
M01_L08:
       cmp       qword ptr [rbp+28],0
       je        short M01_L09
       mov       rcx,7FFF60900020
       mov       edx,26
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,19770B24900
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C3D558]
       xor       eax,eax
       mov       [rbp+28],rax
M01_L09:
       mov       rax,r15
       mov       rcx,14ABE8FA551E
       cmp       [rbp],rcx
       je        short M01_L10
       call      CORINFO_HELP_FAIL_FAST
M01_L10:
       nop
       lea       rsp,[rbp+48]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1B1F
       mov       rdx,7FFF60804020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,91DA
       mov       rdx,7FFF60804020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,19750B23060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,2C54
       mov       rdx,7FFF60804020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,19750B23060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       rdi,rax
       mov       [rsi+8],ebx
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.SR.Format(System.String, System.Object)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.ArgumentException..ctor(System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 854
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner.SplitCharSeparatorRemoveEmptyEntriesCount()
;             var result = this._commaDelimitedString.Split(ControlChars.Comma, 2, StringSplitOptions.RemoveEmptyEntries);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       dword ptr [rsp+3C],2C
       mov       edx,[rcx]
       lea       rdx,[rsp+3C]
       mov       r8d,1
       lea       r9,[rsp+28]
       mov       [r9],rdx
       mov       [r9+8],r8d
       lea       rdx,[rsp+28]
       mov       r8d,2
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 104
```
```assembly
; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+30]
       mov       rsi,rcx
       lea       rdi,[rbp+8]
       mov       ecx,10
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rax,4D2E08354091
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M01_L11
       test      ebx,ebx
       jl        near ptr M01_L12
       cmp       ebx,1
       jg        near ptr M01_L12
       cmp       ebx,1
       sete      bl
       movzx     ebx,bl
       test      edi,edi
       je        short M01_L00
       test      ebx,ebx
       je        short M01_L02
       cmp       dword ptr [rsi+8],0
       jne       short M01_L02
M01_L00:
       mov       rcx,7FFF608F0020
       mov       edx,25
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,1A6857E48F8
       mov       rax,[rax]
       mov       rcx,4D2E08354091
       cmp       [rbp],rcx
       je        short M01_L01
       call      CORINFO_HELP_FAIL_FAST
M01_L01:
       nop
       lea       rsp,[rbp+48]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       cmp       edi,1
       jne       short M01_L04
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,rsi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rbx
       mov       rcx,4D2E08354091
       cmp       [rbp],rcx
       je        short M01_L03
       call      CORINFO_HELP_FAIL_FAST
M01_L03:
       nop
       lea       rsp,[rbp+48]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r8,[rsp+30]
       lea       rcx,[rbp+38]
       mov       [rcx],r8
       mov       dword ptr [rcx+8],80
       xor       r8d,r8d
       mov       [rbp+28],r8
       xor       r8d,r8d
       mov       [rbp+30],r8d
       lea       r8,[rbp+28]
       mov       rcx,rsi
       call      System.String.MakeSeparatorList(System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+30]
       mov       ecx,eax
       mov       edx,[rbp+40]
       cmp       rcx,rdx
       ja        near ptr M01_L13
       mov       r8,[rbp+38]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,rsi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rbx
       mov       rcx,4D2E08354091
       cmp       [rbp],rcx
       je        short M01_L05
       call      CORINFO_HELP_FAIL_FAST
M01_L05:
       nop
       lea       rsp,[rbp+48]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       test      ebx,ebx
       jne       short M01_L07
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitKeepEmptyEntries(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
       jmp       short M01_L08
M01_L07:
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitOmitEmptyEntries(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
M01_L08:
       cmp       qword ptr [rbp+28],0
       je        short M01_L09
       mov       rcx,7FFF608F0020
       mov       edx,26
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1A6857E4900
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C2D558]
       xor       eax,eax
       mov       [rbp+28],rax
M01_L09:
       mov       rax,r15
       mov       rcx,4D2E08354091
       cmp       [rbp],rcx
       je        short M01_L10
       call      CORINFO_HELP_FAIL_FAST
M01_L10:
       nop
       lea       rsp,[rbp+48]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1B1F
       mov       rdx,7FFF607F4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,91DA
       mov       rdx,7FFF607F4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,1A6757E3060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,2C54
       mov       rdx,7FFF607F4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,1A6757E3060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       rdi,rax
       mov       [rsi+8],ebx
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.SR.Format(System.String, System.Object)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.ArgumentException..ctor(System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 854
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner.SplitCharSeparatorRemoveEmptyEntries()
;             var result = this._commaDelimitedString.Split(ControlChars.Comma, StringSplitOptions.RemoveEmptyEntries);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       dword ptr [rsp+3C],2C
       mov       edx,[rcx]
       lea       rdx,[rsp+3C]
       mov       r8d,1
       lea       r9,[rsp+28]
       mov       [r9],rdx
       mov       [r9+8],r8d
       lea       rdx,[rsp+28]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 104
```
```assembly
; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+30]
       mov       rsi,rcx
       lea       rdi,[rbp+8]
       mov       ecx,10
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rax,9C2663A5B8E3
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M01_L11
       test      ebx,ebx
       jl        near ptr M01_L12
       cmp       ebx,1
       jg        near ptr M01_L12
       cmp       ebx,1
       sete      bl
       movzx     ebx,bl
       test      edi,edi
       je        short M01_L00
       test      ebx,ebx
       je        short M01_L02
       cmp       dword ptr [rsi+8],0
       jne       short M01_L02
M01_L00:
       mov       rcx,7FFF60920020
       mov       edx,25
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,1ADB9036910
       mov       rax,[rax]
       mov       rcx,9C2663A5B8E3
       cmp       [rbp],rcx
       je        short M01_L01
       call      CORINFO_HELP_FAIL_FAST
M01_L01:
       nop
       lea       rsp,[rbp+48]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       cmp       edi,1
       jne       short M01_L04
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,rsi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rbx
       mov       rcx,9C2663A5B8E3
       cmp       [rbp],rcx
       je        short M01_L03
       call      CORINFO_HELP_FAIL_FAST
M01_L03:
       nop
       lea       rsp,[rbp+48]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r8,[rsp+30]
       lea       rcx,[rbp+38]
       mov       [rcx],r8
       mov       dword ptr [rcx+8],80
       xor       r8d,r8d
       mov       [rbp+28],r8
       xor       r8d,r8d
       mov       [rbp+30],r8d
       lea       r8,[rbp+28]
       mov       rcx,rsi
       call      System.String.MakeSeparatorList(System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+30]
       mov       ecx,eax
       mov       edx,[rbp+40]
       cmp       rcx,rdx
       ja        near ptr M01_L13
       mov       r8,[rbp+38]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,rsi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rbx
       mov       rcx,9C2663A5B8E3
       cmp       [rbp],rcx
       je        short M01_L05
       call      CORINFO_HELP_FAIL_FAST
M01_L05:
       nop
       lea       rsp,[rbp+48]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       test      ebx,ebx
       jne       short M01_L07
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitKeepEmptyEntries(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
       jmp       short M01_L08
M01_L07:
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitOmitEmptyEntries(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
M01_L08:
       cmp       qword ptr [rbp+28],0
       je        short M01_L09
       mov       rcx,7FFF60920020
       mov       edx,26
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1ADB9036918
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C5D558]
       xor       eax,eax
       mov       [rbp+28],rax
M01_L09:
       mov       rax,r15
       mov       rcx,9C2663A5B8E3
       cmp       [rbp],rcx
       je        short M01_L10
       call      CORINFO_HELP_FAIL_FAST
M01_L10:
       nop
       lea       rsp,[rbp+48]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1B1F
       mov       rdx,7FFF60824020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,91DA
       mov       rdx,7FFF60824020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,1ADC9033060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,2C54
       mov       rdx,7FFF60824020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,1ADC9033060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       rdi,rax
       mov       [rsi+8],ebx
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.SR.Format(System.String, System.Object)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.ArgumentException..ctor(System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 854
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner.SplitStringSeparator()
;             var result = this._commaDelimitedString.Split(",", StringSplitOptions.None);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       edx,[rcx]
       mov       rdx,16A8B7C3100
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,16A8B7C3060
       mov       rdx,[rdx]
M00_L00:
       xor       r8d,r8d
       mov       [rsp+20],r8d
       xor       r8d,r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 92
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+30]
       mov       rsi,rcx
       lea       rdi,[rbp+8]
       mov       ecx,1C
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rax,0C3FBBF4A8379
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L14
       test      ebx,ebx
       jl        near ptr M01_L15
       cmp       ebx,1
       jg        near ptr M01_L15
       cmp       ebx,1
       sete      r14b
       movzx     r14d,r14b
       test      rdx,rdx
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L01
       test      r8,r8
       je        short M01_L00
       mov       [rbp+0C0],r8
       cmp       dword ptr [r8+8],0
       mov       r8,[rbp+0C0]
       jne       short M01_L01
M01_L00:
       xor       ecx,ecx
       xor       edx,edx
       lea       r8,[rbp+28]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+28]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L01:
       test      edi,edi
       je        short M01_L02
       test      r14d,r14d
       je        short M01_L03
       cmp       dword ptr [rsi+8],0
       jne       short M01_L03
M01_L02:
       mov       rcx,7FFF608E0020
       mov       edx,25
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,16A8B7C8D60
       mov       rax,[rcx]
       jmp       near ptr M01_L12
M01_L03:
       cmp       edi,1
       je        short M01_L04
       test      r15d,r15d
       je        short M01_L05
       cmp       dword ptr [rdx+8],0
       jne       short M01_L05
M01_L04:
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,rsi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,r15
       jmp       near ptr M01_L12
M01_L05:
       test      r15d,r15d
       je        short M01_L06
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L06:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+68]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+58],r9
       xor       r9d,r9d
       mov       [rbp+60],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+48]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+38],r9
       xor       r9d,r9d
       mov       [rbp+40],r9d
       lea       r8,[rbp+58]
       lea       r9,[rbp+38]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+60]
       mov       ecx,eax
       mov       edx,[rbp+70]
       cmp       rcx,rdx
       ja        near ptr M01_L16
       mov       r8,[rbp+68]
       mov       r9d,[rbp+40]
       mov       ecx,r9d
       mov       edx,[rbp+50]
       cmp       rcx,rdx
       ja        near ptr M01_L17
       mov       r10,[rbp+48]
       test      eax,eax
       jne       short M01_L07
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       mov       rcx,r14
       mov       r8,rsi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,r14
       jmp       near ptr M01_L12
M01_L07:
       test      r14d,r14d
       jne       short M01_L08
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       xor       r9d,r9d
       call      System.String.SplitKeepEmptyEntries(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       rbx,rax
       jmp       short M01_L09
M01_L08:
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       xor       r9d,r9d
       call      System.String.SplitOmitEmptyEntries(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       rbx,rax
M01_L09:
       cmp       qword ptr [rbp+58],0
       je        short M01_L10
       mov       rcx,7FFF608E0020
       mov       edx,26
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,16A8B7C8D68
       mov       rcx,[rcx]
       mov       rdx,[rbp+58]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C1D558]
       xor       ecx,ecx
       mov       [rbp+58],rcx
M01_L10:
       cmp       qword ptr [rbp+38],0
       je        short M01_L11
       mov       rcx,7FFF608E0020
       mov       edx,26
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,16A8B7C8D68
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C1D558]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L11:
       mov       rax,rbx
M01_L12:
       mov       rcx,0C3FBBF4A8379
       cmp       [rbp],rcx
       je        short M01_L13
       call      CORINFO_HELP_FAIL_FAST
M01_L13:
       nop
       lea       rsp,[rbp+78]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1B1F
       mov       rdx,7FFF607E4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,91DA
       mov       rdx,7FFF607E4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,16A8B7C3060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,2C54
       mov       rdx,7FFF607E4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,16A8B7C3060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       rdi,rax
       mov       [rsi+8],ebx
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.SR.Format(System.String, System.Object)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.ArgumentException..ctor(System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L17:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 1032
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner.SplitStringSeparatorCount()
;             var result = this._commaDelimitedString.Split(",", 2, StringSplitOptions.None);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       edx,[rcx]
       mov       rdx,1E7D87A3100
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1E7D87A3060
       mov       rdx,[rdx]
M00_L00:
       xor       r8d,r8d
       mov       [rsp+20],r8d
       xor       r8d,r8d
       mov       r9d,2
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 92
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+30]
       mov       rsi,rcx
       lea       rdi,[rbp+8]
       mov       ecx,1C
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rax,5BD008FB4E7C
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L14
       test      ebx,ebx
       jl        near ptr M01_L15
       cmp       ebx,1
       jg        near ptr M01_L15
       cmp       ebx,1
       sete      r14b
       movzx     r14d,r14b
       test      rdx,rdx
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L01
       test      r8,r8
       je        short M01_L00
       mov       [rbp+0C0],r8
       cmp       dword ptr [r8+8],0
       mov       r8,[rbp+0C0]
       jne       short M01_L01
M01_L00:
       xor       ecx,ecx
       xor       edx,edx
       lea       r8,[rbp+28]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+28]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L01:
       test      edi,edi
       je        short M01_L02
       test      r14d,r14d
       je        short M01_L03
       cmp       dword ptr [rsi+8],0
       jne       short M01_L03
M01_L02:
       mov       rcx,7FFF60910020
       mov       edx,25
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1E7C87A48F8
       mov       rax,[rcx]
       jmp       near ptr M01_L12
M01_L03:
       cmp       edi,1
       je        short M01_L04
       test      r15d,r15d
       je        short M01_L05
       cmp       dword ptr [rdx+8],0
       jne       short M01_L05
M01_L04:
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,rsi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,r15
       jmp       near ptr M01_L12
M01_L05:
       test      r15d,r15d
       je        short M01_L06
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L06:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+68]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+58],r9
       xor       r9d,r9d
       mov       [rbp+60],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+48]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+38],r9
       xor       r9d,r9d
       mov       [rbp+40],r9d
       lea       r8,[rbp+58]
       lea       r9,[rbp+38]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+60]
       mov       ecx,eax
       mov       edx,[rbp+70]
       cmp       rcx,rdx
       ja        near ptr M01_L16
       mov       r8,[rbp+68]
       mov       r9d,[rbp+40]
       mov       ecx,r9d
       mov       edx,[rbp+50]
       cmp       rcx,rdx
       ja        near ptr M01_L17
       mov       r10,[rbp+48]
       test      eax,eax
       jne       short M01_L07
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       mov       rcx,r14
       mov       r8,rsi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,r14
       jmp       near ptr M01_L12
M01_L07:
       test      r14d,r14d
       jne       short M01_L08
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       xor       r9d,r9d
       call      System.String.SplitKeepEmptyEntries(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       rbx,rax
       jmp       short M01_L09
M01_L08:
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       xor       r9d,r9d
       call      System.String.SplitOmitEmptyEntries(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       rbx,rax
M01_L09:
       cmp       qword ptr [rbp+58],0
       je        short M01_L10
       mov       rcx,7FFF60910020
       mov       edx,26
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1E7C87A4900
       mov       rcx,[rcx]
       mov       rdx,[rbp+58]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C4D558]
       xor       ecx,ecx
       mov       [rbp+58],rcx
M01_L10:
       cmp       qword ptr [rbp+38],0
       je        short M01_L11
       mov       rcx,7FFF60910020
       mov       edx,26
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1E7C87A4900
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C4D558]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L11:
       mov       rax,rbx
M01_L12:
       mov       rcx,5BD008FB4E7C
       cmp       [rbp],rcx
       je        short M01_L13
       call      CORINFO_HELP_FAIL_FAST
M01_L13:
       nop
       lea       rsp,[rbp+78]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1B1F
       mov       rdx,7FFF60814020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,91DA
       mov       rdx,7FFF60814020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,1E7D87A3060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,2C54
       mov       rdx,7FFF60814020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,1E7D87A3060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       rdi,rax
       mov       [rsi+8],ebx
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.SR.Format(System.String, System.Object)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.ArgumentException..ctor(System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L17:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 1032
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner.SplitStringSeparatorRemoveEmptyEntriesCount()
;             var result = this._commaDelimitedString.Split(",", 2, StringSplitOptions.RemoveEmptyEntries);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       edx,[rcx]
       mov       rdx,1DBFE333100
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1DBFE333060
       mov       rdx,[rdx]
M00_L00:
       mov       dword ptr [rsp+20],1
       xor       r8d,r8d
       mov       r9d,2
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 92
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+30]
       mov       rsi,rcx
       lea       rdi,[rbp+8]
       mov       ecx,1C
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rax,0AFB02AF71BF7
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L14
       test      ebx,ebx
       jl        near ptr M01_L15
       cmp       ebx,1
       jg        near ptr M01_L15
       cmp       ebx,1
       sete      r14b
       movzx     r14d,r14b
       test      rdx,rdx
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L01
       test      r8,r8
       je        short M01_L00
       mov       [rbp+0C0],r8
       cmp       dword ptr [r8+8],0
       mov       r8,[rbp+0C0]
       jne       short M01_L01
M01_L00:
       xor       ecx,ecx
       xor       edx,edx
       lea       r8,[rbp+28]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+28]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L01:
       test      edi,edi
       je        short M01_L02
       test      r14d,r14d
       je        short M01_L03
       cmp       dword ptr [rsi+8],0
       jne       short M01_L03
M01_L02:
       mov       rcx,7FFF60900020
       mov       edx,25
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1DBFE338D60
       mov       rax,[rcx]
       jmp       near ptr M01_L12
M01_L03:
       cmp       edi,1
       je        short M01_L04
       test      r15d,r15d
       je        short M01_L05
       cmp       dword ptr [rdx+8],0
       jne       short M01_L05
M01_L04:
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,rsi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,r15
       jmp       near ptr M01_L12
M01_L05:
       test      r15d,r15d
       je        short M01_L06
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L06:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+68]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+58],r9
       xor       r9d,r9d
       mov       [rbp+60],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+48]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+38],r9
       xor       r9d,r9d
       mov       [rbp+40],r9d
       lea       r8,[rbp+58]
       lea       r9,[rbp+38]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+60]
       mov       ecx,eax
       mov       edx,[rbp+70]
       cmp       rcx,rdx
       ja        near ptr M01_L16
       mov       r8,[rbp+68]
       mov       r9d,[rbp+40]
       mov       ecx,r9d
       mov       edx,[rbp+50]
       cmp       rcx,rdx
       ja        near ptr M01_L17
       mov       r10,[rbp+48]
       test      eax,eax
       jne       short M01_L07
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       mov       rcx,r14
       mov       r8,rsi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,r14
       jmp       near ptr M01_L12
M01_L07:
       test      r14d,r14d
       jne       short M01_L08
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       xor       r9d,r9d
       call      System.String.SplitKeepEmptyEntries(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       rbx,rax
       jmp       short M01_L09
M01_L08:
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       xor       r9d,r9d
       call      System.String.SplitOmitEmptyEntries(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       rbx,rax
M01_L09:
       cmp       qword ptr [rbp+58],0
       je        short M01_L10
       mov       rcx,7FFF60900020
       mov       edx,26
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1DBFE338D68
       mov       rcx,[rcx]
       mov       rdx,[rbp+58]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C3D558]
       xor       ecx,ecx
       mov       [rbp+58],rcx
M01_L10:
       cmp       qword ptr [rbp+38],0
       je        short M01_L11
       mov       rcx,7FFF60900020
       mov       edx,26
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1DBFE338D68
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C3D558]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L11:
       mov       rax,rbx
M01_L12:
       mov       rcx,0AFB02AF71BF7
       cmp       [rbp],rcx
       je        short M01_L13
       call      CORINFO_HELP_FAIL_FAST
M01_L13:
       nop
       lea       rsp,[rbp+78]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1B1F
       mov       rdx,7FFF60804020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,91DA
       mov       rdx,7FFF60804020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,1DBFE333060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,2C54
       mov       rdx,7FFF60804020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,1DBFE333060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       rdi,rax
       mov       [rsi+8],ebx
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.SR.Format(System.String, System.Object)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.ArgumentException..ctor(System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L17:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 1032
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner.SplitStringSeparatorRemoveEmptyEntries()
;             var result = this._commaDelimitedString.Split(",", StringSplitOptions.RemoveEmptyEntries);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       edx,[rcx]
       mov       rdx,15F8AF03100
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,15F8AF03060
       mov       rdx,[rdx]
M00_L00:
       mov       dword ptr [rsp+20],1
       xor       r8d,r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 92
```
```assembly
; System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+30]
       mov       rsi,rcx
       lea       rdi,[rbp+8]
       mov       ecx,1C
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rax,7A41FA1527E0
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L14
       test      ebx,ebx
       jl        near ptr M01_L15
       cmp       ebx,1
       jg        near ptr M01_L15
       cmp       ebx,1
       sete      r14b
       movzx     r14d,r14b
       test      rdx,rdx
       setne     r15b
       movzx     r15d,r15b
       test      r15d,r15d
       jne       short M01_L01
       test      r8,r8
       je        short M01_L00
       mov       [rbp+0C0],r8
       cmp       dword ptr [r8+8],0
       mov       r8,[rbp+0C0]
       jne       short M01_L01
M01_L00:
       xor       ecx,ecx
       xor       edx,edx
       lea       r8,[rbp+28]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+28]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L01:
       test      edi,edi
       je        short M01_L02
       test      r14d,r14d
       je        short M01_L03
       cmp       dword ptr [rsi+8],0
       jne       short M01_L03
M01_L02:
       mov       rcx,7FFF60910020
       mov       edx,25
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,15F8AF08D60
       mov       rax,[rcx]
       jmp       near ptr M01_L12
M01_L03:
       cmp       edi,1
       je        short M01_L04
       test      r15d,r15d
       je        short M01_L05
       cmp       dword ptr [rdx+8],0
       jne       short M01_L05
M01_L04:
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,rsi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,r15
       jmp       near ptr M01_L12
M01_L05:
       test      r15d,r15d
       je        short M01_L06
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L12
M01_L06:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+68]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+58],r9
       xor       r9d,r9d
       mov       [rbp+60],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+48]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+38],r9
       xor       r9d,r9d
       mov       [rbp+40],r9d
       lea       r8,[rbp+58]
       lea       r9,[rbp+38]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+60]
       mov       ecx,eax
       mov       edx,[rbp+70]
       cmp       rcx,rdx
       ja        near ptr M01_L16
       mov       r8,[rbp+68]
       mov       r9d,[rbp+40]
       mov       ecx,r9d
       mov       edx,[rbp+50]
       cmp       rcx,rdx
       ja        near ptr M01_L17
       mov       r10,[rbp+48]
       test      eax,eax
       jne       short M01_L07
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       mov       rcx,r14
       mov       r8,rsi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,r14
       jmp       near ptr M01_L12
M01_L07:
       test      r14d,r14d
       jne       short M01_L08
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       xor       r9d,r9d
       call      System.String.SplitKeepEmptyEntries(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       rbx,rax
       jmp       short M01_L09
M01_L08:
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       xor       r9d,r9d
       call      System.String.SplitOmitEmptyEntries(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       rbx,rax
M01_L09:
       cmp       qword ptr [rbp+58],0
       je        short M01_L10
       mov       rcx,7FFF60910020
       mov       edx,26
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,15F8AF08D68
       mov       rcx,[rcx]
       mov       rdx,[rbp+58]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C4D558]
       xor       ecx,ecx
       mov       [rbp+58],rcx
M01_L10:
       cmp       qword ptr [rbp+38],0
       je        short M01_L11
       mov       rcx,7FFF60910020
       mov       edx,26
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,15F8AF08D68
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C4D558]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L11:
       mov       rax,rbx
M01_L12:
       mov       rcx,7A41FA1527E0
       cmp       [rbp],rcx
       je        short M01_L13
       call      CORINFO_HELP_FAIL_FAST
M01_L13:
       nop
       lea       rsp,[rbp+78]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1B1F
       mov       rdx,7FFF60814020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,91DA
       mov       rdx,7FFF60814020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,15F8AF03060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,2C54
       mov       rdx,7FFF60814020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,15F8AF03060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       rdi,rax
       mov       [rsi+8],ebx
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.SR.Format(System.String, System.Object)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.ArgumentException..ctor(System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L17:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 1032
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner.StartsWithOrdinal()
;             var result = RandomData.GenerateWord(10).StartsWithOrdinal(RandomData.GenerateWord(5));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,0A
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32)
       mov       rdi,rax
       mov       ecx,5
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+8]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 57
```
```assembly
; dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32)
;             Encapsulation.TryValidateParam(length, minimumValue: 1, paramName: nameof(length));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var returnValue = GenerateWord(length, DefaultMinCharacter, DefaultMaxCharacter);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             return returnValue;
;             ^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rdx,1F57A9A3060
       mov       rsi,[rdx]
       test      ecx,ecx
       jle       short M01_L00
       cmp       ecx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       test      edx,edx
       je        short M01_L00
       mov       edx,41
       mov       r8d,7A
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32, Char, Char)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rsi,rsi
       jne       short M01_L01
       call      dotNetTips.Utility.Standard.Properties.Resources.get_NumberNotInRange()
       mov       rsi,rax
M01_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,6B
       mov       rdx,7FFF60BEEFB0
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 137
```
```assembly
; dotNetTips.Utility.Standard.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
;             if (input.IsNullOrEmpty() || valueToCompare.IsNullOrEmpty())
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 return false;
;                 ^^^^^^^^^^^^^
;             return 0 == string.Compare(input, 0, valueToCompare, 0, valueToCompare.Length, StringComparison.Ordinal);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,38
       test      rcx,rcx
       je        short M02_L00
       cmp       dword ptr [rcx+8],0
       jbe       short M02_L00
       test      rdx,rdx
       je        short M02_L00
       cmp       dword ptr [rdx+8],0
       ja        short M02_L01
M02_L00:
       xor       eax,eax
       add       rsp,38
       ret
M02_L01:
       mov       r8d,[rdx+8]
       mov       [rsp+20],r8d
       mov       dword ptr [rsp+28],4
       mov       r8,rdx
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       ret
; Total bytes of code 76
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner.StartsWithOrdinalIgnoreCase()
;             var result = RandomData.GenerateWord(10).StartsWithOrdinalIgnoreCase(RandomData.GenerateWord(5));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,0A
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32)
       mov       rdi,rax
       mov       ecx,5
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+8]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 57
```
```assembly
; dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32)
;             Encapsulation.TryValidateParam(length, minimumValue: 1, paramName: nameof(length));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var returnValue = GenerateWord(length, DefaultMinCharacter, DefaultMaxCharacter);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             return returnValue;
;             ^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rdx,258644B3060
       mov       rsi,[rdx]
       test      ecx,ecx
       jle       short M01_L00
       cmp       ecx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       test      edx,edx
       je        short M01_L00
       mov       edx,41
       mov       r8d,7A
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32, Char, Char)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rsi,rsi
       jne       short M01_L01
       call      dotNetTips.Utility.Standard.Properties.Resources.get_NumberNotInRange()
       mov       rsi,rax
M01_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,6B
       mov       rdx,7FFF60BDEFB0
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 137
```
```assembly
; dotNetTips.Utility.Standard.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
;             if (input.IsNullOrEmpty() || valueToCompare.IsNullOrEmpty())
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 return false;
;                 ^^^^^^^^^^^^^
;             return 0 ==
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 string.Compare(input, 0, valueToCompare, 0, valueToCompare.Length, StringComparison.OrdinalIgnoreCase);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,38
       test      rcx,rcx
       je        short M02_L00
       cmp       dword ptr [rcx+8],0
       jbe       short M02_L00
       test      rdx,rdx
       je        short M02_L00
       cmp       dword ptr [rdx+8],0
       ja        short M02_L01
M02_L00:
       xor       eax,eax
       add       rsp,38
       ret
M02_L01:
       mov       r8d,[rdx+8]
       mov       [rsp+20],r8d
       mov       dword ptr [rsp+28],5
       mov       r8,rdx
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       ret
; Total bytes of code 76
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner.SubstringTrim()
;             var result = RandomData.GenerateWord(100).SubstringTrim(25, 25);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,64
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32)
       mov       rcx,rax
       mov       edx,19
       mov       r8d,19
       call      dotNetTips.Utility.Standard.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 62
```
```assembly
; dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32)
;             Encapsulation.TryValidateParam(length, minimumValue: 1, paramName: nameof(length));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var returnValue = GenerateWord(length, DefaultMinCharacter, DefaultMaxCharacter);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             return returnValue;
;             ^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rdx,23514663060
       mov       rsi,[rdx]
       test      ecx,ecx
       jle       short M01_L00
       cmp       ecx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       test      edx,edx
       je        short M01_L00
       mov       edx,41
       mov       r8d,7A
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32, Char, Char)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rsi,rsi
       jne       short M01_L01
       call      dotNetTips.Utility.Standard.Properties.Resources.get_NumberNotInRange()
       mov       rsi,rax
M01_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,6B
       mov       rdx,7FFF60BDEFB0
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 137
```
```assembly
; dotNetTips.Utility.Standard.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
;             if (input.IsNullOrEmpty())
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      rdi,rdi
       je        short M02_L00
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jne       short M02_L01
;                 ExceptionThrower.ThrowArgumentNullException(nameof(input));
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M02_L00:
       mov       rcx,23544661170
       mov       rcx,[rcx]
       call      dotNetTips.Utility.Standard.Common.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       mov       ecx,esi
       neg       ecx
       shr       ecx,1F
       mov       eax,esi
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M02_L02
;                 ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(startIndex));
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,235446616C0
       mov       rcx,[rcx]
       call      dotNetTips.Utility.Standard.Common.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M02_L02:
       mov       ecx,ebx
       neg       ecx
       shr       ecx,1F
       mov       eax,ebx
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M02_L03
;                 ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(length));
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,235446615A0
       mov       rcx,[rcx]
       call      dotNetTips.Utility.Standard.Common.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
;             if (startIndex >= input.Length - length)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M02_L03:
       mov       ebp,[rdi+8]
       mov       eax,ebp
       sub       eax,ebx
       cmp       eax,esi
       jle       near ptr M02_L20
;             if (length == 0)
;             ^^^^^^^^^^^^^^^^
       test      ebx,ebx
       jne       short M02_L04
;                 return string.Empty;
;                 ^^^^^^^^^^^^^^^^^^^^
       mov       rax,23514663060
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
;             var endIndex = startIndex + length - 1;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M02_L04:
       lea       ebx,[rsi+rbx+0FFFF]
       jmp       short M02_L06
;                 startIndex++;
;                 ^^^^^^^^^^^^^
M02_L05:
       inc       esi
;             while (( startIndex <= endIndex ) && char.IsWhiteSpace(input[startIndex]))
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M02_L06:
       cmp       esi,ebx
       jg        short M02_L12
       cmp       esi,ebp
       jae       near ptr M02_L21
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,0FF
       ja        short M02_L09
       cmp       ecx,20
       je        short M02_L07
       lea       edx,[rcx+0FFF7]
       cmp       edx,4
       jbe       short M02_L07
       cmp       ecx,0A0
       je        short M02_L07
       cmp       ecx,85
       sete      al
       movzx     eax,al
       jmp       short M02_L08
M02_L07:
       mov       eax,1
M02_L08:
       jmp       short M02_L10
M02_L09:
       xor       edx,edx
       call      System.Globalization.CharUnicodeInfo.InternalGetCategoryValue(Int32, Int32)
       add       eax,0FFFFFFF5
       cmp       eax,2
       setbe     al
       movzx     eax,al
M02_L10:
       test      eax,eax
       jne       short M02_L05
       jmp       short M02_L12
;                 endIndex--;
;                 ^^^^^^^^^^^
M02_L11:
       dec       ebx
;             while (( endIndex >= startIndex ) && char.IsWhiteSpace(input[endIndex]))
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M02_L12:
       cmp       ebx,esi
       jl        short M02_L17
       cmp       ebx,ebp
       jae       near ptr M02_L21
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,0FF
       ja        short M02_L15
       cmp       ecx,20
       je        short M02_L13
       lea       edx,[rcx+0FFF7]
       cmp       edx,4
       jbe       short M02_L13
       cmp       ecx,0A0
       je        short M02_L13
       cmp       ecx,85
       sete      al
       movzx     eax,al
       jmp       short M02_L14
M02_L13:
       mov       eax,1
M02_L14:
       jmp       short M02_L16
M02_L15:
       xor       edx,edx
       call      System.Globalization.CharUnicodeInfo.InternalGetCategoryValue(Int32, Int32)
       add       eax,0FFFFFFF5
       cmp       eax,2
       setbe     al
       movzx     eax,al
M02_L16:
       test      eax,eax
       jne       short M02_L11
;             var newLength = endIndex - startIndex + 1;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M02_L17:
       mov       r8d,ebx
       sub       r8d,esi
       inc       r8d
;             if (newLength == 0)
;             ^^^^^^^^^^^^^^^^^^^
       test      r8d,r8d
       jne       short M02_L18
;                 return string.Empty;
;                 ^^^^^^^^^^^^^^^^^^^^
       mov       rax,23514663060
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
;                 return ( newLength == input.Length ) ? input : input.Substring(startIndex, newLength);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M02_L18:
       cmp       ebp,r8d
       je        short M02_L19
       mov       rcx,rdi
       mov       edx,esi
       mov       rax,offset System.String.Substring(Int32, Int32)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M02_L19:
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
;                 throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex + length must be <= value.Length");
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M02_L20:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,11E3
       mov       rdx,7FFF60BF6290
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,11F9
       mov       rdx,7FFF60BF6290
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 528
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner.ToTitleCase()
;             var words = RandomData.GenerateWords(10, 10, 10)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 .ToDelimitedString(ControlChars.Space);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(words.ToTitleCase());
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,0A
       mov       edx,0A
       mov       r8d,0A
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Utility.Standard.Extensions.CollectionExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,20
       call      dotNetTips.Utility.Standard.Extensions.CollectionExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       mov       rcx,rax
       mov       rsi,[rsi+8]
       call      dotNetTips.Utility.Standard.Extensions.StringExtensions.ToTitleCase(System.String)
       mov       edx,[rsi]
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 86
```
```assembly
; dotNetTips.Utility.Standard.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
;             Encapsulation.TryValidateParam(count, minimumValue: 1, paramName: nameof(count));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,20B93743060
       mov       rbp,[rcx]
       test      esi,esi
       jle       near ptr M01_L04
       cmp       esi,7FFFFFFF
       setle     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L04
;             var strings = new List<string>();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,20B93748CD8
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
;             for (var wordCount = 0; wordCount < count; wordCount++)
;                  ^^^^^^^^^^^^^^^^^
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L02
M01_L00:
       mov       ecx,edi
       mov       edx,ebx
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L03
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
M01_L01:
       inc       r14d
       cmp       r14d,esi
       jl        short M01_L00
M01_L02:
       mov       rdx,rbp
       mov       rcx,offset MD_System.Collections.Immutable.ImmutableList.ToImmutableList(System.Collections.Generic.IEnumerable`1<!!0>)
       mov       rax,offset System.Collections.Immutable.ImmutableList.ToImmutableList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M01_L03:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M01_L01
M01_L04:
       test      rbp,rbp
       jne       short M01_L05
       call      dotNetTips.Utility.Standard.Properties.Resources.get_NumberNotInRange()
       mov       rbp,rax
M01_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFF60BCEFB0
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 274
```
```assembly
; dotNetTips.Utility.Standard.Extensions.CollectionExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
;             if (list.HasItems() == false)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 return string.Empty;
;                 ^^^^^^^^^^^^^^^^^^^^
;             var sb = new StringBuilder();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             list.ToList()
;             ^^^^^^^
;                 .ForEach(item =>
;             ^^^^^^^
;                 {
;             ^^^^^^^
;                     if (sb.Length > 0)
;             ^^^^^^^
;                     {
;             ^^^^^^^
;                         sb.Append(delimiter.ToString(CultureInfo.CurrentCulture));
;             ^^^^^^^
;                     }
;             ^^^^^^^
; 
;             ^^^^^^^
;                     sb.Append(item.ToString());
;             ^^^^^^^
;                 });
;             ^^^^^^^
;             return sb.ToString();
;             ^^^^^^^^^^^^^^^^^^^^^
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+8]
       test      rcx,rcx
       jne       short M02_L00
       mov       rcx,rsi
       mov       rdx,7FFF60CA0CD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L00:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M02_L01
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Extensions.CollectionExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
M02_L01:
       mov       rax,20B93743060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       test      rcx,rcx
       jne       short M02_L03
       mov       rcx,rsi
       mov       rdx,7FFF60CA0D90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+18]
       test      rcx,rcx
       jne       short M02_L04
       mov       rcx,rsi
       mov       rdx,7FFF60CA0ED0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Standard.Extensions.CollectionExtensions+<>c__DisplayClass61_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rax,[7FFF60C47010]
       cmp       [rcx],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
; Total bytes of code 333
```
```assembly
; dotNetTips.Utility.Standard.Extensions.StringExtensions.ToTitleCase(System.String)
;             if (input.IsNullOrEmpty())
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 ExceptionThrower.ThrowArgumentNullException(nameof(input));
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      rsi,rsi
       je        short M03_L00
       cmp       dword ptr [rsi+8],0
       ja        short M03_L01
M03_L00:
       mov       rcx,20BB3741170
       mov       rcx,[rcx]
       call      dotNetTips.Utility.Standard.Common.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,offset System.Globalization.TextInfo.ToTitleCase(System.String)
       cmp       [rcx],ecx
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 81
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner.ToTrimmedString()
;             var result = this._stringToTrim.ToTrimmed();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       call      dotNetTips.Utility.Standard.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; dotNetTips.Utility.Standard.Extensions.StringExtensions.ToTrimmed(System.String)
;             if (input.IsNullOrEmpty())
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 ExceptionThrower.ThrowArgumentNullException(nameof(input));
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             return input.TrimEnd().TrimStart();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      rsi,rsi
       je        short M01_L00
       cmp       dword ptr [rsi+8],0
       ja        short M01_L01
M01_L00:
       mov       rcx,198B7A5D120
       mov       rcx,[rcx]
       call      dotNetTips.Utility.Standard.Common.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L01:
       mov       rdx,198B7A54868
       mov       rdx,[rdx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.String.TrimEnd(Char[])
       mov       rcx,rax
       mov       rdx,198B7A54868
       mov       rdx,[rdx]
       mov       rax,offset System.String.TrimStart(Char[])
       cmp       [rcx],ecx
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 96
```

