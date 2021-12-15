// <copyright file="ObcReportExtensions.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Extension methods on <see cref="OBeautifulCode.DataStructure.Report"/>.
    /// </summary>
    public static partial class ObcReportExtensions
    {
        /// <summary>
        /// Convert a <see cref="OBeautifulCode.DataStructure.Report"/> to a <see cref="Report"/>.
        /// </summary>
        /// <param name="obcReport">The OBC TreeTable to convert.</param>
        /// <param name="treeTableConversionMode">The TreeTable conversion strategy to use.</param>
        /// <param name="tokenToSubstitutionMap">TODO:.</param>
        /// <returns>A Report.</returns>
        public static Report ConvertToVuescapeReport(
            this OBeautifulCode.DataStructure.Report obcReport,
            TreeTableConversionMode treeTableConversionMode = TreeTableConversionMode.Relaxed,
            IReadOnlyDictionary<string, string> tokenToSubstitutionMap = null)
        {
            var sections = obcReport.Sections.Select(_ => _.ConvertToVuescapeSection(treeTableConversionMode, tokenToSubstitutionMap)).ToList();
            var result = new Report(obcReport.Id, sections, obcReport.Title);
            return result;
        }
    }
}
