// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SlottedUiObject.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System.Collections.Generic;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// This class maps a slot name to a <see cref="UiObject"/> while providing a default slot.
    /// </summary>
    public partial class SlottedUiObject : IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SlottedUiObject"/> class.
        /// </summary>
        /// <param name="slotNameToUiObjectMap">The slot name to UiObject map.</param>
        /// <param name="defaultSlot">The default slot.</param>
        public SlottedUiObject(IReadOnlyDictionary<string, UiObject> slotNameToUiObjectMap, string defaultSlot)
        {
            if (defaultSlot == null)
            {
                new { slotNameToUiObjectMap }.AsArg().Must().BeNull();
            }
            else
            {
                new { slotNameToUiObjectMap }.AsArg().Must().NotBeNullNorEmptyDictionary();
            }

            this.SlotNameToUiObjectMap = slotNameToUiObjectMap;
            this.DefaultSlot = defaultSlot;
        }

        /// <summary>
        /// Gets the slot name to UiObject map.
        /// </summary>
        public IReadOnlyDictionary<string, UiObject>  SlotNameToUiObjectMap { get; private set; }

        /// <summary>
        /// Gets the default slot.
        /// </summary>
        public string DefaultSlot { get; private set; }
    }
}
