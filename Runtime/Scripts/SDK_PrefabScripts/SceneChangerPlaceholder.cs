using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public class SceneChangerPlaceholder : SceneComponentPlaceholderBase
    {
        [SerializeField, Tooltip("Name of an environment that has a static event associated from the backoffice")]

        private string sceneAddressableName;



        public string SceneAddressableName => sceneAddressableName;
    }
}
