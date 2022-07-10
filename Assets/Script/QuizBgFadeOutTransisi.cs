using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizBgFadeOutTransisi : MonoBehaviour
{
    public UIAnimationTypes animType;
    public GameObject target;
    public float durasiIn, durasiOut, delay, fade;

    public void FadeIn()
    {
        LeanTween.alpha(target.GetComponent<RectTransform>(), fade, durasiIn).setDelay(delay).setOnStart(OpenMe);
    }

    public void FadeOut()
    {
        LeanTween.alpha(target.GetComponent<RectTransform>(), 0f, durasiOut).setDelay(delay).setOnComplete(DestroyMe);
    }
    // Start is called before the first frame update
    void Start()
    {
        FadeOut();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void DestroyMe()
    {
        gameObject.SetActive(false);
    }

    public void OpenMe()
    {
        gameObject.SetActive(true);
    }
}
