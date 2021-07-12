// <copyright file="ConvertObcToVuescapeTreeTableOp.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Collections.Generic;

    using Naos.Protocol.Domain;

    using OBeautifulCode.Assertion.Recipes;

    /// <summary>
    /// Convert a <see cref="OBeautifulCode.DataStructure.TreeTable"/> to a Vuescape <see cref="TreeTable"/>.
    /// </summary>
    public partial class ConvertObcToVuescapeTreeTableOp : ReturningOperationBase<TreeTable>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertObcToVuescapeTreeTableOp"/> class.
        /// </summary>
        /// <param name="obcTreeTable">The OBC TreeTable to convert.</param>
        /// <param name="treeTableConversionMode">The TreeTable conversion strategy to use.</param>
        /// <param name="tokenToSubstitutionMap">TODO:.</param>
        public ConvertObcToVuescapeTreeTableOp(
            OBeautifulCode.DataStructure.TreeTable obcTreeTable,
            TreeTableConversionMode treeTableConversionMode = TreeTableConversionMode.Relaxed,
            IReadOnlyDictionary<string, string> tokenToSubstitutionMap = null)
        {
            new { obcTreeTable }.AsArg().Must().NotBeNull();
            new { treeTableConversionStrategy = treeTableConversionMode }.AsArg().Must().NotBeEqualTo(TreeTableConversionMode.None);

            this.ObcTreeTable = obcTreeTable;
            this.TreeTableConversionMode = treeTableConversionMode;
            this.TokenToSubstitutionMap = tokenToSubstitutionMap;
        }

        /// <summary>
        /// Gets the ObcTreeTable.
        /// </summary>
        public OBeautifulCode.DataStructure.TreeTable ObcTreeTable { get; private set; }

        /// <summary>
        /// Gets the TreeTableConversionStrategy.
        /// </summary>
        public TreeTableConversionMode TreeTableConversionMode { get; private set; }

        /// <summary>
        /// Gets the TokenToSubstitutionMap.
        /// </summary>
        // ReSharper disable once MemberCanBePrivate.Global
        public IReadOnlyDictionary<string, string> TokenToSubstitutionMap { get; private set; }
    }
}
