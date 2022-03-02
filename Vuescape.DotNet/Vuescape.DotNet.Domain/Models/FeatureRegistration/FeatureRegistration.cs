// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FeatureRegistration.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Vuescape.DotNet.Domain
{
    using System.Collections.Generic;

    using OBeautifulCode.Type;

    /// <summary>
    /// Registers features.
    /// </summary>
    public partial class FeatureRegistration : IModelViaCodeGen, IHaveStringId
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureRegistration"/> class.
        /// </summary>
        /// <param name="id">The ID.</param>
        /// <param name="title">The title.</param>
        /// <param name="menuTitlePath">OPTIONAL. A forward slash delimited string corresponding to where in the menu hierarchy to place this feature.  e.g. "Reports/Sales".</param>
        /// <param name="resourceInstructions">OPTIONAL. The instructions on how to load and display resources.</param>
        /// <returns>A <see cref="FeatureRegistration"/> with a single <see cref="MenuNavigationItem"/>.</returns>
        public static FeatureRegistration CreateWithMenu(string id, string title, string menuTitlePath, IReadOnlyCollection<ResourceInstruction> resourceInstructions)
        {
            return new FeatureRegistration(
                id,
                title,
                new[] { new MenuNavigationItem(title, menuTitlePath) },
                resourceInstructions);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureRegistration"/> class.
        /// </summary>
        /// <param name="id">The ID.</param>
        /// <param name="title">The title.</param>
        /// <param name="navigationItems">OPTIONAL. The navigation items.</param>
        /// <param name="resourceInstructions">OPTIONAL. The instructions on how to load and display resources.</param>
        public FeatureRegistration(string id, string title, IReadOnlyCollection<NavigationItemBase> navigationItems, IReadOnlyCollection<ResourceInstruction> resourceInstructions)
        {
            this.Id = id;
            this.Title = title;
            this.NavigationItems = navigationItems;
            this.ResourceInstructions = resourceInstructions;
        }

        /// <inheritdoc />
        public string Id { get; }

        /// <summary>
        /// Gets the title.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Gets the navigation items.
        /// </summary>
        public IReadOnlyCollection<NavigationItemBase> NavigationItems { get; }

        /// <summary>
        /// Gets the resource instructions.
        /// </summary>
        public IReadOnlyCollection<ResourceInstruction> ResourceInstructions { get; }
    }
}
