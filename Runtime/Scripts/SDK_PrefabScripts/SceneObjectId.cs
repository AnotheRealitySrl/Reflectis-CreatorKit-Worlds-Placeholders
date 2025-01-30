#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using System.Collections.Generic;
using Reflectis.CreatorKit.Worlds.Placeholders;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    [ExecuteInEditMode]
    public class SceneObjectId : MonoBehaviour
    {

        [SerializeField, HideInInspector]
        private int uniqueID;

        public int UniqueID
        {
            get
            {
                if (uniqueID == 0 && !string.IsNullOrEmpty(gameObject.scene.name))
                {
                    Debug.Log($"Unassigned Unique ID {uniqueID} to {gameObject.name} in scene {gameObject.scene.name}", gameObject);
                    GenerateObjectUniqueID();
                }
                return uniqueID;
            }
            set => uniqueID = value;
        }

        private void Reset()
        {
            GenerateObjectUniqueID();
        }


        [ContextMenu("Generate Unique ID")]
        public void GenerateObjectUniqueID()
        {
            //Debug.Log($"Generating Unique ID for {gameObject.name}", gameObject);
            //If it is a prefab in the project, do not generate a new ID
            if (string.IsNullOrEmpty(gameObject.scene.name))
            {
                uniqueID = 0;
                Debug.Log($"The object is not in scene {gameObject.name}", gameObject);
            }
            else
            {
                if (uniqueID == 0)
                {
                    Debug.Log($"Generating Unique ID for {gameObject.name}", gameObject);
                    uniqueID = GenerateNewUniqueID();
                    Debug.Log($"Assigned Unique ID {uniqueID} to {gameObject.name}", gameObject);
                }
                else
                {
                    Debug.Log($"Unique ID {uniqueID} already assigned to {gameObject.name}", gameObject);
                }
            }
            Debug.Log($"Generated Unique ID {uniqueID} for {gameObject.name}", gameObject);
#if UNITY_EDITOR
            if (!Application.isPlaying)
            {
                EditorUtility.SetDirty(this);
            }
#endif
        }


        public static int GenerateNewUniqueID()
        {
            List<int> ids = new List<int>();
            var objects = FindObjectsByType<SceneObjectId>(FindObjectsSortMode.None);
            //Using select makes unity crash if we are adding a gameobject istance to the scene in editor
            foreach (var item in objects)
            {
                ids.Add(item.uniqueID);
            }
            int uniqueID = Random.Range(1, int.MaxValue);
            while (ids.Contains(uniqueID))
            {
                uniqueID = Random.Range(1, int.MaxValue);
            }
            return uniqueID;
        }
    }
}


#if UNITY_EDITOR
[CustomEditor(typeof(SceneObjectId))]
public class UniqueIDAssignerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        // Ottieni il riferimento al componente
        SceneObjectId assigner = (SceneObjectId)target;

        // Mostra un messaggio con l'ID univoco
        EditorGUILayout.LabelField($"ObjectID: [{assigner.UniqueID}]");

    }
}
#endif
