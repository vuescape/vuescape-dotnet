﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.177.0)
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace Vuescape.DotNet.Domain.Test
{
    using global::System;
    using global::System.CodeDom.Compiler;
    using global::System.Collections.Concurrent;
    using global::System.Collections.Generic;
    using global::System.Collections.ObjectModel;
    using global::System.Diagnostics.CodeAnalysis;

    using global::FakeItEasy;

    using global::OBeautifulCode.AutoFakeItEasy;
    using global::OBeautifulCode.DataStructure;
    using global::OBeautifulCode.Math.Recipes;
    using global::OBeautifulCode.Type;

    using global::Vuescape.DotNet.Domain;

    /// <summary>
    /// The default (code generated) Dummy Factory.
    /// Derive from this class to add any overriding or custom registrations.
    /// </summary>
    [ExcludeFromCodeCoverage]
    [GeneratedCode("OBeautifulCode.CodeGen.ModelObject", "1.0.177.0")]
#if !VuescapeDotNetSolution
    internal
#else
    public
#endif
    abstract class DefaultDotNetDummyFactory : IDummyFactory
    {
        public DefaultDotNetDummyFactory()
        {
            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new Vuescape.DotNet.Domain.CellFormat(
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<Vuescape.DotNet.Domain.HorizontalAlignment?>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () =>
                {
                    var availableTypes = new[]
                    {
                        typeof(ConstrainTreeTableHeightClientBehavior),
                        typeof(GeneratePdfClientBehavior),
                        typeof(SortTreeTableClientBehavior),
                        typeof(ToggleTreeTableChildRowExpansionClientBehavior)
                    };

                    var randomIndex = ThreadSafeRandom.Next(0, availableTypes.Length);

                    var randomType = availableTypes[randomIndex];

                    var result = (ClientBehaviorBase)AD.ummy(randomType);

                    return result;
                });

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new ColumnDefinition(
                                 A.Dummy<ColumnWidthBehavior>(),
                                 A.Dummy<ColumnWrapBehavior>(),
                                 A.Dummy<decimal?>(),
                                 A.Dummy<UnitOfMeasure?>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new ColumnSorter(
                                 A.Dummy<SortDirection>(),
                                 A.Dummy<SortComparisonStrategy>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new ConstrainTreeTableHeightClientBehavior
                             {
                                 Name = A.Dummy<string>(),
                             });

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new ConvertObcToVuescapeReportOp(
                                 A.Dummy<OBeautifulCode.DataStructure.Report>(),
                                 A.Dummy<ObcToVuescapeConversionContext>(),
                                 A.Dummy<IReadOnlyDictionary<string, string>>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new CssStyles(
                                 A.Dummy<CssStyleWrapper>(),
                                 A.Dummy<IReadOnlyList<CssStyleWrapper>>(),
                                 A.Dummy<IReadOnlyList<IReadOnlyList<CssStyleWrapper>>>(),
                                 A.Dummy<CssStyleWrapper>(),
                                 A.Dummy<IReadOnlyList<CssStyleWrapper>>(),
                                 A.Dummy<CssStyleWrapper>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new CssStyleWrapper(
                                 A.Dummy<string>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new GeneratePdfClientBehavior
                             {
                                 Name = A.Dummy<string>(),
                             });

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new Hover(
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<ContentKind>(),
                                 A.Dummy<string>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new Link(
                                 A.Dummy<string>(),
                                 A.Dummy<Vuescape.DotNet.Domain.LinkTarget>(),
                                 A.Dummy<string>(),
                                 A.Dummy<CssStyles>(),
                                 A.Dummy<ResourceKind>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new ObcToVuescapeConversionContext(
                                 A.Dummy<ReportConversionMode>(),
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<CultureKind?>(),
                                 A.Dummy<StandardTimeZone?>(),
                                 A.Dummy<bool>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new Vuescape.DotNet.Domain.Report(
                                 A.Dummy<string>(),
                                 A.Dummy<IReadOnlyList<Vuescape.DotNet.Domain.Section>>(),
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<IReadOnlyList<Link>>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new Vuescape.DotNet.Domain.Section(
                                 A.Dummy<string>(),
                                 A.Dummy<Vuescape.DotNet.Domain.TreeTable>(),
                                 A.Dummy<string>(),
                                 A.Dummy<string>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new SlottedUiObject(
                                 A.Dummy<IReadOnlyDictionary<string, UiObject>>(),
                                 A.Dummy<string>(),
                                 A.Dummy<string>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new SortTreeTableClientBehavior
                             {
                                 Name = A.Dummy<string>(),
                             });

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new ToggleTreeTableChildRowExpansionClientBehavior
                             {
                                 Name = A.Dummy<string>(),
                             });

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new Vuescape.DotNet.Domain.TreeTable(
                                 A.Dummy<string>(),
                                 A.Dummy<IReadOnlyList<ColumnDefinition>>(),
                                 A.Dummy<TreeTableContent>(),
                                 A.Dummy<IReadOnlyCollection<ClientBehaviorBase>>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new TreeTableCell(
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<Hover>(),
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<IReadOnlyDictionary<string, string>>(),
                                 A.Dummy<int?>(),
                                 A.Dummy<bool>(),
                                 A.Dummy<Vuescape.DotNet.Domain.CellFormat>(),
                                 A.Dummy<IReadOnlyDictionary<string, Link>>(),
                                 A.Dummy<SlottedUiObject>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new TreeTableContent(
                                 A.Dummy<IReadOnlyList<TreeTableHeaderRow>>(),
                                 A.Dummy<IReadOnlyList<TreeTableRow>>(),
                                 A.Dummy<IReadOnlyList<TreeTableRow>>(),
                                 A.Dummy<bool>(),
                                 A.Dummy<bool>(),
                                 A.Dummy<bool>(),
                                 A.Dummy<bool>(),
                                 A.Dummy<bool>(),
                                 A.Dummy<bool>(),
                                 A.Dummy<string>(),
                                 A.Dummy<int?>(),
                                 A.Dummy<string>(),
                                 A.Dummy<IReadOnlyDictionary<string, string>>(),
                                 A.Dummy<SortLevel>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new TreeTableHeaderCell(
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<Hover>(),
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<IReadOnlyDictionary<string, string>>(),
                                 A.Dummy<int?>(),
                                 A.Dummy<bool>(),
                                 A.Dummy<ColumnSorter>(),
                                 A.Dummy<Vuescape.DotNet.Domain.CellFormat>(),
                                 A.Dummy<IReadOnlyDictionary<string, Link>>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new TreeTableHeaderRow(
                                 A.Dummy<string>(),
                                 A.Dummy<IReadOnlyList<TreeTableHeaderCell>>(),
                                 A.Dummy<string>(),
                                 A.Dummy<IReadOnlyDictionary<string, string>>(),
                                 A.Dummy<string>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new TreeTableRow(
                                 A.Dummy<string>(),
                                 A.Dummy<IReadOnlyList<TreeTableCell>>(),
                                 A.Dummy<int?>(),
                                 A.Dummy<string>(),
                                 A.Dummy<IReadOnlyDictionary<string, string>>(),
                                 A.Dummy<string>(),
                                 A.Dummy<bool>(),
                                 A.Dummy<bool>(),
                                 A.Dummy<bool>(),
                                 A.Dummy<bool>(),
                                 A.Dummy<bool?>(),
                                 A.Dummy<IReadOnlyDictionary<string, Link>>(),
                                 A.Dummy<IReadOnlyList<TreeTableRow>>(),
                                 A.Dummy<bool?>(),
                                 A.Dummy<IReadOnlyList<TreeTableRow>>(),
                                 A.Dummy<IReadOnlyList<TreeTableRow>>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new UiObject(
                                 A.Dummy<object>(),
                                 A.Dummy<UiObjectType?>(),
                                 A.Dummy<string>()));
        }

        /// <inheritdoc />
        public Priority Priority => new FakeItEasy.Priority(1);

        /// <inheritdoc />
        public bool CanCreate(Type type)
        {
            return false;
        }

        /// <inheritdoc />
        public object Create(Type type)
        {
            return null;
        }
    }
}