using Reflectis.CreatorKit.Worlds.Core.Placeholders;
using UnityEditor;
using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public class InventoryItemPlaceholder : SceneComponentPlaceholderNetwork, IAddressablePlaceholder
    {
        [Tooltip("The name of the item")]
        public string itemName; //Name of the item

        [Tooltip("Whether or not the item is a consumable or an infinite item")]
        public bool consumable; //Whether or not the item is a consumable or an infinite item

        [Tooltip("Number of times the item can be used before being lost")]
        [HideInInspector] public int numberOfUses = 0; //Shown only if consumable is true

        [Tooltip("The icon used to display the item in the menu")]
        public Sprite icon; //The icon to display in the inventory

        public virtual string AddressableKey => itemName;
    }

#if UNITY_EDITOR
    [CustomEditor(typeof(InventoryItemPlaceholder))]
    public class InventoryItemPlaceholderEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            //DrawDefaultInspector();
            DrawPropertiesExcluding(serializedObject, "IsNetworked", "<IsNetworked>k__BackingField");
            SerializedProperty networked = serializedObject.FindProperty("<IsNetworked>k__BackingField");

            // Draw the "consumable" field
            SerializedProperty consumableProp = serializedObject.FindProperty("consumable");

            // Conditionally show "numberOfUses"
            if (consumableProp.boolValue)
            {
                SerializedProperty usesProp = serializedObject.FindProperty("numberOfUses");
                EditorGUILayout.PropertyField(usesProp);
            }

            networked.boolValue = true;

            serializedObject.ApplyModifiedProperties();
        }
    }
#endif
}
