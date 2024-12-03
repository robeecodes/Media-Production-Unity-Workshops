using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class LightOnOff : MonoBehaviour
{
    private Light _light;
    
    private void Start() {
        _light = gameObject.GetComponent<Light>();
        int on = Random.Range(0, 10);

        _light.enabled = on > 5 ? true : false;
    }

    public void Flicker() {
        _light.enabled = !_light.enabled;
    }
}
