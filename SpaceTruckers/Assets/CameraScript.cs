using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    [SerializeField] float cameraSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * Time.deltaTime * cameraSpeed;
    }
}
