// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SortTreeTableClientBehavior.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Base class for all Client Actions.
    /// </summary>
    public partial class SortTreeTableClientBehavior : ClientBehaviorBase, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SortTreeTableClientBehavior"/> class.
        /// </summary>
        public SortTreeTableClientBehavior()
            : base("SortTreeTableClientBehavior")
        {
            // TODO: determine what args/config this behavior should accept.
        }
    }
}
