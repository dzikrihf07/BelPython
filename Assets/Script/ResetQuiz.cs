using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class ResetQuiz : MonoBehaviour
{
    public void ResetGass()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
