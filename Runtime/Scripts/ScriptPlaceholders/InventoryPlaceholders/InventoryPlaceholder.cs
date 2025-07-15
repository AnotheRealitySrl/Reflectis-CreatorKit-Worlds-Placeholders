using Reflectis.CreatorKit.Worlds.Core.Placeholders;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public class InventoryPlaceholder : SceneComponentPlaceholderBase
    {
        /*public enum EInventoryLayout
        {
            Radial = 0,
            Grid = 0,   
        }*/

        [Tooltip("The list of the items that are already inside the menu")]
        public List<InventoryItemPlaceholder> inventoryItems; //list of the scriptable objects describing the inventory items

        [Tooltip("The distance offset of the radialMenu from the camera")]
        public float zOffset;

        [Tooltip("The distance offset of the radialMenu on the y axis")]
        public float yOffset;

        [Tooltip("The radius that the items are going to use when opening the radialMenu")]
        public float radius;

        [Tooltip("The speed with which the radialMenu will be opened")]
        public float openSpeed = 1f;

        [Tooltip("the input pressed in order to open and close the radialMenu")]
        public InputAction action;

    }
}
