// <copyright file="HtmlIdGenerator.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System;
    using System.Threading;

    /// <summary>
    /// Generates ephemeral IDs suitable for HTML element IDs.
    /// </summary>
    public static class HtmlIdGenerator
    {
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

                // combine tick count & thread ID for a better per-thread seed.
                var seed = (Environment.TickCount * 31) + Thread.CurrentThread.ManagedThreadId;
                rng = new Random(seed);

                return rng;
            }
        }

        /// <summary>
        /// Generates a new pseudo-random Id suitable for ephemeral use.
        /// The Id will be all lowercase + digits and between 11-13 characters long.
        /// </summary>
        /// <returns>The new Id.</returns>
        public static string NewId()
        {
            // fill a local 8-byte buffer with randomness.
            var buffer = new byte[8];
            RandomGenerator.NextBytes(buffer);

            // Read 64 bits, mask off the high (sign) bit to yield a non-negative 63-bit value,
            // then encode in base-36.
            var raw = BitConverter.ToUInt64(buffer, 0) & long.MaxValue;
            var result = ToBase36(raw);

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
                // max length for 63 bits in base-36 is ceil(log₃₆(2⁶³)) ≈ 13 chars
                var buffer = new char[13];
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
