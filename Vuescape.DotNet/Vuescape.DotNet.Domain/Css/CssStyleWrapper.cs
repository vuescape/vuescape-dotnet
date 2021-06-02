// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CssStyleWrapper.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Wraps a Css Style.
    /// </summary>
    public partial class CssStyleWrapper : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CssStyleWrapper"/> class.
        /// </summary>
        /// <param name="cssStyle">The CSS Style.</param>
        public CssStyleWrapper(string cssStyle)
        {
            this.CssStyle = cssStyle;
        }

        /// <summary>
        /// Gets the CSS Style.
        /// </summary>
        public string CssStyle { get; private set; }
    }
}
