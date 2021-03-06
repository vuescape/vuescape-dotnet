// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EnumerableEqualityComparer.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package. Will be overwritten with package update except in OBeautifulCode.Equality.Recipes source.
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Equality.Recipes
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeAnalysis.Recipes;

    using static global::System.FormattableString;

    /// <summary>
    /// An implementation of <see cref="IEqualityComparer{T}"/> for any <see cref="IEnumerable{T}"/>.
    /// </summary>
    /// <remarks>
    /// Adapted from: <a href="https://stackoverflow.com/a/14675741/356790" />.
    /// </remarks>
    /// <typeparam name="T">The type of objects to enumerate.</typeparam>
#if !OBeautifulCodeEqualitySolution
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.CodeDom.Compiler.GeneratedCode("OBeautifulCode.Equality.Recipes", "See package version number")]
    internal
#else
    public
#endif
    class EnumerableEqualityComparer<T> : IEqualityComparer<IEnumerable<T>>
    {
        private readonly EnumerableEqualityComparerStrategy enumerableEqualityComparerStrategy;

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerableEqualityComparer{T}"/> class.
        /// </summary>
        /// <param name="enumerableEqualityComparerStrategy">The strategy to use when comparing two <see cref="IEnumerable{T}"/> for equality.</param>
        public EnumerableEqualityComparer(
            EnumerableEqualityComparerStrategy enumerableEqualityComparerStrategy = EnumerableEqualityComparerStrategy.SequenceEqual)
        {
            this.enumerableEqualityComparerStrategy = enumerableEqualityComparerStrategy;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Justification = ObcSuppressBecause.CA1065_DoNotRaiseExceptionsInUnexpectedLocations_ThrowNotSupportedExceptionForUnreachableCodePath)]
        public bool Equals(
            IEnumerable<T> x,
            IEnumerable<T> y)
        {
            bool result;

            switch (this.enumerableEqualityComparerStrategy)
            {
                case EnumerableEqualityComparerStrategy.SequenceEqual:
                    result = x.IsSequenceEqualTo(y);
                    break;
                case EnumerableEqualityComparerStrategy.UnorderedEqual:
                    result = x.IsUnorderedEqualTo(y);
                    break;
                default:
                    throw new NotSupportedException(Invariant($"This {nameof(EnumerableEqualityComparerStrategy)} is not supported: {this.enumerableEqualityComparerStrategy}."));
            }

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Justification = ObcSuppressBecause.CA1065_DoNotRaiseExceptionsInUnexpectedLocations_ThrowNotSupportedExceptionForUnreachableCodePath)]
        public int GetHashCode(
            IEnumerable<T> obj)
        {
            int result;

            var objAsList = new List<T>(obj);

            switch (this.enumerableEqualityComparerStrategy)
            {
                case EnumerableEqualityComparerStrategy.SequenceEqual:
                    result = HashCodeHelper.Initialize().Hash(objAsList).Value;
                    break;
                case EnumerableEqualityComparerStrategy.UnorderedEqual:
                    result = HashCodeHelper.Initialize().Hash<IReadOnlyCollection<T>>(objAsList).Value;
                    break;
                default:
                    throw new NotSupportedException(Invariant($"This {nameof(EnumerableEqualityComparerStrategy)} is not supported: {this.enumerableEqualityComparerStrategy}."));
            }

            return result;
        }
    }
}
