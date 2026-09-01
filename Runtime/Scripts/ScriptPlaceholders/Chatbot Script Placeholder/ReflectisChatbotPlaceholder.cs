using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace Virtuademy.CreatorKit.Worlds.Placeholders
{
    [MovedFrom(false, "Reflectis.CreatorKit.Worlds.Placeholders", "Reflectis.CreatorKit.Worlds.Placeholders")]
    public class ReflectisChatbotPlaceholder : ChatbotPlaceholderBase
    {
        [Tooltip("This is the name of the agent that you create in the section Reflectis AI of the Back Office." +
            "Copy-paste the name here to make this chatbot use such agent.")]
        [SerializeField] private string agent = "minimario";

        public string Agent => agent;
    }
}
