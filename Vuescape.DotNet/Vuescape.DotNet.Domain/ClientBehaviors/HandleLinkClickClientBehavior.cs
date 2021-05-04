// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HandleLinkClickClientBehavior.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// A client behavior to add client click handling based on any defined <see cref="Link"/>s.
    /// </summary>
    public partial class HandleLinkClickClientBehavior : ClientBehaviorBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HandleLinkClickClientBehavior "/> class.
        /// </summary>
        public HandleLinkClickClientBehavior()
            : base("HandleLinkClickClientBehavior")
        {
        }
    }
}
