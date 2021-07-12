// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GeneratePdfClientBehavior.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    /// <summary>
    /// A client behavior to generate a PDF.
    /// </summary>
    public partial class GeneratePdfClientBehavior : ClientBehaviorBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratePdfClientBehavior"/> class.
        /// </summary>
        public GeneratePdfClientBehavior()
            : base("GeneratePdfBehavior")
        {
            // TODO: determine what args/properties this behavior should have.
        }
    }
}
