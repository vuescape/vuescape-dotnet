﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.196.0)
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
    public partial class CellFormat : IModel<CellFormat>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="CellFormat"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(CellFormat left, CellFormat right)
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
        /// Determines whether two objects of type <see cref="CellFormat"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(CellFormat left, CellFormat right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(CellFormat other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.FontHexColor.IsEqualTo(other.FontHexColor, StringComparer.Ordinal)
                      && this.FontSizeInPixels.IsEqualTo(other.FontSizeInPixels, StringComparer.Ordinal)
                      && this.BackgroundHexColor.IsEqualTo(other.BackgroundHexColor, StringComparer.Ordinal)
                      && this.HorizontalAlignment.IsEqualTo(other.HorizontalAlignment);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as CellFormat);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.FontHexColor)
            .Hash(this.FontSizeInPixels)
            .Hash(this.BackgroundHexColor)
            .Hash(this.HorizontalAlignment)
            .Value;

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public CellFormat DeepClone()
        {
            var result = new CellFormat(
                                 this.FontHexColor?.DeepClone(),
                                 this.FontSizeInPixels?.DeepClone(),
                                 this.BackgroundHexColor?.DeepClone(),
                                 this.HorizontalAlignment?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="FontHexColor" />.
        /// </summary>
        /// <param name="fontHexColor">The new <see cref="FontHexColor" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="CellFormat" /> using the specified <paramref name="fontHexColor" /> for <see cref="FontHexColor" /> and a deep clone of every other property.</returns>
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
        public CellFormat DeepCloneWithFontHexColor(string fontHexColor)
        {
            var result = new CellFormat(
                                 fontHexColor,
                                 this.FontSizeInPixels?.DeepClone(),
                                 this.BackgroundHexColor?.DeepClone(),
                                 this.HorizontalAlignment?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="FontSizeInPixels" />.
        /// </summary>
        /// <param name="fontSizeInPixels">The new <see cref="FontSizeInPixels" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="CellFormat" /> using the specified <paramref name="fontSizeInPixels" /> for <see cref="FontSizeInPixels" /> and a deep clone of every other property.</returns>
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
        public CellFormat DeepCloneWithFontSizeInPixels(string fontSizeInPixels)
        {
            var result = new CellFormat(
                                 this.FontHexColor?.DeepClone(),
                                 fontSizeInPixels,
                                 this.BackgroundHexColor?.DeepClone(),
                                 this.HorizontalAlignment?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="BackgroundHexColor" />.
        /// </summary>
        /// <param name="backgroundHexColor">The new <see cref="BackgroundHexColor" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="CellFormat" /> using the specified <paramref name="backgroundHexColor" /> for <see cref="BackgroundHexColor" /> and a deep clone of every other property.</returns>
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
        public CellFormat DeepCloneWithBackgroundHexColor(string backgroundHexColor)
        {
            var result = new CellFormat(
                                 this.FontHexColor?.DeepClone(),
                                 this.FontSizeInPixels?.DeepClone(),
                                 backgroundHexColor,
                                 this.HorizontalAlignment?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="HorizontalAlignment" />.
        /// </summary>
        /// <param name="horizontalAlignment">The new <see cref="HorizontalAlignment" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="CellFormat" /> using the specified <paramref name="horizontalAlignment" /> for <see cref="HorizontalAlignment" /> and a deep clone of every other property.</returns>
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
        public CellFormat DeepCloneWithHorizontalAlignment(HorizontalAlignment? horizontalAlignment)
        {
            var result = new CellFormat(
                                 this.FontHexColor?.DeepClone(),
                                 this.FontSizeInPixels?.DeepClone(),
                                 this.BackgroundHexColor?.DeepClone(),
                                 horizontalAlignment);

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"Vuescape.DotNet.Domain.CellFormat: FontHexColor = {this.FontHexColor?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, FontSizeInPixels = {this.FontSizeInPixels?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, BackgroundHexColor = {this.BackgroundHexColor?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, HorizontalAlignment = {this.HorizontalAlignment?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}