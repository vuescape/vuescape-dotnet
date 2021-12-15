// <copyright file="ObcSectionExtensions.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Collections.Generic;

    /// <summary>
    /// Extension methods on <see cref="OBeautifulCode.DataStructure.Section"/>.
    /// </summary>
    public static partial class ObcReportExtensions
    {
        /// <summary>
        /// Convert a <see cref="OBeautifulCode.DataStructure.Section"/> to a <see cref="Section"/>.
        /// </summary>
        /// <param name="obcSection">The OBC Section to convert.</param>
        /// <param name="treeTableConversionMode">The TreeTable conversion strategy to use.</param>
        /// <param name="tokenToSubstitutionMap">TODO:.</param>
        /// <returns>A TreeTable.</returns>
        public static Section ConvertToVuescapeSection(
            this OBeautifulCode.DataStructure.Section obcSection,
            TreeTableConversionMode treeTableConversionMode = TreeTableConversionMode.Relaxed,
            IReadOnlyDictionary<string, string> tokenToSubstitutionMap = null)
        {
            var op = new ConvertObcToVuescapeTreeTableOp(obcSection.TreeTable, treeTableConversionMode, tokenToSubstitutionMap);
            var protocol = new ConvertObcToVuescapeTreeTableProtocol();
            var treeTable = protocol.Execute(op);
            var result = new Section(obcSection.Id, treeTable, obcSection.Title);

            return result;
        }
    }
}
