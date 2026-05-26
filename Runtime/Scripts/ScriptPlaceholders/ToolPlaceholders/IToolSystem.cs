using Reflectis.CreatorKit.Worlds.Placeholders;
using Reflectis.SDK.Core.SystemFramework;
using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public interface IToolSystem : ISystem
    {
        public void InstantiateInventory(ToolPlaceholder inventoryPlaceholder);

        public void SetInventoryAlpha(float value);

        public void AddItemToInventory(ToolItemPlaceholder _placeholder);
    }
}
