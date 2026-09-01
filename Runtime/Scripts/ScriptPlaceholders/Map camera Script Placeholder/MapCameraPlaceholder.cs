using Virtuademy.CreatorKit.Worlds.Core.Placeholders;

using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace Virtuademy.CreatorKit.Worlds.Placeholders
{
    [RequireComponent(typeof(Camera))]
    [MovedFrom(false, "Reflectis.CreatorKit.Worlds.Placeholders", "Reflectis.CreatorKit.Worlds.Placeholders")]
    public class MapCameraPlaceholder : SceneComponentPlaceholderBase
    {
        public Camera Cam => GetComponent<Camera>();

        private void Awake()
        {
            Cam.enabled = false;
        }
    }
}