using Virtuademy.CreatorKit.Worlds.Core.Placeholders;

using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Scripting.APIUpdating;

namespace Virtuademy.CreatorKit.Worlds.Placeholders
{
    [MovedFrom(false, "Reflectis.CreatorKit.Worlds.Placeholders", "Reflectis.CreatorKit.Worlds.Placeholders")]
    public class AddOpenHelpOnActionPlaceholder : SceneComponentPlaceholderBase
    {
        [SerializeField]
        private InputActionReference vrInput;
        [SerializeField]
        private InputActionReference desktopInput;
        [SerializeField]
        private InputActionReference mobileInput;

        public InputActionReference VrInput { get => vrInput; set => vrInput = value; }
        public InputActionReference DesktopInput { get => desktopInput; set => desktopInput = value; }
        public InputActionReference MobileInput { get => mobileInput; set => mobileInput = value; }
    }
}
