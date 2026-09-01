using Virtuademy.CreatorKit.Worlds.Core.Placeholders;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace Virtuademy.CreatorKit.Worlds.Placeholders
{
    [RequireComponent(typeof(InteractablePlaceholder))]
    [MovedFrom(false, "Reflectis.CreatorKit.Worlds.Placeholders", "Reflectis.CreatorKit.Worlds.Placeholders")]
    public abstract class InteractionBehaviourPlaceholder : SceneComponentPlaceholderBase
    {
        private InteractablePlaceholder interactionPlaceholder;
        protected InteractablePlaceholder InteractionPlaceholder
        {
            get
            {
                if (interactionPlaceholder == null)
                {
                    interactionPlaceholder = GetComponentInChildren<InteractablePlaceholder>(true);
                }
                return interactionPlaceholder;
            }
        }
    }
}
