// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DotNetJsonSerializationConfiguration.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Vuescape.DotNet.Serialization.Json
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using OBeautifulCode.Serialization;
    using OBeautifulCode.Serialization.Json;
    using OBeautifulCode.Type;
    using OBeautifulCode.Type.Recipes;

    using Vuescape.DotNet.Domain;

    /// <inheritdoc />
    public class DotNetJsonSerializationConfiguration : JsonSerializationConfigurationBase
    {
        /// <inheritdoc />
        protected override IReadOnlyCollection<string> TypeToRegisterNamespacePrefixFilters =>
            new[]
            {
                Vuescape.DotNet.Domain.ProjectInfo.Namespace,
                OBeautifulCode.DataStructure.ProjectInfo.Namespace,
            };

        // /// <inheritdoc />
        // protected override IReadOnlyCollection<JsonSerializationConfigurationType> DependentJsonSerializationConfigurationTypes =>
        //    new[]
        //    {
        //        typeof(ProtocolJsonSerializationConfiguration).ToJsonSerializationConfigurationType(),
        //    };

        /// <inheritdoc />
        protected override IReadOnlyCollection<TypeToRegisterForJson> TypesToRegisterForJson => new[]
            {
                new TypeToRegisterForJson(
                    typeof(UiObject),
                    MemberTypesToInclude.None,
                    RelatedTypesToInclude.None,
                    new JsonConverterBuilder("ui-object-converter", () => new UiObjectReaderJsonConverter(this), () => new UiObjectReaderJsonConverter(this)),
                    null),
            }
            .Concat(
                Type.EmptyTypes
                    .Concat(new[] { typeof(IModel) })
                    .Concat(Vuescape.DotNet.Domain.ProjectInfo.Assembly.GetPublicEnumTypes())
                    .Select(_ => _.ToTypeToRegisterForJson()))
            .ToList();
    }
}