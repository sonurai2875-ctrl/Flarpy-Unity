using UnityEngine;
using UnityEngine.InputSystem;

public class Birdscriipt : MonoBehaviour
{   
    public Rigidbody2D MyRigidbody;
    public float flapstrengh = 11f;
    public Logicmanager logicmanager;
    public bool birdisAlive=true;
    void Start()
    {
     logicmanager = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logicmanager>();  
    }
    void Update()
    {   if(Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame && birdisAlive)
       { MyRigidbody.linearVelocity = Vector2.up * flapstrengh;
       }
       if (transform.position.y > 10f || transform.position.y < -10f)
       {
        logicmanager.GameOver();
        birdisAlive=false;
       }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicmanager.GameOver();
        birdisAlive=false;
    }
}
