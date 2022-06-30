using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeScnHome : MonoBehaviour
{
    public void btPindah () {
        SceneManager.LoadScene("ScnHome");
    }

    void Update()
    {
       if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene("ScnHome");
            }
        } 
    }
}
