// <copyright file="TreeTableRowTest.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

namespace Vuescape.DotNet.Domain.Test
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    using FakeItEasy;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.AutoFakeItEasy;
    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Recipes;
    using OBeautifulCode.Math.Recipes;
    using OBeautifulCode.Type;

    using Xunit;

    using static System.FormattableString;

    [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
    public static partial class TreeTableRowTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static TreeTableRowTest()
        {
            ConstructorArgumentValidationTestScenarios.RemoveAllScenarios();
            ConstructorArgumentValidationTestScenarios.AddScenario(ConstructorArgumentValidationTestScenario<TreeTableRow>.ForceGeneratedTestsToPassAndWriteMyOwnScenario);
        }

        [Fact]
        public static void Constructor___Should_not_throw___When_id_and_names_and_items_are_provided()
        {
            // Arrange
            var id = A.Dummy<string>();
            var cssClasses = A.Dummy<string>();
            var depth = A.Dummy<int>();

            // A.Dummy<IReadOnlyCollection<TreeTableRowDependency>>();
            IReadOnlyCollection<TreeTableRowDependency> dependencies = null;
            var isExpandable = A.Dummy<bool>();
            var isExpanded = A.Dummy<bool>();
            var isFocused = A.Dummy<bool?>();
            var isSelected = A.Dummy<bool>();
            var isVisible = A.Dummy<bool>();
            var items = A.Dummy<IReadOnlyList<TreeTableCell>>();
            var renderer = A.Dummy<string>();
            var value = A.Dummy<IObject>();
            var children = A.Dummy<IReadOnlyList<TreeTableRow>>();

            // Act
            var ex = Record.Exception(() => new TreeTableRow(id, cssClasses, depth, isExpandable, isExpanded, isFocused, isSelected, isVisible, items, renderer, value, children, dependencies));

            // Assert
            ex.AsTest().Must().BeNull();
        }

        [Fact]
        public static void Constructor___Should_throw___When_id_is_null()
        {
            // Arrange
            string id = null;
            var cssClasses = A.Dummy<string>();
            var depth = A.Dummy<int>();

            // A.Dummy<IReadOnlyCollection<TreeTableRowDependency>>();
            IReadOnlyCollection<TreeTableRowDependency> dependencies = null;
            var isExpandable = A.Dummy<bool>();
            var isExpanded = A.Dummy<bool>();
            var isFocused = A.Dummy<bool?>();
            var isSelected = A.Dummy<bool>();
            var isVisible = A.Dummy<bool>();
            var items = A.Dummy<IReadOnlyList<TreeTableCell>>();
            var renderer = A.Dummy<string>();
            var value = A.Dummy<IObject>();
            var children = A.Dummy<IReadOnlyList<TreeTableRow>>();

            // Act
            var ex = Record.Exception(() => new TreeTableRow(id, cssClasses, depth, isExpandable, isExpanded, isFocused, isSelected, isVisible, items, renderer, value, children, dependencies));

            // Assert
            ex.AsTest().Must().BeOfType<ArgumentNullException>();
            ex.Message.AsTest().Must().ContainString("id");
        }

        [Fact]
        public static void Constructor___Should_throw___When_name_is_null()
        {
            // Arrange
            string id = A.Dummy<string>();
            string name = null;
            var cssClasses = A.Dummy<string>();
            var depth = A.Dummy<int>();

            // A.Dummy<IReadOnlyCollection<TreeTableRowDependency>>();
            IReadOnlyCollection<TreeTableRowDependency> dependencies = null;
            var isExpandable = A.Dummy<bool>();
            var isExpanded = A.Dummy<bool>();
            var isFocused = A.Dummy<bool?>();
            var isSelected = A.Dummy<bool>();
            var isVisible = A.Dummy<bool>();
            var items = A.Dummy<IReadOnlyList<TreeTableCell>>();
            var renderer = A.Dummy<string>();
            var value = A.Dummy<IObject>();
            var children = A.Dummy<IReadOnlyList<TreeTableRow>>();

            // Act
            var ex = Record.Exception(() => new TreeTableRow(id, cssClasses, depth, isExpandable, isExpanded, isFocused, isSelected, isVisible, items, renderer, value, children, dependencies));

            // Assert
            ex.AsTest().Must().BeOfType<ArgumentNullException>();
            ex.Message.AsTest().Must().ContainString("name");
        }

        [Fact]
        public static void Constructor___Should_throw___When_items_is_null()
        {
            // Arrange
            var id = A.Dummy<string>();
            var cssClasses = A.Dummy<string>();
            var depth = A.Dummy<int>();

            // A.Dummy<IReadOnlyCollection<TreeTableRowDependency>>();
            IReadOnlyCollection<TreeTableRowDependency> dependencies = null;
            var isExpandable = A.Dummy<bool>();
            var isExpanded = A.Dummy<bool>();
            var isFocused = A.Dummy<bool?>();
            var isSelected = A.Dummy<bool>();
            var isVisible = A.Dummy<bool>();
            IReadOnlyList<TreeTableCell> items = null;
            var renderer = A.Dummy<string>();
            var value = A.Dummy<IObject>();
            var children = A.Dummy<IReadOnlyList<TreeTableRow>>();

            // Act
            var ex = Record.Exception(() => new TreeTableRow(id, cssClasses, depth, isExpandable, isExpanded, isFocused, isSelected, isVisible, items, renderer, value, children, dependencies));

            // Assert
            ex.AsTest().Must().BeOfType<ArgumentNullException>();
            ex.Message.AsTest().Must().ContainString("items");
        }

        [Fact]
        public static void Constructor___Should_throw___When_items_is_empty()
        {
            // Arrange
            var id = A.Dummy<string>();
            var cssClasses = A.Dummy<string>();
            var depth = A.Dummy<int>();

            // A.Dummy<IReadOnlyCollection<TreeTableRowDependency>>();
            IReadOnlyCollection<TreeTableRowDependency> dependencies = null;
            var isExpandable = A.Dummy<bool>();
            var isExpanded = A.Dummy<bool>();
            var isFocused = A.Dummy<bool?>();
            var isSelected = A.Dummy<bool>();
            var isVisible = A.Dummy<bool>();
            var items = new List<TreeTableCell>();
            var renderer = A.Dummy<string>();
            var value = A.Dummy<IObject>();
            var children = A.Dummy<IReadOnlyList<TreeTableRow>>();

            // Act
            var ex = Record.Exception(() => new TreeTableRow(id, cssClasses, depth, isExpandable, isExpanded, isFocused, isSelected, isVisible, items, renderer, value, children, dependencies));

            // Assert
            ex.AsTest().Must().BeOfType<ArgumentException>();
            ex.Message.AsTest().Must().ContainString("items");
        }
    }
}