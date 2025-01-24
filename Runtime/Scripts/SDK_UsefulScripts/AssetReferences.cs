using System;

using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    [Serializable]
    public class AssetReferences : IEquatable<AssetReferences>
    {
        public GameObject prefabToInstantiate;
        public Transform posToSpawn;
        public float spawnChance;

        public bool Equals(AssetReferences other) =>
                prefabToInstantiate == other.prefabToInstantiate &&
                posToSpawn == other.posToSpawn &&
                spawnChance == other.spawnChance;
    }
}
