using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingMenu : MonoBehaviour
{

    public Transform PlayerHead;
    public GameObject MenuUI;

    // Update is called once per frame
    void Update()
    {
        MenuUI.transform.position = PlayerHead.position + new Vector3(PlayerHead.forward.x, PlayerHead.forward.y, PlayerHead.forward.z).normalized * 2;
        MenuUI.transform.LookAt(new Vector3(PlayerHead.position.x, PlayerHead.position.y, PlayerHead.position.z));
        MenuUI.transform.forward *= -1;
    }
}
