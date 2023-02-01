using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class MenuController : MonoBehaviour
{

    public GameObject MainMenu;
    public InputActionAsset InputActions;

    // Start is called before the first frame update
    void Start()
    {
        InputAction MenuAction = InputActions.FindActionMap("XRI LeftHand Interaction").FindAction("UI Open Menu");
        MenuAction.performed += OnMenuOpen;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMenuOpen(InputAction.CallbackContext context)
    {
        MainMenu.SetActive(true);
    }
}
