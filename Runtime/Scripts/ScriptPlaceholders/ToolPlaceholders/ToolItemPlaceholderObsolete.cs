using Virtuademy.CreatorKit.Worlds.Core.Placeholders;
using UnityEditor;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;


namespace Virtuademy.CreatorKit.Worlds.Placeholders
{
    [RequireComponent(typeof(PickablePlaceholder))]
    [MovedFrom(false, "Reflectis.CreatorKit.Worlds.Placeholders", "Reflectis.CreatorKit.Worlds.Placeholders")]
    public class ToolItemPlaceholderObsolete : PickablePlaceholder, IAddressablePlaceholder
    {

        //[Tooltip("Whether or not the item is a consumable or an infinite item")]
        //public bool consumable; //Whether or not the item is a consumable or an infinite item
    }

#if UNITY_EDITOR
    [CustomEditor(typeof(ToolItemPlaceholderObsolete))]
    [MovedFrom(false, "Reflectis.CreatorKit.Worlds.Placeholders", "Reflectis.CreatorKit.Worlds.Placeholders")]
    public class ToolItemPlaceholderObsoleteEditor : Editor
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
