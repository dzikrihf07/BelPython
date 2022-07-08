using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]
public class SliderController : MonoBehaviour
{
    public GameObject btBack, btLanjutMateri, btNext;
    public static int progress;
    public Slider slider;
    float currentVelocity;
    public int sliderLanjut;

    void Start()
    {
        progress = 0;
    }

    void Update()
    {
        GetCurrentSlider();
        float smoothSlider = Mathf.SmoothDamp(slider.value, progress, ref currentVelocity, 100 * Time.deltaTime);
        slider.value = smoothSlider;
        slider.value = progress;

        if (slider.value == 0)
        {
            btBack.SetActive(false);
            btLanjutMateri.SetActive(false);
            btNext.SetActive(true);
        }

        else if (slider.value == 1)
        {
            btBack.SetActive(true);
            btLanjutMateri.SetActive(false);
            btNext.SetActive(true);
        }

        else if (slider.value == sliderLanjut)
        {
            btNext.SetActive(false);
            btLanjutMateri.SetActive(true);
        }
        return;
    }

    void GetCurrentSlider()
    {
        float fillAmount = (float)sliderLanjut;
    }
}
