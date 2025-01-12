// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SelectOption.cs" company="Vuescape">
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
    public partial class SelectOption : IHaveId<string>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectOption"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for the option.</param>
        /// <param name="displayName">The label for the UI.</param>
        public SelectOption(string id, string displayName)
        {
            this.Id = id;
            this.DisplayName = displayName;
        }

        /// <summary>
        /// Gets the unique identifier for the option.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the display name.
        /// </summary>
        public string DisplayName { get; private set; }
    }
}
