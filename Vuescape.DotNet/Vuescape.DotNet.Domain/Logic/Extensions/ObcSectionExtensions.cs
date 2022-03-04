// <copyright file="ObcSectionExtensions.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Collections.Generic;

    using OBeautifulCode.Assertion.Recipes;

    /// <summary>
    /// Extension methods on <see cref="OBeautifulCode.DataStructure.Section"/>.
    /// </summary>
    public static partial class ObcReportExtensions
    {
        /// <summary>
        /// Convert a <see cref="OBeautifulCode.DataStructure.Section"/> to a <see cref="Section"/>.
        /// </summary>
        /// <param name="obcSection">The OBC Section to convert.</param>
        /// <param name="obcToVuescapeConversionContext">The conversion context.</param>
        /// <param name="tokenToSubstitutionMap">TODO:.</param>
        /// <returns>A TreeTable.</returns>
        public static Section ConvertToVuescapeSection(
            this OBeautifulCode.DataStructure.Section obcSection,
            ObcToVuescapeConversionContext obcToVuescapeConversionContext,
            IReadOnlyDictionary<string, string> tokenToSubstitutionMap = null)
        {
            new { obcSection }.Must().NotBeNull();

            var obcTreeTable = obcSection.TreeTable;

            var treeTable = obcTreeTable.ConvertToVuescapeTreeTable(obcToVuescapeConversionContext, tokenToSubstitutionMap);
            var result = new Section(obcSection.Id, treeTable, obcSection.Title, obcSection.Name);

            return result;
        }
    }
}
