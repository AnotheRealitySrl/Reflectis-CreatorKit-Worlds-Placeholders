using Reflectis.CreatorKit.Worlds.Core.Placeholders;

using TMPro;

using UnityEngine;
using UnityEngine.Events;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{

    public class RPMAvatarWebViewPlaceholder : SceneComponentPlaceholderBase
    {
        [SerializeField]
        private GameObject loader;
        [SerializeField]
        private GameObject buttonObj;
        [SerializeField]
        private TextMeshProUGUI goToWebsiteText;

        private UnityEvent onClickEvent = new UnityEvent();

        public GameObject Loader { get => loader; set => loader = value; }
        public GameObject ButtonObj => buttonObj;
        public TextMeshProUGUI GoToWebsiteText { get => goToWebsiteText; set => goToWebsiteText = value; }
        public UnityEvent OnClickEvent => onClickEvent;

        public void OnClickCustomizeInvoke()
        {
            OnClickEvent?.Invoke();
        }
    }
}
