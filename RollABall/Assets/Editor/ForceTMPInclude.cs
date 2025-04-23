using UnityEditor;
using UnityEngine;
using TMPro;

public class ForceTMPInclude : MonoBehaviour
{
    [InitializeOnLoadMethod]
    static void EnsureTMPSettingsIncluded()
    {
        TMP_Settings settings = Resources.Load<TMP_Settings>("TMP Settings");
        if (settings == null)
        {
            Debug.LogError("TMP Settings.asset was not found in Resources. Make sure it exists at Assets/TextMesh Pro/Resources/TMP Settings.asset");
        }
        else
        {
            Debug.Log($"✅ TMP Settings will be included in the build. TMP default font: {TMP_Settings.defaultFontAsset}");
        }
    }
}
