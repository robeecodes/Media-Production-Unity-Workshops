using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class LightOnOff : MonoBehaviour
{
    private void Start() {
        int on = Random.Range(0, 10);

        gameObject.SetActive(on <= 5);
    }

    public void Flicker() {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
