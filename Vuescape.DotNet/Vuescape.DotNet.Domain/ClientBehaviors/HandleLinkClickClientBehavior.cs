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
    /// Behavior to add client click handling based on any defined <see cref="Link"/>s.
    /// </summary>
    public partial class HandleLinkClickClientBehavior : ClientBehaviorBase, IModelViaCodeGen
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
