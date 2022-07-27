using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizBgFadeInTransisi : MonoBehaviour
{
    public UIAnimationTypes animType;
    public float durasiIn, durasiOut, delay, fade;
    public Image image;

    public void FadeIn()
    {
        LeanTween.alpha(gameObject.GetComponent<RectTransform>(), fade, durasiIn).setDelay(delay).setOnStart(OpenMe);
    }

    public void FadeOut()
    {
        image = GetComponent<Image>();
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        LeanTween.alpha(gameObject.GetComponent<RectTransform>(), 0f, durasiOut).setDelay(delay).setOnComplete(DestroyMe);
    }
    // Start is called before the first frame update
    void Start()
    {
        FadeIn();
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
