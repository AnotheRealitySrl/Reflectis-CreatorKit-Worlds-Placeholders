using System.Collections.Generic;
using UnityEngine;
namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public class ControlManager : MonoBehaviour
    {
        public List<InformativeItem_Abstract> informativeItems = new List<InformativeItem_Abstract>();

        public void StartTaskAtIndex(int i)
        {
            informativeItems[i].StartTask();
        }
    }
}
