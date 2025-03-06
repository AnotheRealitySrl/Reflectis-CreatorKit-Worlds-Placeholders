using UnityEditor;

namespace Reflectis.CreatorKit.Worlds.Placeholders.Editor
{
    [CustomEditor(typeof(InteractionPlaceholder))]
    public class InteractationPlaceholderEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            InteractionPlaceholder interactablePlaceholder = target as InteractionPlaceholder;
            // IsNetworked is a property -> <IsNetworked>k__BackingField
            EditorGUILayout.PropertyField(serializedObject.FindProperty("<IsNetworked>k__BackingField"));

            EditorGUILayout.PropertyField(serializedObject.FindProperty("automaticSetup"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("interactionColliders"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("lockHoverDuringInteraction"));

            serializedObject.ApplyModifiedProperties();
        }
    }
}
