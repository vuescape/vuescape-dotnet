// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FeatureNavigationRegistration.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Vuescape.DotNet.Domain
{
    using System.Collections.Generic;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Registers a feature for navigation within the application.
    /// </summary>
    public partial class FeatureNavigationRegistration : IHaveStringId, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureNavigationRegistration"/> class.
        /// </summary>
        /// <param name="id">The ID.</param>
        /// <param name="featureId">The ID of the <see cref="Feature"/> to be registered.</param>
        /// <param name="navigationItems">The navigation items describing how to render navigation to this feature.</param>
        public FeatureNavigationRegistration(string id, string featureId, IReadOnlyList<NavigationItemBase> navigationItems)
        {
            id.MustForArg().NotBeNullNorWhiteSpace();
            featureId.MustForArg().NotBeNullNorWhiteSpace();
            navigationItems.MustForArg().NotBeNullNorEmptyEnumerableNorContainAnyNulls();

            this.Id = id;
            this.FeatureId = featureId;
            this.NavigationItems = navigationItems;
        }

        /// <inheritdoc />
        public string Id { get; private set; }

        /// <summary>
        /// Gets the ID of the <see cref="Feature"/> to register.
        /// </summary>
        public string FeatureId { get; private set; }

        /// <summary>
        /// Gets the navigation items.
        /// </summary>
        public IReadOnlyList<NavigationItemBase> NavigationItems { get; private set; }
    }
}
