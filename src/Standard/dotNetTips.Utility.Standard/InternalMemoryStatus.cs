using System;
using System.Collections.Generic;
using System.Text;

namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Class InternalMemoryStatus.
    /// </summary>
    /// <seealso cref="Object" />
    private class InternalMemoryStatus
    {
        /// <summary>
        /// The m is old os
        /// </summary>
        private bool _isOldOS = (Environment.OSVersion.Version.Major < 5);

        /// <summary>
        /// The m memory status
        /// </summary>
        private Microsoft.VisualBasic.CompilerServices.NativeMethods.MEMORYSTATUS _memoryStatus;

        /// <summary>
        /// The m memory status ex
        /// </summary>
        private Microsoft.VisualBasic.CompilerServices.NativeMethods.MEMORYSTATUSEX _memoryStatusEx;

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalMemoryStatus" /> class.
        /// </summary>
        internal InternalMemoryStatus()
        {
        }

        /// <summary>
        /// Refreshes this instance.
        /// </summary>
        [SecurityCritical]
        private void Refresh()
        {
            if (this._isOldOS)
            {
                this._memoryStatus = new Microsoft.VisualBasic.CompilerServices.NativeMethods.MEMORYSTATUS();
                Microsoft.VisualBasic.CompilerServices.NativeMethods.GlobalMemoryStatus(ref this._memoryStatus);
            }
            else
            {
                this._memoryStatusEx = new Microsoft.VisualBasic.CompilerServices.NativeMethods.MEMORYSTATUSEX();
                this._memoryStatusEx.Init();

                if (!Microsoft.VisualBasic.CompilerServices.NativeMethods.GlobalMemoryStatusEx(ref this._memoryStatusEx))
                {
                    throw ExceptionUtils.GetWin32Exception("DiagnosticInfo_Memory", new string[0]);
                }
            }
        }

        /// <summary>
        /// Gets the total physical memory.
        /// </summary>
        /// <value>The total physical memory.</value>
        internal ulong TotalPhysicalMemory
        {
            [SecurityCritical]
            get
            {
                this.Refresh();

                if (this._isOldOS)
                {
                    return (ulong)this._memoryStatus.dwTotalPhys;
                }

                return this._memoryStatusEx.ullTotalPhys;
            }
        }

        /// <summary>
        /// Gets the available physical memory.
        /// </summary>
        /// <value>The available physical memory.</value>
        internal ulong AvailablePhysicalMemory
        {
            [SecurityCritical]
            get
            {
                this.Refresh();

                if (this._isOldOS)
                {
                    return (ulong)this._memoryStatus.dwAvailPhys;
                }

                return this._memoryStatusEx.ullAvailPhys;
            }
        }

        /// <summary>
        /// Gets the total virtual memory.
        /// </summary>
        /// <value>The total virtual memory.</value>
        internal ulong TotalVirtualMemory
        {
            [SecurityCritical]
            get
            {
                this.Refresh();

                if (this._isOldOS)
                {
                    return (ulong)this._memoryStatus.dwTotalVirtual;
                }

                return this._memoryStatusEx.ullTotalVirtual;
            }
        }

        /// <summary>
        /// Gets the available virtual memory.
        /// </summary>
        /// <value>The available virtual memory.</value>
        internal ulong AvailableVirtualMemory
        {
            [SecurityCritical]
            get
            {
                this.Refresh();

                if (this._isOldOS)
                {
                    return (ulong)this._memoryStatus.dwAvailVirtual;
                }

                return this._memoryStatusEx.ullAvailVirtual;
            }
        }
    }
}
