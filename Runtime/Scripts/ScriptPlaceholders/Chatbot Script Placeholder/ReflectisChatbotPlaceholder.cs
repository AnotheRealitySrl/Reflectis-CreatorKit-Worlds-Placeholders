using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public class ReflectisChatbotPlaceholder : ChatbotPlaceholderBase
    {
        [Tooltip("This will be the name of the avatar, displayed in the chat panel.")]
        [SerializeField] private string agent = "minimario";

        public string Agent => agent;
    }
}
