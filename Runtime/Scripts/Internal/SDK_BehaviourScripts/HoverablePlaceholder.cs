using Virtuademy.CreatorKit.Worlds.Core.Placeholders;

using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace Virtuademy.CreatorKit.Worlds.Placeholders
{
    [RequireComponent(typeof(Collider))]
    [MovedFrom(false, "Reflectis.CreatorKit.Worlds.Placeholders", "Reflectis.CreatorKit.Worlds.Placeholders")]
    public class HoverablePlaceholder : SceneComponentPlaceholderBase
    {
        private string hoverActionName = "TriggerHoverEvent";
        private string unhoverActionName = "TriggerUnhoverEvent";

        public string HoverActionName => hoverActionName;
        public string UnhoverActionName => unhoverActionName;
    }
}
