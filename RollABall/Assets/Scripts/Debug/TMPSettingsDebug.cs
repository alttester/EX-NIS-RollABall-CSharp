using UnityEngine;
using TMPro;

public class TMPSettingsDebug : MonoBehaviour
{
    void Start()
    {
        if (TMP_Settings.instance == null)
        {
            Debug.LogError("❌ TMP_Settings.instance is NULL - not loaded in build?");
        }
        else
        {
            Debug.Log("✅ TMP_Settings instance is loaded.");

            var fallbackFonts = TMP_Settings.fallbackFontAssets;
            var defaultFont = TMP_Settings.defaultFontAsset;

            Debug.Log($"TMP fallback fonts count: {(fallbackFonts != null ? fallbackFonts.Count : 0)}");
            Debug.Log($"TMP default font: {(defaultFont != null ? defaultFont.name : "NULL")}");
        }
    }
}
