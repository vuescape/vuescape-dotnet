// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DiscriminatedTypeBase.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Assertion.Recipes;

    /// <summary>
    /// Provides a base implementation of <see cref="IDiscriminatedType"/> for models that
    /// participate in discriminated (tagged) polymorphism.
    /// </summary>
    public abstract class DiscriminatedTypeBase : IDiscriminatedType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscriminatedTypeBase"/> class.
        /// </summary>
        /// <param name="typeName">The globally unique type name.</param>
        protected DiscriminatedTypeBase(string typeName)
        {
            new { typeName }.AsArg().Must().NotBeNullNorWhiteSpace();

            this.TypeName = typeName;
        }

        /// <summary>
        /// Gets the unique string identifier that discriminates this type
        /// from other related types.
        /// </summary>
        /// <remarks>
        /// Derived classes must override this property and return a globally unique,
        /// stable discriminator string that will remain consistent across code changes.
        /// </remarks>
        public string TypeName { get; private set; }
    }
}
