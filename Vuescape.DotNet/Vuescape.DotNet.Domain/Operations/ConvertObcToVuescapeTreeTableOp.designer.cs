﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.172.0)
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace Vuescape.DotNet.Domain
{
    using global::System;
    using global::System.CodeDom.Compiler;
    using global::System.Collections.Concurrent;
    using global::System.Collections.Generic;
    using global::System.Collections.ObjectModel;
    using global::System.Diagnostics.CodeAnalysis;
    using global::System.Globalization;
    using global::System.Linq;

    using global::OBeautifulCode.Cloning.Recipes;
    using global::OBeautifulCode.DataStructure;
    using global::OBeautifulCode.Equality.Recipes;
    using global::OBeautifulCode.Type;
    using global::OBeautifulCode.Type.Recipes;

    using static global::System.FormattableString;

    [Serializable]
    public partial class ConvertObcToVuescapeTreeTableOp : IModel<ConvertObcToVuescapeTreeTableOp>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="ConvertObcToVuescapeTreeTableOp"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(ConvertObcToVuescapeTreeTableOp left, ConvertObcToVuescapeTreeTableOp right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            {
                return false;
            }

            var result = left.Equals(right);

            return result;
        }

        /// <summary>
        /// Determines whether two objects of type <see cref="ConvertObcToVuescapeTreeTableOp"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(ConvertObcToVuescapeTreeTableOp left, ConvertObcToVuescapeTreeTableOp right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(ConvertObcToVuescapeTreeTableOp other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.ObcTreeTable.IsEqualTo(other.ObcTreeTable)
                      && this.TreeTableConversionMode.IsEqualTo(other.TreeTableConversionMode)
                      && this.TokenToSubstitutionMap.IsEqualTo(other.TokenToSubstitutionMap);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as ConvertObcToVuescapeTreeTableOp);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.ObcTreeTable)
            .Hash(this.TreeTableConversionMode)
            .Hash(this.TokenToSubstitutionMap)
            .Value;

        /// <inheritdoc />
        public new ConvertObcToVuescapeTreeTableOp DeepClone() => (ConvertObcToVuescapeTreeTableOp)this.DeepCloneInternal();

        /// <summary>
        /// Deep clones this object with a new <see cref="ObcTreeTable" />.
        /// </summary>
        /// <param name="obcTreeTable">The new <see cref="ObcTreeTable" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ConvertObcToVuescapeTreeTableOp" /> using the specified <paramref name="obcTreeTable" /> for <see cref="ObcTreeTable" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings")]
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")]
        [SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames")]
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1722:IdentifiersShouldNotHaveIncorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly")]
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public ConvertObcToVuescapeTreeTableOp DeepCloneWithObcTreeTable(OBeautifulCode.DataStructure.TreeTable obcTreeTable)
        {
            var result = new ConvertObcToVuescapeTreeTableOp(
                                 obcTreeTable,
                                 this.TreeTableConversionMode.DeepClone(),
                                 this.TokenToSubstitutionMap?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="TreeTableConversionMode" />.
        /// </summary>
        /// <param name="treeTableConversionMode">The new <see cref="TreeTableConversionMode" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ConvertObcToVuescapeTreeTableOp" /> using the specified <paramref name="treeTableConversionMode" /> for <see cref="TreeTableConversionMode" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings")]
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")]
        [SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames")]
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1722:IdentifiersShouldNotHaveIncorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly")]
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public ConvertObcToVuescapeTreeTableOp DeepCloneWithTreeTableConversionMode(TreeTableConversionMode treeTableConversionMode)
        {
            var result = new ConvertObcToVuescapeTreeTableOp(
                                 this.ObcTreeTable?.DeepClone(),
                                 treeTableConversionMode,
                                 this.TokenToSubstitutionMap?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="TokenToSubstitutionMap" />.
        /// </summary>
        /// <param name="tokenToSubstitutionMap">The new <see cref="TokenToSubstitutionMap" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="ConvertObcToVuescapeTreeTableOp" /> using the specified <paramref name="tokenToSubstitutionMap" /> for <see cref="TokenToSubstitutionMap" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings")]
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")]
        [SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames")]
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1722:IdentifiersShouldNotHaveIncorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly")]
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public ConvertObcToVuescapeTreeTableOp DeepCloneWithTokenToSubstitutionMap(IReadOnlyDictionary<string, string> tokenToSubstitutionMap)
        {
            var result = new ConvertObcToVuescapeTreeTableOp(
                                 this.ObcTreeTable?.DeepClone(),
                                 this.TreeTableConversionMode.DeepClone(),
                                 tokenToSubstitutionMap);

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        protected override OperationBase DeepCloneInternal()
        {
            var result = new ConvertObcToVuescapeTreeTableOp(
                                 this.ObcTreeTable?.DeepClone(),
                                 this.TreeTableConversionMode.DeepClone(),
                                 this.TokenToSubstitutionMap?.DeepClone());

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"Vuescape.DotNet.Domain.ConvertObcToVuescapeTreeTableOp: ObcTreeTable = {this.ObcTreeTable?.ToString() ?? "<null>"}, TreeTableConversionMode = {this.TreeTableConversionMode.ToString() ?? "<null>"}, TokenToSubstitutionMap = {this.TokenToSubstitutionMap?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}