using UnityEngine;

public class KunciJawabanTxt : MonoBehaviour
{
    public GameObject smBenar, smSalah, fade, imgOut, txtOut;
    public string JawabanBenar;
    public static string JawabanUntkShow;

    private void Update()
    {
        JawabanUntkShow = JawabanBenar;
    }

    public void btInputKlik()
    {
        if (ReadInputSoal.input == JawabanBenar)
        {
            smBenar.SetActive(true);
            smSalah.SetActive(false);
            fade.SetActive(true);
            imgOut.SetActive(false);
            txtOut.SetActive(false);
        }
        else
        {
            smBenar.SetActive(false);
            smSalah.SetActive(true);
            fade.SetActive(true);
            imgOut.SetActive(false);
            txtOut.SetActive(false);
        }
    }
}
