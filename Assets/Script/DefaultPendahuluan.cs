using UnityEngine;

public class DefaultPendahuluan : MonoBehaviour
{
    public GameObject txt1, txt2, txt3, txt4, txt5, image, logo, mainmenu, materi1, materi2, materi3, materi4, materi5;

    // Start is called before the first frame update
    private void Start()
    {
        txt1.SetActive(false);
        txt2.SetActive(false);
        txt3.SetActive(false);
        txt4.SetActive(false);
        txt5.SetActive(false);
        materi1.SetActive(false);
        materi2.SetActive(false);
        materi3.SetActive(false);
        materi4.SetActive(false);
        materi5.SetActive(false);
        image.SetActive(true);
        logo.SetActive(true);
        mainmenu.SetActive(true);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}