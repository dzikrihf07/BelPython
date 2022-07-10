using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ResetQuiz : MonoBehaviour
{
    private const int V = 1;
    public UnityEvent onCompleteCallBack;
    public GameObject Target;

    public void resetGass()
    {
        DestroyMe();
        StartCoroutine(V);
    }

    private void StartCoroutine(float v)
    {
        Instantiate(Target);
    }

    public void onCompete()
    {
        if (onCompleteCallBack != null)
        {
            Instantiate(Target);
        }
    }

    void DestroyMe()
    {
        Destroy(Target);
    }
}
