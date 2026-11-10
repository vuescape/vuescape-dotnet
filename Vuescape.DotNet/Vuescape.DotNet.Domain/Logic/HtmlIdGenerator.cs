// <copyright file="HtmlIdGenerator.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System;

    /// <summary>
    /// Generates ephemeral IDs suitable for HTML element IDs.
    /// </summary>
    public static class HtmlIdGenerator
    {
        // The length of the largest 63-bit value in base-36, ceil(log₃₆(2⁶³)), to which every Id is padded.
        private const int IdLength = 13;

        // Seeds each thread's generator. Random isn't thread-safe, so it's only used under its own lock.
        private static readonly Random SeedGenerator = new Random();

        // ReSharper disable once InconsistentNaming
        [ThreadStatic]
        private static Random rng;

        private static Random RandomGenerator
        {
            get
            {
                if (rng != null)
                {
                    return rng;
                }

                // A seed made from the time and thread could repeat on two threads, which would then make the same Ids.
                int seed;
                lock (SeedGenerator)
                {
                    seed = SeedGenerator.Next();
                }

                rng = new Random(seed);

                return rng;
            }
        }

        /// <summary>
        /// Generates a new pseudo-random Id suitable for ephemeral use.
        /// The Id will be all lowercase + digits and 13 characters long.
        /// </summary>
        /// <returns>The new Id.</returns>
        public static string NewId()
        {
            // fill a local 8-byte buffer with randomness.
            var buffer = new byte[8];
            RandomGenerator.NextBytes(buffer);

            // Read 64 bits, mask off the high (sign) bit to yield a non-negative 63-bit value,
            // then encode in base-36.
            // Padded, since a small value has fewer digits.
            var raw = BitConverter.ToUInt64(buffer, 0) & long.MaxValue;
            var result = ToBase36(raw).PadLeft(IdLength, '0');

            return result;
        }

        /// <summary>
        /// Converts the specified 64-bit unsigned integer to its lowercase base-36 string representation.
        /// </summary>
        /// <param name="value">The unsigned 64-bit integer to convert.</param>
        /// <returns>A string containing the base-36 representation of <paramref name="value"/>, using digits '0'–'9' and letters 'a'–'z'.
        /// If <paramref name="value"/> is zero, returns "0".
        /// </returns>
        private static string ToBase36(ulong value)
        {
            const string alphabet = "0123456789abcdefghijklmnopqrstuvwxyz";

            string result;
            if (value == 0)
            {
                result = "0";
            }
            else
            {
                var buffer = new char[IdLength];
                var pos = buffer.Length;

                while (value > 0)
                {
                    var digit = (int)(value % 36);
                    buffer[--pos] = alphabet[digit];
                    value /= 36;
                }

                // slice off the unused leading chars
                result = new string(buffer, pos, buffer.Length - pos);
            }

            return result;
        }
    }
}
