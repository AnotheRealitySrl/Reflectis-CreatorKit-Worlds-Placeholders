using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.InputSystem;
using static Reflectis.CreatorKit.Worlds.Placeholders.InventoryPlaceholder;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public class InventoryPlaceholder : SpawnableHandlerPlaceholder
    {
        public enum EInventoryLayout
        {
            Radial = 0,
            Grid = 1,   
        }

        [HideInInspector] public EInventoryLayout inventoryLayout = EInventoryLayout.Radial; //Hide for now --> Display in the future

        [Tooltip("The list of the items that are already inside the menu")]
        public List<InventoryItemPlaceholder> inventoryItems; //list of the scriptable objects describing the inventory items

        [Tooltip("The distance offset of the radialMenu from the camera")]
        public float zOffset = 0.8f;

        [Tooltip("The distance offset of the radialMenu on the y axis")]
        public float yOffset = 1.15f;

        [Tooltip("The radius that the items are going to use when opening the radialMenu")]
        public float radius = 0.3f;

        [Tooltip("The speed with which the radialMenu will be opened")]
        public float openSpeed = 1f;

        [Tooltip("the input pressed in order to open and close the radialMenu")]
        public InputAction action;

        [Tooltip("Whether or not you want to show the hand item in the inventory, used to remove items instead of clicking on the same item again")]
        [HideInInspector] public bool displayEmptyHand;
        [HideInInspector] public Sprite emptyHandSprite;
        [HideInInspector] public string emptyHandName;
    }


#if UNITY_EDITOR
    [CustomEditor(typeof(InventoryPlaceholder))]
    public class InventoryPlaceholderEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            InventoryPlaceholder inventoryPlaceholder = (InventoryPlaceholder)target;
            if(inventoryPlaceholder.inventoryLayout == EInventoryLayout.Radial)
            {
                SerializedProperty displayEmptyHand = serializedObject.FindProperty("displayEmptyHand");
                EditorGUILayout.PropertyField(displayEmptyHand);

                if(inventoryPlaceholder.displayEmptyHand == true)
                {
                    SerializedProperty emptyHandSprite = serializedObject.FindProperty("emptyHandSprite");
                    EditorGUILayout.PropertyField(emptyHandSprite);
                    SerializedProperty emptyHandName = serializedObject.FindProperty("emptyHandName");
                    EditorGUILayout.PropertyField(emptyHandName);
                }
            }
            serializedObject.ApplyModifiedProperties();
        }
    }
#endif
}

