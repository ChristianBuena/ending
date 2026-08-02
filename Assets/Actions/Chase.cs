using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class Chase : MonoBehaviour
{
    [SerializeField] private float chaseSpeed = 5f;
    private Rigidbody2D rb;
    [SerializeField] private Transform target;
    private Vector2 movementDirection;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            movementDirection = direction;

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rb.rotation = angle;  
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movementDirection * chaseSpeed;
    }
}
