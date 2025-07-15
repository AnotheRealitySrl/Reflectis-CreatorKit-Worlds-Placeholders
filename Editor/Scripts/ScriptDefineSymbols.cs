using Reflectis.SDK.Core.Editor;
using UnityEditor;

namespace Reflectis.CreatorKit.Worlds.Placeholders.Editor
{
    [InitializeOnLoad]
    public class ScriptDefineSymbols
    {
        public const string PLACEHOLDERS_SCRIPT_DEFINE_SYMBOL = "REFLECTIS_CREATOR_KIT_WORLDS_PLACEHOLDERS";
        static ScriptDefineSymbols()
        {
            ScriptDefineSymbolsUtilities.AddScriptingDefineSymbolToAllBuildTargetGroups(PLACEHOLDERS_SCRIPT_DEFINE_SYMBOL);
        }
    }
}