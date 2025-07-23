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
            var result = Convert.ToString((long)raw, 36);
            return result;
        }
    }
}
