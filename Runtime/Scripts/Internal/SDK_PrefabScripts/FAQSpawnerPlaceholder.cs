using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Scripting.APIUpdating;

namespace Virtuademy.CreatorKit.Worlds.Placeholders
{
    [MovedFrom(false, "Reflectis.CreatorKit.Worlds.Placeholders", "Reflectis.CreatorKit.Worlds.Placeholders")]
    public class FAQSpawnerPlaceholder : MonoBehaviour
    {
        [SerializeField]
        private string faqCategory;
        [SerializeField]
        private Transform faqParent;
        [SerializeField]
        private Size blockSize;

        public string FaqCategory { get => faqCategory; set => faqCategory = value; }
        public Transform FaqParent { get => faqParent; set => faqParent = value; }
        public Size BlockSize { get => blockSize; set => blockSize = value; }
    }
}
