using UnityEngine;
using UnityEngine.InputSystem;

public class ManualRotation : MonoBehaviour
{
    public InputActionProperty testValue;
    public GameObject controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion value = testValue.action.ReadValue<Quaternion>();
        Debug.Log(value.ToString());
        controller.transform.Rotate(value.eulerAngles);
    }
}
