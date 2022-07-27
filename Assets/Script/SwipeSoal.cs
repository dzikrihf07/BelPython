using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeSoal : MonoBehaviour
{
    public GameObject scrollbar;
    private float scroll_pos = 0;
    private float[] pos;
    private int posisi = 0;

    public void lanjut()
    {
        if (posisi < pos.Length - 1)
        {
            posisi += 1;
            scroll_pos = pos[posisi];
        }
    }

    public void kembali()
    {
        if (posisi < pos.Length - 1)
        {
            posisi -= 1;
            scroll_pos = pos[posisi];
        }
    }

    // Update is called once per frame
    private void Update()
    {
        pos = new float[transform.childCount];
        float distance = 1f / (pos.Length - 1f);
        for (int i = 0; i < pos.Length; i++)
        {
            pos[i] = distance * i;
        }

        if (Input.GetMouseButton(0))
        {
            scroll_pos = scrollbar.GetComponent<Scrollbar>().value;
        }
        else
        {
            for (int i = 0; i < pos.Length; i++)
            {
                if (scroll_pos < pos[i] + (distance / 2) && scroll_pos > pos[i] - (distance / 2))
                {
                    scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, pos[i], 0.15f);
                    posisi = i;
                }
            }
        }

        /*
        if (Input.GetMouseButtonDown(0))
            Debug.Log("Pressed primary button.");

        if (Input.GetMouseButtonDown(1))
            Debug.Log("Pressed secondary button.");

        if (Input.GetMouseButtonDown(2))
            Debug.Log("Pressed middle click.");
        */
    }
}
