using System.Collections.Generic;
using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public class Informative_Highlight : MonoBehaviour
    {
        [SerializeField]
        private Material[] highlightMaterial = default;

        private Dictionary<MeshRenderer, Material[]> materialMap = new Dictionary<MeshRenderer, Material[]>();

        private void Awake()
        {
            var renderers = GetComponentsInChildren<MeshRenderer>(true);

            foreach (var renderer in renderers)
            {
                // We store the array so we maintain sub-mesh material order
                materialMap[renderer] = renderer.sharedMaterials;
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////
        public void Highlight(int index)
        {
            foreach (var kvp in materialMap)
            {
                MeshRenderer renderer = kvp.Key;
                if (renderer == null) continue;

                // Create an array matching the sub-mesh count
                int materialCount = kvp.Value.Length;
                Material[] swapArray = new Material[materialCount];

                for (int i = 0; i < materialCount; i++)
                {
                    swapArray[i] = highlightMaterial[index];
                }

                renderer.sharedMaterials = swapArray;
            }
        }

        public void ResetMaterials()
        {
            foreach (var kvp in materialMap)
            {
                if (kvp.Key != null)
                {
                    kvp.Key.sharedMaterials = kvp.Value;
                }
            }
        }
    }
}
