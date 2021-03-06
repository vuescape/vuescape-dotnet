// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DotNetDummyFactory.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package Naos.Build.Conventions.VisualStudioProjectTemplates.Domain.Test (1.55.54)
// </auto-generated>
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
        private static object GetObjectByUiObjectType(
            UiObjectType uiObjectType)
        {
            switch (uiObjectType)
            {
                case UiObjectType.None:
                    throw new ArgumentOutOfRangeException(Invariant(
                        $"${nameof(uiObjectType)} cannot have value ${UiObjectType.None.ToString()}."));
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

        public DotNetDummyFactory()
        {
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
                                A.Dummy<string>(),
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
                                    A.Dummy<string>(),
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
                                A.Dummy<string>(),
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
                        A.Dummy<string>(),
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
        }
    }
}