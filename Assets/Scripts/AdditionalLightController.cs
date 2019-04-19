using UnityEngine;

public class AdditionalLightController : MonoBehaviour
{
    [Header("Additional Light Controller")]
    [SerializeField] private Light _light;

    private PerformanceController _performanceController;

    private void Awake()
    {
        _performanceController = FindObjectOfType<PerformanceController>();
        SetAdditionalLightOn(_performanceController.AdditionalLights);
        _performanceController.OnAdditionalLightsChanged += SetAdditionalLightOn;
    }

    private void OnDestroy()
    {
        _performanceController.OnAdditionalLightsChanged -= SetAdditionalLightOn;
    }

    private void SetAdditionalLightOn(bool on)
    {
        _light.enabled = on;
    }
}
