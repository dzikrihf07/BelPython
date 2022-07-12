using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class txtJwbShow : MonoBehaviour
{
    public GameObject txt1, txt2, txt3, txt4, outputA, outputB, outputC, outputD;
    // Start is called before the first frame update
    private void Start()
    {
        if (IdJawaban.jawaban == 1)
        {
            txt1.SetActive(true);
            outputA.SetActive(false);
            txt2.SetActive(false);
            outputB.SetActive(false);
            txt3.SetActive(false);
            outputC.SetActive(false);
            txt4.SetActive(false);
            outputD.SetActive(false);
        }
        else if (IdJawaban.jawaban == 2)
        {
            txt1.SetActive(false);
            outputA.SetActive(false);
            txt2.SetActive(true);
            outputB.SetActive(true);
            txt3.SetActive(false);
            outputC.SetActive(false);
            txt4.SetActive(false);
            outputD.SetActive(false);
        }
        else if (IdJawaban.jawaban == 3)
        {
            txt1.SetActive(false);
            outputA.SetActive(false);
            txt2.SetActive(false);
            outputB.SetActive(false);
            txt3.SetActive(true);
            outputC.SetActive(true);
            txt4.SetActive(false);
            outputD.SetActive(false);
        }
        else if (IdJawaban.jawaban == 4)
        {
            txt1.SetActive(false);
            outputA.SetActive(false);
            txt2.SetActive(false);
            outputB.SetActive(false);
            txt3.SetActive(false);
            outputC.SetActive(false);
            txt4.SetActive(true);
            outputD.SetActive(true);
        }
    }
}
