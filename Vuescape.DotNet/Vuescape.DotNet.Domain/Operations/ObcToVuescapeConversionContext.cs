// <copyright file="ObcToVuescapeConversionContext.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Context object converting a <see cref="OBeautifulCode.DataStructure.Report"/> to a <see cref="Report"/>.
    /// </summary>
    public partial class ObcToVuescapeConversionContext : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObcToVuescapeConversionContext"/> class.
        /// </summary>
        /// <param name="reportConversionMode">OPTIONAL. The report conversion mode. Defaults to Relaxed.</param>
        /// <param name="queryString">OPTIONAL. The query string of an associated web request that spawned the current operation. Does not include the leading "?".</param>
        /// <param name="baseUrl">OPTIONAL. The base URL to use for constructing links.</param>
        /// <param name="cultureKind">OPTIONAL. The culture kind. Defaults to Invariant.</param>
        /// <param name="localTimeZone">OPTIONAL. The local time zone. Defaults to Eastern.</param>
        /// <param name="shouldSummaryRowsDisplayInFooter">OPTIONAL. Should summary rows display in the footer. This effectively pins summary rows to the bottom of the report.</param>
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "2#", Justification = ObcSuppressBecause.CA1054_UriParametersShouldNotBeStrings_PreferToRepresentUrlAsString)]
        public ObcToVuescapeConversionContext(
            ReportConversionMode reportConversionMode = ReportConversionMode.Relaxed,
            string queryString = null,
            string baseUrl = null,
            CultureKind? cultureKind = OBeautifulCode.Type.CultureKind.Invariant,
            StandardTimeZone? localTimeZone = StandardTimeZone.Eastern,
            bool shouldSummaryRowsDisplayInFooter = false)
        {
            new { reportConversionMode }.AsArg().Must().NotBeEqualTo(ReportConversionMode.None);

            this.ReportConversionMode = reportConversionMode;
            this.QueryString = queryString;
            this.BaseUrl = baseUrl;
            this.CultureKind = cultureKind;
            this.LocalTimeZone = localTimeZone;
            this.ShouldSummaryRowsDisplayInFooter = shouldSummaryRowsDisplayInFooter;
        }

        /// <summary>
        /// Gets the ReportConversionMode.
        /// </summary>
        public ReportConversionMode ReportConversionMode { get; private set; }

        /// <summary>
        /// Gets the query string that spawned the current operation.  Does not include leading "?".
        /// </summary>
        public string QueryString { get; private set; }

        /// <summary>
        /// Gets the Base URL to use when constructing links.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Justification = ObcSuppressBecause.CA1056_UriPropertiesShouldNotBeStrings_PreferToRepresentUrlAsString)]
        public string BaseUrl { get; private set; }

        /// <summary>
        /// Gets the <see cref="CultureKind"/> to use when not specified.
        /// </summary>
        public CultureKind? CultureKind { get; private set; }

        /// <summary>
        /// Gets the <see cref="StandardTimeZone"/> to use when not specified.
        /// </summary>
        public StandardTimeZone? LocalTimeZone { get; private set; }

        /// <summary>
        /// Gets a value indicating whether summary rows should display in the footer.
        /// </summary>
        public bool ShouldSummaryRowsDisplayInFooter { get; private set; }
    }
}