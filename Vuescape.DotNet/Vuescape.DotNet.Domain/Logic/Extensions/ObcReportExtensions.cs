// <copyright file="ObcReportExtensions.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    using OBeautifulCode.Assertion.Recipes;

    /// <summary>
    /// Extension methods on <see cref="OBeautifulCode.DataStructure.Report"/>.
    /// </summary>
    public static partial class ObcReportExtensions
    {
        /// <summary>
        /// Convert a <see cref="OBeautifulCode.DataStructure.Report"/> to a <see cref="Report"/>.
        /// </summary>
        /// <param name="obcReport">The OBC Report to convert.</param>
        /// <param name="obcToVuescapeConversionContext">The conversion context.</param>
        /// <param name="tokenToSubstitutionMap">TODO:.</param>
        /// <returns>A Report.</returns>
        public static Report ConvertToVuescapeReport(
            this OBeautifulCode.DataStructure.Report obcReport,
            ObcToVuescapeConversionContext obcToVuescapeConversionContext,
            IReadOnlyDictionary<string, string> tokenToSubstitutionMap = null)
        {
            new { obcReport }.Must().NotBeNull();

            var sections = obcReport.Sections.Select(_ => _.ConvertToVuescapeSection(obcToVuescapeConversionContext, tokenToSubstitutionMap)).ToList();

            string additionalReportInfo = null;
            if (obcReport.Format?.DisplayTimestamp == true)
            {
                additionalReportInfo = obcReport.TimestampUtc?.ToString("dddd, MMMM, d, yyyy", CultureInfo.InvariantCulture);
                if (additionalReportInfo != null)
                {
                    additionalReportInfo = "As Of: " + additionalReportInfo;
                }
            }

            var result = new Report(obcReport.Id, sections, obcReport.Title, additionalReportInfo);
            return result;
        }
    }
}
