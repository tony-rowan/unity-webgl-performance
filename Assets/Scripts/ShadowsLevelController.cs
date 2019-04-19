using UnityEngine;

public class ShadowsLevelController : MonoBehaviour
{
    [Header("Shadows Level Controller")]
    [SerializeField] private Light _light;

    private PerformanceController _performanceController;

    private void Awake()
    {
        _performanceController = FindObjectOfType<PerformanceController>();
        SetShadowsLevel(_performanceController.ShadowsLevel);
        _performanceController.OnShadowsLevelChanged += SetShadowsLevel;
    }

    private void OnDestroy()
    {
        _performanceController.OnShadowsLevelChanged -= SetShadowsLevel;
    }


    private void SetShadowsLevel(LightShadows shadowsLevel)
    {
        _light.shadows = shadowsLevel;
    }
}
