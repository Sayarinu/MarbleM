using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Transform playerTransformation;

    Vector3 offSet;
    // Start is called before the first frame update
    void Start()
    {
        playerTransformation = GameObject.FindGameObjectWithTag("Player").transform;
        offSet = transform.position - playerTransformation.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = playerTransformation.position + offSet;
    }
}
