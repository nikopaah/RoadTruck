using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVehicle : MonoBehaviour
{
    private float speed = 0.4f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed);
    }
}
