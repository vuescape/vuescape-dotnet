// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DotNetDummyFactory.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Vuescape.DotNet.Domain.Test
{
    using System;
    using System.Collections.Generic;

    using FakeItEasy;

    using OBeautifulCode.AutoFakeItEasy;
    using OBeautifulCode.Math.Recipes;
    using OBeautifulCode.Representation.System;

    using static System.FormattableString;

    /// <summary>
    /// A Dummy Factory for types in <see cref="Vuescape.DotNet.Domain"/>.
    /// </summary>
#if !VuescapeDotNetSolution
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [System.CodeDom.Compiler.GeneratedCode("Vuescape.DotNet.Domain.Test", "See package version number")]
    internal
#else
    public
#endif
    class DotNetDummyFactory : DefaultDotNetDummyFactory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.NamingRules", "SA1305:Field names should not use Hungarian notation", Justification = "Not Hungarian notation.")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = "Methods with simple switch statements can be excluded.")]
        private static object GetObjectByUiObjectType(
            UiObjectType uiObjectType)
        {
            switch (uiObjectType)
            {
                case UiObjectType.None:
                    throw new ArgumentOutOfRangeException(Invariant(
                        $"${nameof(uiObjectType)} cannot have value ${UiObjectType.None}."));
                case UiObjectType.Bool:
                    return A.Dummy<bool>();
                case UiObjectType.String:
                    return A.Dummy<string>();
                case UiObjectType.Int:
                    return A.Dummy<int>();
                case UiObjectType.Short:
                    return A.Dummy<short>();
                case UiObjectType.Long:
                    return A.Dummy<long>();
                case UiObjectType.Decimal:
                    return A.Dummy<decimal>();
                case UiObjectType.DateTime:
                    return A.Dummy<DateTime>();
                case UiObjectType.Guid:
                    return A.Dummy<Guid>();
                case UiObjectType.Enum:
                    return A.Dummy<ContentKind>();
                case UiObjectType.SpecifiedType:
                    return A.Dummy<ClientBehaviorBase>();
                default:
                    throw new ArgumentOutOfRangeException(nameof(uiObjectType), uiObjectType, null);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.NamingRules", "SA1305:Field names should not use Hungarian notation", Justification = "Not Hungarian notation.")]
        public DotNetDummyFactory()
        {
            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () =>
                {
                    var cells = new List<TreeTableHeaderCell>();

                    var numberOfCells = ThreadSafeRandom.Next(0, 4);
                    ColumnSorter columnSorter = A.Dummy<ColumnSorter>().Whose(_ => _.SortDirection == SortDirection.Ascending);
                    for (var i = 0; i <= numberOfCells; i++)
                    {
                        string id = A.Dummy<string>();
                        string displayValue = A.Dummy<string>();
                        Hover hover = A.Dummy<Hover>();
                        string renderer = A.Dummy<string>();
                        string cssClasses = A.Dummy<string>();
                        IReadOnlyDictionary<string, string> cssStyles = A.Dummy<IReadOnlyDictionary<string, string>>();
                        int? colspan = A.Dummy<int?>();
                        bool isVisible = A.Dummy<bool>();

                        CellFormat cellFormat = A.Dummy<CellFormat>();
                        IReadOnlyDictionary<string, Link> links = A.Dummy<IReadOnlyDictionary<string, Link>>();

                        var treeTableHeaderCell = new TreeTableHeaderCell(id, displayValue, hover, renderer, cssClasses, cssStyles, colspan, isVisible, columnSorter, cellFormat, links);
                        cells.Add(treeTableHeaderCell);
                        columnSorter = A.Dummy<ColumnSorter>().Whose(_ => _.SortDirection == SortDirection.None);
                    }

                    return (IReadOnlyList<TreeTableHeaderCell>)cells;
                });

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () =>
                {
                    var columnWidthBehavior = A.Dummy<ColumnWidthBehavior>();
                    var widthUnitOfMeasure = A.Dummy<UnitOfMeasure?>();
                    var width = A.Dummy<decimal?>();
                    var columnWrapBehavior = A.Dummy<ColumnWrapBehavior>();

                    if (widthUnitOfMeasure != null)
                    {
                        width = A.Dummy<decimal>();
                    }

                    return new ColumnDefinition(columnWidthBehavior, columnWrapBehavior, width, widthUnitOfMeasure);
                });

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () =>
                {
                    var wrapBehavior = A.Dummy<ColumnWrapBehavior>();
                    var widthBehavior = A.Dummy<ColumnWidthBehavior>();
                    decimal? width = null;
                    UnitOfMeasure? unitOfMeasure = null;
                    if (ThreadSafeRandom.Next(0, 1) == 0)
                    {
                        width = A.Dummy<decimal>();
                        unitOfMeasure = A.Dummy<UnitOfMeasure>();
                    }

                    return new ColumnDefinition(widthBehavior, wrapBehavior, width, unitOfMeasure);
                });

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () =>
                {
                    var uiObjectType = A.Dummy<UiObjectType>();
                    var value = GetObjectByUiObjectType(uiObjectType);

                    switch (uiObjectType)
                    {
                        case UiObjectType.Enum:
                            {
                                var assemblyQualifiedNameEnum = value.GetType().ToRepresentation().RemoveAssemblyVersions().BuildAssemblyQualifiedName();
                                return new UiObject(value, uiObjectType, assemblyQualifiedNameEnum);
                            }

                        case UiObjectType.SpecifiedType:
                            var assemblyQualifiedName = value.GetType().ToRepresentation().RemoveAssemblyVersions().BuildAssemblyQualifiedName();
                            return new UiObject(value, uiObjectType, assemblyQualifiedName);
                    }

                    return new UiObject(value);
                });

            /* Add any overriding or custom registrations here. */
            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () =>
                {
                    var numberOfChildren = ThreadSafeRandom.Next(0, 4);
                    var children = new List<TreeTableRow>();
                    for (int x = 0; x < numberOfChildren; x++)
                    {
                        if (ThreadSafeRandom.Next(0, 2) == 0)
                        {
                            children.Add(new TreeTableRow(
                                A.Dummy<string>(),
                                A.Dummy<IReadOnlyList<TreeTableCell>>(),
                                A.Dummy<int>(),
                                A.Dummy<string>(),
                                A.Dummy<IReadOnlyDictionary<string, string>>(),
                                A.Dummy<string>(),
                                A.Dummy<bool>(),
                                A.Dummy<bool>(),
                                A.Dummy<bool>(),
                                A.Dummy<bool>(),
                                A.Dummy<bool?>(),
                                A.Dummy<IReadOnlyDictionary<string, Link>>(),
                                null));
                        }
                        else
                        {
                            var numberOfGrandchildren = ThreadSafeRandom.Next(0, 3);
                            var grandChildren = new List<TreeTableRow>();

                            for (int y = 0; y < numberOfGrandchildren; y++)
                            {
                                grandChildren.Add(new TreeTableRow(
                                    A.Dummy<string>(),
                                    A.Dummy<IReadOnlyList<TreeTableCell>>(),
                                    A.Dummy<int>(),
                                    A.Dummy<string>(),
                                    A.Dummy<IReadOnlyDictionary<string, string>>(),
                                    A.Dummy<string>(),
                                    A.Dummy<bool>(),
                                    A.Dummy<bool>(),
                                    A.Dummy<bool>(),
                                    A.Dummy<bool>(),
                                    A.Dummy<bool?>(),
                                    A.Dummy<IReadOnlyDictionary<string, Link>>(),
                                    null));
                            }

                            children.Add(new TreeTableRow(
                                A.Dummy<string>(),
                                A.Dummy<IReadOnlyList<TreeTableCell>>(),
                                A.Dummy<int>(),
                                A.Dummy<string>(),
                                A.Dummy<IReadOnlyDictionary<string, string>>(),
                                A.Dummy<string>(),
                                A.Dummy<bool>(),
                                A.Dummy<bool>(),
                                A.Dummy<bool>(),
                                A.Dummy<bool>(),
                                A.Dummy<bool?>(),
                                A.Dummy<IReadOnlyDictionary<string, Link>>(),
                                grandChildren));
                        }
                    }

                    return new TreeTableRow(
                        A.Dummy<string>(),
                        A.Dummy<IReadOnlyList<TreeTableCell>>(),
                        A.Dummy<int>(),
                        A.Dummy<string>(),
                        A.Dummy<IReadOnlyDictionary<string, string>>(),
                        A.Dummy<string>(),
                        A.Dummy<bool>(),
                        A.Dummy<bool>(),
                        A.Dummy<bool>(),
                        A.Dummy<bool>(),
                        A.Dummy<bool?>(),
                        A.Dummy<IReadOnlyDictionary<string, Link>>(),
                        children);
                });

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () =>
                {
                    var randomNumber = ThreadSafeRandom.Next(0, 4);

                    UiObject result;

                    if (randomNumber == 0)
                    {
                        result = new UiObject(null);
                    }
                    else if (randomNumber == 1)
                    {
                        var candidateValues = new object[]
                        {
                            A.Dummy<bool>(),
                            A.Dummy<DateTime>(),
                            A.Dummy<decimal>(),
                            A.Dummy<Guid>(),
                            A.Dummy<int>(),
                            A.Dummy<long>(),
                            A.Dummy<short>(),
                            A.Dummy<string>(),
                        };

                        var value = candidateValues[ThreadSafeRandom.Next(0, candidateValues.Length)];

                        result = new UiObject(value);
                    }
                    else if (randomNumber == 2)
                    {
                        result = new UiObject(A.Dummy<Link>());
                    }
                    else
                    {
                        result = new UiObject(A.Dummy<UiObjectType>());
                    }

                    return result;
                });

            AutoFixtureBackedDummyFactory.ConstrainDummyToExclude(LinkTarget.None);
            AutoFixtureBackedDummyFactory.ConstrainDummyToExclude(UiObjectType.None);
            AutoFixtureBackedDummyFactory.ConstrainDummyToExclude(ContentKind.None);
            AutoFixtureBackedDummyFactory.ConstrainDummyToExclude(SortComparisonStrategy.None);
            AutoFixtureBackedDummyFactory.ConstrainDummyToExclude(TreeTableConversionMode.None);
            AutoFixtureBackedDummyFactory.ConstrainDummyToExclude(ColumnWidthBehavior.None);
            AutoFixtureBackedDummyFactory.ConstrainDummyToExclude(UnitOfMeasure.None);

            // var obcDataStructureDummyFactory = new OBeautifulCode.DataStructure.Test.DataStructureDummyFactory();
        }
    }
}