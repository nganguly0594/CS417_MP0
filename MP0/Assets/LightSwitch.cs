using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public InputActionReference action;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Light light1 = GetComponent<Light>();
        bool color = true;

        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if (color) {
                light1.color = Color.white;
                color = false;
            } else {
                light1.color = Color.red;
                color = true;
            }
        };
    }

    // Update is called once per frame
    void Update()
    { 
    }
}
