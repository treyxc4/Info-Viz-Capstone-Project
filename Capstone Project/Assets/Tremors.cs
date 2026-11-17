using UnityEngine;

public class Tremors : MonoBehaviour
{
    public GameObject controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private Vector3 newdirposX = new Vector3(1, 0, 0);
    private Vector3 newdirnegX = new Vector3(-1, 0, 0);
    private float timer = 0.167f;
    private bool pos = false;
    void Update()
    {
                if ((timer-=Time.deltaTime) < 0 && pos == true)
                {
                    timer = 0.167f;
                    controller.transform.Rotate(Vector3.left * 5);
                    pos = false;
                }
                else if ((timer-=Time.deltaTime) < 0 && pos == false)
                {
                    timer = 0.167f;
                    controller.transform.Rotate(Vector3.right * 5);
                    pos = true;
                }
    }
}
