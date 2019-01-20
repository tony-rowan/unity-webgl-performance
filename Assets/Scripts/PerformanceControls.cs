using UnityEngine;

public class PerformanceControls : MonoBehaviour
{
    [SerializeField] private Light mainDirectionalLight;
    [SerializeField] private Light[] spotLights;
    [SerializeField] private Light carHeadLights;
    [SerializeField] private Light carLowLight;

    public void UpdateDirectionalLight(int lightMode) {
        switch (lightMode) {
            case 0:
                mainDirectionalLight.enabled = true;
                mainDirectionalLight.shadows = LightShadows.None;
                return;
            case 1:
                mainDirectionalLight.enabled = true;
                mainDirectionalLight.shadows = LightShadows.Hard;
                return;
            case 2:
                mainDirectionalLight.enabled = true;
                mainDirectionalLight.shadows = LightShadows.Soft;
                return;
            case 3:
                mainDirectionalLight.enabled = false;
                return;
        }
    }

    public void UpdateSpotLights(int lightMode) {
        switch (lightMode) {
            case 0:
                foreach(Light spotLight in spotLights) {
                    spotLight.enabled = true;
                    spotLight.shadows = LightShadows.None;
                }
                return;
            case 1:
                foreach (Light spotLight in spotLights) {
                    spotLight.enabled = true;
                    spotLight.shadows = LightShadows.Hard;
                }
                return;
            case 2:
                foreach (Light spotLight in spotLights) {
                    spotLight.enabled = true;
                    spotLight.shadows = LightShadows.Soft;
                }
                return;
            case 3:
                foreach (Light spotLight in spotLights) {
                    spotLight.enabled = false;
                }
                return;
        }
    }

    public void UpdateCarHeadLights(int lightMode) {
        switch (lightMode) {
            case 0:
                carHeadLights.enabled = true;
                carHeadLights.shadows = LightShadows.None;
                return;
            case 1:
                carHeadLights.enabled = true;
                carHeadLights.shadows = LightShadows.Hard;
                return;
            case 2:
                carHeadLights.enabled = true;
                carHeadLights.shadows = LightShadows.Soft;
                return;
            case 3:
                carHeadLights.enabled = false;
                return;
        }
    }

    public void UpdateCarLowLight(int lightMode) {
        switch (lightMode) {
            case 0:
                carLowLight.enabled = true;
                carLowLight.shadows = LightShadows.None;
                return;
            case 1:
                carLowLight.enabled = true;
                carLowLight.shadows = LightShadows.Hard;
                return;
            case 2:
                carLowLight.enabled = true;
                carLowLight.shadows = LightShadows.Soft;
                return;
            case 3:
                carLowLight.enabled = false;
                return;
        }
    }
}
