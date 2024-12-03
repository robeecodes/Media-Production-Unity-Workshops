using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class CreateBall : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private GameObject ground;

    void Start()
    {
        int balls = Random.Range(5, 20);
        Bounds groundBounds = ground.GetComponent<Collider>().bounds;
        int ballDiameter = (int)Math.Ceiling(ballPrefab.GetComponent<Collider>().bounds.extents.y) * 2;

        for (int i = 0; i < balls; i++) {
            SpawnBall(groundBounds, ballDiameter);
        }
    }

    private void SpawnBall(Bounds groundBounds, int ballDiameter) {
        int x = Random.Range((int)groundBounds.min.x, (int)groundBounds.max.x);
        int z = Random.Range((int)groundBounds.min.z, (int)groundBounds.max.z);
        int y = Random.Range((int)ground.transform.position.y + ballDiameter + 1, (int)ground.transform.position.y + 20 + ballDiameter);
        
        GameObject ball = Instantiate(ballPrefab, new Vector3(x, y, z), Quaternion.identity);
        Renderer renderer = ball.GetComponent<Renderer>();
        renderer.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}
