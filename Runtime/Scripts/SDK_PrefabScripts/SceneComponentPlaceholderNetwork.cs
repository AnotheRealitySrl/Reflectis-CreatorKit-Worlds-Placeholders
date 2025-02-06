using Reflectis.CreatorKit.Worlds.Core.Placeholders;

using UnityEngine;
using UnityEngine.Serialization;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public class SceneComponentPlaceholderNetwork : SceneComponentPlaceholderBase, INetworkPlaceholder
    {
        [field: SerializeField, FormerlySerializedAs("isNetworked")] public bool IsNetworked { get; set; }
    }
}
