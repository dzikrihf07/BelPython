using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UIAnimationTypes
{
    Move,
    Scale,
    ScaleX,
    ScaleY,
    Fade
}

public class AnimTransisi : MonoBehaviour
{
    public LeanTweenType AnimIn, AnimOut;
    public UIAnimationTypes animType;
    public AnimationCurve AnimCurveIn, AnimCurveOut;
    public float durasiIn, durasiOut, delay, fade;

    public void OnClose()
    {
        if (AnimOut == LeanTweenType.animationCurve)
        {
            LeanTween.scale(gameObject, new Vector3(0, 0, 0), durasiOut).setDelay(delay).setEase(AnimCurveOut).setOnComplete(DestroyMe);
        }
        else
        {
            LeanTween.scale(gameObject, new Vector3(0, 0, 0), durasiOut).setDelay(delay).setEase(AnimOut).setOnComplete(DestroyMe);
        }
    }

    public void OnOpen()
    {
        transform.localScale = new Vector3(0, 0, 0);

        if (AnimIn == LeanTweenType.animationCurve)
        {
            LeanTween.scale(gameObject, new Vector3(1, 1, 1), durasiIn).setDelay(delay).setEase(AnimCurveIn).setOnStart(OpenMe);
        }
        else
        {
            LeanTween.scale(gameObject, new Vector3(1, 1, 1), durasiIn).setDelay(delay).setEase(AnimIn).setOnStart(OpenMe);
        }
    }

    public void FadeIn()
    {
        LeanTween.alpha(gameObject.GetComponent<RectTransform>(), fade, durasiIn).setDelay(delay).setOnStart(OpenMe);
    }

    public void FadeOut()
    {
        LeanTween.alpha(gameObject.GetComponent<RectTransform>(), 0f, durasiOut).setDelay(delay).setOnComplete(DestroyMe);
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
