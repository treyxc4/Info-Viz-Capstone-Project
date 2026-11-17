using UnityEngine;

public class Splash : MonoBehaviour
{

    public float tempTimer = 3f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {

    }
    void OnTriggerStay(Collider col)
    {
        if(col.CompareTag("Dirt"))
        {
            print("Dirt");
            tempTimer -= Time.deltaTime;
            print(tempTimer);
            if (tempTimer <= 0)
            {
                Destroy(col.gameObject);
            }
        }
    }
}
