using Virtuademy.CreatorKit.Worlds.Core.Placeholders;

using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace Virtuademy.CreatorKit.Worlds.Placeholders
{
    [MovedFrom(false, "Reflectis.CreatorKit.Worlds.Placeholders", "Reflectis.CreatorKit.Worlds.Placeholders")]
    public class MirrorPlaceholder : SceneComponentPlaceholderBase, IAddressablePlaceholder
    {
        [SerializeField] private string addressableKey;

        [SerializeField] private Transform panTransform;
        [SerializeField] private Transform teleportTarget;

        public string AddressableKey => addressableKey;

        public Transform PanTransform => panTransform;
        public Transform TeleportTarget => teleportTarget;
    }
}
