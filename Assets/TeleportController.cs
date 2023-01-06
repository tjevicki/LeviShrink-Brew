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
        TeleportationRayInteractor.enabled = true;
    }

    private void OnTeleportCanceled(InputAction.CallbackContext context)
    {
        TeleportationRayInteractor.TryGetHitInfo(out Vector3 position, out Vector3 normal, out int positionInLine, out bool isValid);
        if (isValid)
        {
            TeleportRequest TeleportRequest = new TeleportRequest()
            {
                destinationPosition = position,
            };

            TeleportationProvider.QueueTeleportRequest(TeleportRequest);
        }

        TeleportationRayInteractor.enabled = false;
    }
}
