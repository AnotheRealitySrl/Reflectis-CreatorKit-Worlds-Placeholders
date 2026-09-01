using Virtuademy.CreatorKit.Worlds.Core.ObjectSpawner;

using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace Virtuademy.CreatorKit.Worlds.Placeholders
{
    [MovedFrom(false, "Reflectis.CreatorKit.Worlds.Placeholders", "Reflectis.CreatorKit.Worlds.Placeholders")]
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
