using Reflectis.CreatorKit.Worlds.Core.ObjectSpawner;

using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public class SpawnObjectData : MonoBehaviour
    {
        [SerializeField]
        private GameObject prefab;
        [SerializeField]
        private SpawnPosition spawnPosition;

        public GameObject Prefab { get => prefab; }
        public SpawnPosition SpawnPosition { get => spawnPosition; }
    }
}
