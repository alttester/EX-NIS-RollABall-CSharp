using UnityEngine;
using TMPro;

public class ForceTMPSettingsInclusion : MonoBehaviour
{
    [SerializeField] private TMP_Settings tmpSettings;

    void Awake()
    {
        if (tmpSettings == null)
        {
            tmpSettings = Resources.Load<TMP_Settings>("TMP Settings");
        }

        // Referință dummy care forțează includerea assetului în build
        if (tmpSettings != null)
        {
            Debug.Log("TMP Settings loaded: " + tmpSettings.name);
        }
        else
        {
            Debug.LogWarning("TMP Settings asset not found in Resources!");
        }
    }
}
