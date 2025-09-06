

namespace Vuescape.DotNet.Domain.Test
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    using FakeItEasy;

    using OBeautifulCode.AutoFakeItEasy;
    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.Math.Recipes;

    using Xunit;

    using static System.FormattableString;

    [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
    public static partial class ReadOnlyFileUploadComponentPayloadTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static ReadOnlyFileUploadComponentPayloadTest()
        {
            ConstructorArgumentValidationTestScenarios.RemoveAllScenarios()
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<ReadOnlyFileUploadComponentPayload>
                    {
                        Name = "constructor should throw ArgumentNullException when parameter 'id' is null scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<ReadOnlyFileUploadComponentPayload>();

                            var result = new ReadOnlyFileUploadComponentPayload(
                                null,
                                referenceObject.FileName,
                                referenceObject.FileSizeInBytes,
                                referenceObject.DownloadNavigationAction,
                                referenceObject.MetadataLineItems);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentNullException),
                        ExpectedExceptionMessageContains = new[] { "id", },
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<ReadOnlyFileUploadComponentPayload>
                    {
                        Name = "constructor should throw ArgumentException when parameter 'id' is white space scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<ReadOnlyFileUploadComponentPayload>();

                            var result = new ReadOnlyFileUploadComponentPayload(
                                Invariant($"  {Environment.NewLine}  "),
                                referenceObject.FileName,
                                referenceObject.FileSizeInBytes,
                                referenceObject.DownloadNavigationAction,
                                referenceObject.MetadataLineItems);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentException),
                        ExpectedExceptionMessageContains = new[] { "id", "white space", },
                    })
                .AddScenario(() =>
                    new ConstructorArgumentValidationTestScenario<ReadOnlyFileUploadComponentPayload>
                    {
                        Name =
                            "constructor should throw ArgumentException when parameter 'fileSizeInBytes' is less than zero scenario",
                        ConstructionFunc = () =>
                        {
                            var referenceObject = A.Dummy<ReadOnlyFileUploadComponentPayload>();

                            var result = new ReadOnlyFileUploadComponentPayload(
                                referenceObject.Id,
                                referenceObject.FileName,
                                A.Dummy<long>().ThatIs(_ => _ < 0L),
                                referenceObject.DownloadNavigationAction,
                                referenceObject.MetadataLineItems);

                            return result;
                        },
                        ExpectedExceptionType = typeof(ArgumentOutOfRangeException),
                        ExpectedExceptionMessageContains = new[] { "fileSizeInBytes", "0", },
                    });
        }
    }
}