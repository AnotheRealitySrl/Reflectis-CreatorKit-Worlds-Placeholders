using UnityEngine;
using static Reflectis.CreatorKit.Worlds.Core.Interaction.IManipulable;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public class ManipulablePlaceholder : InteractionBehaviourPlaceholder
    {
        [SerializeField, Tooltip("Translate, rotate and scale.")]
        private EManipulationMode manipulationMode = (EManipulationMode)~0;

        [SerializeField, Tooltip("Enables hand and ray interaction on this object")]
        private EVRInteraction vrInteraction = (EVRInteraction)~0;

        [SerializeField, Tooltip("A dynamic attach means that the object won't snap to the center of gravity")]
        private bool dynamicAttach;

        [SerializeField, Tooltip("Resets the rotation on one or more axes when the interaction ends (VR-only)")]
        private bool adjustRotationOnRelease;

        [SerializeField, Tooltip("Resets the rotation on the X axis")]
        private bool realignAxisX = true;

        [SerializeField, Tooltip("Resets the rotation on the Y axis")]
        private bool realignAxisY = false;

        [SerializeField, Tooltip("Resets the rotation on the Z axis")]
        private bool realignAxisZ = true;

        [SerializeField, Tooltip("How much time is needed to reset the rotation")]
        private float realignDurationTimeInSeconds = 1f;

        [SerializeField, Tooltip("If selected, the object will face the camera on mouse interaction")]
        private bool mouseLookAtCamera;

        [SerializeField, Tooltip("If specified, a dynamic attach will be generated on interaction")]
        private Transform attachTransform;

        public bool DynamicAttach { get => dynamicAttach; }
        public bool AdjustRotationOnRelease { get => adjustRotationOnRelease; }
        public EVRInteraction VRInteraction { get => vrInteraction; }
        public EManipulationMode ManipulationMode { get => manipulationMode; }
        public bool RealignAxisX { get => realignAxisX; }
        public bool RealignAxisY { get => realignAxisY; }
        public bool RealignAxisZ { get => realignAxisZ; }
        public float RealignDurationTimeInSeconds { get => realignDurationTimeInSeconds; }
        public bool MouseLookAtCamera => mouseLookAtCamera;
        public Transform AttachTransform => attachTransform;

    }
}
