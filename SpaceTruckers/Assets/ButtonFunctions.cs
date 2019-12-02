using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{

    public void LoadScene(string scene)
    {
        Debug.Log(scene);
        SceneManager.LoadScene(scene);
    }
}
