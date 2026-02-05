using UnityEngine;
using UnityEngine.InputSystem;

public class Teleport : MonoBehaviour
{
    public InputActionReference action;
    public Transform externalView;
    public GameObject teleportObjectPosition;
    private Transform internalPosition;
    public Transform originalPosition;
    private bool outside = false;

    void Start()
    { 

        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if (outside)
            {
                teleportObjectPosition.transform.position = originalPosition.position;
            }
            else
            {
                teleportObjectPosition.transform.position = externalView.position;
            }

            outside = !outside;
        };
    }

    void Update()
    {
    }
}