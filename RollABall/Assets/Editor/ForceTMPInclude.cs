using UnityEditor;
using UnityEngine;
using TMPro;

public static class ForceTMPSettingsInclude
{
    [InitializeOnLoadMethod]
    static void IncludeTMPSettings()
    {
        var settings = Resources.Load<TMP_Settings>("TMP Settings");
        if (settings != null)
        {
            Debug.Log("✅ TMP_Settings found and will be included in build.");
            // Mark asset to be included in build
            EditorUtility.SetDirty(settings);
        }
        else
        {
            Debug.LogWarning("⚠️ TMP_Settings not found in Resources folder. Make sure it's named 'TMP Settings' and located under 'Assets/TextMesh Pro/Resources'.");
        }
    }
}
