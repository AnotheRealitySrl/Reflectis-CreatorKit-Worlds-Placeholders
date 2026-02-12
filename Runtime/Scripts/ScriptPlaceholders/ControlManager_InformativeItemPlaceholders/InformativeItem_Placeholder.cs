
using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public class InformativeItem_Placeholder : InformativeItem_Abstract
    {

        public override void StartTask()
        {
            base.StartTask();

            Debug.LogError("Test");
        }
    }
}
