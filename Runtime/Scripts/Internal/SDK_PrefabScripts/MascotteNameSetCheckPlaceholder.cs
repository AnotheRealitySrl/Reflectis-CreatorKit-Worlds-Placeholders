using Virtuademy.CreatorKit.Worlds.Core.Placeholders;

using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace Virtuademy.CreatorKit.Worlds.Placeholders
{
    [MovedFrom(false, "Reflectis.CreatorKit.Worlds.Placeholders", "Reflectis.CreatorKit.Worlds.Placeholders")]
    public class MascotteNameSetCheckPlaceholder : SceneComponentPlaceholderBase
    {
        [SerializeField] private string mascotteName;

        public string MascotteName { get => mascotteName; set => mascotteName = value; }
    }
}
