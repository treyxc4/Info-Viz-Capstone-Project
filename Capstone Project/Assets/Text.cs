using UnityEngine;
using TMPro;
public class Text : MonoBehaviour
{

    public TMP_Text text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private int phase = 0;
    private float timer = 5f;
    void Update()
    {
        if ((timer -= Time.deltaTime) < 0 && phase == 0)
        {
            text.text = "Welcome to The Experiment!";
            timer = 10f;
            phase++;
        }
        else if ((timer -= Time.deltaTime) < 0 && phase == 1)
        {
            text.text = "Try picking up a cube";
            timer = 30f;
            phase++;
        }
        else if ((timer -= Time.deltaTime) < 0 && phase == 2)
        {
            text.text = "Now, try stacking as many cubes as you can";
            timer = 100f;
            phase++;
        }
        else if ((timer -= Time.deltaTime) < 0 && phase == 3)
        {
            text.text = "How many did you get?";
            timer = 30f;
            phase++;
        }
        else if ((timer -= Time.deltaTime) < 0 && phase == 4)
        {
            text.text = "Now, try to pick up the plate with the egg";
            timer = 100f;
            phase++;
        }
        else if ((timer -= Time.deltaTime) < 0 && phase == 5)
        {
            text.text = "Bring it to the table";
            timer = 100f;
            phase++;
        }
    }
}
