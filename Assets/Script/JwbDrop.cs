using UnityEngine;
using UnityEngine.EventSystems;

public class JwbDrop : MonoBehaviour, IDropHandler
{
    public GameObject smBenar, smSalah; //, id1, id2;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            if (KunciJawabanBenar.jawaban == 1)
            {
                smBenar.SetActive(true);
                smSalah.SetActive(false);
            }
            else
            {
                smBenar.SetActive(false);
                smSalah.SetActive(true);
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