using UnityEngine;

public class middlepipe : MonoBehaviour
{   
    public  Logicmanager logicmanager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logicmanager = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logicmanager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer==3){
       logicmanager.addScore(1);
    }
    }
}
