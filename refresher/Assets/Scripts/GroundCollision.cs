using UnityEngine;
using Object = UnityEngine.Object;

public class GroundCollision : MonoBehaviour {
    private Object[] _lights;
    private void Awake() {
        _lights = FindObjectsByType(typeof(LightOnOff), FindObjectsSortMode.None);
    }

    private void OnCollisionEnter(Collision collision) {
        if (!collision.gameObject.name.Contains("Ball")) return;
        foreach (LightOnOff light in _lights) light.Flicker();
    }

    private void OnCollisionExit(Collision collision) {
        if (!collision.gameObject.name.Contains("Ball")) return;
        foreach (LightOnOff light in _lights) light.Flicker();
    }
}
