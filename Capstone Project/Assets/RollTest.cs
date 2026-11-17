using UnityEngine;

public class RollTest : MonoBehaviour
{
    public GameObject cube;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public float lerpedValue;
    public float duration = 1f;

    float timeElapsed = 0f;
    float start = 0f;
    float end = 10f;
    void Update()
    {
        if (timeElapsed < duration)
        {
            float t = timeElapsed / duration;
            lerpedValue = Mathf.Lerp(start, end, t);
            timeElapsed += Time.deltaTime;
        }
        else
        {
            lerpedValue = end;
            timeElapsed = 0f;
            lerpedValue = 0;
            start = end;
            end *= -1;
        }
        cube.transform.rotation = Quaternion.Euler(0f, 0f, lerpedValue);
    }
}
