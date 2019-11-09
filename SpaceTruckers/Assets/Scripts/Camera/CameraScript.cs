using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    [SerializeField] float cameraSpeed = 10f;
    [SerializeField] bool inLevelSelector = false;

    GameObject player;
    [SerializeField] float minX;
    [SerializeField] float maxX;
    [SerializeField] float minY;
    [SerializeField] float maxY;


    float highestX = 0;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }


    private void LateUpdate()
    {
        if (!inLevelSelector)
        {
            //transform.position += Vector3.right * Time.deltaTime * cameraSpeed;

            if (transform.position.x > highestX)
                highestX = transform.position.x;

            float x = Mathf.Clamp(player.transform.position.x, highestX, maxX);
            float y = Mathf.Clamp(player.transform.position.y, minY, maxY);
            transform.position = new Vector3(x, y, transform.position.z);

        }
        else
        {
            float x = Mathf.Clamp(player.transform.position.x, minX, maxX);
            float y = Mathf.Clamp(player.transform.position.y, minY, maxY);
            transform.position = new Vector3(x, y, transform.position.z);
        }


    }
}
