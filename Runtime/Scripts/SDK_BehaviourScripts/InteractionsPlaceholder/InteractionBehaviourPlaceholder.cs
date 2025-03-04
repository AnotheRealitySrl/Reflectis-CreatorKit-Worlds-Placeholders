using Reflectis.CreatorKit.Worlds.Core.Placeholders;
using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    [RequireComponent(typeof(InteractionPlaceholder))]
    public abstract class InteractionBehaviourPlaceholder : SceneComponentPlaceholderBase
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
