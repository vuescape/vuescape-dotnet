// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BadgeSeverity.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    /// <summary>
    /// Represents the severity levels for a badge.
    /// </summary>
    public enum BadgeSeverity
    {
        /// <summary>
        /// Represents a null or undefined severity.
        /// </summary>
        None,

        /// <summary>
        /// Represents the 'secondary' severity.
        /// </summary>
        Secondary,

        /// <summary>
        /// Represents the 'info' severity.
        /// </summary>
        Info,

        /// <summary>
        /// Represents the 'success' severity.
        /// </summary>
        Success,

        /// <summary>
        /// Represents the 'warn' severity.
        /// </summary>
        Warn,

        /// <summary>
        /// Represents the 'danger' severity.
        /// </summary>
        Danger,

        /// <summary>
        /// Represents the 'contrast' severity.
        /// </summary>
        Contrast,
    }
}
