// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Class1Test.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Vuescape.DotNet.Domain.Test
{
    using System;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.CodeGen.ModelObject.Recipes;

    using Xunit;

    /// <summary>
    /// TODO: Starting point for new project.
    /// </summary>
    public static partial class Class1Test
    {
        static Class1Test()
        {
            // If the constructor cannot throw, clear all scenarios by calling ConstructorArgumentValidationTestScenarios.RemoveAllScenarios() and add ConstructorArgumentValidationTestScenario<Class1>.ConstructorCannotThrowScenario.
            ConstructorArgumentValidationTestScenarios.RemoveAllScenarios();
            ConstructorArgumentValidationTestScenarios.AddScenario(ConstructorArgumentValidationTestScenario<Class1>.ConstructorCannotThrowScenario);
        }

        [Fact]
        public static void Method___Should_do_something___When_called()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}