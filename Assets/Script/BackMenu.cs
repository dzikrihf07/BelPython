using UnityEngine;

public class BackMenu : MonoBehaviour
{
    public GameObject image, logopython, mainmenu, txt, menuoff;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        {
            if (Application.platform == RuntimePlatform.Android)
            {
                if (Input.GetKey(KeyCode.Escape))
                {
                    image.SetActive(true);
                    logopython.SetActive(true);
                    mainmenu.SetActive(true);
                    txt.SetActive(false);
                    menuoff.SetActive(false);
                    return;
                }
            }
        }
    }
}