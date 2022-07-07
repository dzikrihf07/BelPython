using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public GameObject btBack, btLanjutMateri, btNext;
    public static int progress = 0 ;
    public Slider slider;
    float currentVelocity;

    void Update()
    {
        float smoothSlider = Mathf.SmoothDamp(slider.value, progress, ref currentVelocity, 100 * Time.deltaTime);
        slider.value = smoothSlider;
        slider.value = progress;

        if (slider.value == 0)
        {
            btBack.SetActive(false);
        }

        else if (slider.value == 1)
        {
            btBack.SetActive(true);
        }

        else if (slider.value == 2)
        {
            btNext.SetActive(false);
            btLanjutMateri.SetActive(true);
        }
        return;
    }
}
