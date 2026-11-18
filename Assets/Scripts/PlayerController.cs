using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // create speed for the vehicle
    public float speed = 5.0f;
    // create turn speed for the vehicle
    public float turnSpeed;
    // Bind the arrow keys to the vehicle movement
    public InputAction moveAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward
        // transform.Translate(0, 0, 1); original code
        transform.Translate(Vector3.forward * Time.deltaTime * speed); // slow vehicle down
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed); // turn the vehicle left and right
    }
}
