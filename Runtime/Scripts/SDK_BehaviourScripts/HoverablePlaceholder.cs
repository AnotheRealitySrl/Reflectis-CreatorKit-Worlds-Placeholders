using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

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
