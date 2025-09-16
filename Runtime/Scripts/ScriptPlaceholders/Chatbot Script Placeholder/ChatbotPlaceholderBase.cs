using Reflectis.CreatorKit.Worlds.Core.Placeholders;

using UnityEngine;
using UnityEngine.Events;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public abstract class ChatbotPlaceholderBase : SceneComponentPlaceholderBase
    {
        [Header("Chatbot structure.\n" +
             "Do not modify it, unless you need to create custom avatars.")]
        [SerializeField] protected Transform avatarContainer;
        [SerializeField] protected RectTransform chatPanel;

        [Tooltip("By default, the animator is searched automatically in avatar's hierarchy. " +
            "Specify the animator in the case the avatar in use has multiple animators in the hierarchy.")]
        [SerializeField] protected Animator animator;


        public Transform AvatarContainer => avatarContainer;
        public RectTransform ChatPanel => chatPanel;
        public Animator Animator => animator;

        public UnityEvent OnChatBotSelect { get; } = new();
        public UnityEvent OnChatBotUnselected { get; } = new();
    }
}
