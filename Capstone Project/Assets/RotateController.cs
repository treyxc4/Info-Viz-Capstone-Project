using UnityEngine;
using UnityEngine.InputSystem;

public class RotateController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public GameObject controller;
   public InputActionProperty RotationValue;
   public SkinnedMeshRenderer handMesh;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        handMesh.enabled = true;
    }

    // Update is called once per frame
    public float lerpedValue;
    public float duration = 0.165f;

    float timeElapsed = 0f;
    float start = 0f;
    float end = 15f;
    void Update()
    {
        Quaternion value = RotationValue.action.ReadValue<Quaternion>();

        if (timeElapsed < duration)
        {
            float t = timeElapsed / duration;
            lerpedValue = Mathf.Lerp(start, end, t * 10f);
            timeElapsed += Time.deltaTime * 10f;
        }
        else
        {
            lerpedValue = end;
            timeElapsed = 0f;
            lerpedValue = 0;
            start = end;
            end *= -1;
        }
        controller.transform.rotation = Quaternion.Euler(value.x * 100f, value.y * 100f, lerpedValue);
    }
}
