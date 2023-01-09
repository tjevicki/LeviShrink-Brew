using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameUIController : MonoBehaviour
{
    public GameObject EndGameUI;

    // Start is called before the first frame update
    void Start()
    {
        EndGameUI.SetActive(false);
    }

    public void ShowEndGameUI()
    {
        EndGameUI.SetActive(true);
    }
}
