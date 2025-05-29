using UnityEditor;

namespace Reflectis.CreatorKit.Worlds.Placeholders.Editor
{
    [CustomEditor(typeof(ManipulablePlaceholder))]
    public class ManipulablePlaceholderEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            ManipulablePlaceholder interactablePlaceholder = target as ManipulablePlaceholder;

            EditorGUILayout.PropertyField(serializedObject.FindProperty("manipulationMode"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("vrInteraction"));
            if (interactablePlaceholder.VrInteraction != 0)
            {
                EditorGUILayout.PropertyField(serializedObject.FindProperty("dynamicAttach"));
                EditorGUILayout.PropertyField(serializedObject.FindProperty("adjustRotationOnRelease"));

                if (interactablePlaceholder.AdjustRotationOnRelease)
                {
                    EditorGUILayout.PropertyField(serializedObject.FindProperty("realignAxisX"));
                    EditorGUILayout.PropertyField(serializedObject.FindProperty("realignAxisY"));
                    EditorGUILayout.PropertyField(serializedObject.FindProperty("realignAxisZ"));
                    EditorGUILayout.PropertyField(serializedObject.FindProperty("realignDurationTimeInSeconds"));
                }
            }
            serializedObject.ApplyModifiedProperties();
        }
    }
}
