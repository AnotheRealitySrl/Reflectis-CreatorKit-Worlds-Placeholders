using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    [RequireComponent(typeof(MascottePlaceholder))]
    public class MascottePanelPlaceholder : PanelPlaceholder
    {
        [SerializeField]
        private string[] faqCategory;

        public string[] FaqCategory { get => faqCategory; }

    }
}