// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NoAction.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    /// <summary>
    /// Represents an unknown action type.
    /// </summary>
    public partial class NoAction : ActionBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoAction"/> class with a reason.
        /// </summary>
        /// <param name="reason">OPTIONAL reason associated with the no-op action. Default is null.</param>
        public NoAction(string reason = null)
            : base(DiscriminatedTypeNames.NoAction)
        {
            this.Reason = reason;
        }

        /// <summary>
        /// Gets the reason associated with the no-op action, if any.
        /// </summary>
        public string Reason { get; private set; }
    }
}
