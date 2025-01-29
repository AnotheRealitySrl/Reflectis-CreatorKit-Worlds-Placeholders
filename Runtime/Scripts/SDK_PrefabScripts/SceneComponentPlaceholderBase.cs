using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public abstract class SceneComponentPlaceholderBase : MonoBehaviour
    {
        [SerializeField] private bool automaticSetup = true;

        public bool AutomaticSetup => automaticSetup;

    }
}