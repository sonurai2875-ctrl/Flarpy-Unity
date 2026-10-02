using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    [SerializeField] private float speed = 1f;

    private float tileWidth;
    private Vector3 startPos;

    void Awake()
    {
        startPos = transform.position;
        // Automatically measures 1 tile width regardless of the image size
        tileWidth = GetComponent<SpriteRenderer>().sprite.bounds.size.x * transform.localScale.x;
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        // Snaps back seamlessly when moved by 1 tile width
        if (transform.position.x <= startPos.x - tileWidth)
        {
            transform.position = startPos;
        }
    }
}