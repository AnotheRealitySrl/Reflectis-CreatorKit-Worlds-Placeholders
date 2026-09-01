using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace Virtuademy.CreatorKit.Worlds.Placeholders
{
    [RequireComponent(typeof(PickablePlaceholder))]
    [MovedFrom(false, "Reflectis.CreatorKit.Worlds.Placeholders", "Reflectis.CreatorKit.Worlds.Placeholders")]
    public class WearablePlaceholder : SceneComponentPlaceholderNetwork
    {
        [Tooltip("If set to false then the user cannot unequip this wearable")]
        public bool canRemove = true;
    }
}
