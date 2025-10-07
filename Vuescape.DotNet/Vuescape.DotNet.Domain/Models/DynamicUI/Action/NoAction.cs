// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NoAction.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Assertion.Recipes;

    /// <summary>
    /// Represents an unknown action type.
    /// </summary>
    public partial class NoAction : ActionBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoAction"/> class with a reason.
        /// </summary>
        /// <param name="reason">The reason associated with the no-op action. Default is null.</param>
        public NoAction(string reason)
            : base(DiscriminatedTypeNames.NoAction)
        {
            new { reason }.AsArg().Must().NotBeNullNorWhiteSpace();

            this.Reason = reason;
        }

        /// <summary>
        /// Gets the reason associated with the no-op action, if any.
        /// </summary>
        public string Reason { get; private set; }
    }
}
