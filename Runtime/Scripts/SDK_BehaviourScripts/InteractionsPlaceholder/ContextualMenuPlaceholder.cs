using Reflectis.SDK.Core.Utilities;

using UnityEngine;

using static Reflectis.CreatorKit.Worlds.Core.Interaction.IContextualMenuManageable;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public class ContextualMenuPlaceholder : InteractionBehaviourPlaceholder
    {
        #region Contextual menu

        [Header("Contextual menu")]
        [HelpBox("Please note that only \"Delete\", \"Lock Transform\" and \"Color Picker\" options are currently fully supported. " +
            " \"Non proportional scale\" is supported only if the interactable mode \"Manipulable\" is selected. " +
            "Other options will not be considered", HelpBoxMessageType.Warning)]

        [SerializeField, Tooltip("Select how many options will be available in this menu")]
        private EContextualMenuOption contextualMenuOptions =
            EContextualMenuOption.Delete;

        public EContextualMenuOption ContextualMenuOptions { get => contextualMenuOptions; set => contextualMenuOptions = value; }
        #endregion

        #region Options Settings
        #region Color picker
        public bool colorFirstMeshOnly;
        #endregion

        #region ModelExploder
        public bool explosionMoveSubmeshes;
        #endregion

        #endregion
    }
}
