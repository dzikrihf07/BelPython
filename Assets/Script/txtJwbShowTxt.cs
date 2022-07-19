using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class txtJwbShowTxt : MonoBehaviour
{
    public Text txt, txtOutput;
    public GameObject txtHasil, hideInput, output;
    private string textShow, textOutput;
    public string txtInpSoal;

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
            textOutput = "NameError: name '" + ReadInputSoal.input + "' is not defined";
            output.SetActive(true);
        }
    }
}
