using Reflectis.CreatorKit.Worlds.Core.Placeholders;

using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
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
