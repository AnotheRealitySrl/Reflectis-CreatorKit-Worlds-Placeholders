using UnityEditor;

namespace Reflectis.CreatorKit.Worlds.Placeholders.Editor
{
    [CustomEditor(typeof(InteractionPlaceholder))]
    public class InteractationPlaceholderEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            InteractionPlaceholder interactablePlaceholder = target as InteractionPlaceholder;

            EditorGUILayout.PropertyField(serializedObject.FindProperty("automaticSetup"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("interactionColliders"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("lockHoverDuringInteraction"));

            serializedObject.ApplyModifiedProperties();
        }
    }
}
