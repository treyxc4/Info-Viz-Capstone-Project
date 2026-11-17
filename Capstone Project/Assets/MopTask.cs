using UnityEngine;

public class MopTask : MonoBehaviour
{

    public GameObject spawnObj;

    public float MinX = -2f;
    public float MaxX = 2.6f;

    //for 3d you have z position
    public float MinZ = -1.4f;
    public float MaxZ = 3.3f;

    //turn off or on 3D placement
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MopEvent()
    {
        for(int i = 0; i < 5; i++)
        {
            SpawnObject();
        }
    }
    
    void SpawnObject() {
        float x = Random.Range(MinX,MaxX);
        // float y = Random.Range(MinY,MaxY);
        float z = Random.Range(MinZ,MaxZ);

        Instantiate(spawnObj, new Vector3(x, 0.121f ,z), Quaternion.identity);
    }

}
