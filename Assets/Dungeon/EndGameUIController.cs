using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameUIController : MonoBehaviour
{
    public Transform PlayerHead;
    public GameObject EndGameUI;

    // Start is called before the first frame update
    void Start()
    {
        EndGameUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        EndGameUI.transform.position = PlayerHead.position + new Vector3(PlayerHead.forward.x, PlayerHead.forward.y, PlayerHead.forward.z).normalized * 2;
        EndGameUI.transform.LookAt(new Vector3(PlayerHead.position.x, PlayerHead.position.y, PlayerHead.position.z));
        EndGameUI.transform.forward *= -1;
    }

    public void ShowEndGameUI()
    {
        EndGameUI.SetActive(true);
    }
}
