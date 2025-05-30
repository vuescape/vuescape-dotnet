// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GlobalSuppressions.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable CommentTypo
using System.Diagnostics.CodeAnalysis;

using OBeautifulCode.CodeAnalysis.Recipes;

// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the
// Code Analysis results, point to "Suppress Message", and click
// "In Suppression File".
// You do not need to add suppressions to this file manually.
[assembly: SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Scope = "member", Target = "~M:Vuescape.DotNet.Domain.TreeTableRow.DeepClone~Vuescape.DotNet.Domain.TreeTableRow", Justification = ObcSuppressBecause.CA1502_AvoidExcessiveComplexity_DisagreeWithAssessment)]
[assembly: SuppressMessage("StyleCop.CSharp.NamingRules", "SA1305:Field names should not use Hungarian notation", Justification = "This is not Hungarian Notation.", Scope = "member", Target = "~M:Vuescape.DotNet.Domain.UiObjectExtensions.RequiresAssemblyQualifiedName(System.Nullable{Vuescape.DotNet.Domain.UiObjectType})~System.Boolean")]
