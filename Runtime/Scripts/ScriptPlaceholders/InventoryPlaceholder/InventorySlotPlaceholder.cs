using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public class InventorySlotPlaceholder : SceneComponentPlaceholderNetwork
    {
        [Tooltip("Number of wear slots in the wear inventory. You cannot equip or hold more that this value items")]
        public int wearSlotsCount = 1;

        [Tooltip("Number of slots in the inventory. You cannot equip or hold more that this value items")]
        public int inventorySlotsCount = 2;
    }
}
