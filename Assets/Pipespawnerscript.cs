using UnityEngine;

public class Pipespawnerscript : MonoBehaviour
{   
     public GameObject pipe;
     public float spawnrate=2;
     float timer=0;
    public float heightoffset=2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<spawnrate)
        {
            timer+=Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer=0;
        }
    }
    void spawnPipe()
    {   
        float lowestpoint = transform.position.y - heightoffset;
        float highestpoint = transform.position.y + heightoffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestpoint,highestpoint), 0),transform.rotation);
        
    }
}
