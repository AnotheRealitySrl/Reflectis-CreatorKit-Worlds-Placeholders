using System;

using Unity.VisualScripting;

using UnityEngine;
using static Reflectis.CreatorKit.Worlds.Core.Interaction.IVisualScriptingInteractable;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public class VisualScriptingInteractablePlaceholder : InteractionBehaviourPlaceholder
    {
        #region Visual Scripting interaction

        [SerializeField, Tooltip("If set to true the hover callback won't be called if the generic interactable is in a " +
            "state that is different from idle. As an example if the interactable is selected, it will keep the hover state " +
            "until the selection is over and the user is not hovering the object.")]
        private bool lockHoverDuringInteraction;

        [SerializeField, Tooltip("Reference to the script machine that describes what happens during interaction events." +
            "Utilize \"VisualScriptingInteractableHoverEnter\",\"VisualScriptingInteractableHoverExit\",\"VisualScriptingInteractableSelectEnter\",\"VisualScriptingInteractableSelectExit\"" +
            " and \"VisualScriptingInteractableInteract\" nodes to custumize your interactions")]
        private ScriptMachine interactionsScriptMachine;

        [SerializeField, Tooltip("Reference to the script machine that describes what happens if the object is destroyed while selected." +
            "The script machine has to be assigned to a different empty gameobject! " +
            "Utilize \"VisualScriptingInteractableUnselectOnDestroy\" node to custumize the interaction")]
        private ScriptMachine unselectOnDestroyScriptMachine;

        [Header("Allowed states")]

        [SerializeField, Tooltip("Choose which state are enabled on this object in desktop platforms.")]
        private EAllowedVisualScriptingInteractableState desktopAllowedStates = (EAllowedVisualScriptingInteractableState)~0;

        [SerializeField, Tooltip("Choose which state are enabled on this object in VR platforms.")]
        private EAllowedVisualScriptingInteractableState vrAllowedStates = (EAllowedVisualScriptingInteractableState)~0;

        [HideInInspector]
        public Action<GameObject> OnSelectedActionVisualScripting;

        public ScriptMachine InteractionsScriptMachine => interactionsScriptMachine;

        public EAllowedVisualScriptingInteractableState DesktopAllowedStates => desktopAllowedStates;
        public EAllowedVisualScriptingInteractableState VRAllowedStates => vrAllowedStates;


        [SerializeField, Tooltip("Enables hand and ray interaction on this object")]
        private EVRVisualScriptingInteraction vrVisualScriptingInteraction = (EVRVisualScriptingInteraction)~0;

        public EVRVisualScriptingInteraction VrVisualScriptingInteraction { get => vrVisualScriptingInteraction; set => vrVisualScriptingInteraction = value; }

        #endregion

    }
}
