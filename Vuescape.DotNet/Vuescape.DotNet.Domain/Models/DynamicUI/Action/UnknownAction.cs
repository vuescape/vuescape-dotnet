// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnknownAction.cs" company="Vuescape">
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
    public class UnknownAction : ActionBase, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnknownAction"/> class.
        /// </summary>
        public UnknownAction()
        {
        }

        /// <inheritdoc />
        public override string Type => "unknown";
    }
}
