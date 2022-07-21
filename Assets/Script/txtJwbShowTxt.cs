using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class txtJwbShowTxt : MonoBehaviour
{
    public Text txt, txtOutput;
    public GameObject txtHasil, hideInput, output;
    private string textShow, textOutput;
    public string txtInpSoal, outputAwal, outputAkhir;

    private void Update()
    {
        textShow = ReadInputSoal.input+txtInpSoal;
        
        if (ReadInputSoal.input == KunciJawabanTxt.JawabanUntkShow)
        {
            txt.text = textShow;
            txtOutput.text = textOutput;
            txtHasil.SetActive(true);
            hideInput.SetActive(false);
        }
        else
        {
            txt.text = textShow;
            txtOutput.text = textOutput;
            txtHasil.SetActive(true);
            hideInput.SetActive(false);
            textOutput = outputAwal + ReadInputSoal.input + outputAkhir;
            output.SetActive(true);
        }
    }
}
