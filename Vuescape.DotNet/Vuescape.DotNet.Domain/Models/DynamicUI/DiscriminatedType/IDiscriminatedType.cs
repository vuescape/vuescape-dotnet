// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDiscriminatedType.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    /// <summary>
    /// Represents a model that participates in a discriminated (tagged) type hierarchy.
    /// </summary>
    public interface IDiscriminatedType
    {
        /// <summary>
        /// Gets the unique string identifier for this discriminated type.
        /// </summary>
        string TypeName { get; }
    }
}
