﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.155.0)
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
    public partial class TreeTableCell : IModel<TreeTableCell>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="TreeTableCell"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(TreeTableCell left, TreeTableCell right)
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
        /// Determines whether two objects of type <see cref="TreeTableCell"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(TreeTableCell left, TreeTableCell right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(TreeTableCell other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.Id.IsEqualTo(other.Id, StringComparer.Ordinal)
                      && this.DisplayValue.IsEqualTo(other.DisplayValue, StringComparer.Ordinal)
                      && this.Hover.IsEqualTo(other.Hover)
                      && this.Renderer.IsEqualTo(other.Renderer, StringComparer.Ordinal)
                      && this.CssClasses.IsEqualTo(other.CssClasses, StringComparer.Ordinal)
                      && this.CssStyle.IsEqualTo(other.CssStyle, StringComparer.Ordinal)
                      && this.Colspan.IsEqualTo(other.Colspan)
                      && this.IsVisible.IsEqualTo(other.IsVisible)
                      && this.Links.IsEqualTo(other.Links)
                      && this.Slots.IsEqualTo(other.Slots);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as TreeTableCell);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.Id)
            .Hash(this.DisplayValue)
            .Hash(this.Hover)
            .Hash(this.Renderer)
            .Hash(this.CssClasses)
            .Hash(this.CssStyle)
            .Hash(this.Colspan)
            .Hash(this.IsVisible)
            .Hash(this.Links)
            .Hash(this.Slots)
            .Value;

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public TreeTableCell DeepClone()
        {
            var result = new TreeTableCell(
                                 this.Id?.DeepClone(),
                                 this.DisplayValue?.DeepClone(),
                                 this.Hover?.DeepClone(),
                                 this.Renderer?.DeepClone(),
                                 this.CssClasses?.DeepClone(),
                                 this.CssStyle?.DeepClone(),
                                 this.Colspan?.DeepClone(),
                                 this.IsVisible.DeepClone(),
                                 this.Links?.DeepClone(),
                                 this.Slots?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Id" />.
        /// </summary>
        /// <param name="id">The new <see cref="Id" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TreeTableCell" /> using the specified <paramref name="id" /> for <see cref="Id" /> and a deep clone of every other property.</returns>
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
        public TreeTableCell DeepCloneWithId(string id)
        {
            var result = new TreeTableCell(
                                 id,
                                 this.DisplayValue?.DeepClone(),
                                 this.Hover?.DeepClone(),
                                 this.Renderer?.DeepClone(),
                                 this.CssClasses?.DeepClone(),
                                 this.CssStyle?.DeepClone(),
                                 this.Colspan?.DeepClone(),
                                 this.IsVisible.DeepClone(),
                                 this.Links?.DeepClone(),
                                 this.Slots?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="DisplayValue" />.
        /// </summary>
        /// <param name="displayValue">The new <see cref="DisplayValue" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TreeTableCell" /> using the specified <paramref name="displayValue" /> for <see cref="DisplayValue" /> and a deep clone of every other property.</returns>
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
        public TreeTableCell DeepCloneWithDisplayValue(string displayValue)
        {
            var result = new TreeTableCell(
                                 this.Id?.DeepClone(),
                                 displayValue,
                                 this.Hover?.DeepClone(),
                                 this.Renderer?.DeepClone(),
                                 this.CssClasses?.DeepClone(),
                                 this.CssStyle?.DeepClone(),
                                 this.Colspan?.DeepClone(),
                                 this.IsVisible.DeepClone(),
                                 this.Links?.DeepClone(),
                                 this.Slots?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Hover" />.
        /// </summary>
        /// <param name="hover">The new <see cref="Hover" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TreeTableCell" /> using the specified <paramref name="hover" /> for <see cref="Hover" /> and a deep clone of every other property.</returns>
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
        public TreeTableCell DeepCloneWithHover(Hover hover)
        {
            var result = new TreeTableCell(
                                 this.Id?.DeepClone(),
                                 this.DisplayValue?.DeepClone(),
                                 hover,
                                 this.Renderer?.DeepClone(),
                                 this.CssClasses?.DeepClone(),
                                 this.CssStyle?.DeepClone(),
                                 this.Colspan?.DeepClone(),
                                 this.IsVisible.DeepClone(),
                                 this.Links?.DeepClone(),
                                 this.Slots?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Renderer" />.
        /// </summary>
        /// <param name="renderer">The new <see cref="Renderer" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TreeTableCell" /> using the specified <paramref name="renderer" /> for <see cref="Renderer" /> and a deep clone of every other property.</returns>
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
        public TreeTableCell DeepCloneWithRenderer(string renderer)
        {
            var result = new TreeTableCell(
                                 this.Id?.DeepClone(),
                                 this.DisplayValue?.DeepClone(),
                                 this.Hover?.DeepClone(),
                                 renderer,
                                 this.CssClasses?.DeepClone(),
                                 this.CssStyle?.DeepClone(),
                                 this.Colspan?.DeepClone(),
                                 this.IsVisible.DeepClone(),
                                 this.Links?.DeepClone(),
                                 this.Slots?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="CssClasses" />.
        /// </summary>
        /// <param name="cssClasses">The new <see cref="CssClasses" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TreeTableCell" /> using the specified <paramref name="cssClasses" /> for <see cref="CssClasses" /> and a deep clone of every other property.</returns>
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
        public TreeTableCell DeepCloneWithCssClasses(string cssClasses)
        {
            var result = new TreeTableCell(
                                 this.Id?.DeepClone(),
                                 this.DisplayValue?.DeepClone(),
                                 this.Hover?.DeepClone(),
                                 this.Renderer?.DeepClone(),
                                 cssClasses,
                                 this.CssStyle?.DeepClone(),
                                 this.Colspan?.DeepClone(),
                                 this.IsVisible.DeepClone(),
                                 this.Links?.DeepClone(),
                                 this.Slots?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="CssStyle" />.
        /// </summary>
        /// <param name="cssStyle">The new <see cref="CssStyle" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TreeTableCell" /> using the specified <paramref name="cssStyle" /> for <see cref="CssStyle" /> and a deep clone of every other property.</returns>
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
        public TreeTableCell DeepCloneWithCssStyle(string cssStyle)
        {
            var result = new TreeTableCell(
                                 this.Id?.DeepClone(),
                                 this.DisplayValue?.DeepClone(),
                                 this.Hover?.DeepClone(),
                                 this.Renderer?.DeepClone(),
                                 this.CssClasses?.DeepClone(),
                                 cssStyle,
                                 this.Colspan?.DeepClone(),
                                 this.IsVisible.DeepClone(),
                                 this.Links?.DeepClone(),
                                 this.Slots?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Colspan" />.
        /// </summary>
        /// <param name="colspan">The new <see cref="Colspan" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TreeTableCell" /> using the specified <paramref name="colspan" /> for <see cref="Colspan" /> and a deep clone of every other property.</returns>
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
        public TreeTableCell DeepCloneWithColspan(int? colspan)
        {
            var result = new TreeTableCell(
                                 this.Id?.DeepClone(),
                                 this.DisplayValue?.DeepClone(),
                                 this.Hover?.DeepClone(),
                                 this.Renderer?.DeepClone(),
                                 this.CssClasses?.DeepClone(),
                                 this.CssStyle?.DeepClone(),
                                 colspan,
                                 this.IsVisible.DeepClone(),
                                 this.Links?.DeepClone(),
                                 this.Slots?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="IsVisible" />.
        /// </summary>
        /// <param name="isVisible">The new <see cref="IsVisible" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TreeTableCell" /> using the specified <paramref name="isVisible" /> for <see cref="IsVisible" /> and a deep clone of every other property.</returns>
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
        public TreeTableCell DeepCloneWithIsVisible(bool isVisible)
        {
            var result = new TreeTableCell(
                                 this.Id?.DeepClone(),
                                 this.DisplayValue?.DeepClone(),
                                 this.Hover?.DeepClone(),
                                 this.Renderer?.DeepClone(),
                                 this.CssClasses?.DeepClone(),
                                 this.CssStyle?.DeepClone(),
                                 this.Colspan?.DeepClone(),
                                 isVisible,
                                 this.Links?.DeepClone(),
                                 this.Slots?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Links" />.
        /// </summary>
        /// <param name="links">The new <see cref="Links" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TreeTableCell" /> using the specified <paramref name="links" /> for <see cref="Links" /> and a deep clone of every other property.</returns>
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
        public TreeTableCell DeepCloneWithLinks(IReadOnlyDictionary<string, Link> links)
        {
            var result = new TreeTableCell(
                                 this.Id?.DeepClone(),
                                 this.DisplayValue?.DeepClone(),
                                 this.Hover?.DeepClone(),
                                 this.Renderer?.DeepClone(),
                                 this.CssClasses?.DeepClone(),
                                 this.CssStyle?.DeepClone(),
                                 this.Colspan?.DeepClone(),
                                 this.IsVisible.DeepClone(),
                                 links,
                                 this.Slots?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Slots" />.
        /// </summary>
        /// <param name="slots">The new <see cref="Slots" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="TreeTableCell" /> using the specified <paramref name="slots" /> for <see cref="Slots" /> and a deep clone of every other property.</returns>
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
        public TreeTableCell DeepCloneWithSlots(SlottedUiObject slots)
        {
            var result = new TreeTableCell(
                                 this.Id?.DeepClone(),
                                 this.DisplayValue?.DeepClone(),
                                 this.Hover?.DeepClone(),
                                 this.Renderer?.DeepClone(),
                                 this.CssClasses?.DeepClone(),
                                 this.CssStyle?.DeepClone(),
                                 this.Colspan?.DeepClone(),
                                 this.IsVisible.DeepClone(),
                                 this.Links?.DeepClone(),
                                 slots);

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"Vuescape.DotNet.Domain.TreeTableCell: Id = {this.Id?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, DisplayValue = {this.DisplayValue?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Hover = {this.Hover?.ToString() ?? "<null>"}, Renderer = {this.Renderer?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, CssClasses = {this.CssClasses?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, CssStyle = {this.CssStyle?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Colspan = {this.Colspan?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, IsVisible = {this.IsVisible.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Links = {this.Links?.ToString() ?? "<null>"}, Slots = {this.Slots?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}