using Reflectis.SDK.Core;
using Reflectis.SDK.Core.CharacterController;
using Reflectis.SDK.Core.SystemFramework;
using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public class InputFunctionSetter : MonoBehaviour
    {
        public void SetDefaultInputs()
        {
            SM.GetSystem<ICharacterControllerSystem>().SetDeafultSettingsAsActive();
        }

        public void SetStaticCamera ()
        {
            InputSettings newInput = new InputSettings(false, false, false, false, false, true, false, false, false);
            SM.GetSystem<ICharacterControllerSystem>().DisableAllButCamera(newInput);
        }

        public void SetRotationCamera(bool constrainedRotation)
        {
            InputSettings newInput = new InputSettings(true, false, false, false, false, true, false, false, constrainedRotation);
            SM.GetSystem<ICharacterControllerSystem>().DisableAllButCamera(newInput);
        }
    }
}
