using Virtuademy.CreatorKit.Worlds.Core.Placeholders;

using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Scripting.APIUpdating;

namespace Virtuademy.CreatorKit.Worlds.Placeholders
{
    [RequireComponent(typeof(SpawnObjectData))]
    [MovedFrom(false, "Reflectis.CreatorKit.Worlds.Placeholders", "Reflectis.CreatorKit.Worlds.Placeholders")]
    public class ObjectSpawnerPlaceholder : SceneComponentPlaceholderBase
    {
        [SerializeField]
        private InputActionReference vrInput;
        [SerializeField]
        private InputActionReference desktopInput;

        public InputActionReference VrInput { get => vrInput; }
        public InputActionReference DesktopInput { get => desktopInput; }
    }
}
