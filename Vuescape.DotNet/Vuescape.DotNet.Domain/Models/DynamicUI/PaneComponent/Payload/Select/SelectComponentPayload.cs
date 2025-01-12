// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SelectComponentPayload.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents the payload for a select component.
    /// </summary>
    public partial class SelectComponentPayload : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectComponentPayload"/> class.
        /// </summary>
        /// <param name="options">The options to display in the select component.</param>
        /// <param name="selectedValue">The currently selected value.</param>
        /// <param name="onChangeAction">The action to perform when the value changes.</param>
        /// <param name="name">The name of the select component.</param>
        /// <param name="optionLabel">The property used to display labels for options.</param>
        /// <param name="placeholder">The placeholder text for the select component.</param>
        /// <param name="disabled">Indicates whether the component is disabled.</param>
        /// <param name="cssClass">The CSS class for the select component.</param>
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1305:Field names should not use Hungarian notation", Justification = "This is not Hungarian notation")]
        public SelectComponentPayload(
            IReadOnlyList<SelectOption> options,
            SelectOption selectedValue = null,
            ActionBase onChangeAction = null,
            string name = null,
            string optionLabel = null,
            string placeholder = null,
            bool? disabled = null,
            string cssClass = null)
        {
            new { options }.AsArg().Must().NotBeNullNorEmptyEnumerableNorContainAnyNulls();

            this.Options = options;
            this.SelectedValue = selectedValue;
            this.OnChangeAction = onChangeAction;
            this.Name = name;
            this.OptionLabel = optionLabel;
            this.Placeholder = placeholder;
            this.Disabled = disabled;
            this.CssClass = cssClass;
        }

        /// <summary>
        /// Gets the options to display in the select component.
        /// </summary>
        public IReadOnlyList<SelectOption> Options { get; private set; }

        /// <summary>
        /// Gets the currently selected value. Null if no value is selected.
        /// </summary>
        public SelectOption SelectedValue { get; private set; }

        /// <summary>
        /// Gets the action to perform when the value of the select component changes.
        /// Optional.
        /// </summary>
        public ActionBase OnChangeAction { get; private set; }

        /// <summary>
        /// Gets the name of the select component.
        /// Optional.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the property of the options object used to display the label in the select component.
        /// Optional.
        /// </summary>
        public string OptionLabel { get; private set; }

        /// <summary>
        /// Gets the placeholder text for the select component.
        /// Optional.
        /// </summary>
        public string Placeholder { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the select component is disabled.
        /// Optional.
        /// </summary>
        public bool? Disabled { get; private set; }

        /// <summary>
        /// Gets the CSS class for the select component.
        /// Optional.
        /// </summary>
        public string CssClass { get; private set; }
    }
}
