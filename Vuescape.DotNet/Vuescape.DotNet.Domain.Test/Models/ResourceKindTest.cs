// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SlottedUiObjectTest.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain.Test
{
    using System;
    using System.Linq;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Enum.Recipes;

    using Xunit;

    public class ResourceKindTest
    {
        [Fact]
        public void ResourceKind___Should_have_same_names_and_values_as_OBC_ResourceKind___Always()
        {
            // TODO: When OBC has Bson* values then remove where condition.
            var vuescapeResourceKindMap = typeof(ResourceKind)
                .GetDefinedEnumValues()
                .Where(_ =>
                    (ResourceKind)Convert.ChangeType(_, typeof(ResourceKind)) != ResourceKind.BsonAsBytes &&
                    (ResourceKind)Convert.ChangeType(_, typeof(ResourceKind)) != ResourceKind.BsonAsText)
                .ToDictionary(_ => Enum.GetName(_.GetType(), _), _ => Convert.ChangeType(_, _.GetTypeCode()));

            // TODO: remove where exclusion for Website when the Vuescape ResourceKind contains Website.
            // Avoiding changing value of Bson* in Vuescape ResourceKind until validate that it is safe to make that breaking change.
            // i.e. that integer value is not persisted such as in a serialized payload/config.
            var obcResourceKindMap = typeof(OBeautifulCode.DataStructure.UrlLinkedResourceKind)
                .GetDefinedEnumValues()
                .Where(_ => (OBeautifulCode.DataStructure.UrlLinkedResourceKind)_ != OBeautifulCode.DataStructure.UrlLinkedResourceKind.Website)
                .ToDictionary(_ => Enum.GetName(_.GetType(), _), _ => Convert.ChangeType(_, _.GetTypeCode()));

            vuescapeResourceKindMap.MustForTest(nameof(vuescapeResourceKindMap)).BeEqualTo(obcResourceKindMap);
        }
    }
}