
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseAim: MonoBehaviour
{
    private Camera mainCamera;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        mainCamera = Camera.main;
    }

    void Update()
    {
        aimAtMouseClick();
    }

    //Translating the mouse position from screen to the game world 
    //get the distance between the game object position and mouse position
    // angle for easy rotation
    private void aimAtMouseClick()
    {
        Vector2 mousePosition = mainCamera.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        Vector2 direction = mousePosition - rb.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;  

    }
}
