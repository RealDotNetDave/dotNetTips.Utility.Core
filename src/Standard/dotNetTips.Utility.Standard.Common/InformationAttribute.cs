// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Common
// Author           : David McCarter
// Created          : 07-29-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-05-2020
// ***********************************************************************
// <copyright file="InformationAttribute.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace dotNetTips.Utility.Standard.Common
{
    /// <summary>
    /// BenchMarkStatus attribute to add more meta data for types.
    /// </summary>
    [Information(message: "For use in InformationAttribute.", author: "David McCarter", createdOn: "7/29/2020", modifiedOn: "8/4/2020", BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
    public enum BenchMarkStatus
    {
        /// <summary>
        /// No benchmark.
        /// </summary>
        None,

        /// <summary>
        /// Benchmark is not required
        /// </summary>
        NotRequired,

        /// <summary>
        /// Benchmark work is in progress.
        /// </summary>
        WIP,

        /// <summary>
        /// Benchmarks done.
        /// </summary>
        Completed
    }

    /// <summary>
    /// Information status.
    /// </summary>
    [Information(message: "For use in InformationAttribute.", author: "David McCarter", createdOn: "7/29/2020", modifiedOn: "8/4/2020", BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
    public enum Status
    {
        /// <summary>
        /// The not set
        /// </summary>
        NotSet,

        /// <summary>
        /// New method or class.
        /// </summary>
        New,

        /// <summary>
        /// Method or class is available for use (from other assemblies).
        /// </summary>
        Available,

        /// <summary>
        /// Method or class not in use.
        /// </summary>
        NotUsed
    }

    /// <summary>
    /// Class InformationAttribute. This class cannot be inherited.
    /// Implements the <see cref="System.Attribute" />
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Delegate, Inherited = false)]
    public sealed class InformationAttribute : Attribute
    {

        private double _unitTestCoverage = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="InformationAttribute" /> class.
        /// </summary>
        public InformationAttribute()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InformationAttribute" /> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="author">The author.</param>
        /// <param name="createdOn">The created on.</param>
        public InformationAttribute(string message, string author, string createdOn) : this(message, author, createdOn, createdOn)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InformationAttribute" /> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="author">The author.</param>
        /// <param name="createdOn">The created on.</param>
        /// <param name="modifiedOn">The modified on.</param>
        public InformationAttribute(string message, string author, string createdOn, string modifiedOn)
        {
            Description = message;
            Author = author;

            if (DateTimeOffset.TryParse(createdOn, out DateTimeOffset createdDate))
            {
                CreatedOn = createdDate;


                if (DateTimeOffset.TryParse(modifiedOn, out DateTimeOffset modifiedDate))
                {
                    ModifiedOn = modifiedDate;
                }
            }

            if (string.IsNullOrEmpty(ModifiedBy))
            {
                ModifiedBy = author;
            }
        }

        /// <summary>
        /// Gets the author.
        /// </summary>
        /// <value>The author.</value>
        public string Author { get; }

        /// <summary>
        /// Gets or sets the benchmark status.
        /// </summary>
        /// <value>The bench mark status.</value>
        public BenchMarkStatus BenchMarkStatus { get; set; } = BenchMarkStatus.None;

        /// <summary>
        /// Gets the created on date.
        /// </summary>
        /// <value>The created on.</value>
        public DateTimeOffset CreatedOn { get; }

        /// <summary>
        /// Gets the description of the type, method or event.
        /// </summary>
        /// <value>The message.</value>
        public string Description { get; }

        /// <summary>
        /// Gets or sets the modified by.
        /// </summary>
        /// <value>The modified by.</value>
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Gets the modified on date.
        /// </summary>
        /// <value>The modified on.</value>
        public DateTimeOffset ModifiedOn { get; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        public Status Status { get; set; } = Status.Available;

        /// <summary>
        /// Gets or sets the unit test coverage.
        /// </summary>
        /// <value>The unit test coverage.</value>
        /// <exception cref="ArgumentOutOfRangeException">Unit test coverage must be in the range of 0 - 100. - UnitTestCoverage</exception>
        /// <remarks>Value must be between 0 - 100</remarks>
        public double UnitTestCoverage
        {
            get => this._unitTestCoverage;
            set
            {
                this._unitTestCoverage = IsInRange(value, 0, 100) ? value : throw new ArgumentOutOfRangeException("Unit test coverage must be in the range of 0 - 100.", nameof(UnitTestCoverage));
            }
        }

        private static bool IsInRange(int value, int lower, int upper)
        {
            return value >= lower && value <= upper;
        }

        private static bool IsInRange(double value, double lower, double upper)
        {
            return value >= lower && value <= upper;
        }

    }
}
