using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public class FloorPlaceholder : SceneComponentPlaceholderBase
    {
        [SerializeField] private GameObject customReticleVR;

        public GameObject CustomReticleVR => customReticleVR;
    }
}

