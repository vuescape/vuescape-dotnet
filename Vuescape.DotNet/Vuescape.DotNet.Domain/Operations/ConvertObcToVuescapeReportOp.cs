// <copyright file="ConvertObcToVuescapeReportOp.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Collections.Generic;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Convert a <see cref="OBeautifulCode.DataStructure.Report"/> to a Vuescape <see cref="Report"/>.
    /// </summary>
    public partial class ConvertObcToVuescapeReportOp : ReturningOperationBase<Report>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertObcToVuescapeReportOp"/> class.
        /// </summary>
        /// <param name="obcReport">The OBC Report to convert.</param>
        /// <param name="obcToVuescapeConversionContext">The context to use in the conversion.</param>
        /// <param name="tokenToSubstitutionMap">TODO:.</param>
        public ConvertObcToVuescapeReportOp(
            OBeautifulCode.DataStructure.Report obcReport,
            ObcToVuescapeConversionContext obcToVuescapeConversionContext,
            IReadOnlyDictionary<string, string> tokenToSubstitutionMap = null)
        {
            new { obcReport }.AsArg().Must().NotBeNull();
            new { obcToVuescapeConversionContext }.AsArg().Must().NotBeNull();

            this.ObcReport = obcReport;
            this.TokenToSubstitutionMap = tokenToSubstitutionMap;
            this.ObcToVuescapeConversionContext = obcToVuescapeConversionContext;
        }

        /// <summary>
        /// Gets the OBC Report.
        /// </summary>
        public OBeautifulCode.DataStructure.Report ObcReport { get; private set; }

        /// <summary>
        /// Gets the ObcToVuescapeConversionContext.
        /// </summary>
        public ObcToVuescapeConversionContext ObcToVuescapeConversionContext { get; private set; }

        /// <summary>
        /// Gets the TokenToSubstitutionMap.
        /// </summary>
        // ReSharper disable once MemberCanBePrivate.Global
        public IReadOnlyDictionary<string, string> TokenToSubstitutionMap { get; private set; }
    }
}
