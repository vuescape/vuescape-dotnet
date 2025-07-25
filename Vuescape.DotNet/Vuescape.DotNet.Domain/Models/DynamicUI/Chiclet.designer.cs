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
    public partial class Chiclet : IModel<Chiclet>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="Chiclet"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(Chiclet left, Chiclet right)
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
        /// Determines whether two objects of type <see cref="Chiclet"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(Chiclet left, Chiclet right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(Chiclet other)
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
                      && this.Title.IsEqualTo(other.Title, StringComparer.Ordinal)
                      && this.IsVisible.IsEqualTo(other.IsVisible)
                      && this.Icons.IsEqualTo(other.Icons)
                      && this.CssClass.IsEqualTo(other.CssClass, StringComparer.Ordinal)
                      && this.Action.IsEqualTo(other.Action);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as Chiclet);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.Id)
            .Hash(this.Title)
            .Hash(this.IsVisible)
            .Hash(this.Icons)
            .Hash(this.CssClass)
            .Hash(this.Action)
            .Value;

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public Chiclet DeepClone()
        {
            var result = new Chiclet(
                                 this.Id?.DeepClone(),
                                 this.Title?.DeepClone(),
                                 this.IsVisible.DeepClone(),
                                 this.Action?.DeepClone(),
                                 this.Icons?.DeepClone(),
                                 this.CssClass?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Id" />.
        /// </summary>
        /// <param name="id">The new <see cref="Id" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="Chiclet" /> using the specified <paramref name="id" /> for <see cref="Id" /> and a deep clone of every other property.</returns>
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
        public Chiclet DeepCloneWithId(string id)
        {
            var result = new Chiclet(
                                 id,
                                 this.Title?.DeepClone(),
                                 this.IsVisible.DeepClone(),
                                 this.Action?.DeepClone(),
                                 this.Icons?.DeepClone(),
                                 this.CssClass?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Title" />.
        /// </summary>
        /// <param name="title">The new <see cref="Title" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="Chiclet" /> using the specified <paramref name="title" /> for <see cref="Title" /> and a deep clone of every other property.</returns>
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
        public Chiclet DeepCloneWithTitle(string title)
        {
            var result = new Chiclet(
                                 this.Id?.DeepClone(),
                                 title,
                                 this.IsVisible.DeepClone(),
                                 this.Action?.DeepClone(),
                                 this.Icons?.DeepClone(),
                                 this.CssClass?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="IsVisible" />.
        /// </summary>
        /// <param name="isVisible">The new <see cref="IsVisible" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="Chiclet" /> using the specified <paramref name="isVisible" /> for <see cref="IsVisible" /> and a deep clone of every other property.</returns>
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
        public Chiclet DeepCloneWithIsVisible(bool isVisible)
        {
            var result = new Chiclet(
                                 this.Id?.DeepClone(),
                                 this.Title?.DeepClone(),
                                 isVisible,
                                 this.Action?.DeepClone(),
                                 this.Icons?.DeepClone(),
                                 this.CssClass?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Icons" />.
        /// </summary>
        /// <param name="icons">The new <see cref="Icons" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="Chiclet" /> using the specified <paramref name="icons" /> for <see cref="Icons" /> and a deep clone of every other property.</returns>
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
        public Chiclet DeepCloneWithIcons(IReadOnlyList<string> icons)
        {
            var result = new Chiclet(
                                 this.Id?.DeepClone(),
                                 this.Title?.DeepClone(),
                                 this.IsVisible.DeepClone(),
                                 this.Action?.DeepClone(),
                                 icons,
                                 this.CssClass?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="CssClass" />.
        /// </summary>
        /// <param name="cssClass">The new <see cref="CssClass" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="Chiclet" /> using the specified <paramref name="cssClass" /> for <see cref="CssClass" /> and a deep clone of every other property.</returns>
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
        public Chiclet DeepCloneWithCssClass(string cssClass)
        {
            var result = new Chiclet(
                                 this.Id?.DeepClone(),
                                 this.Title?.DeepClone(),
                                 this.IsVisible.DeepClone(),
                                 this.Action?.DeepClone(),
                                 this.Icons?.DeepClone(),
                                 cssClass);

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Action" />.
        /// </summary>
        /// <param name="action">The new <see cref="Action" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="Chiclet" /> using the specified <paramref name="action" /> for <see cref="Action" /> and a deep clone of every other property.</returns>
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
        public Chiclet DeepCloneWithAction(ActionBase action)
        {
            var result = new Chiclet(
                                 this.Id?.DeepClone(),
                                 this.Title?.DeepClone(),
                                 this.IsVisible.DeepClone(),
                                 action,
                                 this.Icons?.DeepClone(),
                                 this.CssClass?.DeepClone());

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"Vuescape.DotNet.Domain.Chiclet: Id = {this.Id?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Title = {this.Title?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, IsVisible = {this.IsVisible.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Icons = {this.Icons?.ToString() ?? "<null>"}, CssClass = {this.CssClass?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Action = {this.Action?.ToString() ?? "<null>"}.");

            return result;
        }
    }
}