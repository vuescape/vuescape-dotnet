﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.154.0)
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
    using global::OBeautifulCode.Equality.Recipes;
    using global::OBeautifulCode.Type;
    using global::OBeautifulCode.Type.Recipes;

    using static global::System.FormattableString;

    [Serializable]
    public partial class TreeTableContent : IModel<TreeTableContent>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="TreeTableContent"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(TreeTableContent left, TreeTableContent right)
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
        /// Determines whether two objects of type <see cref="TreeTableContent"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(TreeTableContent left, TreeTableContent right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(TreeTableContent other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.Headers.IsEqualTo(other.Headers)
                      && this.Rows.IsEqualTo(other.Rows)
                      && this.ShouldScrollVertical.IsEqualTo(other.ShouldScrollVertical)
                      && this.ShouldScrollHorizontal.IsEqualTo(other.ShouldScrollHorizontal)
                      && this.ShouldSyncHeaderScroll.IsEqualTo(other.ShouldSyncHeaderScroll)
                      && this.ShouldSyncFooterScroll.IsEqualTo(other.ShouldSyncFooterScroll)
                      && this.ShouldIncludeFooter.IsEqualTo(other.ShouldIncludeFooter)
                      && this.ShouldFreezeFirstColumn.IsEqualTo(other.ShouldFreezeFirstColumn)
                      && this.DeadAreaColor.IsEqualTo(other.DeadAreaColor, StringComparer.Ordinal)
                      && this.MaxRows.IsEqualTo(other.MaxRows)
                      && this.CssStyle.IsEqualTo(other.CssStyle, StringComparer.Ordinal);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as TreeTableContent);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.Headers)
            .Hash(this.Rows)
            .Hash(this.ShouldScrollVertical)
            .Hash(this.ShouldScrollHorizontal)
            .Hash(this.ShouldSyncHeaderScroll)
            .Hash(this.ShouldSyncFooterScroll)
            .Hash(this.ShouldIncludeFooter)
            .Hash(this.ShouldFreezeFirstColumn)
            .Hash(this.DeadAreaColor)
            .Hash(this.MaxRows)
            .Hash(this.CssStyle)
            .Value;

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public TreeTableContent DeepClone()
        {
            var result = new TreeTableContent(
                                 this.Headers?.DeepClone(),
                                 this.Rows?.DeepClone(),
                                 this.ShouldScrollVertical.DeepClone(),
                                 this.ShouldScrollHorizontal.DeepClone(),
                                 this.ShouldSyncHeaderScroll.DeepClone(),
                                 this.ShouldSyncFooterScroll.DeepClone(),
                                 this.ShouldIncludeFooter.DeepClone(),
                                 this.ShouldFreezeFirstColumn.DeepClone(),
                                 this.DeadAreaColor?.DeepClone(),
                                 this.MaxRows?.DeepClone(),
                                 this.CssStyle?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Headers" />.
        /// </summary>
        /// <param name="headers">The new <see cref="Headers" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TreeTableContent" /> using the specified <paramref name="headers" /> for <see cref="Headers" /> and a deep clone of every other property.</returns>
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
        public TreeTableContent DeepCloneWithHeaders(IReadOnlyList<TreeTableHeaderRow> headers)
        {
            var result = new TreeTableContent(
                                 headers,
                                 this.Rows?.DeepClone(),
                                 this.ShouldScrollVertical.DeepClone(),
                                 this.ShouldScrollHorizontal.DeepClone(),
                                 this.ShouldSyncHeaderScroll.DeepClone(),
                                 this.ShouldSyncFooterScroll.DeepClone(),
                                 this.ShouldIncludeFooter.DeepClone(),
                                 this.ShouldFreezeFirstColumn.DeepClone(),
                                 this.DeadAreaColor?.DeepClone(),
                                 this.MaxRows?.DeepClone(),
                                 this.CssStyle?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Rows" />.
        /// </summary>
        /// <param name="rows">The new <see cref="Rows" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TreeTableContent" /> using the specified <paramref name="rows" /> for <see cref="Rows" /> and a deep clone of every other property.</returns>
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
        public TreeTableContent DeepCloneWithRows(IReadOnlyList<TreeTableRow> rows)
        {
            var result = new TreeTableContent(
                                 this.Headers?.DeepClone(),
                                 rows,
                                 this.ShouldScrollVertical.DeepClone(),
                                 this.ShouldScrollHorizontal.DeepClone(),
                                 this.ShouldSyncHeaderScroll.DeepClone(),
                                 this.ShouldSyncFooterScroll.DeepClone(),
                                 this.ShouldIncludeFooter.DeepClone(),
                                 this.ShouldFreezeFirstColumn.DeepClone(),
                                 this.DeadAreaColor?.DeepClone(),
                                 this.MaxRows?.DeepClone(),
                                 this.CssStyle?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ShouldScrollVertical" />.
        /// </summary>
        /// <param name="shouldScrollVertical">The new <see cref="ShouldScrollVertical" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TreeTableContent" /> using the specified <paramref name="shouldScrollVertical" /> for <see cref="ShouldScrollVertical" /> and a deep clone of every other property.</returns>
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
        public TreeTableContent DeepCloneWithShouldScrollVertical(bool shouldScrollVertical)
        {
            var result = new TreeTableContent(
                                 this.Headers?.DeepClone(),
                                 this.Rows?.DeepClone(),
                                 shouldScrollVertical,
                                 this.ShouldScrollHorizontal.DeepClone(),
                                 this.ShouldSyncHeaderScroll.DeepClone(),
                                 this.ShouldSyncFooterScroll.DeepClone(),
                                 this.ShouldIncludeFooter.DeepClone(),
                                 this.ShouldFreezeFirstColumn.DeepClone(),
                                 this.DeadAreaColor?.DeepClone(),
                                 this.MaxRows?.DeepClone(),
                                 this.CssStyle?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ShouldScrollHorizontal" />.
        /// </summary>
        /// <param name="shouldScrollHorizontal">The new <see cref="ShouldScrollHorizontal" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TreeTableContent" /> using the specified <paramref name="shouldScrollHorizontal" /> for <see cref="ShouldScrollHorizontal" /> and a deep clone of every other property.</returns>
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
        public TreeTableContent DeepCloneWithShouldScrollHorizontal(bool shouldScrollHorizontal)
        {
            var result = new TreeTableContent(
                                 this.Headers?.DeepClone(),
                                 this.Rows?.DeepClone(),
                                 this.ShouldScrollVertical.DeepClone(),
                                 shouldScrollHorizontal,
                                 this.ShouldSyncHeaderScroll.DeepClone(),
                                 this.ShouldSyncFooterScroll.DeepClone(),
                                 this.ShouldIncludeFooter.DeepClone(),
                                 this.ShouldFreezeFirstColumn.DeepClone(),
                                 this.DeadAreaColor?.DeepClone(),
                                 this.MaxRows?.DeepClone(),
                                 this.CssStyle?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ShouldSyncHeaderScroll" />.
        /// </summary>
        /// <param name="shouldSyncHeaderScroll">The new <see cref="ShouldSyncHeaderScroll" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TreeTableContent" /> using the specified <paramref name="shouldSyncHeaderScroll" /> for <see cref="ShouldSyncHeaderScroll" /> and a deep clone of every other property.</returns>
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
        public TreeTableContent DeepCloneWithShouldSyncHeaderScroll(bool shouldSyncHeaderScroll)
        {
            var result = new TreeTableContent(
                                 this.Headers?.DeepClone(),
                                 this.Rows?.DeepClone(),
                                 this.ShouldScrollVertical.DeepClone(),
                                 this.ShouldScrollHorizontal.DeepClone(),
                                 shouldSyncHeaderScroll,
                                 this.ShouldSyncFooterScroll.DeepClone(),
                                 this.ShouldIncludeFooter.DeepClone(),
                                 this.ShouldFreezeFirstColumn.DeepClone(),
                                 this.DeadAreaColor?.DeepClone(),
                                 this.MaxRows?.DeepClone(),
                                 this.CssStyle?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ShouldSyncFooterScroll" />.
        /// </summary>
        /// <param name="shouldSyncFooterScroll">The new <see cref="ShouldSyncFooterScroll" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TreeTableContent" /> using the specified <paramref name="shouldSyncFooterScroll" /> for <see cref="ShouldSyncFooterScroll" /> and a deep clone of every other property.</returns>
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
        public TreeTableContent DeepCloneWithShouldSyncFooterScroll(bool shouldSyncFooterScroll)
        {
            var result = new TreeTableContent(
                                 this.Headers?.DeepClone(),
                                 this.Rows?.DeepClone(),
                                 this.ShouldScrollVertical.DeepClone(),
                                 this.ShouldScrollHorizontal.DeepClone(),
                                 this.ShouldSyncHeaderScroll.DeepClone(),
                                 shouldSyncFooterScroll,
                                 this.ShouldIncludeFooter.DeepClone(),
                                 this.ShouldFreezeFirstColumn.DeepClone(),
                                 this.DeadAreaColor?.DeepClone(),
                                 this.MaxRows?.DeepClone(),
                                 this.CssStyle?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ShouldIncludeFooter" />.
        /// </summary>
        /// <param name="shouldIncludeFooter">The new <see cref="ShouldIncludeFooter" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TreeTableContent" /> using the specified <paramref name="shouldIncludeFooter" /> for <see cref="ShouldIncludeFooter" /> and a deep clone of every other property.</returns>
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
        public TreeTableContent DeepCloneWithShouldIncludeFooter(bool shouldIncludeFooter)
        {
            var result = new TreeTableContent(
                                 this.Headers?.DeepClone(),
                                 this.Rows?.DeepClone(),
                                 this.ShouldScrollVertical.DeepClone(),
                                 this.ShouldScrollHorizontal.DeepClone(),
                                 this.ShouldSyncHeaderScroll.DeepClone(),
                                 this.ShouldSyncFooterScroll.DeepClone(),
                                 shouldIncludeFooter,
                                 this.ShouldFreezeFirstColumn.DeepClone(),
                                 this.DeadAreaColor?.DeepClone(),
                                 this.MaxRows?.DeepClone(),
                                 this.CssStyle?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="ShouldFreezeFirstColumn" />.
        /// </summary>
        /// <param name="shouldFreezeFirstColumn">The new <see cref="ShouldFreezeFirstColumn" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TreeTableContent" /> using the specified <paramref name="shouldFreezeFirstColumn" /> for <see cref="ShouldFreezeFirstColumn" /> and a deep clone of every other property.</returns>
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
        public TreeTableContent DeepCloneWithShouldFreezeFirstColumn(bool shouldFreezeFirstColumn)
        {
            var result = new TreeTableContent(
                                 this.Headers?.DeepClone(),
                                 this.Rows?.DeepClone(),
                                 this.ShouldScrollVertical.DeepClone(),
                                 this.ShouldScrollHorizontal.DeepClone(),
                                 this.ShouldSyncHeaderScroll.DeepClone(),
                                 this.ShouldSyncFooterScroll.DeepClone(),
                                 this.ShouldIncludeFooter.DeepClone(),
                                 shouldFreezeFirstColumn,
                                 this.DeadAreaColor?.DeepClone(),
                                 this.MaxRows?.DeepClone(),
                                 this.CssStyle?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="DeadAreaColor" />.
        /// </summary>
        /// <param name="deadAreaColor">The new <see cref="DeadAreaColor" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TreeTableContent" /> using the specified <paramref name="deadAreaColor" /> for <see cref="DeadAreaColor" /> and a deep clone of every other property.</returns>
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
        public TreeTableContent DeepCloneWithDeadAreaColor(string deadAreaColor)
        {
            var result = new TreeTableContent(
                                 this.Headers?.DeepClone(),
                                 this.Rows?.DeepClone(),
                                 this.ShouldScrollVertical.DeepClone(),
                                 this.ShouldScrollHorizontal.DeepClone(),
                                 this.ShouldSyncHeaderScroll.DeepClone(),
                                 this.ShouldSyncFooterScroll.DeepClone(),
                                 this.ShouldIncludeFooter.DeepClone(),
                                 this.ShouldFreezeFirstColumn.DeepClone(),
                                 deadAreaColor,
                                 this.MaxRows?.DeepClone(),
                                 this.CssStyle?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="MaxRows" />.
        /// </summary>
        /// <param name="maxRows">The new <see cref="MaxRows" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TreeTableContent" /> using the specified <paramref name="maxRows" /> for <see cref="MaxRows" /> and a deep clone of every other property.</returns>
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
        public TreeTableContent DeepCloneWithMaxRows(int? maxRows)
        {
            var result = new TreeTableContent(
                                 this.Headers?.DeepClone(),
                                 this.Rows?.DeepClone(),
                                 this.ShouldScrollVertical.DeepClone(),
                                 this.ShouldScrollHorizontal.DeepClone(),
                                 this.ShouldSyncHeaderScroll.DeepClone(),
                                 this.ShouldSyncFooterScroll.DeepClone(),
                                 this.ShouldIncludeFooter.DeepClone(),
                                 this.ShouldFreezeFirstColumn.DeepClone(),
                                 this.DeadAreaColor?.DeepClone(),
                                 maxRows,
                                 this.CssStyle?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="CssStyle" />.
        /// </summary>
        /// <param name="cssStyle">The new <see cref="CssStyle" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TreeTableContent" /> using the specified <paramref name="cssStyle" /> for <see cref="CssStyle" /> and a deep clone of every other property.</returns>
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
        public TreeTableContent DeepCloneWithCssStyle(string cssStyle)
        {
            var result = new TreeTableContent(
                                 this.Headers?.DeepClone(),
                                 this.Rows?.DeepClone(),
                                 this.ShouldScrollVertical.DeepClone(),
                                 this.ShouldScrollHorizontal.DeepClone(),
                                 this.ShouldSyncHeaderScroll.DeepClone(),
                                 this.ShouldSyncFooterScroll.DeepClone(),
                                 this.ShouldIncludeFooter.DeepClone(),
                                 this.ShouldFreezeFirstColumn.DeepClone(),
                                 this.DeadAreaColor?.DeepClone(),
                                 this.MaxRows?.DeepClone(),
                                 cssStyle);

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"Vuescape.DotNet.Domain.TreeTableContent: Headers = {this.Headers?.ToString() ?? "<null>"}, Rows = {this.Rows?.ToString() ?? "<null>"}, ShouldScrollVertical = {this.ShouldScrollVertical.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, ShouldScrollHorizontal = {this.ShouldScrollHorizontal.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, ShouldSyncHeaderScroll = {this.ShouldSyncHeaderScroll.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, ShouldSyncFooterScroll = {this.ShouldSyncFooterScroll.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, ShouldIncludeFooter = {this.ShouldIncludeFooter.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, ShouldFreezeFirstColumn = {this.ShouldFreezeFirstColumn.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, DeadAreaColor = {this.DeadAreaColor?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, MaxRows = {this.MaxRows?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, CssStyle = {this.CssStyle?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}.");

            return result;
        }
    }
}