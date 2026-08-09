using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class Chase : MonoBehaviour
{
    [SerializeField] private float chaseSpeed = 5f;

    private Rigidbody2D rb;
    private Animator animator;
    private Transform target;
    private Vector2 movementDirection;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        target = GameObject.Find("Player").transform;
    }

    void Update()
    {
        if (!target) return;

        movementDirection = (target.position - transform.position).normalized;

        animator.SetFloat("MoveX", movementDirection.x);
        animator.SetFloat("MoveY", movementDirection.y);
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movementDirection * chaseSpeed;
    }
}