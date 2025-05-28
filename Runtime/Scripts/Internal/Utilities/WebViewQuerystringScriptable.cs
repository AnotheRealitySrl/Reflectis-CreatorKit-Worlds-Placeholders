#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif

using System.Collections.Generic;

using UnityEngine;

using Reflectis.CreatorKit.Worlds.Placeholders;

[CreateAssetMenu(menuName = "AnotheReality/Utils/WebViewQuerystringScriptable", fileName = "WebViewQuerystringScriptable")]
public class WebViewQuerystringScriptable
#if ODIN_INSPECTOR
    : SerializedScriptableObject
#endif
{
    // These Dictionaries will be serialized by Odin.
    [SerializeField] private Dictionary<QuerystringParameter, string> querystringKeyMappings = new();
    [SerializeField] private Dictionary<string, string> constantQuerystrings = new();

    public Dictionary<QuerystringParameter, string> QuerystringKeyMappings => querystringKeyMappings;
    public Dictionary<string, string> ConstantQuerystrings => constantQuerystrings;
}