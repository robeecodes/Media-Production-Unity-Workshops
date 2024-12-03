using UnityEngine;

public class LightOnOff : MonoBehaviour
{
    private GameObject _light;

    private void Start() {
        _light = gameObject;
        Debug.Log(_light);
    }
    
    public void Flicker() {
        _light.SetActive(!_light.activeSelf);
    }
}
