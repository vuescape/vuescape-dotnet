// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DownloadAction.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Assertion.Recipes;

    /// <summary>
    /// Represents a navigation action with a payload containing navigation details.
    /// </summary>
    public partial class DownloadAction : ActionBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadAction"/> class.
        /// </summary>
        /// <param name="payload">The payload containing navigation details.</param>
        public DownloadAction(DownloadActionPayload payload)
            : base(DiscriminatedTypeNames.DownloadAction)
        {
            new { payload }.AsArg().Must().NotBeNull();

            this.Payload = payload;
        }

        /// <summary>
        /// Gets the payload containing navigation details.
        /// </summary>
        public DownloadActionPayload Payload { get; private set; }
    }
}
