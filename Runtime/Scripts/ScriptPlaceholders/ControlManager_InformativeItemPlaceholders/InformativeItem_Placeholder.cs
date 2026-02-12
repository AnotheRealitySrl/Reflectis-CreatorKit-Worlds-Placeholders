
using UnityEngine;

namespace Reflectis
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
