// <copyright file="ConvertObcToVuescapeReportProtocol.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Executes a <see cref="ConvertObcToVuescapeReportOp"/>.
    /// </summary>
    public class ConvertObcToVuescapeReportProtocol
        : SyncSpecificReturningProtocolBase<ConvertObcToVuescapeReportOp, Report>
    {
        /// <summary>
        /// Executes a <see cref="ConvertObcToVuescapeReportOp"/>.
        /// </summary>
        /// <param name="operation">The operation to execute.</param>
        /// <returns>A Report.</returns>
        public override Report Execute(
            ConvertObcToVuescapeReportOp operation)
        {
            new { operation }.MustForArg().NotBeNull();

            var result = operation.ObcReport.ConvertToVuescapeReport(operation.ObcToVuescapeConversionContext, operation.TokenToSubstitutionMap);
            return result;
        }
    }
}
