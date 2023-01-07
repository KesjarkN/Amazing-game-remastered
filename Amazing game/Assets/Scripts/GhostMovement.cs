using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMovement : MonoBehaviour
{

    private Vector3 initPosition;

    // Speed of the object
    public float speed = 3.0f;

    // Minimum and maximum X positions
    public float amplitude = 30;


    public void Start() {
        initPosition = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(initPosition.x +  amplitude * Mathf.Cos(Time.time / speed), transform.position.y, transform.position.z);
    }
}
