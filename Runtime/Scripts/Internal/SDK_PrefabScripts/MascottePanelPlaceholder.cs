using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace Virtuademy.CreatorKit.Worlds.Placeholders
{
    [RequireComponent(typeof(MascottePlaceholder))]
    [MovedFrom(false, "Reflectis.CreatorKit.Worlds.Placeholders", "Reflectis.CreatorKit.Worlds.Placeholders")]
    public class MascottePanelPlaceholder : PanelPlaceholder
    {
        [SerializeField]
        private string[] faqCategory;

        public string[] FaqCategory { get => faqCategory; }

    }
}