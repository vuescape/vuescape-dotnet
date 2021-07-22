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
        /// <param name="defaultSlotName">The default slot name.</param>
        /// <param name="activeSlotName">The active slot name.</param>
        public SlottedUiObject(IReadOnlyDictionary<string, UiObject> slotNameToUiObjectMap, string defaultSlotName, string activeSlotName = null)
        {
            if (defaultSlotName == null)
            {
                new { slotNameToUiObjectMap }.AsArg().Must().BeNull();
            }
            else
            {
                new { slotNameToUiObjectMap }.AsArg().Must().NotBeNullNorEmptyDictionary();
            }

            this.SlotNameToUiObjectMap = slotNameToUiObjectMap;
            this.DefaultSlotName = defaultSlotName;
            this.ActiveSlotName = activeSlotName;
        }

        /// <summary>
        /// Gets the slot name to UiObject map.
        /// </summary>
        public IReadOnlyDictionary<string, UiObject>  SlotNameToUiObjectMap { get; private set; }

        /// <summary>
        /// Gets the default slot name.
        /// </summary>
        public string DefaultSlotName { get; private set; }

        /// <summary>
        /// Gets the active slot name.
        /// </summary>
        public string ActiveSlotName { get; private set; }
    }
}
