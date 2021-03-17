// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Class1.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// TODO: Starting point for new project.
    /// </summary>
    public partial class Class1 : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Class1"/> class.
        /// </summary>
        /// <param name="isCodeGen">This is the parameter.</param>
        public Class1(
            bool isCodeGen)
        {
            this.IsCodeGen = isCodeGen;
        }

        /// <summary>
        /// Gets a value indicating whether the thingee is frobbed.
        /// </summary>
        public bool IsCodeGen { get; private set; }
    }
}