using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace Virtuademy.CreatorKit.Worlds.Core.Placeholders
{
    [MovedFrom(false, "Reflectis.CreatorKit.Worlds.Core.Placeholders", "Reflectis.CreatorKit.Worlds.Placeholders")]
    public class LocalizationFileLoaderPlaceholder : SceneComponentPlaceholderBase
    {
        [SerializeField]
        private TextAsset localizationCSV;

        public TextAsset LocalizationCSV { get => localizationCSV; set => localizationCSV = value; }
    }
}
