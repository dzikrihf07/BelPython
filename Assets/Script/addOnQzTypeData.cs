using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addOnQzTypeData : MonoBehaviour
{
    public GameObject sukses1, sukses2, error, output;
    public string satu;
    public string dua;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ReadInputSoal.input == satu)
        {
            sukses1.SetActive(true);
            error.SetActive(false);
            output.SetActive(false);
        }
        else if(ReadInputSoal.input == dua)
        {
            sukses2.SetActive(true);
            error.SetActive(false);
            output.SetActive(false);
        }
    }
}
