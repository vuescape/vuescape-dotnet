﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Chiclet.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System;
    using System.Collections.Generic;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents a chiclet item with an ID, title, visibility, icons, CSS class, and action.
    /// </summary>
    public class Chiclet : IHaveId<string>, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Chiclet"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for the chiclet.</param>
        /// <param name="title">The title of the chiclet.</param>
        /// <param name="isVisible">Indicates whether the chiclet is visible.</param>
        /// <param name="action">The action associated with the chiclet.</param>
        /// <param name="icons">The optional list of icon identifiers for the chiclet.</param>
        /// <param name="cssClass">The optional CSS class to style the chiclet.</param>
        public Chiclet(
            string id,
            string title,
            bool isVisible,
            Action action,
            IReadOnlyList<string> icons = null,
            string cssClass = null)
        {
            new { id }.AsArg().Must().NotBeNull();
            new { title }.AsArg().Must().NotBeNull();

            this.Id = id;
            this.Title = title;
            this.IsVisible = isVisible;
            this.Action = action;
            this.Icons = icons;
            this.CssClass = cssClass;
        }

        /// <summary>
        /// Gets the unique identifier for the chiclet.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets the title of the chiclet.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Gets a value indicating whether the chiclet is visible.
        /// </summary>
        public bool IsVisible { get; }

        /// <summary>
        /// Gets the optional list of icon identifiers for the chiclet.
        /// </summary>
        public IReadOnlyList<string> Icons { get; }

        /// <summary>
        /// Gets the optional CSS class to style the chiclet.
        /// </summary>
        public string CssClass { get; }

        /// <summary>
        /// Gets the action associated with the chiclet.
        /// </summary>
        public Action Action { get; }
    }
}
