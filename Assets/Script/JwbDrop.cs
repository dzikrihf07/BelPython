using UnityEngine;
using UnityEngine.EventSystems;

public class JwbDrop : MonoBehaviour, IDropHandler
{
    public GameObject smBenar, smSalah;

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
}