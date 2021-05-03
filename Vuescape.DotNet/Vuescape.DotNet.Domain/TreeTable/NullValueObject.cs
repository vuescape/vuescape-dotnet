// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NullValueObject.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Type;

    /// <summary>
    /// Null implementation of <see cref="IObject"/> for use as arbitrary Value used in a
    /// <see cref="TreeTableRow"/>, <see cref="TreeTableCell"/>, or <see cref="TreeTableRowDependency"/>.
    /// </summary>
    public partial class NullValueObject : IObject, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NullValueObject"/> class.
        /// </summary>
        /// <param name="dummy">A dummy value.</param>
        public NullValueObject(
            string dummy)
        {
            this.Dummy = dummy;
        }

        /// <summary>
        /// Gets the dummy value.
        /// </summary>
        public string Dummy { get; private set; }
    }
}
