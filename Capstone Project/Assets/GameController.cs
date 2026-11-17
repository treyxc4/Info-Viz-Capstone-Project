using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public TMP_Text textBox;
    public TMP_Text timerText;
    public AudioSource source;
    public AudioClip clip0;
    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;

    public int task = 0;

    private float timer = 100f;
    void Start()
    {
        Task0();
    }
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            timerText.text = timer.ToString("0.0");
        }
        else
        {
            task += 1;
            newTask();
        }
       
    }
    public void Skip()
    {
        task += 1;
        newTask();
    }
    void newTask()
    {
        switch (task)
        {
            case 0:
                Task0();
                break;
            case 1:
                Task1();
                break;
            case 2:
                Task2();
                break;
            case 3:
                Task3();
                break;
        }
    }
    void Task0()
    {       
            textBox.text = "Welcome to the experience! Head over to the panel for instructions";
            source.PlayOneShot(clip0);
            timer = 60;
    }
    void Task1()
    {
            textBox.text = "Try to stack as many cubes as you can. Task 1/3";
            source.PlayOneShot(clip1);
            timer = 60;
    }
    void Task2()
    {
            textBox.text = "Bring the plate with the egg over to the table. Task 2/3";
            source.PlayOneShot(clip2);
            timer = 60;
    }
    void Task3()
    {
            textBox.text = "Pick up the mop. Task 3/3";
            source.PlayOneShot(clip3);
            timer = 60;
            gameObject.GetComponent<MopTask>().MopEvent();
    }
}
