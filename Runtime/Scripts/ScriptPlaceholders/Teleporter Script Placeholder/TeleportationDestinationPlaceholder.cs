using Virtuademy.CreatorKit.Worlds.Core.Placeholders;

using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace Virtuademy.CreatorKit.Worlds.Placeholders
{
    [MovedFrom(false, "Reflectis.CreatorKit.Worlds.Placeholders", "Reflectis.CreatorKit.Worlds.Placeholders")]
    public class TeleportationDestinationPlaceholder : SceneComponentPlaceholderBase
    {
        [SerializeField, Tooltip("Write the teleportation point's name that will appear in the map")]
        private string teleportAreaName;

        public string TeleportAreaName => teleportAreaName;
    }
}
