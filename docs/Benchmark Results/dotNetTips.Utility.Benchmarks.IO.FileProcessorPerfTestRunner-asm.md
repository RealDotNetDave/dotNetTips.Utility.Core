## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.IO.FileProcessorPerfTestRunner.CopyFilesWithEvent()
;             var processor = new FileProcessor();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             processor.Processed += this.Processor_Processed;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             processor.CopyFiles(this._tempFiles, new DirectoryInfo(Path.GetTempPath()));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             processor.Processed -= this.Processor_Processed;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         }
;         ^
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.IO.FileProcessor
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.EventHandler`1[[dotNetTips.Utility.Standard.IO.FileProgressEventArgs, dotNetTips.Utility.Standard]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      rsi,rsi
       je        near ptr M00_L00
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.IO.FileProcessorPerfTestRunner.Processor_Processed(System.Object, dotNetTips.Utility.Standard.IO.FileProgressEventArgs)
       mov       [rbx+18],rcx
       mov       rcx,rdi
       mov       rdx,rbx
       call      dotNetTips.Utility.Standard.IO.FileProcessor.add_Processed(System.EventHandler`1<dotNetTips.Utility.Standard.IO.FileProgressEventArgs>)
       mov       rbx,[rsi+38]
       mov       rcx,offset MT_System.IO.DirectoryInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      System.IO.Path.GetTempPath()
       mov       r14,rax
       mov       dword ptr [rbp+20],0FFFFFFFF
       mov       rcx,r14
       call      System.IO.Path.GetFullPath(System.String)
       mov       r8,rax
       mov       dword ptr [rsp+20],1
       mov       rdx,r14
       mov       rcx,rbp
       xor       r9d,r9d
       call      System.IO.DirectoryInfo.Init(System.String, System.String, System.String, Boolean)
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,rbp
       call      dotNetTips.Utility.Standard.IO.FileProcessor.CopyFiles(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>, System.IO.DirectoryInfo)
       mov       rcx,offset MT_System.EventHandler`1[[dotNetTips.Utility.Standard.IO.FileProgressEventArgs, dotNetTips.Utility.Standard]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.IO.FileProcessorPerfTestRunner.Processor_Processed(System.Object, dotNetTips.Utility.Standard.IO.FileProgressEventArgs)
       mov       [rbx+18],rcx
       mov       rcx,rdi
       mov       rdx,rbx
       mov       rax,offset dotNetTips.Utility.Standard.IO.FileProcessor.remove_Processed(System.EventHandler`1<dotNetTips.Utility.Standard.IO.FileProgressEventArgs>)
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M00_L00:
       mov       rcx,rbx
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 261
```
```assembly
; dotNetTips.Utility.Benchmarks.IO.FileProcessorPerfTestRunner.Processor_Processed(System.Object, dotNetTips.Utility.Standard.IO.FileProgressEventArgs)
;             base.Consumer.Consume(e.Message);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             this._filesToDelete.Add(e.Name);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       mov       rsi,rcx
       mov       rdi,r8
       mov       rcx,[rsi+8]
       mov       rdx,[rdi+8]
       mov       eax,[rcx]
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rsi+28]
       mov       rdx,[rdi+10]
       mov       rax,offset dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       cmp       [rcx],ecx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 52
```
```assembly
; dotNetTips.Utility.Standard.IO.FileProcessor.add_Processed(System.EventHandler`1<dotNetTips.Utility.Standard.IO.FileProgressEventArgs>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+8]
M02_L00:
       test      rbx,rbx
       jne       short M02_L01
       mov       rdx,rdi
       jmp       short M02_L02
M02_L01:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFF60BFFB70]
       mov       rdx,rax
M02_L02:
       mov       rax,rdx
       test      rax,rax
       je        short M02_L03
       mov       rcx,offset MT_System.EventHandler`1[[dotNetTips.Utility.Standard.IO.FileProgressEventArgs, dotNetTips.Utility.Standard]]
       cmp       [rax],rcx
       je        short M02_L03
       call      CORINFO_HELP_CHKCASTCLASS_SPECIAL
M02_L03:
       lea       rcx,[rsi+8]
       mov       rdx,rax
       mov       r8,rbx
       call      00007FFFC0418AA0
       cmp       rax,rbx
       mov       rbx,rax
       jne       short M02_L00
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 101
```
```assembly
; System.IO.Path.GetTempPath()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,50
       vzeroupper
       lea       rbp,[rsp+20]
       xor       eax,eax
       mov       [rbp+10],rax
       mov       [rbp+20],rax
       mov       rax,0FC06E0DE5F67
       mov       [rbp+8],rax
       add       rsp,20
       test      esp,[rsp]
       sub       rsp,210
       sub       rsp,20
       lea       rcx,[rsp+20]
       xor       eax,eax
       mov       [rbp+10],rax
       lea       rax,[rbp+20]
       mov       [rax],rcx
       mov       dword ptr [rax+8],104
       xor       ecx,ecx
       mov       [rbp+18],ecx
       lea       rcx,[rbp+10]
       call      System.IO.Path.GetTempPath(System.Text.ValueStringBuilder ByRef)
       lea       rcx,[rbp+10]
       call      System.IO.PathHelper.Normalize(System.Text.ValueStringBuilder ByRef)
       mov       rsi,rax
       mov       rdi,[rbp+10]
       lea       rcx,[rbp+10]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       vmovdqu   xmmword ptr [rcx+10],xmm0
       test      rdi,rdi
       je        short M03_L00
       mov       rcx,7FFF608F0020
       mov       edx,26
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1ECE65948D8
       mov       rcx,[rcx]
       mov       rdx,rdi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C13228]
M03_L00:
       mov       rax,rsi
       mov       rcx,0FC06E0DE5F67
       cmp       [rbp+8],rcx
       je        short M03_L01
       call      CORINFO_HELP_FAIL_FAST
M03_L01:
       nop
       lea       rsp,[rbp+30]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 214
```
```assembly
; System.IO.Path.GetFullPath(System.String)
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       test      rsi,rsi
       je        short M04_L01
       lea       rcx,[rsi+0C]
       mov       eax,[rsi+8]
       lea       rdx,[rsp+28]
       mov       [rdx],rcx
       mov       [rdx+8],eax
       lea       rcx,[rsp+28]
       call      System.IO.PathInternal.IsEffectivelyEmpty(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       near ptr M04_L02
       lea       rcx,[rsi+0C]
       mov       r8d,[rsi+8]
       xor       edx,edx
       call      System.SpanHelpers.Contains(Char ByRef, Char, Int32)
       test      eax,eax
       jne       near ptr M04_L03
       lea       rcx,[rsi+0C]
       mov       eax,[rsi+8]
       lea       rdx,[rsp+28]
       mov       [rdx],rcx
       mov       [rdx+8],eax
       lea       rcx,[rsp+28]
       call      System.IO.PathInternal.IsExtended(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       je        short M04_L00
       mov       rax,rsi
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M04_L00:
       mov       rcx,rsi
       call      System.IO.PathHelper.Normalize(System.String)
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,15517
       mov       rdx,7FFF607F4020
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M04_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,3F26
       mov       rdx,7FFF607F4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,1ECC6593060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       rdi,rax
       mov       ecx,15517
       mov       rdx,7FFF607F4020
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,6726
       mov       rdx,7FFF607F4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,1ECC6593060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       rdi,rax
       mov       ecx,15517
       mov       rdx,7FFF607F4020
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 404
```
```assembly
; System.IO.DirectoryInfo.Init(System.String, System.String, System.String, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       mov       rsi,rcx
       lea       rdi,[rsp+20]
       mov       ecx,10
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,r9
       mov       r14d,[rsp+0B0]
       mov       rdx,rbx
       test      rdx,rdx
       je        near ptr M05_L12
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       short M05_L00
       mov       rsi,rbx
M05_L00:
       test      r14b,r14b
       jne       short M05_L01
       mov       rcx,rsi
       call      System.IO.Path.GetFullPath(System.String)
       jmp       short M05_L02
M05_L01:
       mov       rax,rsi
M05_L02:
       mov       rsi,rax
       mov       rdx,rbp
       test      rdx,rdx
       jne       near ptr M05_L11
       test      rsi,rsi
       jne       short M05_L03
       xor       ecx,ecx
       xor       ebx,ebx
       jmp       short M05_L04
M05_L03:
       lea       rcx,[rsi+0C]
       mov       ebx,[rsi+8]
M05_L04:
       mov       eax,ebx
       lea       rdx,[rsp+20]
       mov       [rdx],rcx
       mov       [rdx+8],eax
       lea       rcx,[rsp+20]
       call      System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,ebx
       je        short M05_L07
       test      rsi,rsi
       jne       short M05_L05
       xor       ecx,ecx
       xor       edx,edx
       jmp       short M05_L06
M05_L05:
       lea       rcx,[rsi+0C]
       mov       edx,[rsi+8]
M05_L06:
       lea       rax,[rsp+30]
       lea       r8,[rsp+20]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rax
       lea       rdx,[rsp+20]
       call      System.IO.Path.TrimEndingDirectorySeparator(System.ReadOnlySpan`1<Char>)
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+20]
       mov       rax,[rsp+30]
       mov       [rdx],rax
       mov       eax,[rsp+38]
       mov       [rdx+8],eax
       lea       rdx,[rsp+20]
       call      System.IO.Path.GetFileName(System.ReadOnlySpan`1<Char>)
       jmp       short M05_L10
M05_L07:
       test      rsi,rsi
       jne       short M05_L08
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M05_L09
M05_L08:
       lea       rcx,[rsi+0C]
       mov       eax,[rsi+8]
M05_L09:
       mov       [rsp+40],rcx
       mov       [rsp+48],eax
M05_L10:
       mov       rcx,[rsp+40]
       mov       [rsp+50],rcx
       mov       ecx,[rsp+48]
       mov       [rsp+58],ecx
       lea       rcx,[rsp+50]
       call      System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rdx,rax
M05_L11:
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+50],r14b
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L12:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,615
       mov       rdx,7FFF60B41710
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 397
```
```assembly
; dotNetTips.Utility.Standard.IO.FileProcessor.CopyFiles(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>, System.IO.DirectoryInfo)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFD8],rax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFB8],rsp
       mov       [rbp+10],rcx
       mov       [rbp+20],r8
       mov       rsi,rdx
;             Encapsulation.TryValidateParam(files, nameof(files));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       r8,1ECC6593060
       mov       r8,[r8]
       mov       rdx,1ECF6593088
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
;             Encapsulation.TryValidateParam<ArgumentNullException>(destinationFolder != null, nameof(destinationFolder));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp+20],0
       setne     dl
       movzx     edx,dl
       mov       r9,1ECC6593060
       mov       r9,[r9]
       mov       r8,1ECF6593090
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
;             var successCount = 0;
;             ^^^^^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp+0FFE4],ecx
;             if (destinationFolder.Exists == false)
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C02560]
       test      eax,eax
       jne       short M06_L00
;                 destinationFolder.Create();
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+20]
       mov       rcx,[rcx+8]
       xor       edx,edx
       call      System.IO.FileSystem.CreateDirectory(System.String, Byte[])
M06_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp+0FFC8],rax
;             for (int i = 0; i < list.Count; i++)
;                  ^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp+0FFE0],ecx
       mov       rcx,[rbp+0FFC8]
       cmp       dword ptr [rcx+10],0
       jle       near ptr M06_L06
;                 FileInfo tempFile = list[i];
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M06_L01:
       mov       ecx,[rbp+0FFE0]
       mov       rax,[rbp+0FFC8]
       cmp       ecx,[rax+10]
       jae       near ptr M06_L07
       mov       rcx,[rbp+0FFC8]
       mov       rcx,[rcx+8]
       mov       eax,[rcx+8]
       cmp       [rbp+0FFE0],eax
       jae       near ptr M06_L08
       mov       eax,[rbp+0FFE0]
       movsxd    rax,eax
       mov       rcx,[rcx+rax*8+10]
       mov       [rbp+0FFC0],rcx
;                 if (tempFile.Exists)
;                 ^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+0FFC0]
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C02560]
       test      eax,eax
       je        near ptr M06_L04
       mov       rcx,[rbp+0FFC0]
       mov       rsi,[rcx+8]
       mov       rcx,[rbp+0FFC0]
       call      System.IO.FileInfo.get_Directory()
       mov       rdi,rax
       mov       rcx,offset MT_System.IO.DirectoryInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[rdi+8]
       call      System.IO.Path.GetPathRoot(System.String)
       mov       rdi,rax
       mov       dword ptr [rbx+20],0FFFFFFFF
       mov       rcx,rdi
       call      System.IO.Path.GetFullPath(System.String)
       mov       r8,rax
       mov       dword ptr [rsp+20],1
       mov       rdx,rdi
       mov       rcx,rbx
       xor       r9d,r9d
       call      System.IO.DirectoryInfo.Init(System.String, System.String, System.String, Boolean)
       mov       rdi,[rbx+8]
       mov       rcx,offset MT_System.IO.FileInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r8,[rbp+20]
       mov       r8,[r8+8]
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.String.Replace(System.String, System.String)
       mov       rdx,rax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rbx
       xor       r8d,r8d
       xor       r9d,r9d
       call      System.IO.FileInfo..ctor(System.String, System.String, System.String, Boolean)
;                         if (newFileName.Directory.Exists == false)
;                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,rbx
       call      System.IO.FileInfo.get_Directory()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C02560]
       test      eax,eax
       jne       short M06_L02
       mov       rcx,rbx
       call      System.IO.FileInfo.get_Directory()
       mov       rcx,[rax+8]
       xor       edx,edx
       call      System.IO.FileSystem.CreateDirectory(System.String, Byte[])
;                         var psw = PerformanceStopwatch.StartNew();
;                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M06_L02:
       mov       rcx,offset MD_dotNetTips.Utility.Standard.TypeHelper.Create()
       call      dotNetTips.Utility.Standard.TypeHelper.Create[[System.__Canon, System.Private.CoreLib]]()
       mov       rsi,rax
       cmp       byte ptr [rsi+18],0
       jne       short M06_L03
       mov       rcx,7FFF60A4EDF0
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       lea       rcx,[rbp+0FFD0]
       call      Interop+Kernel32.QueryPerformanceCounter(Int64*)
       mov       rdx,[rbp+0FFD0]
       mov       [rsi+10],rdx
       mov       byte ptr [rsi+18],1
M06_L03:
       mov       rdx,[rbx+8]
       mov       rcx,[rbp+0FFC0]
       mov       r8d,1
       call      System.IO.FileInfo.CopyTo(System.String, Boolean)
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.Diagnostics.PerformanceStopwatch.StopReset()
       mov       [rbp+0FFD8],rax
;                         successCount += 1;
;                         ^^^^^^^^^^^^^^^^^^
       mov       ecx,[rbp+0FFE4]
       inc       ecx
       mov       [rbp+0FFE4],ecx
;                         this.OnProcessed(new FileProgressEventArgs
;                         ^^^
;                         {
;                         ^^^
;                             Name = tempFile.FullName,
;                         ^^^
;                             Message = tempFile.Name,
;                         ^^^
;                             ProgressState = FileProgressState.Copied,
;                         ^^^
;                             Size = tempFile.Length,
;                         ^^^
;                             SpeedInMilliseconds = perf.TotalMilliseconds,
;                         ^^^
;                         });
;                         ^^^
       mov       rcx,offset MT_dotNetTips.Utility.Standard.IO.FileProgressEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1ECC6593060
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+0FFC0]
       mov       rdx,[rdx+8]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+0FFC0]
       mov       rdx,[rdx+18]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+28],3
       mov       rcx,[rbp+0FFC0]
       call      System.IO.FileInfo.get_Length()
       mov       [rsi+18],rax
       lea       rcx,[rbp+0FFD8]
       call      System.TimeSpan.get_TotalMilliseconds()
       vmovsd    qword ptr [rsi+20],xmm0
;                     }
;                     ^
       mov       rcx,[rbp+10]
       mov       rdx,rsi
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       short M06_L05
;                     this.OnProcessed(new FileProgressEventArgs
;                     ^^^
;                     {
;                     ^^^
;                         Name = tempFile.FullName,
;                     ^^^
;                         ProgressState = FileProgressState.Error,
;                     ^^^
;                         Size = tempFile.Length,
;                     ^^^
;                         Message = Resources.FileNotFound,
;                     ^^^
;                     });
;                     ^^^
M06_L04:
       mov       rcx,offset MT_dotNetTips.Utility.Standard.IO.FileProgressEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1ECC6593060
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+0FFC0]
       mov       rdx,[rdx+8]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+28],ecx
       mov       rcx,[rbp+0FFC0]
       call      System.IO.FileInfo.get_Length()
       mov       [rsi+18],rax
       call      dotNetTips.Utility.Standard.Properties.Resources.get_FileNotFound()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rdx,rsi
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
M06_L05:
       mov       eax,[rbp+0FFE0]
       inc       eax
       mov       [rbp+0FFE0],eax
       mov       eax,[rbp+0FFE0]
       mov       rdx,[rbp+0FFC8]
       cmp       eax,[rdx+10]
       jl        near ptr M06_L01
;             return successCount;
;             ^^^^^^^^^^^^^^^^^^^^
M06_L06:
       mov       eax,[rbp+0FFE4]
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M06_L07:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M06_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+70]
;                     catch (Exception ex)
;                     ^^^^^^^^^^^^^^^^^^^^
       mov       rsi,rdx
;                         this.OnProcessed(new FileProgressEventArgs
;                         ^^^
;                         {
;                         ^^^
;                             Name = tempFile.FullName,
;                         ^^^
;                             ProgressState = FileProgressState.Error,
;                         ^^^
;                             Size = tempFile.Length,
;                         ^^^
;                             Message = ex.Message,
;                         ^^^
;                         });
;                         ^^^
       mov       rcx,offset MT_dotNetTips.Utility.Standard.IO.FileProgressEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.IO.FileProgressEventArgs..ctor()
       mov       rcx,[rbp+0FFC0]
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C02550]
       mov       rdx,rax
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.IO.FileProgressEventArgs.set_Name(System.String)
       mov       rcx,rdi
       xor       edx,edx
       call      dotNetTips.Utility.Standard.IO.FileProgressEventArgs.set_ProgressState(dotNetTips.Utility.Standard.IO.FileProgressState)
       mov       rcx,[rbp+0FFC0]
       call      System.IO.FileInfo.get_Length()
       mov       rdx,rax
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.IO.FileProgressEventArgs.set_Size(Int64)
;                     }
;                     ^
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rdx,rax
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.IO.FileProgressEventArgs.set_Message(System.String)
       mov       rcx,[rbp+10]
       mov       rdx,rdi
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       lea       rax,[7FFF60C0D525]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 1036
```
```assembly
; dotNetTips.Utility.Standard.IO.FileProcessor.remove_Processed(System.EventHandler`1<dotNetTips.Utility.Standard.IO.FileProgressEventArgs>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+8]
M07_L00:
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Delegate.Remove(System.Delegate, System.Delegate)
       mov       rdx,rax
       test      rdx,rdx
       je        short M07_L01
       mov       rcx,offset MT_System.EventHandler`1[[dotNetTips.Utility.Standard.IO.FileProgressEventArgs, dotNetTips.Utility.Standard]]
       cmp       [rdx],rcx
       je        short M07_L01
       mov       rdx,rax
       call      CORINFO_HELP_CHKCASTCLASS_SPECIAL
       mov       rdx,rax
M07_L01:
       lea       rcx,[rsi+8]
       mov       r8,rbx
       call      00007FFFC0418AA0
       cmp       rax,rbx
       mov       rbx,rax
       jne       short M07_L00
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 90
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.IO.FileProcessorPerfTestRunner.DeleteFilesWithEvent()
;             var tempFiles = RandomData.GenerateFiles(this._fileCount, this._fileLength);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var processor = new FileProcessor();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             processor.Processed += this.Processor_Processed;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             _ = processor.DeleteFiles(this._tempFiles);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             processor.Processed -= this.Processor_Processed;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         }
;         ^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+40]
       mov       r8d,[rsi+44]
       lea       rcx,[rsp+20]
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateFiles(Int32, Int32)
       mov       rcx,offset MT_dotNetTips.Utility.Standard.IO.FileProcessor
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.EventHandler`1[[dotNetTips.Utility.Standard.IO.FileProgressEventArgs, dotNetTips.Utility.Standard]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.IO.FileProcessorPerfTestRunner.Processor_Processed(System.Object, dotNetTips.Utility.Standard.IO.FileProgressEventArgs)
       mov       [rbx+18],rcx
       mov       rcx,rdi
       mov       rdx,rbx
       call      dotNetTips.Utility.Standard.IO.FileProcessor.add_Processed(System.EventHandler`1<dotNetTips.Utility.Standard.IO.FileProgressEventArgs>)
       mov       rdx,[rsi+38]
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.IO.FileProcessor.DeleteFiles(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>)
       mov       rcx,offset MT_System.EventHandler`1[[dotNetTips.Utility.Standard.IO.FileProgressEventArgs, dotNetTips.Utility.Standard]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.IO.FileProcessorPerfTestRunner.Processor_Processed(System.Object, dotNetTips.Utility.Standard.IO.FileProgressEventArgs)
       mov       [rbx+18],rcx
       mov       rcx,rdi
       mov       rdx,rbx
       call      dotNetTips.Utility.Standard.IO.FileProcessor.remove_Processed(System.EventHandler`1<dotNetTips.Utility.Standard.IO.FileProgressEventArgs>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 188
```
```assembly
; dotNetTips.Utility.Standard.Tester.RandomData.GenerateFiles(Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
;             Encapsulation.TryValidateParam(count, 1, int.MaxValue, nameof(count));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,188C5AA3060
       mov       rbp,[rcx]
       mov       r14,rbp
       test      esi,esi
       jle       near ptr M01_L04
       cmp       esi,7FFFFFFF
       setle     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L04
;             Encapsulation.TryValidateParam(fileLength, 1, int.MaxValue, nameof(fileLength));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      edi,edi
       jle       near ptr M01_L06
       cmp       edi,7FFFFFFF
       setle     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L06
;             var files = new List<string>(count);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
;             for (var fileCount = 0; fileCount < count; fileCount++)
;                  ^^^^^^^^^^^^^^^^^
       xor       ebp,ebp
       test      esi,esi
       jle       short M01_L02
M01_L00:
       mov       ecx,edi
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateTempFile(Int32)
       mov       r8,rax
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L03
       lea       eax,[rdx+1]
       mov       [r14+10],eax
       call      CORINFO_HELP_ARRADDR_ST
M01_L01:
       inc       ebp
       cmp       ebp,esi
       jl        short M01_L00
M01_L02:
       call      System.IO.Path.GetTempPath()
       mov       rdx,rax
;             return (Path.GetTempPath(), files.AsEnumerable());
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       rcx,r14
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M01_L01
M01_L04:
       test      r14,r14
       jne       short M01_L05
       call      dotNetTips.Utility.Standard.Properties.Resources.get_NumberNotInRange()
       mov       r14,rax
M01_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFF60BD7660
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rbp,rbp
       jne       short M01_L07
       call      dotNetTips.Utility.Standard.Properties.Resources.get_NumberNotInRange()
       mov       rbp,rax
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,2F
       mov       rdx,7FFF60BD7660
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 371
```
```assembly
; dotNetTips.Utility.Benchmarks.IO.FileProcessorPerfTestRunner.Processor_Processed(System.Object, dotNetTips.Utility.Standard.IO.FileProgressEventArgs)
;             base.Consumer.Consume(e.Message);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             this._filesToDelete.Add(e.Name);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       mov       rsi,rcx
       mov       rdi,r8
       mov       rcx,[rsi+8]
       mov       rdx,[rdi+8]
       mov       eax,[rcx]
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rsi+28]
       mov       rdx,[rdi+10]
       mov       rax,offset dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       cmp       [rcx],ecx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 52
```
```assembly
; dotNetTips.Utility.Standard.IO.FileProcessor.add_Processed(System.EventHandler`1<dotNetTips.Utility.Standard.IO.FileProgressEventArgs>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+8]
M03_L00:
       test      rbx,rbx
       jne       short M03_L01
       mov       rdx,rdi
       jmp       short M03_L02
M03_L01:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFF60BFFB70]
       mov       rdx,rax
M03_L02:
       mov       rax,rdx
       test      rax,rax
       je        short M03_L03
       mov       rcx,offset MT_System.EventHandler`1[[dotNetTips.Utility.Standard.IO.FileProgressEventArgs, dotNetTips.Utility.Standard]]
       cmp       [rax],rcx
       je        short M03_L03
       call      CORINFO_HELP_CHKCASTCLASS_SPECIAL
M03_L03:
       lea       rcx,[rsi+8]
       mov       rdx,rax
       mov       r8,rbx
       call      00007FFFC0418AA0
       cmp       rax,rbx
       mov       rbx,rax
       jne       short M03_L00
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 101
```
```assembly
; dotNetTips.Utility.Standard.IO.FileProcessor.DeleteFiles(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>)
       push      rbp
       push      rsi
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFC8],rax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFC0],rsp
       mov       [rbp+10],rcx
       mov       rsi,rdx
;             Encapsulation.TryValidateParam(files, nameof(files));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       r8,188C5AA3060
       mov       r8,[r8]
       mov       rdx,188B5AA1070
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
;             var successCount = 0;
;             ^^^^^^^^^^^^^^^^^^^^^
       xor       edx,edx
       mov       [rbp+0FFF4],edx
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp+0FFD8],rax
;             for (int i = 0; i < list.Count; i++)
;                  ^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp+0FFF0],ecx
       mov       rcx,[rbp+0FFD8]
       cmp       dword ptr [rcx+10],0
       jle       near ptr M04_L04
;                 FileInfo tempFile = list[i];
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M04_L00:
       mov       ecx,[rbp+0FFF0]
       mov       rax,[rbp+0FFD8]
       cmp       ecx,[rax+10]
       jae       near ptr M04_L05
       mov       rcx,[rbp+0FFD8]
       mov       rcx,[rcx+8]
       mov       eax,[rcx+8]
       cmp       [rbp+0FFF0],eax
       jae       near ptr M04_L06
       mov       eax,[rbp+0FFF0]
       movsxd    rax,eax
       mov       rcx,[rcx+rax*8+10]
       mov       [rbp+0FFD0],rcx
;                 if (tempFile.Exists)
;                 ^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C02560]
       test      eax,eax
       je        near ptr M04_L02
;                         var psw = PerformanceStopwatch.StartNew();
;                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MD_dotNetTips.Utility.Standard.TypeHelper.Create()
       call      dotNetTips.Utility.Standard.TypeHelper.Create[[System.__Canon, System.Private.CoreLib]]()
       mov       rsi,rax
       cmp       byte ptr [rsi+18],0
       jne       short M04_L01
       mov       rcx,7FFF60A4EDF0
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       lea       rcx,[rbp+0FFE0]
       call      Interop+Kernel32.QueryPerformanceCounter(Int64*)
       mov       rcx,[rbp+0FFE0]
       mov       [rsi+10],rcx
       mov       byte ptr [rsi+18],1
M04_L01:
       mov       rcx,[rbp+0FFD0]
       mov       rcx,[rcx+8]
       call      System.IO.FileSystem.DeleteFile(System.String)
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.Diagnostics.PerformanceStopwatch.StopReset()
       mov       [rbp+0FFE8],rax
;                         successCount += 1;
;                         ^^^^^^^^^^^^^^^^^^
       mov       ecx,[rbp+0FFF4]
       inc       ecx
       mov       [rbp+0FFF4],ecx
;                         this.OnProcessed(new FileProgressEventArgs
;                         ^^^
;                         {
;                         ^^^
;                             Name = tempFile.FullName,
;                         ^^^
;                             Message = tempFile.Name,
;                         ^^^
;                             ProgressState = FileProgressState.Deleted,
;                         ^^^
;                             Size = tempFile.Length,
;                         ^^^
;                             SpeedInMilliseconds = perf.TotalMilliseconds,
;                         ^^^
;                         });
;                         ^^^
       mov       rcx,offset MT_dotNetTips.Utility.Standard.IO.FileProgressEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,188C5AA3060
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+0FFD0]
       mov       rdx,[rdx+8]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+0FFD0]
       mov       rdx,[rdx+18]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+28],1
       mov       rcx,[rbp+0FFD0]
       call      System.IO.FileInfo.get_Length()
       mov       [rsi+18],rax
       lea       rcx,[rbp+0FFE8]
       call      System.TimeSpan.get_TotalMilliseconds()
       vmovsd    qword ptr [rsi+20],xmm0
;                     }
;                     ^
       mov       rcx,[rbp+10]
       mov       rdx,rsi
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       short M04_L03
;                     this.OnProcessed(new FileProgressEventArgs
;                     ^^^
;                     {
;                     ^^^
;                         Name = tempFile.FullName,
;                     ^^^
;                         ProgressState = FileProgressState.Error,
;                     ^^^
;                         Message = Resources.FileNotFound,
;                     ^^^
;                     });
;                     ^^^
M04_L02:
       mov       rcx,offset MT_dotNetTips.Utility.Standard.IO.FileProgressEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,188C5AA3060
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+0FFD0]
       mov       rdx,[rdx+8]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+28],eax
       call      dotNetTips.Utility.Standard.Properties.Resources.get_FileNotFound()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rdx,rsi
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
M04_L03:
       mov       eax,[rbp+0FFF0]
       inc       eax
       mov       [rbp+0FFF0],eax
       mov       eax,[rbp+0FFF0]
       mov       rdx,[rbp+0FFD8]
       cmp       eax,[rdx+10]
       jl        near ptr M04_L00
;             return successCount;
;             ^^^^^^^^^^^^^^^^^^^^
M04_L04:
       mov       eax,[rbp+0FFF4]
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
M04_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M04_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       rdx,rax
       test      rdx,rdx
       jne       short M04_L07
;                     catch (Exception ex) when (ex is IOException || ex is SecurityException || ex is UnauthorizedAccessException)
;                                          ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       jmp       short M04_L10
M04_L07:
       mov       [rbp+0FFC8],rdx
       mov       rcx,offset MT_System.IO.IOException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M04_L08
       mov       rdx,[rbp+0FFC8]
       mov       rcx,offset MT_System.Security.SecurityException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M04_L08
       mov       rdx,[rbp+0FFC8]
       mov       rcx,offset MT_System.UnauthorizedAccessException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       setne     al
       movzx     eax,al
       jmp       short M04_L09
M04_L08:
       mov       eax,1
M04_L09:
       test      eax,eax
       setne     al
       movzx     eax,al
M04_L10:
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
;                         this.OnProcessed(new FileProgressEventArgs
;                         ^^^
;                         {
;                         ^^^
;                             Name = tempFile.FullName,
;                         ^^^
;                             ProgressState = FileProgressState.Error,
;                         ^^^
;                             Size = tempFile.Length,
;                         ^^^
;                             Message = ex.Message,
;                         ^^^
;                         });
;                         ^^^
       mov       rcx,offset MT_dotNetTips.Utility.Standard.IO.FileProgressEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.IO.FileProgressEventArgs..ctor()
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C02550]
       mov       rdx,rax
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.IO.FileProgressEventArgs.set_Name(System.String)
       mov       rcx,rsi
       xor       edx,edx
       call      dotNetTips.Utility.Standard.IO.FileProgressEventArgs.set_ProgressState(dotNetTips.Utility.Standard.IO.FileProgressState)
       mov       rcx,[rbp+0FFD0]
       call      System.IO.FileInfo.get_Length()
       mov       rdx,rax
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.IO.FileProgressEventArgs.set_Size(Int64)
;                     }
;                     ^
       mov       rcx,[rbp+0FFC8]
       mov       rax,[rbp+0FFC8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rdx,rax
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.IO.FileProgressEventArgs.set_Message(System.String)
       mov       rcx,[rbp+10]
       mov       rdx,rsi
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       lea       rax,[7FFF60C0DA57]
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 877
```
```assembly
; dotNetTips.Utility.Standard.IO.FileProcessor.remove_Processed(System.EventHandler`1<dotNetTips.Utility.Standard.IO.FileProgressEventArgs>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+8]
M05_L00:
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Delegate.Remove(System.Delegate, System.Delegate)
       mov       rdx,rax
       test      rdx,rdx
       je        short M05_L01
       mov       rcx,offset MT_System.EventHandler`1[[dotNetTips.Utility.Standard.IO.FileProgressEventArgs, dotNetTips.Utility.Standard]]
       cmp       [rdx],rcx
       je        short M05_L01
       mov       rdx,rax
       call      CORINFO_HELP_CHKCASTCLASS_SPECIAL
       mov       rdx,rax
M05_L01:
       lea       rcx,[rsi+8]
       mov       r8,rbx
       call      00007FFFC0418AA0
       cmp       rax,rbx
       mov       rbx,rax
       jne       short M05_L00
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 90
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.IO.FileProcessorPerfTestRunner.DeleteFoldersWithEvent()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       call      System.IO.Path.GetTempPath()
       mov       rdi,rax
;             var directories = new List<DirectoryInfo>(Capacity);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.IO.DirectoryInfo, System.IO.FileSystem]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       edx,64
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
;             for (var directoryCount = 0; directoryCount < Capacity; directoryCount++)
;                  ^^^^^^^^^^^^^^^^^^^^^^
       xor       ebp,ebp
M00_L00:
       mov       ecx,0F
       mov       edx,41
       mov       r8d,5A
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.IO.Path.Combine(System.String, System.String)
       mov       rcx,rax
       call      System.IO.Directory.CreateDirectory(System.String)
       mov       r8,rax
       inc       dword ptr [rbx+14]
       mov       rcx,[rbx+8]
       mov       edx,[rbx+10]
       cmp       [rcx+8],edx
       jbe       short M00_L01
       lea       eax,[rdx+1]
       mov       [rbx+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L02
M00_L01:
       mov       rcx,rbx
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L02:
       inc       ebp
       cmp       ebp,64
       jl        short M00_L00
;             var processor = new FileProcessor();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_dotNetTips.Utility.Standard.IO.FileProcessor
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
;             processor.Processed += this.Processor_Processed;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.EventHandler`1[[dotNetTips.Utility.Standard.IO.FileProgressEventArgs, dotNetTips.Utility.Standard]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       test      rsi,rsi
       je        short M00_L03
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.IO.FileProcessorPerfTestRunner.Processor_Processed(System.Object, dotNetTips.Utility.Standard.IO.FileProgressEventArgs)
       mov       [rbp+18],rcx
;             _ = processor.DeleteFolders(directories);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,rdi
       mov       rdx,rbp
       call      dotNetTips.Utility.Standard.IO.FileProcessor.add_Processed(System.EventHandler`1<dotNetTips.Utility.Standard.IO.FileProgressEventArgs>)
       mov       rcx,rdi
       mov       rdx,rbx
       call      dotNetTips.Utility.Standard.IO.FileProcessor.DeleteFolders(System.Collections.Generic.IEnumerable`1<System.IO.DirectoryInfo>)
;             processor.Processed -= this.Processor_Processed;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.EventHandler`1[[dotNetTips.Utility.Standard.IO.FileProgressEventArgs, dotNetTips.Utility.Standard]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Benchmarks.IO.FileProcessorPerfTestRunner.Processor_Processed(System.Object, dotNetTips.Utility.Standard.IO.FileProgressEventArgs)
       mov       [rbp+18],rcx
;         }
;         ^
       mov       rcx,rdi
       mov       rdx,rbp
       mov       rax,offset dotNetTips.Utility.Standard.IO.FileProcessor.remove_Processed(System.EventHandler`1<dotNetTips.Utility.Standard.IO.FileProgressEventArgs>)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M00_L03:
       mov       rcx,rbp
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 310
```
```assembly
; System.IO.Path.GetTempPath()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,50
       vzeroupper
       lea       rbp,[rsp+20]
       xor       eax,eax
       mov       [rbp+10],rax
       mov       [rbp+20],rax
       mov       rax,0ADF6FB0DA785
       mov       [rbp+8],rax
       add       rsp,20
       test      esp,[rsp]
       sub       rsp,210
       sub       rsp,20
       lea       rcx,[rsp+20]
       xor       eax,eax
       mov       [rbp+10],rax
       lea       rax,[rbp+20]
       mov       [rax],rcx
       mov       dword ptr [rax+8],104
       xor       ecx,ecx
       mov       [rbp+18],ecx
       lea       rcx,[rbp+10]
       call      System.IO.Path.GetTempPath(System.Text.ValueStringBuilder ByRef)
       lea       rcx,[rbp+10]
       call      System.IO.PathHelper.Normalize(System.Text.ValueStringBuilder ByRef)
       mov       rsi,rax
       mov       rdi,[rbp+10]
       lea       rcx,[rbp+10]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       vmovdqu   xmmword ptr [rcx+10],xmm0
       test      rdi,rdi
       je        short M01_L00
       mov       rcx,7FFF608F0020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,28BCFDC48D8
       mov       rcx,[rcx]
       mov       rdx,rdi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C15280]
M01_L00:
       mov       rax,rsi
       mov       rcx,0ADF6FB0DA785
       cmp       [rbp+8],rcx
       je        short M01_L01
       call      CORINFO_HELP_FAIL_FAST
M01_L01:
       nop
       lea       rsp,[rbp+30]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 214
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       test      edi,edi
       jl        near ptr M02_L03
       test      edi,edi
       jne       short M02_L01
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M02_L00
       mov       rdx,7FFF60CAF468
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L00:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+10]
       test      rax,rax
       jne       short M02_L02
       mov       rdx,7FFF60CAF5A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L02:
       movsxd    rdx,edi
       mov       rcx,rax
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,16
       mov       edx,9
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument, System.ExceptionResource)
       int       3
; Total bytes of code 171
```
```assembly
; dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32, Char, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
;             Encapsulation.TryValidateParam(length, 1, int.MaxValue, nameof(length));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,28BAFDC3060
       mov       rbp,[rcx]
       test      esi,esi
       jle       short M03_L02
       cmp       esi,7FFFFFFF
       setle     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L02
;             var word = new StringBuilder(length);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
;             for (var wordCount = 0; wordCount < length; wordCount++)
;                  ^^^^^^^^^^^^^^^^^
       xor       r14d,r14d
       test      esi,esi
       jle       short M03_L01
       movzx     ebx,bx
       movzx     edi,di
M03_L00:
       mov       ecx,edi
       mov       edx,ebx
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateInteger(Int32, Int32)
       movzx     edx,ax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(Char)
       inc       r14d
       cmp       r14d,esi
       jl        short M03_L00
;             return word.ToString();
;             ^^^^^^^^^^^^^^^^^^^^^^^
M03_L01:
       mov       rcx,rbp
       mov       rax,[7FFF60967010]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M03_L02:
       test      rbp,rbp
       jne       short M03_L03
       call      dotNetTips.Utility.Standard.Properties.Resources.get_NumberNotInRange()
       mov       rbp,rax
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,6B
       mov       rdx,7FFF60BD7660
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 222
```
```assembly
; System.IO.Path.Combine(System.String, System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       je        short M04_L00
       test      rdx,rdx
       je        short M04_L00
       mov       rax,offset System.IO.Path.CombineInternal(System.String, System.String)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M04_L00:
       test      rcx,rcx
       je        short M04_L01
       mov       rcx,28B9FDC1070
       mov       rsi,[rcx]
       jmp       short M04_L02
M04_L01:
       mov       rcx,28B9FDC1078
       mov       rsi,[rcx]
M04_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 106
```
```assembly
; System.IO.Directory.CreateDirectory(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       test      rsi,rsi
       je        short M05_L00
       cmp       dword ptr [rsi+8],0
       je        near ptr M05_L01
       mov       rcx,rsi
       call      System.IO.Path.GetFullPath(System.String)
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       call      System.IO.FileSystem.CreateDirectory(System.String, Byte[])
       mov       rcx,offset MT_System.IO.DirectoryInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+20],0FFFFFFFF
       mov       dword ptr [rsp+20],1
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       xor       r9d,r9d
       call      System.IO.DirectoryInfo.Init(System.String, System.String, System.String, Boolean)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,615
       mov       rdx,7FFF60B41710
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L01:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,24F
       mov       rdx,7FFF60B41710
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       rdi,rax
       mov       ecx,615
       mov       rdx,7FFF60B41710
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 258
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,[rsi+10]
       lea       ebp,[rbx+1]
       mov       edx,ebp
       mov       rcx,rsi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].EnsureCapacity(Int32)
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 57
```
```assembly
; dotNetTips.Utility.Benchmarks.IO.FileProcessorPerfTestRunner.Processor_Processed(System.Object, dotNetTips.Utility.Standard.IO.FileProgressEventArgs)
;             base.Consumer.Consume(e.Message);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             this._filesToDelete.Add(e.Name);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       mov       rsi,rcx
       mov       rdi,r8
       mov       rcx,[rsi+8]
       mov       rdx,[rdi+8]
       mov       eax,[rcx]
       add       rcx,8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rsi+28]
       mov       rdx,[rdi+10]
       mov       rax,offset dotNetTips.Utility.Standard.Collections.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       cmp       [rcx],ecx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 52
```
```assembly
; dotNetTips.Utility.Standard.IO.FileProcessor.add_Processed(System.EventHandler`1<dotNetTips.Utility.Standard.IO.FileProgressEventArgs>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+8]
M08_L00:
       test      rbx,rbx
       jne       short M08_L01
       mov       rdx,rdi
       jmp       short M08_L02
M08_L01:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFF60C0FB70]
       mov       rdx,rax
M08_L02:
       mov       rax,rdx
       test      rax,rax
       je        short M08_L03
       mov       rcx,offset MT_System.EventHandler`1[[dotNetTips.Utility.Standard.IO.FileProgressEventArgs, dotNetTips.Utility.Standard]]
       cmp       [rax],rcx
       je        short M08_L03
       call      CORINFO_HELP_CHKCASTCLASS_SPECIAL
M08_L03:
       lea       rcx,[rsi+8]
       mov       rdx,rax
       mov       r8,rbx
       call      00007FFFC0418AA0
       cmp       rax,rbx
       mov       rbx,rax
       jne       short M08_L00
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 101
```
```assembly
; dotNetTips.Utility.Standard.IO.FileProcessor.DeleteFolders(System.Collections.Generic.IEnumerable`1<System.IO.DirectoryInfo>)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFD8],rax
       mov       [rbp+0FFD0],rsp
       mov       [rbp+10],rcx
       mov       rsi,rdx
;             Encapsulation.TryValidateParam(folders, nameof(folders));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       r8,28BAFDC3060
       mov       r8,[r8]
       mov       rdx,28BCFDCD038
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
;             var successCount = 0;
;             ^^^^^^^^^^^^^^^^^^^^^
       xor       edx,edx
       mov       [rbp+0FFF4],edx
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp+0FFE8],rax
;             for (int i = 0; i < list.Count; i++)
;                  ^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp+0FFF0],ecx
       mov       rcx,[rbp+0FFE8]
       cmp       dword ptr [rcx+10],0
       jle       near ptr M09_L03
;                 DirectoryInfo tempFolder = list[i];
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M09_L00:
       mov       ecx,[rbp+0FFF0]
       mov       rax,[rbp+0FFE8]
       cmp       ecx,[rax+10]
       jae       near ptr M09_L04
       mov       rcx,[rbp+0FFE8]
       mov       rcx,[rcx+8]
       mov       eax,[rcx+8]
       cmp       [rbp+0FFF0],eax
       jae       near ptr M09_L05
       mov       eax,[rbp+0FFF0]
       movsxd    rax,eax
       mov       rcx,[rcx+rax*8+10]
       mov       [rbp+0FFE0],rcx
;                 if (tempFolder.Exists)
;                 ^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+0FFE0]
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C12560]
       test      eax,eax
       je        short M09_L01
;                         tempFolder.Delete(recursive: true);
;                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+0FFE0]
       mov       rcx,[rcx+8]
       mov       edx,1
       call      System.IO.FileSystem.RemoveDirectory(System.String, Boolean)
;                         successCount += 1;
;                         ^^^^^^^^^^^^^^^^^^
       mov       ecx,[rbp+0FFF4]
       inc       ecx
       mov       [rbp+0FFF4],ecx
;                         this.OnProcessed(new FileProgressEventArgs
;                         ^^^
;                         {
;                         ^^^
;                             Name = tempFolder.FullName,
;                         ^^^
;                             ProgressState = FileProgressState.Deleted,
;                         ^^^
;                         });
;                         ^^^
       mov       rcx,offset MT_dotNetTips.Utility.Standard.IO.FileProgressEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,28BAFDC3060
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+0FFE0]
       mov       rdx,[rdx+8]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
;                     }
;                     ^
       mov       dword ptr [rsi+28],1
       mov       rcx,[rbp+10]
       mov       rdx,rsi
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       short M09_L02
;                     this.OnProcessed(new FileProgressEventArgs
;                     ^^^
;                     {
;                     ^^^
;                         Name = tempFolder.FullName,
;                     ^^^
;                         ProgressState = FileProgressState.Error,
;                     ^^^
;                         Message = Resources.FolderNotFound,
;                     ^^^
;                     });
;                     ^^^
M09_L01:
       mov       rcx,offset MT_dotNetTips.Utility.Standard.IO.FileProgressEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,28BAFDC3060
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+0FFE0]
       mov       rdx,[rdx+8]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+28],eax
       call      dotNetTips.Utility.Standard.Properties.Resources.get_FolderNotFound()
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rdx,rsi
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
M09_L02:
       mov       eax,[rbp+0FFF0]
       inc       eax
       mov       [rbp+0FFF0],eax
       mov       eax,[rbp+0FFF0]
       mov       rdx,[rbp+0FFE8]
       cmp       eax,[rdx+10]
       jl        near ptr M09_L00
;             return successCount;
;             ^^^^^^^^^^^^^^^^^^^^
M09_L03:
       mov       eax,[rbp+0FFF4]
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
M09_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M09_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       rdx,rax
       test      rdx,rdx
       jne       short M09_L06
;                     catch (Exception ex) when (ex is IOException || ex is SecurityException || ex is UnauthorizedAccessException || ex is DirectoryNotFoundException)
;                                          ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       jmp       short M09_L09
M09_L06:
       mov       [rbp+0FFD8],rdx
       mov       rcx,offset MT_System.IO.IOException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M09_L07
       mov       rdx,[rbp+0FFD8]
       mov       rcx,offset MT_System.Security.SecurityException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M09_L07
       mov       rdx,[rbp+0FFD8]
       mov       rcx,offset MT_System.UnauthorizedAccessException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M09_L07
       mov       rdx,[rbp+0FFD8]
       mov       rcx,offset MT_System.IO.DirectoryNotFoundException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       setne     al
       movzx     eax,al
       jmp       short M09_L08
M09_L07:
       mov       eax,1
M09_L08:
       test      eax,eax
       setne     al
       movzx     eax,al
M09_L09:
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
;                         this.OnProcessed(new FileProgressEventArgs
;                         ^^^
;                         {
;                         ^^^
;                             Name = tempFolder.FullName,
;                         ^^^
;                             ProgressState = FileProgressState.Error,
;                         ^^^
;                             Message = ex.Message,
;                         ^^^
;                         });
;                         ^^^
       mov       rcx,offset MT_dotNetTips.Utility.Standard.IO.FileProgressEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.IO.FileProgressEventArgs..ctor()
       mov       rcx,[rbp+0FFE0]
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C12550]
       mov       rdx,rax
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.IO.FileProgressEventArgs.set_Name(System.String)
       mov       rcx,rsi
       xor       edx,edx
       call      dotNetTips.Utility.Standard.IO.FileProgressEventArgs.set_ProgressState(dotNetTips.Utility.Standard.IO.FileProgressState)
;                     }
;                     ^
       mov       rcx,[rbp+0FFD8]
       mov       rax,[rbp+0FFD8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rdx,rax
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.IO.FileProgressEventArgs.set_Message(System.String)
       mov       rcx,[rbp+10]
       mov       rdx,rsi
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       lea       rax,[7FFF60C12EA4]
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 744
```
```assembly
; dotNetTips.Utility.Standard.IO.FileProcessor.remove_Processed(System.EventHandler`1<dotNetTips.Utility.Standard.IO.FileProgressEventArgs>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+8]
M10_L00:
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Delegate.Remove(System.Delegate, System.Delegate)
       mov       rdx,rax
       test      rdx,rdx
       je        short M10_L01
       mov       rcx,offset MT_System.EventHandler`1[[dotNetTips.Utility.Standard.IO.FileProgressEventArgs, dotNetTips.Utility.Standard]]
       cmp       [rdx],rcx
       je        short M10_L01
       mov       rdx,rax
       call      CORINFO_HELP_CHKCASTCLASS_SPECIAL
       mov       rdx,rax
M10_L01:
       lea       rcx,[rsi+8]
       mov       r8,rbx
       call      00007FFFC0418AA0
       cmp       rax,rbx
       mov       rbx,rax
       jne       short M10_L00
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 90
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

