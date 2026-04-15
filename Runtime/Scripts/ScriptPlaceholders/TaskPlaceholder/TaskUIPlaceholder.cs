using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public class TaskUIPlaceholder : SpawnableHandlerPlaceholder
    {
        [SerializeField] public GameObject taskSystem; //Reference to task system for callbacks (Forse non serve, ma ci collego gli eventi di callback)
    }
}
