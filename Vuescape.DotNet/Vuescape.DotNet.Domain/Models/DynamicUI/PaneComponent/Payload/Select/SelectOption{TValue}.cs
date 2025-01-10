// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SelectOption{TValue}.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents an option in a selection component.
    /// </summary>
    /// <typeparam name="TValue">The type of the value associated with the option.</typeparam>
    public partial class SelectOption<TValue> : IHaveId<string>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectOption{TValue}"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for the option.</param>
        /// <param name="displayName">The label for the UI.</param>
        /// <param name="value">The raw object associated with the option.</param>
        public SelectOption(string id, string displayName, TValue value)
        {
            this.Id = id;
            this.DisplayName = displayName;
            this.Value = value;
        }

        /// <summary>
        /// Gets the unique identifier for the option.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets the label for the UI.
        /// </summary>
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets the raw object.
        /// </summary>
        public TValue Value { get; private set; }
    }
}
