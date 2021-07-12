// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DotNetBsonSerializationConfiguration.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Vuescape.DotNet.Serialization.Bson
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Naos.Protocol.Serialization.Bson;

    using OBeautifulCode.Serialization;
    using OBeautifulCode.Serialization.Bson;
    using OBeautifulCode.Type;
    using OBeautifulCode.Type.Recipes;

    using Vuescape.DotNet.Domain;

    /// <inheritdoc />
    public class DotNetBsonSerializationConfiguration : BsonSerializationConfigurationBase
    {
        /// <inheritdoc />
        protected override IReadOnlyCollection<string> TypeToRegisterNamespacePrefixFilters =>
            new[]
            {
                Vuescape.DotNet.Domain.ProjectInfo.Namespace,
                OBeautifulCode.DataStructure.ProjectInfo.Namespace,
            };

        /// <inheritdoc />
        protected override IReadOnlyCollection<BsonSerializationConfigurationType> DependentBsonSerializationConfigurationTypes =>
            new[]
            {
                typeof(ProtocolBsonSerializationConfiguration).ToBsonSerializationConfigurationType(),
            };

        /// <inheritdoc />
        protected override IReadOnlyCollection<TypeToRegisterForBson> TypesToRegisterForBson => new[]
            {
                new TypeToRegisterForBson(
                    typeof(UiObject),
                    MemberTypesToInclude.None,
                    RelatedTypesToInclude.None,
                    new BsonSerializerBuilder(() => new UiObjectBsonSerializer(), BsonSerializerOutputKind.Object),
                    null),
            }
            .Concat(
                new Type[0]
                    .Concat(new[] { typeof(IModel) })
                    .Concat(Vuescape.DotNet.Domain.ProjectInfo.Assembly.GetPublicEnumTypes())
                    .Select(_ => _.ToTypeToRegisterForBson()))
            .ToList();
    }
}