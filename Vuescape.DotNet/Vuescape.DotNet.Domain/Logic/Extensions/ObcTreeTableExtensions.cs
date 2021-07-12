// <copyright file="ObcTreeTableExtensions.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Collections.Generic;

    /// <summary>
    /// Extension methods on <see cref="OBeautifulCode.DataStructure.TreeTable"/>.
    /// </summary>
    public static partial class ObcTreeTableExtensions
    {
        /// <summary>
        /// Convert a <see cref="OBeautifulCode.DataStructure.TreeTable"/> to a <see cref="TreeTable"/>.
        /// </summary>
        /// <param name="obcTreeTable">The OBC TreeTable to convert.</param>
        /// <param name="treeTableConversionMode">The TreeTable conversion strategy to use.</param>
        /// <param name="tokenToSubstitutionMap">TODO:.</param>
        /// <returns>A TreeTable.</returns>
        public static TreeTable ConvertToVuescapeTreeTable(
            this OBeautifulCode.DataStructure.TreeTable obcTreeTable,
            TreeTableConversionMode treeTableConversionMode = TreeTableConversionMode.Relaxed,
            IReadOnlyDictionary<string, string> tokenToSubstitutionMap = null)
        {
            var op = new ConvertObcToVuescapeTreeTableOp(obcTreeTable, treeTableConversionMode, tokenToSubstitutionMap);
            var protocol = new ConvertObcToVuescapeTreeTableProtocol();
            var result = protocol.Execute(op);

            return result;
        }
    }
}
