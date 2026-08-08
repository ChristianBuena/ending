using UnityEngine;

public class Bullet: MonoBehaviour
{
    [SerializeField] private float speed = 50f;
    private Vector2 direction;
    private float bulletCounter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {  
        //move the bullet smoothly
        transform.Translate(direction * speed * Time.deltaTime);
        Initialize(direction, 0.5f);
    }

    public void Initialize(Vector2 shootDirection, float lifetime)
    {
        direction = shootDirection.normalized;
        Destroy(gameObject, lifetime);
    }

    public void Break(GameObject gameObject, float lifetime)
    {
        Destroy(gameObject, lifetime);
    }
}
