using Reflectis.CreatorKit.Worlds.Core.Placeholders;

using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    [RequireComponent(typeof(Collider))]
    public class HoverablePlaceholder : SceneComponentPlaceholderBase
    {
        private string hoverActionName = "TriggerHoverEvent";
        private string unhoverActionName = "TriggerUnhoverEvent";

        public string HoverActionName => hoverActionName;
        public string UnhoverActionName => unhoverActionName;
    }
}
