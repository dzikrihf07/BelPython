using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetSoal : MonoBehaviour
{
    public GameObject prefabDel;
    public void resetGass()
    {
        _ = Resources.Load("Prefab Soal/MtrHelloWorld/1.prefab") as GameObject;
    }
}
