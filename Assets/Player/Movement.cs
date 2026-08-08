using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [Header("Movement Settings")]
    //Variables
    [SerializeField] private float movementSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movementInput;

    
    // giving rb variable the rigidbody2d component
    // making sure that the main camera is the one that have the mainCamera tag
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    //fixedUpdate is called based on physic rate
    void FixedUpdate()
    {   
        // Moves the physical 2D Rigidbody based on input directions
        rb.MovePosition(rb.position + movementInput * movementSpeed * Time.fixedDeltaTime);
    }
    
    // Utilizing Unity Input Action system (for Input Action system function always start on On 
    // to be detected by the player input component)
    void OnMove(InputValue value)
    {
        movementInput = value.Get<Vector2>();
    }
}
