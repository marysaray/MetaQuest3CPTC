using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Create speed for the vehicle
    public float speed = 5.0f;

    // Create turn speed for the vehicle
    public float turnSpeed;

    // Bind the arrow keys to the vehicle movement
    public InputAction moveAction;

    // Create display in Inspector to see key pressed during Game Mode
    public Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Enable the input from keyboard to be used in the game
        moveAction.Enable(); 
    }

    // Update is called once per frame
    void Update()
    {
        // Displays in the Inspector the key pressed during Game Mode
        moveInput = moveAction.ReadValue<Vector2>();

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y); 

        // turn the vehicle left and right
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * moveInput.x); 
    }
}
