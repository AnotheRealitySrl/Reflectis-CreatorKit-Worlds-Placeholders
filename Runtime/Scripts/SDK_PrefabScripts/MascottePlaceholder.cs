using Reflectis.CreatorKit.Worlds.Core.Placeholders;

using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public class MascottePlaceholder : SceneComponentPlaceholderBase
    {
        [SerializeField]
        private string mascotteName;
        [Header("Animator")]
        [SerializeField]
        private Animator animator;
        [Header("Pan")]
        [SerializeField]
        private bool panOnInit;

        public Animator Animator { get => animator; }
        public bool PanOnInit { get => panOnInit; }
        public string MascotteName { get => mascotteName; set => mascotteName = value; }
    }
}
