using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] Image bar;

    [Header("REQUIRED!!")]
    [SerializeField] GameObject endPlatform;
    [SerializeField] GameObject player;

    Vector3 distance; 
    Vector3 initalDistance;

    private void Start()
    { 
        initalDistance = endPlatform.transform.position - player.transform.position;
    }
    private void Update()
    {
        distance = endPlatform.transform.position - player.transform.position;
        float progress = (initalDistance.x - distance.x) / initalDistance.x;
        bar.fillAmount = progress;
    }


}
