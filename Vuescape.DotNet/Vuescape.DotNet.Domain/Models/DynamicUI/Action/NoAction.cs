// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NoAction.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents an unknown action type.
    /// </summary>
    public class NoAction : ActionBase, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoAction"/> class.
        /// </summary>
        public NoAction()
        {
        }

        /// <inheritdoc />
        public override string Type => "noAction";
    }
}
