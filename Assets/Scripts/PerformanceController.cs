using UnityEngine;
using UnityEngine.UI;
using System;

public class PerformanceController : MonoBehaviour
{
    public bool AdditionalLights { get; private set; }
    public LightShadows ShadowsLevel { get; private set; }

    public event Action<bool> OnAdditionalLightsChanged;
    public event Action<LightShadows> OnShadowsLevelChanged;

    [Header("Controls")]
    [SerializeField] private Dropdown _additionalLightsDropdown;
    [SerializeField] private Dropdown _shadowsLevelDropdown;

    public void SetAdditionLightsOn(int dropdownValue)
    {
        AdditionalLights = AdditionalLightsFromDropdownValue(dropdownValue);
        OnAdditionalLightsChanged?.Invoke(AdditionalLights);
    }

    public void SetShadowsLevel(int dropdownValue)
    {
        ShadowsLevel = ShadowsLevelFromDropdownValue(dropdownValue);
        OnShadowsLevelChanged?.Invoke(ShadowsLevel);
    }

    private void Awake()
    {
        SetAdditionLightsOn(_additionalLightsDropdown.value);
        SetShadowsLevel(_shadowsLevelDropdown.value);

        _additionalLightsDropdown.onValueChanged.AddListener(SetAdditionLightsOn);
        _shadowsLevelDropdown.onValueChanged.AddListener(SetShadowsLevel);
    }

    private bool AdditionalLightsFromDropdownValue(int value)
    {
        return value == 1;
    }

    private LightShadows ShadowsLevelFromDropdownValue(int value)
    {
        switch (value)
        {
            case 0: return LightShadows.None;
            case 1: return LightShadows.Hard;
            case 2: return LightShadows.Soft;

            default: throw new ArgumentException();
        }
    }
}
