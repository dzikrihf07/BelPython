using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuksesHide : MonoBehaviour
{
    public GameObject Sukses;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Sukses.SetActive(false);
    }
}
