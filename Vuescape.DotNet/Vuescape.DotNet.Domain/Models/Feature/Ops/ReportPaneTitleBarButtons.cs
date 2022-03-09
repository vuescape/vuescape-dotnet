// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportPaneTitleBarButtons.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System;

    /// <summary>
    /// The Buttons that can be displayed at the top of a report pane.
    /// </summary>
    [Flags]
    public enum ReportPaneTitleBarButtons
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// The report pane can be maximized (and by implication restored to the previous size).
        /// </summary>
        Maximize = 1,

        /// <summary>
        /// The report pane can be closed.
        /// </summary>
        Close = 2,
    }
}
