using Reflectis.CreatorKit.Worlds.Core.Placeholders;

using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public class MascotteNameSetCheckPlaceholder : SceneComponentPlaceholderBase
    {
        [SerializeField] private string mascotteName;

        public string MascotteName { get => mascotteName; set => mascotteName = value; }
    }
}
