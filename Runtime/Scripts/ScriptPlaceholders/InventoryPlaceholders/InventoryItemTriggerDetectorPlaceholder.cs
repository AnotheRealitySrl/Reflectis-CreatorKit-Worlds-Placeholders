using Reflectis.CreatorKit.Worlds.Core.Placeholders;
using UnityEngine;
using UnityEngine.Events;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public class InventoryItemTriggerDetectorPlaceholder : SceneComponentPlaceholderBase
    {
        [Tooltip("The reference to the item that triggers the action when entering the collider")]
        public InventoryItemPlaceholder inventoryItem;

        [Tooltip("The collider in the scene that is triggered when the inventory item enters its space")]
        public Collider[] detectorCollider; 

        public UnityEvent OnItemTriggerEnter;
        public UnityEvent OnItemTriggerExit;
    }
}
