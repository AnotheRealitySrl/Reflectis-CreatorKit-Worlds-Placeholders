using Reflectis.CreatorKit.Worlds.Core.Placeholders;

using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public class VoiceChatGroupPlaceholder : SceneComponentPlaceholderBase
    {
        [SerializeField] private string voiceRoomName = "Global";
        [SerializeField] private bool isMainChannel = false;

        public string VoiceRoomName => voiceRoomName;
        public bool IsMainChannel => isMainChannel;
    }
}
