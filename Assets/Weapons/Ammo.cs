using UnityEngine;

public class Ammo : MonoBehaviour
{

    [SerializeField] private float speed = 50f;
    private Vector2 direction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {  
        transform.Translate(direction * speed * Time.deltaTime);
        Initialize(direction, 0.5f);
    }

    public void Initialize(Vector2 shootDirection, float lifetime)
    {
        direction = shootDirection.normalized;
        Destroy(gameObject, lifetime);
    }
}
