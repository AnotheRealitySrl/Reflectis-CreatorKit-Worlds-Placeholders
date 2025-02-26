using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    [RequireComponent(typeof(InteractionPlaceholder))]
    public abstract class InteractionBehaviourPlaceholder : SceneComponentPlaceholderNetwork
    {
        private InteractionPlaceholder interactionPlaceholder;
        protected InteractionPlaceholder InteractionPlaceholder
        {
            get
            {
                if (interactionPlaceholder == null)
                {
                    interactionPlaceholder = GetComponentInChildren<InteractionPlaceholder>(true);
                }
                return interactionPlaceholder;
            }
        }
    }
}
