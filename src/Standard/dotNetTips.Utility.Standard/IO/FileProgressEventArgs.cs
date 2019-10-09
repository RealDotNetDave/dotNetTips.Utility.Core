// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 08-07-2017
//
// Last Modified By : David McCarter
// Last Modified On : 05-31-2019
// ***********************************************************************
// <copyright file="FileProgressEventArgs.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace dotNetTips.Utility.Standard.IO
{
    /// <summary>
    /// Class ProgressEventArgs.
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    public sealed class FileProgressEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileProgressEventArgs" /> class.
        /// </summary>
        public FileProgressEventArgs() => this.Message = string.Empty;

        /// <summary>
        /// Gets the file progres message
        /// </summary>
        /// <value>The message.</value>
        public string Message
        {
            get; set;
        }

        /// <summary>
        /// The name
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get; set;
        }

        /// <summary>
        /// The progress state
        /// </summary>
        /// <value>The state of the progress.</value>
        public FileProgressState ProgressState
        {
            get; set;
        }

        /// <summary>
        /// The size
        /// </summary>
        /// <value>The size.</value>
        public long Size
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the speed in milliseconds.
        /// </summary>
        /// <value>The speed in milliseconds.</value>
        public double SpeedInMilliseconds
        {
            get; set;
        }
    }
}
