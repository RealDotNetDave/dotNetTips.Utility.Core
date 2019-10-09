namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Class ComputerInfoDebugView. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="Object" />
    internal sealed class ComputerInfoDebugView
    {
        /// <summary>
        /// The m instance being watched
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComputerInfo _instanceBeingWatched;

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerInfoDebugView" /> class.
        /// </summary>
        /// <param name="RealClass">The real class.</param>
        public ComputerInfoDebugView(ComputerInfo RealClass)
        {
            this._instanceBeingWatched = RealClass;
        }

        /// <summary>
        /// Gets the total physical memory.
        /// </summary>
        /// <value>The total physical memory.</value>
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public ulong TotalPhysicalMemory => this._instanceBeingWatched.TotalPhysicalMemory;

        /// <summary>
        /// Gets the available physical memory.
        /// </summary>
        /// <value>The available physical memory.</value>
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public ulong AvailablePhysicalMemory => this._instanceBeingWatched.AvailablePhysicalMemory;

        /// <summary>
        /// Gets the total virtual memory.
        /// </summary>
        /// <value>The total virtual memory.</value>
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public ulong TotalVirtualMemory => this._instanceBeingWatched.TotalVirtualMemory;

        /// <summary>
        /// Gets the available virtual memory.
        /// </summary>
        /// <value>The available virtual memory.</value>
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public ulong AvailableVirtualMemory => this._instanceBeingWatched.AvailableVirtualMemory;

        /// <summary>
        /// Gets the installed UI culture.
        /// </summary>
        /// <value>The installed UI culture.</value>
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public CultureInfo InstalledUICulture => this._instanceBeingWatched.InstalledUICulture;

        /// <summary>
        /// Gets the os platform.
        /// </summary>
        /// <value>The os platform.</value>
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public string OSPlatform => this._instanceBeingWatched.OSPlatform;

        /// <summary>
        /// Gets the os version.
        /// </summary>
        /// <value>The os version.</value>
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public string OSVersion => this._instanceBeingWatched.OSVersion;
    }
}
