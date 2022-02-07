// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportConversionMode.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    /// <summary>
    /// The strategy to use when converting an <see cref="OBeautifulCode.DataStructure.TreeTable"/> to a Vuescape <see cref="TreeTable"/>.
    /// </summary>
    public enum ReportConversionMode
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Strict will throw an exception if any <see cref="OBeautifulCode.DataStructure.Report"/> properties can not be converted or are not supported.
        /// </summary>
        Strict,

        /// <summary>
        /// Relaxed will make a best efforts attempt to convert using defaults, ignoring unsupported properties or making assumptions where required.
        /// It is still possible for an exception to be thrown in the case of inconsistent values or situations that cannot be sensibly resolved.
        /// </summary>
        Relaxed,
    }
}
