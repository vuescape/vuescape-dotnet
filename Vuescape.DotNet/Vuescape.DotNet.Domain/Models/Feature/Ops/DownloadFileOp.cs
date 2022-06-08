// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DownloadFileOp.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.DataStructure;
    using OBeautifulCode.Type;

    /// <summary>
    /// An operation to download a file.
    /// </summary>
    public partial class DownloadFileOp : LinkedResourceOpBase, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadFileOp"/> class.
        /// </summary>
        /// <param name="linkedResource">The linked resource.</param>
        public DownloadFileOp(
            ILinkedResource linkedResource)
            : base(linkedResource)
        {
            linkedResource.MustForArg(nameof(linkedResource)).NotBeNull();
        }

        /// <summary>
        /// Gets the LinkTarget.
        /// </summary>
        public LinkTarget LinkTarget => LinkTarget.Download;
    }
}
