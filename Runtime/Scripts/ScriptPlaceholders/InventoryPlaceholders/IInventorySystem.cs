using Reflectis.CreatorKit.Worlds.Placeholders;
using Reflectis.SDK.Core.SystemFramework;
using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public interface IInventorySystem : ISystem
    {
        public void InstantiateInventory(InventoryPlaceholder inventoryPlaceholder);

        public void SetInventoryAlpha(float value);
    }
}
