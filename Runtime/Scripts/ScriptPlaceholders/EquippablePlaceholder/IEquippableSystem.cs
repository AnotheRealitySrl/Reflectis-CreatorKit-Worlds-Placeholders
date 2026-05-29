using Reflectis.SDK.Core.SystemFramework;
using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public interface IEquippableSystem : ISystem
    {
        public bool AddItemToContainerInventory(PickablePlaceholder _pickable);
    }
}
