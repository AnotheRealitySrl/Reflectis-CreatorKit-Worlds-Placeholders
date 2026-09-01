using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace Virtuademy.CreatorKit.Worlds.Placeholders
{
    [MovedFrom(false, "Reflectis.CreatorKit.Worlds.Placeholders", "Reflectis.CreatorKit.Worlds.Placeholders")]
    public class InteractableOwnershipPlaceholder : SceneComponentPlaceholderNetwork
    {
        public Transform grabbableItem; //The item to be grabbed, containing photonview

        private void Awake()
        {
            if (grabbableItem == null)
            {
                grabbableItem = gameObject.transform;
            }
        }

    }
}