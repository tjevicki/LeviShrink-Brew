using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class TeleportController : MonoBehaviour
{

    public XRRayInteractor TeleportationRayInteractor;
    public InputActionAsset InputActions;
    public TeleportationProvider TeleportationProvider;

    private InputAction TeleportActivateAction;
    private InputAction TeleportCancelAction;

    // Start is called before the first frame update
    void Start()
    {
        TeleportationRayInteractor.enabled = false;

        TeleportActivateAction = InputActions.FindActionMap("XRI LeftHand Locomotion").FindAction("Teleport Mode Activate");
        TeleportActivateAction.Enable();
        TeleportActivateAction.performed += OnTeleportActivated;
        TeleportActivateAction.canceled += OnTeleportCanceled;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTeleportActivated(InputAction.CallbackContext context)
    {
        Debug.Log("Teleport mode activated.");
        TeleportationRayInteractor.enabled = true;
    }

    private void OnTeleportCanceled(InputAction.CallbackContext context)
    {
        Debug.Log("Teleport mode canceled.");

        if (!TeleportationRayInteractor.TryGetCurrent3DRaycastHit(out RaycastHit raycastHit))
        {
            TeleportationRayInteractor.enabled = false;
            return;
        }

        TeleportRequest TeleportRequest = new TeleportRequest()
        {
            destinationPosition = raycastHit.point,
        };

        TeleportationProvider.QueueTeleportRequest(TeleportRequest);
        TeleportationRayInteractor.enabled = false;
    }
}
