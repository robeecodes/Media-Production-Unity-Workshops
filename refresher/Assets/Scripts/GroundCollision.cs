using System;
using UnityEngine;
using Object = UnityEngine.Object;

public class GroundCollision : MonoBehaviour {
    private Object[] _lights;
    private void Start() {
        _lights = Object.FindObjectsByType(typeof(LightOnOff), FindObjectsSortMode.None);
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name.Contains("Ball")) {
            foreach (LightOnOff light in _lights) {
                light.Flicker();
            }
        }
    }

    void OnCollisionExit(Collision collision) {
        if (collision.gameObject.name.Contains("Ball")) {
            foreach (LightOnOff light in _lights) {
                light.Flicker();
            }
        }
    }
}
