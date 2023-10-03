using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private Vector3 offset3Person = new(0, 5, -7);
    private Vector3 offset1Person = new(-0.13f, 1.8f, 1.7f);
    private Vector3 offset;

    private void Start()
    {
        offset = offset3Person;
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            offset = offset == offset3Person ? offset1Person : offset3Person;
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
