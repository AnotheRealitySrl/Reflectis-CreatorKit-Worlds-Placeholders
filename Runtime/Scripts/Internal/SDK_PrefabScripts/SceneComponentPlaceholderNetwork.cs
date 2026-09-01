using Virtuademy.CreatorKit.Worlds.Core.Placeholders;

using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Scripting.APIUpdating;

namespace Virtuademy.CreatorKit.Worlds.Placeholders
{
    [MovedFrom(false, "Reflectis.CreatorKit.Worlds.Placeholders", "Reflectis.CreatorKit.Worlds.Placeholders")]
    public class SceneComponentPlaceholderNetwork : SceneComponentPlaceholderBase, INetworkPlaceholder
    {
        [field: SerializeField, FormerlySerializedAs("isNetworked")] public bool IsNetworked { get; set; }
    }
}
