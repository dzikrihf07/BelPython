using UnityEngine;
using UnityEngine.EventSystems;

public class KunciJawaban : MonoBehaviour, IDropHandler
{
    public GameObject smBenar, smSalah, fade, jwbOut, imgOut, txtOut;
    public int jawabanBenar;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            if (IdJawaban.jawaban == jawabanBenar)
            {
                smBenar.SetActive(true);
                smSalah.SetActive(false);
                fade.SetActive(true);
                jwbOut.SetActive(true);
                imgOut.SetActive(false);
                txtOut.SetActive(false);
            }
            else
            {
                smBenar.SetActive(false);
                smSalah.SetActive(true);
                fade.SetActive(true);
                jwbOut.SetActive(true);
                imgOut.SetActive(false);
                txtOut.SetActive(false);
            }
        }
    }

    /*public void Reset()
    {
        smBenar.SetActive(false);
        smSalah.SetActive(false);
        id1.SetActive(false);
        id2.SetActive(false);
    }*/
}