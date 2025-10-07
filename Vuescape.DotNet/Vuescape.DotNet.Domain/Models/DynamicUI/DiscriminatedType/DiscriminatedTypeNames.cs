// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DiscriminatedTypeNames.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    /// <summary>
    /// Defines canonical discriminator names used by <see cref="DiscriminatedTypeBase"/> implementations.
    ///
    /// <remarks>
    /// These constant values serve as stable, globally unique identifiers for known
    /// <see cref="DiscriminatedTypeBase"/> subclasses. They are typically serialized into JSON as
    /// the <c>type</c> field and are used by clients (such as a web UI) to determine
    /// which behavior, handler, or component to invoke.
    ///
    /// Discriminator strings should be treated as part of the public contract between
    /// backend and frontend, and must remain stable across refactoring or version updates.
    /// </remarks>
    /// </summary>
    public static class DiscriminatedTypeNames
    {
        /// <summary>
        /// Identifies a discriminated type representing a navigation action.
        /// </summary>
        public static readonly string NavigationAction = "action.navigate";

        /// <summary>
        /// Identifies a discriminated type representing a selection-based navigation action.
        /// </summary>
        public static readonly string SelectNavigationAction = "action.selectNavigate";

        /// <summary>
        /// Identifies a discriminated type representing a no-operation action.
        /// </summary>
        public static readonly string NoAction = "action.noAction";

        /// <summary>
        /// Identifies a discriminated type representing an action button component.
        /// </summary>
        public static readonly string ActionButtonComponent = "component.actionButton";

        /// <summary>
        /// Identifies a discriminated type representing a chiclet grid component.
        /// </summary>
        public static readonly string ChicletGridComponent = "component.chicletGrid";

        /// <summary>
        /// Identifies a discriminated type representing a read only file upload component.
        /// </summary>
        public static readonly string ReadOnlyFileUploadComponent = "component.readOnlyFileUpload";

        /// <summary>
        /// Identifies a discriminated type representing a select component.
        /// </summary>
        public static readonly string SelectComponent = "component.select";

        /// <summary>
        /// Identifies a discriminated type representing a table component.
        /// </summary>
        public static readonly string TableComponent = "component.table";

        /// <summary>
        /// Identifies a discriminated type representing a text component.
        /// </summary>
        public static readonly string TextComponent = "component.text";

        /// <summary>
        /// Identifies a discriminated type representing a button component.
        /// </summary>
        public static readonly string ButtonComponent = "component.button";

        /// <summary>
        /// Identifies a discriminated type representing a file upload component.
        /// </summary>
        public static readonly string FileUploadComponent = "component.fileUpload";

        /// <summary>
        /// Identifies a discriminated type representing a table tabs component.
        /// </summary>
        public static readonly string TableTabsComponent = "component.tableTabs";

        /// <summary>
        /// Identifies a discriminated type representing a text link component.
        /// </summary>
        public static readonly string TextLinkComponent = "component.textLink";
    }
}
