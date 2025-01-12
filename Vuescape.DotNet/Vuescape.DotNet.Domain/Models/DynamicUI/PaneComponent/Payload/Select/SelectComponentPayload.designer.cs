﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.191.0)
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
    public partial class SelectComponentPayload : IModel<SelectComponentPayload>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="SelectComponentPayload"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(SelectComponentPayload left, SelectComponentPayload right)
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
        /// Determines whether two objects of type <see cref="SelectComponentPayload"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(SelectComponentPayload left, SelectComponentPayload right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(SelectComponentPayload other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.Options.IsEqualTo(other.Options)
                      && this.SelectedValue.IsEqualTo(other.SelectedValue)
                      && this.OnChangeAction.IsEqualTo(other.OnChangeAction)
                      && this.Name.IsEqualTo(other.Name, StringComparer.Ordinal)
                      && this.OptionLabel.IsEqualTo(other.OptionLabel, StringComparer.Ordinal)
                      && this.Placeholder.IsEqualTo(other.Placeholder, StringComparer.Ordinal)
                      && this.Disabled.IsEqualTo(other.Disabled)
                      && this.CssClass.IsEqualTo(other.CssClass, StringComparer.Ordinal);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as SelectComponentPayload);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.Options)
            .Hash(this.SelectedValue)
            .Hash(this.OnChangeAction)
            .Hash(this.Name)
            .Hash(this.OptionLabel)
            .Hash(this.Placeholder)
            .Hash(this.Disabled)
            .Hash(this.CssClass)
            .Value;

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public SelectComponentPayload DeepClone()
        {
            var result = new SelectComponentPayload(
                                 this.Options?.DeepClone(),
                                 this.SelectedValue?.DeepClone(),
                                 this.OnChangeAction?.DeepClone(),
                                 this.Name?.DeepClone(),
                                 this.OptionLabel?.DeepClone(),
                                 this.Placeholder?.DeepClone(),
                                 this.Disabled?.DeepClone(),
                                 this.CssClass?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Options" />.
        /// </summary>
        /// <param name="options">The new <see cref="Options" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="SelectComponentPayload" /> using the specified <paramref name="options" /> for <see cref="Options" /> and a deep clone of every other property.</returns>
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
        public SelectComponentPayload DeepCloneWithOptions(IReadOnlyList<SelectOption> options)
        {
            var result = new SelectComponentPayload(
                                 options,
                                 this.SelectedValue?.DeepClone(),
                                 this.OnChangeAction?.DeepClone(),
                                 this.Name?.DeepClone(),
                                 this.OptionLabel?.DeepClone(),
                                 this.Placeholder?.DeepClone(),
                                 this.Disabled?.DeepClone(),
                                 this.CssClass?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="SelectedValue" />.
        /// </summary>
        /// <param name="selectedValue">The new <see cref="SelectedValue" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="SelectComponentPayload" /> using the specified <paramref name="selectedValue" /> for <see cref="SelectedValue" /> and a deep clone of every other property.</returns>
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
        public SelectComponentPayload DeepCloneWithSelectedValue(SelectOption selectedValue)
        {
            var result = new SelectComponentPayload(
                                 this.Options?.DeepClone(),
                                 selectedValue,
                                 this.OnChangeAction?.DeepClone(),
                                 this.Name?.DeepClone(),
                                 this.OptionLabel?.DeepClone(),
                                 this.Placeholder?.DeepClone(),
                                 this.Disabled?.DeepClone(),
                                 this.CssClass?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="OnChangeAction" />.
        /// </summary>
        /// <param name="onChangeAction">The new <see cref="OnChangeAction" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="SelectComponentPayload" /> using the specified <paramref name="onChangeAction" /> for <see cref="OnChangeAction" /> and a deep clone of every other property.</returns>
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
        public SelectComponentPayload DeepCloneWithOnChangeAction(ActionBase onChangeAction)
        {
            var result = new SelectComponentPayload(
                                 this.Options?.DeepClone(),
                                 this.SelectedValue?.DeepClone(),
                                 onChangeAction,
                                 this.Name?.DeepClone(),
                                 this.OptionLabel?.DeepClone(),
                                 this.Placeholder?.DeepClone(),
                                 this.Disabled?.DeepClone(),
                                 this.CssClass?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Name" />.
        /// </summary>
        /// <param name="name">The new <see cref="Name" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="SelectComponentPayload" /> using the specified <paramref name="name" /> for <see cref="Name" /> and a deep clone of every other property.</returns>
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
        public SelectComponentPayload DeepCloneWithName(string name)
        {
            var result = new SelectComponentPayload(
                                 this.Options?.DeepClone(),
                                 this.SelectedValue?.DeepClone(),
                                 this.OnChangeAction?.DeepClone(),
                                 name,
                                 this.OptionLabel?.DeepClone(),
                                 this.Placeholder?.DeepClone(),
                                 this.Disabled?.DeepClone(),
                                 this.CssClass?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="OptionLabel" />.
        /// </summary>
        /// <param name="optionLabel">The new <see cref="OptionLabel" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="SelectComponentPayload" /> using the specified <paramref name="optionLabel" /> for <see cref="OptionLabel" /> and a deep clone of every other property.</returns>
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
        public SelectComponentPayload DeepCloneWithOptionLabel(string optionLabel)
        {
            var result = new SelectComponentPayload(
                                 this.Options?.DeepClone(),
                                 this.SelectedValue?.DeepClone(),
                                 this.OnChangeAction?.DeepClone(),
                                 this.Name?.DeepClone(),
                                 optionLabel,
                                 this.Placeholder?.DeepClone(),
                                 this.Disabled?.DeepClone(),
                                 this.CssClass?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Placeholder" />.
        /// </summary>
        /// <param name="placeholder">The new <see cref="Placeholder" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="SelectComponentPayload" /> using the specified <paramref name="placeholder" /> for <see cref="Placeholder" /> and a deep clone of every other property.</returns>
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
        public SelectComponentPayload DeepCloneWithPlaceholder(string placeholder)
        {
            var result = new SelectComponentPayload(
                                 this.Options?.DeepClone(),
                                 this.SelectedValue?.DeepClone(),
                                 this.OnChangeAction?.DeepClone(),
                                 this.Name?.DeepClone(),
                                 this.OptionLabel?.DeepClone(),
                                 placeholder,
                                 this.Disabled?.DeepClone(),
                                 this.CssClass?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Disabled" />.
        /// </summary>
        /// <param name="disabled">The new <see cref="Disabled" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="SelectComponentPayload" /> using the specified <paramref name="disabled" /> for <see cref="Disabled" /> and a deep clone of every other property.</returns>
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
        public SelectComponentPayload DeepCloneWithDisabled(bool? disabled)
        {
            var result = new SelectComponentPayload(
                                 this.Options?.DeepClone(),
                                 this.SelectedValue?.DeepClone(),
                                 this.OnChangeAction?.DeepClone(),
                                 this.Name?.DeepClone(),
                                 this.OptionLabel?.DeepClone(),
                                 this.Placeholder?.DeepClone(),
                                 disabled,
                                 this.CssClass?.DeepClone());

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="CssClass" />.
        /// </summary>
        /// <param name="cssClass">The new <see cref="CssClass" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="SelectComponentPayload" /> using the specified <paramref name="cssClass" /> for <see cref="CssClass" /> and a deep clone of every other property.</returns>
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
        public SelectComponentPayload DeepCloneWithCssClass(string cssClass)
        {
            var result = new SelectComponentPayload(
                                 this.Options?.DeepClone(),
                                 this.SelectedValue?.DeepClone(),
                                 this.OnChangeAction?.DeepClone(),
                                 this.Name?.DeepClone(),
                                 this.OptionLabel?.DeepClone(),
                                 this.Placeholder?.DeepClone(),
                                 this.Disabled?.DeepClone(),
                                 cssClass);

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"Vuescape.DotNet.Domain.SelectComponentPayload: Options = {this.Options?.ToString() ?? "<null>"}, SelectedValue = {this.SelectedValue?.ToString() ?? "<null>"}, OnChangeAction = {this.OnChangeAction?.ToString() ?? "<null>"}, Name = {this.Name?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, OptionLabel = {this.OptionLabel?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Placeholder = {this.Placeholder?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Disabled = {this.Disabled?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, CssClass = {this.CssClass?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}.");

            return result;
        }
    }
}