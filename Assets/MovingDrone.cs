using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingDrone : MonoBehaviour
{
    public float speed = 1.0f;
    public Vector3 position1 = new Vector3(-5, 0, 0);
    public Vector3 position2 = new Vector3(5, 0, 0);

    void Update()
    {
        transform.position = Vector3.Lerp(position1, position2, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}
