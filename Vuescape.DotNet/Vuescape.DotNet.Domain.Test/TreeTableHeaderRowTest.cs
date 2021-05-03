// <copyright file="TreeTableHeaderRowTest.cs" company="Vuescape">
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

    using Xunit;

    using static System.FormattableString;

    [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
    public static partial class TreeTableHeaderRowTest
    {
        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = ObcSuppressBecause.CA1505_AvoidUnmaintainableCode_DisagreeWithAssessment)]
        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = ObcSuppressBecause.CA1810_InitializeReferenceTypeStaticFieldsInline_FieldsDeclaredInCodeGeneratedPartialTestClass)]
        static TreeTableHeaderRowTest()
        {
            ConstructorArgumentValidationTestScenarios.RemoveAllScenarios();
            ConstructorArgumentValidationTestScenarios.AddScenario(ConstructorArgumentValidationTestScenario<TreeTableHeaderRow>.ForceGeneratedTestsToPassAndWriteMyOwnScenario);
        }

        [Fact]
        public static void Constructor___Should_not_throw___When_id_and_items_are_provided()
        {
            // Arrange
            var id = A.Dummy<string>();
            var cssClasses = A.Dummy<string>();
            var items = A.Dummy<IReadOnlyList<TreeTableHeaderCell>>();

            // Act
            var ex = Record.Exception(() => new TreeTableHeaderRow(id, cssClasses, items));

            // Assert
            ex.AsTest().Must().BeNull();
        }

        [Fact]
        public static void Constructor___Should_throw___When_id_is_null()
        {
            // Arrange
            string id = null;
            var cssClasses = A.Dummy<string>();
            var items = A.Dummy<IReadOnlyList<TreeTableHeaderCell>>();

            // Act
            var ex = Record.Exception(() => new TreeTableHeaderRow(id, cssClasses, items));

            // Assert
            ex.AsTest().Must().BeOfType<ArgumentNullException>();
            ex.Message.AsTest().Must().ContainString("id");
        }

        [Fact]
        public static void Constructor___Should_throw___When_items_is_null()
        {
            // Arrange
            var id = A.Dummy<string>();
            var cssClasses = A.Dummy<string>();
            IReadOnlyList<TreeTableHeaderCell> items = null;

            // Act
            var ex = Record.Exception(() => new TreeTableHeaderRow(id, cssClasses, items));

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
            var items = new List<TreeTableHeaderCell>();

            // Act
            var ex = Record.Exception(() => new TreeTableHeaderRow(id, cssClasses, items));

            // Assert
            ex.AsTest().Must().BeOfType<ArgumentException>();
            ex.Message.AsTest().Must().ContainString("items");
        }
    }
}