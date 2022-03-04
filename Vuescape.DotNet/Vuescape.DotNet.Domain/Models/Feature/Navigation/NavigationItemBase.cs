// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NavigationItemBase.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Base class for Navigation Items.
    /// </summary>
    public abstract partial class NavigationItemBase : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NavigationItemBase"/> class.
        /// </summary>
        /// <param name="link">The <see cref="NavigationLink"/> to navigate to.</param>
        /// <param name="kind">The kind of navigation item.</param>
        protected NavigationItemBase(NavigationLink link, NavigationItemKind kind)
        {
            link.AsArg().Must().NotBeNullNorWhiteSpace();
            kind.AsArg().Must().NotBeEqualTo(NavigationItemKind.None);

            this.Link = link;
            this.Kind = kind;
        }

        /// <summary>
        /// Gets the navigation link.
        /// </summary>
        public NavigationLink Link { get; private set; }

        /// <summary>
        /// Gets the kind of navigation item.
        /// </summary>
        public NavigationItemKind Kind { get; private set; }
    }
}
