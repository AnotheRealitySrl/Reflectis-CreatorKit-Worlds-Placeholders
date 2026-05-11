using Reflectis.CreatorKit.Worlds.Core.Placeholders;
using UnityEditor;
using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public class ToolItemPlaceholder : PickablePlaceholder, IAddressablePlaceholder
    {

        //[Tooltip("Whether or not the item is a consumable or an infinite item")]
        //public bool consumable; //Whether or not the item is a consumable or an infinite item
    }

#if UNITY_EDITOR
    [CustomEditor(typeof(ToolItemPlaceholder))]
    public class ToolItemPlaceholderEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            //DrawDefaultInspector();
            DrawPropertiesExcluding(serializedObject, "IsNetworked", "<IsNetworked>k__BackingField");
            SerializedProperty networked = serializedObject.FindProperty("<IsNetworked>k__BackingField");

            networked.boolValue = true;

            serializedObject.ApplyModifiedProperties();
        }
    }
#endif
}
