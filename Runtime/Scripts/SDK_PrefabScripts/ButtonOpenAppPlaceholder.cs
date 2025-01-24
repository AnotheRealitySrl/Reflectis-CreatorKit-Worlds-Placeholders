using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public class ButtonOpenAppPlaceholder : SceneComponentPlaceholderBase
    {
        [SerializeField] private string appLink;

        public string AppLink => appLink;
    }
}
