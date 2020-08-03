using System;

namespace dotNetTips.Utility.Standard.Common
{
    public enum BenchMarkStatus
    {
        None,
        NotRequired,
        WIP,
        Completed
    }

    /// <summary>
    /// Information status.
    /// </summary>
    [Information(message: "For use in InformationAttribute.", author: "David McCarter", createdOn: "7/29/2020", modifiedOn: "7/29/2020", Status = Status.Available)]
    public enum Status
    {
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

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Delegate, Inherited = false)]
    public sealed class InformationAttribute : Attribute
    {
        private double _unitTestCoverage = 0;

        public InformationAttribute()
        {
        }

        public InformationAttribute(string message, string author, string createdOn) : this(message, author, createdOn, createdOn)
        {
        }

        public InformationAttribute(string message, string author, string createdOn, string modifiedOn)
        {
            Message = message;
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

        public string Author { get; }

        public DateTimeOffset CreatedOn { get; }

        public Status Status { get; set; } = Status.Available;

        public string Message { get; }

        public string ModifiedBy { get; set; }

        public DateTimeOffset ModifiedOn { get; }

        public BenchMarkStatus BenchMarkStatus { get; set; } = BenchMarkStatus.None;

        public double UnitTestCoverage
        {
            get => this._unitTestCoverage;
            set
            {
                if (this.IsInRange(value, 0, 100))
                {
                    this._unitTestCoverage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Unit test coverage must be in the range of 0 - 100.", nameof(UnitTestCoverage));
                }
            }
        }

        private bool IsInRange(int value, int lower, int upper) => value >= lower && value <= upper;

        private bool IsInRange(double value, double lower, double upper) => value >= lower && value <= upper;

    }
}
