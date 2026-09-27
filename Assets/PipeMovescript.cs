using UnityEngine;

public class PipeMovescript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float movespeed=4.5f;
    public float deadzone=-20;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * movespeed * Time.deltaTime;
        if(transform.position.x< deadzone)
        {   
            Debug.Log("Pipe destroyed");
            Destroy(gameObject);
        }
    }
}
