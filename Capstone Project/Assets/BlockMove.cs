using UnityEngine;

public class BlockMove : MonoBehaviour
{
    public GameObject block;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private float timer = 0.5f;
    private bool pos = false;
    void Update()
    {
       if ((timer -=  Time.deltaTime) < 0 && pos == false) {
                            block.transform.Translate(new Vector3(0.2f, 0, 0)); 
                            timer = 0.5f;
                            pos = true;
                        }
                        else if ((timer -=  Time.deltaTime) < 0 && pos == true) {
                            block.transform.Translate(new Vector3(-0.2f, 0,0)); 
                            timer = 0.5f;
                            pos = false;
                        }
    }
}
