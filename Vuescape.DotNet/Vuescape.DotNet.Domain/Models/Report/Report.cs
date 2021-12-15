// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Report.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Vuescape.DotNet.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using OBeautifulCode.Type;

    using static System.FormattableString;

    /// <summary>
    /// An organized collection of <see cref="TreeTable"/> objects.
    /// </summary>
    public partial class Report : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Report"/> class.
        /// </summary>
        /// <param name="id">The report's unique identifier.</param>
        /// <param name="sections">The sections of the report.</param>
        /// <param name="title">OPTIONAL title of the report.  DEFAULT is a report with no title.</param>
        public Report(
            string id,
            IReadOnlyCollection<Section> sections,
            string title = null)
        {
            if (sections == null)
            {
                throw new ArgumentNullException(nameof(sections));
            }

            if (!sections.Any())
            {
                throw new ArgumentException(Invariant($"{nameof(sections)} is an empty enumerable."));
            }

            if (sections.Any(_ => _ == null))
            {
                throw new ArgumentException(Invariant($"{nameof(sections)} contains at least one null element."));
            }

            this.Id = id;
            this.Sections = sections;
            this.Title = title;
        }

        /// <summary>
        /// Gets the report's unique identifier.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the sections of the report.
        /// </summary>
        public IReadOnlyCollection<Section> Sections { get; private set; }

        /// <summary>
        /// Gets the title of the report.
        /// </summary>
        public string Title { get; private set; }
    }
}