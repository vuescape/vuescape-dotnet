// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClientBehaviorBase.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Base class for all client behaviors. A <see cref="ClientBehaviorBase"/> is used to attach client side behavior
    /// in JavaScript and indicates to the UI to wire in some JavaScript code to implement the behavior.
    /// </summary>
    public abstract partial class ClientBehaviorBase : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientBehaviorBase"/> class.
        /// </summary>
        /// <param name="name">Name representation of this behavior.</param>
        protected ClientBehaviorBase(
            string name)
        {
            new { name }.AsArg().Must().NotBeNullNorWhiteSpace();

            this.Name = name;
        }

        /// <summary>
        /// Gets or sets the behavior name.
        /// </summary>
        public string Name { get; set; }
    }
}
