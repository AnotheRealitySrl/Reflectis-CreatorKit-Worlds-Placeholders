using System.Collections.Generic;

using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public class InteractionPlaceholder : SceneComponentPlaceholderNetwork
    {
        #region Settings

        [Header("Interaction settings")]

        [SerializeField, Tooltip("The colliders that will be recognized by the interactable behaviours")]
        private List<Collider> interactionColliders = new();
        [SerializeField, Tooltip("If set to true the hover callback won't be called if the generic interactable is in a " +
            "state that is different from idle. As an example if the interactable is selected, it will keep the hover state " +
            "until the selection is over and the user is not hovering the object.")]
        private bool lockHoverDuringInteraction = false;

        public List<Collider> InteractionColliders => interactionColliders;

        public bool LockHoverDuringInteraction { get; set; }
        #endregion

    }
}
