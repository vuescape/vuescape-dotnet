// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ComparableValue.cs" company="Vuescape">
//   Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System;
    using OBeautifulCode.Type;

    /// <summary>
    /// Represents a row in a table.
    /// </summary>
    public partial class ComparableValue : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComparableValue"/> class.
        /// This exposes primitive types that can be used for sorting and filtering on the UI side.
        /// </summary>
        /// <param name="stringValue">OPTIONAL The string value to compare against.</param>
        /// <param name="numericValue">OPTIONAL The numeric value to compare against.</param>
        /// <param name="dateValue">OPTIONAL The date value to compare against.</param>
        /// <param name="booleanValue">OPTIONAL The boolean value to compare against.</param>
        public ComparableValue(
            string stringValue = null,
            decimal? numericValue = null,
            DateTime? dateValue = null,
            bool? booleanValue = null)
        {
            this.StringValue = stringValue;
            this.NumericValue = numericValue;
            this.DateValue = dateValue;
            this.BooleanValue = booleanValue;
        }

        /// <summary>
        /// Gets the string value.
        /// </summary>
        public string StringValue { get; private set; }

        /// <summary>
        /// Gets the numeric value.
        /// </summary>
        public decimal? NumericValue { get; private set; }

        /// <summary>
        /// Gets the date value.
        /// </summary>
        public DateTime? DateValue { get; private set; }

        /// <summary>
        /// Gets the boolean value.
        /// </summary>
        public bool? BooleanValue { get; private set; }
    }
}
